function CheckIfUserJustLoggedIn() {  
    console.log("CheckIfUserJustLoggedIn function called");
    var sessionLastLogin = "sessionLastLogin";  
    var isLoggedIn = "{% if user %}true{% else %}false{% endif %}";  
    console.log("isLoggedIn:", isLoggedIn);
    
    if (isLoggedIn == 'true') {  
        var userId = "{{user.id}}";  
        userId = userId.replace('{', '').replace('}', '');  
        console.log("User is logged in with userId:", userId);
        
        var lastLogin = sessionStorage.getItem(sessionLastLogin);  
        console.log("lastLogin from sessionStorage:", lastLogin);
        
        if (lastLogin == null) {  
            var dateTimestamp = new Date();  
            sessionStorage.setItem(sessionLastLogin, dateTimestamp);  
            console.log("Setting new lastLogin timestamp in sessionStorage:", dateTimestamp);
            
            webapi.safeAjax({  
                type: "PATCH",  
                url: "/_api/contacts(" + userId + ")",  
                contentType: "application/json",  
                data: JSON.stringify({  
                    "adx_identity_lastsuccessfullogin": dateTimestamp  
                }),  
                success: function (res) {  
                    console.log("AJAX request successful:", res);  
                },
                error: function (err) {
                    console.error("AJAX request failed:", err);
                }
            });  
        } else {
            console.log("lastLogin is not null, no need to update");
        }
    } else {  
        console.log("User is not logged in, removing sessionLastLogin from sessionStorage");
        sessionStorage.removeItem(sessionLastLogin);  
    }  
}

(function(webapi, $) {  
    function safeAjax(ajaxOptions) {  
        console.log("safeAjax function called with options:", ajaxOptions);
        var deferredAjax = $.Deferred();  
        shell.getTokenDeferred().done(function (token) {  
            console.log("Token retrieved:", token);
            
            if (!ajaxOptions.headers) {  
                $.extend(ajaxOptions, {  
                    headers: {  
                        "__RequestVerificationToken": token  
                    }  
                });  
                console.log("Headers added to ajaxOptions:", ajaxOptions.headers);
            } else {  
                ajaxOptions.headers["__RequestVerificationToken"] = token;  
                console.log("Token added to existing headers:", ajaxOptions.headers);
            }  
            
            $.ajax(ajaxOptions)  
                .done(function(data, textStatus, jqXHR) {  
                    console.log("AJAX request done:", data, textStatus, jqXHR);
                    validateLoginSession(data, textStatus, jqXHR, deferredAjax.resolve);  
                }).fail(function(err) {
                    console.error("AJAX request failed:", err);
                    deferredAjax.reject(err);
                });  
        }).fail(function () {  
            console.error("Token retrieval failed");
            deferredAjax.rejectWith(this, arguments);  
        });  
        return deferredAjax.promise();  
    }  
    webapi.safeAjax = safeAjax;  
})(window.webapi = window.webapi || {}, jQuery)