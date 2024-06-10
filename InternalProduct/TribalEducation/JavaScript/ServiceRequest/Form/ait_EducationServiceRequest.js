// Function to retrieve a record and handle the form based on the retrieved values
function showHideDetails(executionContext) {
    var formContext = executionContext.getFormContext();
    var aitProgramValue = formContext.getAttribute("ait_program").getValue();

    // Check if 'ait_program' field is null
    if (aitProgramValue && aitProgramValue.length > 0) 
        {
        aitProgramValue = aitProgramValue[0].id;

        // Remove curly braces from the Program GUID
        aitProgramValue = aitProgramValue.replace("{", "").replace("}", "");

        Xrm.WebApi.retrieveRecord("ait_program", aitProgramValue, "?$select=ait_financialcaptype")
            .then(function(result) 
            {
                var aitFinancialType = result.ait_financialcaptype;

                // Get the tab control
                var tab = formContext.ui.tabs.get("financialcap");
                var masterSection = tab.sections.get("programfinancialcaps");// Retrieve section from financialcap tab - Master Program Section

                switch(aitFinancialType) 
                {
                    case 750000000: // None
                        tab.setVisible(false);
                        break;
                    case 750000002: // Master Program
                        masterSection.setVisible(true);
                        masterSection.setVisible(true);
                    case 748120001: // Sub Program
                        tab.setVisible(true);
                        masterSection.setVisible(true);
                        break;
                    case 750000001: // Standard
                        tab.setVisible(true);
                        masterSection.setVisible(false);
                        break;
                }
            })
            .catch(function(error) {
                console.log(error.message);
            });
        }
}


///////////////////////////////////////////////////////////////////////////////////////////////////////////

function paymentRequestMasterFilters(executionContext) {
    // Check if the "financialcap" tab is selected
    var formContext = executionContext.getFormContext();
    var tabFinancialCap = formContext.ui.tabs.get("financialcap");
    if (!tabFinancialCap || !tabFinancialCap.getDisplayState() === "expanded") {
        // If the tab is not selected or visible, return without executing the function
        return;
    }

    // Get Service Request Attributes
    var paymentrequestid = formContext.data.entity.getId(); // GUID of the Current Record
    console.log("PaymentRequestID:", paymentrequestid);
    var studentprofileid = formContext.getAttribute("ait_studentprofile").getValue(); // Get lookup value of Student Profile
    console.log("Student ProfileID:", studentprofileid);
    var programid = formContext.getAttribute("ait_program").getValue(); // Get lookup value of Program
    console.log("ProgramID:", programid);

    if (!studentprofileid || !programid) {
        console.log("Student Profile or Program is not selected.");
        return;
    }

    // Format programid to pass it to the retrieveRecord function
    var programidstringFormatted = programid[0].id.replace('{', '').replace('}', '');
    // Retrieve Master Program ID
    Xrm.WebApi.retrieveRecord("ait_program", programidstringFormatted, "?$select=_ait_masterprogram_value").then(
        function success(result) {
            var masterprogramid = result._ait_masterprogram_value;
            console.log("Master Program ID:", masterprogramid);

            //Get the subgrid control.
            var gridContext = formContext.getControl("paymentrequestsmaster");
            //Recall the execution method if the subgrid context is null or empty.
            if (!gridContext) {
                setTimeout(SubGridFilterExecution, 3000);
                return;
            }

            // Set Subgrid with the following query based FetchXML
            var fetchXml = "<fetch>" +
                "<entity name='ait_payment'>" +
                    "<attribute name='ait_payment_id' />" +
                    "<attribute name='ait_educationpayeetype' />" +
                    "<attribute name='ait_requestorstudentprofile' />" +
                    "<attribute name='ait_requestedpaymentamount' />" +
                    "<attribute name='ait_program' />" +
                    "<attribute name='ait_paymentstatus' />" +
                    "<attribute name='ait_paymentamount' />" +
                    "<attribute name='ait_paymentdate' />" +
                    "<attribute name='ait_masterprogram' />" +
                    "<filter type='and'>" +
                        "<condition attribute='ait_requestorstudentprofile' operator='eq' value='" + studentprofileid[0].id + "' />" +
                        "<condition attribute='ait_masterprogram' operator='eq' value='" + masterprogramid[0].id + "' />" +
                    "</filter>" +
                "</entity>" +
              "</fetch>";
            console.log("FetchXML:", fetchXml); // Console log to see the constructed FetchXML
            // Update The Subgrid Context
            gridContext.setFilterXml(fetchXml);
            // Refresh grid to show filtered records only.
            gridContext.refresh();
        },
        function error(error) {
            console.log("Error retrieving Master Program ID:", error.message);
        }
    );
}




/////////////////////////////////////////////////////////////////////////////////

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
                        } else {
                            // Clear any existing error notification if the deadline has not passed
                            Xrm.Page.ui.clearFormNotification("deadlineNotification");
                        }
                    } else {
                        // Clear any existing error notification if the application deadline is not found
                        Xrm.Page.ui.clearFormNotification("deadlineNotification");
                        console.log("Application deadline not found for the selected program.");
                    }
                },
                function error(error) {
                    // Clear any existing error notification if there was an error retrieving the program record
                    Xrm.Page.ui.clearFormNotification("deadlineNotification");
                    console.log("Error retrieving program record: " + error.message);
                }
            );
        } else {
            // Clear any existing error notification if the program ID is null
            Xrm.Page.ui.clearFormNotification("deadlineNotification");
            console.log("Program ID is null.");
        }
    } else {
        // Clear any existing error notification if no program is selected
        Xrm.Page.ui.clearFormNotification("deadlineNotification");
        console.log("No program selected.");
    }
}
