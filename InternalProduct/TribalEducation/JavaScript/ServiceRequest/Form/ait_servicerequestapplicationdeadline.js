// Function to check if the application deadline has passed
/**
 * Checks the application deadline for a selected program and displays an error message if the deadline has passed.
 */
function checkApplicationDeadline() {
    // Retrieve the selected program record
    var programAttribute = Xrm.Page.getAttribute("ait_program");
    if (programAttribute && programAttribute.getValue()) {
        var programId = programAttribute.getValue()[0].id;

        if (programId) {
            Xrm.WebApi.retrieveRecord("ait_program", programId, "?$select=ait_applicationdeadline").then(
                function success(result) {
                    // Check if the application deadline exists
                    if (result && result.ait_applicationdeadline) {
                        // Get the application deadline
                        var applicationDeadline = new Date(result.ait_applicationdeadline);

                        // Get today's date
                        var today = new Date();

                        // Compare application deadline with today's date
                        if (applicationDeadline < today) {
                            // Show error message in the Ribbon
                            Xrm.Page.ui.setFormNotification("The Application Deadline for this Program has Passed", "ERROR", "deadlineNotification");
                            Xrm.Page.ui.clearFormNotification("successNotification"); // Clear any existing success notification
                        }
                    } else {
                        console.log("Application deadline not found");
                    }
                },
                function error(error) {
                    console.log("Error retrieving program record: " + error.message);
                }
            );
        } else {
            console.log("Program ID is null");
        }
    } else {
        console.log("No program selected");
    }
}

