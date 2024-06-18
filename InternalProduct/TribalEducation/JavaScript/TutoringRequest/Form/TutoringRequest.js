
/**
 * Sets the default value for the 'ait_requestdate' field to today's date if it doesn't have a value yet.
 */
function defaultRequestDate() {
    // Get the 'ait_requestdate' field
    var requestDateField = Xrm.Page.getAttribute("ait_requestdate");

    // If the field exists and doesn't have a value yet
    if (requestDateField != null && requestDateField.getValue() == null) {
        // Set the default value to today's date
        requestDateField.setValue(new Date());
    }
}


////////////////////////////////////////////////////////////////////////////////
// When Tutoring Request Status = Approved / Denied, Update Decision Date and Make Required
function updateTutoringRequestStatus() {
    // Get 'ait_tutoringrequeststatus'
    var tutoringRequestStatus = Xrm.Page.getAttribute("ait_tutoringrequeststatus").getValue();
    console.log("Tutoring Request Status: ", tutoringRequestStatus);
    
    // If field = Approved / Denied
    if (tutoringRequestStatus === 748120000 || tutoringRequestStatus === 748120001) {
        console.log("Status is Approved or Denied");

        // Get Today's Date
        var today = new Date();
        console.log("Today's Date: ", today);
        
        // Set the field Decision Date = Today's Date
        Xrm.Page.getAttribute("ait_decisiondate").setValue(today);
        console.log("Decision Date set to Today's Date");

        // Make Decision Date Field Required
        Xrm.Page.getAttribute("ait_decisiondate").setRequiredLevel("required");
        console.log("Decision Date Field set to Required");
    } else {
        console.log("Status is neither Approved nor Denied");

        // Set Decision Date to Null
        Xrm.Page.getAttribute("ait_decisiondate").setValue(null);
        console.log("Decision Date set to Null");
        
        // Make Decision Date Field Not Required
        Xrm.Page.getAttribute("ait_decisiondate").setRequiredLevel("none");
        console.log("Decision Date Field set to Not Required");
    }
}

