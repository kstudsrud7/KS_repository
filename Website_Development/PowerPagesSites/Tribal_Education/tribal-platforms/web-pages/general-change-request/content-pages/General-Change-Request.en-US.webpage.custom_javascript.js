var queryString;
(window.onpopstate = function () {
    var match,
        pl     = /\+/g,  // Regex for replacing addition symbol with a space
        search = /([^&=]+)=?([^&]*)/g,
        decode = function (s) { return decodeURIComponent(s.replace(pl, " ")); },
        query  = window.location.search.substring(1);

    queryString = {};
    while (match = search.exec(query))
       queryString[decode(match[1])] = decode(match[2]);
})();
$(document).ready(function(){
    var changerequesttype = queryString["crt"];
    if (changerequesttype == "membership"){
        $("#ait_crtype").val("a33a8d2b-4520-eb11-a813-000d3a31c867");
        $("#ait_crtype_name").val("Request to join tribe");
        $("#ait_crtype_entityname").val("ait_changerequesttype");
    }
    else if (changerequesttype == "idcard"){
        $("#ait_crtype").val("d698fdef-7220-eb11-a813-000d3a31c867");
        $("#ait_crtype_name").val("New or Replacement ID Card");
        $("#ait_crtype_entityname").val("ait_changerequesttype");
    }
});