// JavaScript source code

$(document).ready(function() {
    $('[data-name="diagSection"]').parent().hide();
//Only let them re-size the text box to the width of the form
    $(".textarea").css({"max-width":"409px"});
//If we want to just disable all re-sizing use this:
//$(".textarea").css({"resize":"none"});
});

if (window.jQuery) {
    (function ($) {
        $(document).ready(function () {
            //On change of phoneNumber field, if 10 digits, format in (111)111-1111 format
            $("#ait_phone_user").change(function () {
                var phoneNumber = $("#ait_phone_user").val();
                if (phoneNumber.length === 10) {
                    var formattedNumber = phoneNumber.replace(/(\d{3})(\d{3})(\d{4})/, "($1)$2-$3");
                    $("#ait_phone_user").val(formattedNumber)
                }
            });

            //Validators for Email and Phone:
            if (typeof (Page_Validators) == 'undefined') return;
            // Create new validator for Email
            var emailValidator = document.createElement('span');
            emailValidator.style.display = "none";
            emailValidator.id = "ait_email_user";
            emailValidator.controltovalidate = "ait_email_user";
            emailValidator.errormessage = "<a href='#ait_email_user_label' referencecontrolid='ait_email_user ' onclick='javascript:scrollToAndFocus(\"ait_email_user _label\",\" ait_email_user \");return false;'>Email must be in a valid email format.</a>";
            emailValidator.initialvalue = "";
            emailValidator.evaluationfunction = function () {
                var emailAddress = $("#ait_email_user").val();

                if (emailAddress != undefined && emailAddress.length > 0) {                    
                    var emailPattern = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;
                    if (emailPattern.test(emailAddress)) {
                        if (emailAddress)
                        return true;
                    }
                    else {
                        return false;
                    }
                } else {
                    return true;
                }

            };
            //Create new validator for Phone
            var phoneValidator = document.createElement('span');
            phoneValidator.style.display = "none";
            phoneValidator.id = "ait_phone_user";
            phoneValidator.controltovalidate = "ait_phone_user";
            phoneValidator.errormessage = "<a href='#ait_phone_user_label' referencecontrolid='ait_phone_user ' onclick='javascript:scrollToAndFocus(\"ait_phone_user _label\",\" ait_phone_user \");return false;'>Phone number must be 10 digits with no special characters allowed. Formatting will be populated for you - only input numbers.</a>";
            phoneValidator.initialvalue = "";
            phoneValidator.evaluationfunction = function () {
                var phoneNumber = $("#ait_phone_user").val();
                if (phoneNumber != undefined && phoneNumber.length > 0) {
                    var removeFormatting = phoneNumber.replace('(', '');
                    removeFormatting = removeFormatting.replace(')', '');
                    removeFormatting = removeFormatting.replace('-', '');

                    if (phoneNumber.length === 13) {
                        if (removeFormatting.length === 10 && !isNaN(removeFormatting)) {
                            return true;
                        }
                        else {
                            return false;
                        }
                    }
                    else {
                        return false
                    }
                }
                else {
                    return true;
                }

            };

            // Add the new validator to the page validators array:
            Page_Validators.push(emailValidator);
            Page_Validators.push(phoneValidator);

        });
    }(window.jQuery));
}



