// Populate lookup 'ait_crtype' with 'Add New Household Member' value
$(document).ready(function() {
    console.log("Document is ready");
    
    // Ensure the lookup field is present before making the API call
    if ($("#ait_crtype").length) {
        console.log("Lookup field found, proceeding with API call.");
        fetchCRType_Householdmember();
        $('#ait_crtype').parent().parent().parent().hide(); // Hide the lookup field

    } else {
        console.error("Lookup field 'ait_crtype' not found on the page.");
    }
});

function fetchCRType_Householdmember() {
    console.log("Fetching Change Request Type...");
    
    webapi.safeAjax({
        type: "GET",
        url: "/_api/ait_changerequesttypes?$select=ait_changerequesttypeid,ait_name&$filter=contains(ait_name,'Household')",
        contentType: "application/json",
        headers: {
            "Prefer": "odata.include-annotations=*,odata.maxpagesize=1"
        },
        success: function (data, textStatus, xhr) {
            var results = data;
            console.log(results);
            if (results.value.length > 0) {
                var result = results.value[0];
                // Columns
                var ait_changerequesttypeid = result["ait_changerequesttypeid"]; // Guid
                var ait_name = result["ait_name"]; // Text

                // Populate the lookup field with the fetched data
                populateCRType_Householdmember(ait_changerequesttypeid, ait_name);
            } else {
                console.error("No matching Change Request Type found.");
            }
        },
        error: function (xhr, textStatus, errorThrown) {
            console.log(xhr);
        }
    });
}

function populateCRType_Householdmember(recordId, recordName) {
    console.log("Populating lookup field with:", recordName, recordId);
    
    var entityName = "ait_changerequesttype";  

    if (!recordId || !recordName) {
        console.error("Missing required lookup values. Skipping population.");
        return;
    }
    // Set lookup value in Power Pages (ensure the correct field format)
    $("#ait_crtype_name").val(recordName); // Display Name
    $("#ait_crtype_entityname").val(entityName); // Entity Logical Name
    $("#ait_crtype").val(recordId); // Record ID

    console.log("Lookup field populated successfully.");
}