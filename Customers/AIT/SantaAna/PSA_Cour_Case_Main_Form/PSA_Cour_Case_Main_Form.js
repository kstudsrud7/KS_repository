// Function to show outstanding warrants notification
function showOutstandingWarrantsNotification(executionContext) {
    var formContext = executionContext.getFormContext();
    var primaryRespondent = formContext.getAttribute("ait_primaryrespondent").getValue();
 
    console.log("Primary Respondent Value: ", primaryRespondent);
 
    if (primaryRespondent) {
        var primaryRespondentId = primaryRespondent[0].id.replace("{", "").replace("}", "");
        console.log("Primary Respondent ID: ", primaryRespondentId);
 
        // Define the filter query
        var filterQuery = `?$filter=_psa_courtprofile_value eq '${primaryRespondentId}' and psa_recalldate eq null and psa_servicedate eq null`;

        console.log("Filter Query: ", filterQuery);
 
        // Retrieve multiple records from psa_warrant table
        Xrm.WebApi.retrieveMultipleRecords("psa_warrant", filterQuery).then(
            function success(result) {
                var numberOfWarrants = result.entities.length;
                console.log("Number of Warrants: ", numberOfWarrants);
 
                // Display form notification
                if (numberOfWarrants > 0) {
                    var message = "Outstanding: " + numberOfWarrants + " Warrants";
                    formContext.ui.setFormNotification(message, "INFO", "warrantsNotification");
                    console.log("Form Notification Set: ", message);
                } else {
                    console.log("No Warrant Records");
                }
            },
            function error(error) {
                console.log("Error: ", error.message);
            }
        );
    } else {
        console.log("Primary respondent is not set.");
    }
}
//////////////////////////////////////////////////////////////


function checkCustodyStatus(executionContext) {
    var formContext = executionContext.getFormContext();
    var courtProfileId = formContext.getAttribute("ait_primaryrespondent").getValue();

    // Check if courtProfileId is valid
    if (!courtProfileId) {
        console.log("Court profile ID is not available.");
        return;
    }

    // Remove the curly braces from the ID
    var courtProfileId = courtProfileId[0].id.replace("{", "").replace("}", "");
    console.log("Court Profile ID: ", courtProfileId);

    // Define the filter query to get records from psa_confinement
    var filterQuery = `?$filter=_psa_courtprofile_value eq ${courtProfileId} and psa_releasedate eq null`;

    // Retrieve multiple records from psa_confinement
    Xrm.WebApi.retrieveMultipleRecords("psa_confinement", filterQuery).then(
        function success(result) {
            var numberOfRecords = result.entities.length;
            console.log("Number of Confinement Records: ", numberOfRecords);

            // Check if confinementType exists
            var confinementType = formContext.getAttribute("psa_confinementtype").getValue();
            console.log("Confinement Type Value: ", confinementType);

            if (numberOfRecords > 0) {
                if (confinementType) {
                    // Set notification if confinementType is valid
                    var message = "Confinement: " + confinementType;
                    formContext.ui.setFormNotification(message, "INFO", "custodyNotification");
                    console.log("Form Notification Set: ", message);
                } else {
                    console.log("Confinement Type is null or undefined.");
                    formContext.ui.setFormNotification("Confinement status is active, but type is not specified.", "WARNING", "custodyNotificationNoType");
                }
            } else {
                console.log("No confinement records found with release_date null.");
            }
        },
        function error(error) {
            console.error("Error retrieving confinement records: ", error.message);
            formContext.ui.setFormNotification("Error retrieving confinement records: " + error.message, "ERROR", "custodyErrorNotification");
        }
    );
}

