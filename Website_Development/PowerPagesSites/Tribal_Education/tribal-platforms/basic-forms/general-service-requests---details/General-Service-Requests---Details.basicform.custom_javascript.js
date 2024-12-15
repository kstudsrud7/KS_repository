$(document).ready(function() {
    var currentSRTypeID = $("#ait_servicerequesttype").val();
    if (currentSRTypeID !== '914600000'){
        /*Hide the requested amount field for anything but "Financial" Service Request Type*/
        $("#ait_requestedamount").hide();
        $("#ait_requestedamount_label").hide();
    }
    $('[data-name="diagSection"]').parent().hide();
    /* This if statement is not working because the variable is not returning a value. I gave up and moved on. */
    /*
    if ({{ tpp_diagnosticmode == true }}){
        $('[data-name="diagSection"]').parent().show();
    }
    */
});
