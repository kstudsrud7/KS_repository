// Function to retrieve a record and handle the form based on the retrieved values
function showhidemasterprogram(executionContext) {
    var formContext = executionContext.getFormContext();
    var aitProgramValue = formContext.getAttribute("ait_program").getValue();
    console.log("Program Value: " + aitProgramValue);

    // Check if 'ait_program' field is not null
    if (aitProgramValue && aitProgramValue.length > 0) {
        aitProgramValue = aitProgramValue[0].id;

        // Remove curly braces from the Program GUID
        aitProgramValue = aitProgramValue.replace("{", "").replace("}", "");

        // Retrieve the record from 'ait_program' entity using the Program GUID
        Xrm.WebApi.retrieveRecord("ait_program", aitProgramValue, "?$select=_ait_masterprogram_value")
            .then(function(result) {
                // The retrieved value is in _ait_masterprogram_value
                var aitMasterprogram = result["_ait_masterprogram_value"];
                console.log("Master Program: " + aitMasterprogram); // Log the Master Program GUID

                // Check if 'ait_masterprogram' field has a value
                if (aitMasterprogram) {
                    // Show the 'ait_masterprogram' field
                    formContext.getControl("ait_masterprogram").setVisible(true);

                    // Set the 'ait_masterprogram' field value with the retrieved value
                    formContext.getAttribute("ait_masterprogram").setValue([{ id: aitMasterprogram, entityType: "ait_program" }]);
                } else {
                    // Hide the 'ait_masterprogram' field and clear its value
                    formContext.getControl("ait_masterprogram").setVisible(false);
                    formContext.getAttribute("ait_masterprogram").setValue(null);
                }
            })
            .catch(function(error) {
                console.log(error.message);
            });
    } else {
        // Optionally handle the case where 'ait_program' field is null
        console.log("No Program Value");
        // Hide the 'ait_masterprogram' field and clear its value
        formContext.getControl("ait_masterprogram").setVisible(false);
        formContext.getAttribute("ait_masterprogram").setValue(null);
    }
}

