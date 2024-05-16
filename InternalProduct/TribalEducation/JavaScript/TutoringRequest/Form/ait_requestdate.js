// Function to check if the application deadline has passed
/**
 * Checks the application deadline for a selected program and displays an error message if the deadline has passed.
 */
function checkApplicationDeadline() {
    // Retrieve the selected program record
    var programId = Xrm.Page.getAttribute("ait_program").getValue()[0].id;

    Xrm.WebApi.retrieveRecord("ait_program", programId, "?$select=ait_applicationdeadline").then(
        function success(result) {
            // Check if the application deadline exists
            if (result.ait_applicationdeadline) {
                // Get the application deadline
                var applicationDeadline = new Date(result.ait_applicationdeadline);

                // Get today's date
                var today = new Date();

                // Compare application deadline with today's date
                if (applicationDeadline < today) {
                    // Show error message in the Ribbon
                    Xrm.Page.ui.setFormNotification("The Application Deadline for this Program has Passed", "ERROR", "deadlineNotification");
                    Xrm.Page.ui.clearFormNotification("successNotification"); // Clear any existing success notification
                    Xrm.Page.data.entity.addOnSave(preventSave); // Attach preventSave function to onSave event
                }
            }
        },
        function error(error) {
            console.log("Error retrieving program record: " + error.message);
        }
    );
}

// Function to prevent save/update
function preventSave(executionContext) {
    var saveEvent = executionContext.getEventArgs();
    saveEvent.preventDefault();
}

// Attach onload event handler to the form
Xrm.Page.data.addOnLoad(checkApplicationDeadline);
