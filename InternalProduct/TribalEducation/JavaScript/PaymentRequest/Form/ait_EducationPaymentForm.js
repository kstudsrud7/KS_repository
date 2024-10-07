function VerifyProgramFinCap() {
    // Get Payment Request Field Values
    // On Change of Field:  'Requested Payment Amount ($)'
    var paymentrequestid = Xrm.Page.data.entity.getId();
    console.log("PaymentRequestID:", paymentrequestid);
    var programid = Xrm.Page.getAttribute("ait_program").getValue(); // Get lookup value of ait_program
    console.log("Program:", programid);
    var CurrentrequestedPaymentAmount = Xrm.Page.getAttribute("ait_requestedpaymentamount").getValue(); // Get Requested Payment Amount Value
    console.log("Requested Payment Amount:", CurrentrequestedPaymentAmount);
    var studentProfileID = Xrm.Page.getAttribute("ait_requestorstudentprofile").getValue(); // Get lookup value of ait_studentprofile
    console.log("Student Profile:", studentProfileID);
    var formattedStudentProfileID = studentProfileID[0].id.replace('{', '').replace('}', ''); // Format studentProfileID to pass it to the retrieveRecord function
    console.log("Formatted Student Profile ID:", formattedStudentProfileID);

    // Check if programid is not null
    if (programid != null) {
        // Format programid to pass it to the retrieveRecord function
        var programidstringFormatted = programid[0].id.replace('{', '').replace('}', '');

        // Retrieve Related Program Financial Cap Type field
        Xrm.WebApi.retrieveRecord("ait_program", programidstringFormatted, "?$select=ait_financialcaptype").then(
            function success(result) {
                var financialType = result.ait_financialcaptype;
                console.log("Financial Cap Type:", financialType);

                if (financialType === 750000001) { // Standard Program
                    // Retrieve Program Cap Amount
                    Xrm.WebApi.retrieveRecord("ait_program", programidstringFormatted, "?$select=ait_programcapamount").then(
                        function success(result) {
                            var programCapAmount = result.ait_programcapamount;
                            console.log("Program Cap Amount:", programCapAmount);

                            // Fetch aggregate SUM of ait_requestedpaymentamount
                            var fetchXml = "<fetch>" +
                                "<entity name='ait_payment'>" +
                                "<attribute name='ait_requestedpaymentamount' />" +
                                "<filter>" +
                                "<condition attribute='ait_paymentid' operator='ne' value='" + paymentrequestid + "' />" +
                                "<condition attribute='ait_requestorstudentprofile' operator='eq' value='" + formattedStudentProfileID + "' />" +
                                "<condition attribute='ait_paymentstatus' operator='ne' value='914600002' />" +
                                "<condition attribute='ait_program' operator='eq' value='" + programidstringFormatted + "' />" +
                                "</filter>" +
                                "</entity>" +
                                "</fetch>";
                            console.log("Standard FetchXML:", fetchXml);

                            // Execute FetchXML query
                            Xrm.WebApi.retrieveMultipleRecords("ait_payment", `?fetchXml=${encodeURIComponent(fetchXml)}`).then(
                                function success(result) {
                                    var sumRequestedPaymentAmounts = 0;

                                    if (result.entities.length > 0) {
                                        result.entities.forEach(function (entity) {
                                            // Retrieve the value of ait_requestedpaymentamount attribute from each entity
                                            var requestedPaymentAmount = entity["ait_requestedpaymentamount"];

                                            // Convert the retrieved value to a number and add it to the sum
                                            sumRequestedPaymentAmounts += parseFloat(requestedPaymentAmount);
                                        });

                                        // Add the current requested payment amount
                                        sumRequestedPaymentAmounts += CurrentrequestedPaymentAmount;
                                        console.log("Sum of Requested Payment Amounts:", sumRequestedPaymentAmounts);

                                        // Check if the sumRequestedPaymentAmount exceeds programCapAmount
                                        if (sumRequestedPaymentAmounts > programCapAmount) {
                                            // Show error notification
                                            Xrm.Page.ui.setFormNotification('Requested Amount Exceeds Program Cap Amount', 'ERROR');
                                            // Set ait_requestedpaymentamount to NULL
                                            Xrm.Page.getAttribute("ait_requestedpaymentamount").setValue(null);
                                        } else {
                                            console.log("Sum of requested payment amount is within program cap amount.");
                                            // Clear any previous error notifications
                                            Xrm.Page.ui.clearFormNotification();
                                        }
                                    } else {
                                        console.log("No payment records found for calculation.");
                                        // Set sumRequestedPaymentAmounts to 0
                                        sumRequestedPaymentAmounts = CurrentrequestedPaymentAmount;

                                        // Continue with the remaining logic
                                        // Check if the sumRequestedPaymentAmount exceeds programCapAmount
                                        if (sumRequestedPaymentAmounts > programCapAmount) {
                                            // Show error notification
                                            Xrm.Page.ui.setFormNotification('Requested Amount Exceeds Program Cap Amount', 'ERROR');
                                            // Set ait_requestedpaymentamount to NULL
                                            Xrm.Page.getAttribute("ait_requestedpaymentamount").setValue(null);
                                        } else {
                                            console.log("Sum of requested payment amount is within program cap amount.");
                                            // Clear any previous error notifications
                                            Xrm.Page.ui.clearFormNotification();
                                        }
                                    }
                                },
                                function (error) {
                                    console.log("Error retrieving payment records:", error.message);
                                }
                            );
                        },
                        function (error) {
                            console.log("Error retrieving program cap amount:", error.message);
                        }
                    );
                } else if (financialType === 748120001) { // Sub Program
                    // Retrieve Master ID
                    Xrm.WebApi.retrieveRecord("ait_program", programidstringFormatted, "?$select=_ait_masterprogram_value").then( // Lookups have to have "_schema_value"
                        function success(result) {
                            var masterprogramid = result._ait_masterprogram_value;
                            console.log("Master Program ID:", masterprogramid);

                            // Check if masterprogramid is not null
                            if (masterprogramid != null) {
                                // Format masterprogramid to pass it to the retrieveRecord function
                                var masterprogramidFormatted = masterprogramid.replace('{', '').replace('}', '');

                                // Retrieve Related Sub Program Cap Amount
                                Xrm.WebApi.retrieveRecord("ait_program", programidstringFormatted, "?$select=ait_programcapamount").then(
                                    function success(result) {
                                        var subprogramcapamount = result.ait_programcapamount;
                                        console.log("Sub Program Cap Amount:", subprogramcapamount);

                                        // Fetch aggregate SUM of ait_requestedpaymentamount
                                        var fetchXml = "<fetch>" +
                                            "<entity name='ait_payment'>" +
                                            "<attribute name='ait_requestedpaymentamount' />" +
                                            "<filter>" +
                                            "<condition attribute='ait_paymentid' operator='ne' value='" + paymentrequestid + "' />" +
                                            "<condition attribute='ait_paymentstatus' operator='ne' value='914600002' />" +
                                            "<condition attribute='ait_requestorstudentprofile' operator='eq' value='" + formattedStudentProfileID + "' />" +
                                            "<condition attribute='ait_program' operator='eq' value='" + programidstringFormatted + "' />" +
                                            "</filter>" +
                                            "</entity>" +
                                            "</fetch>";
                                        console.log("Sub Program FetchXML:", fetchXml);

                                        // Execute FetchXML query
                                        Xrm.WebApi.retrieveMultipleRecords("ait_payment", `?fetchXml=${encodeURIComponent(fetchXml)}`).then(
                                            function success(result) {
                                                var sumRequestedPaymentAmounts = 0;

                                                if (result.entities.length > 0) {
                                                    result.entities.forEach(function (entity) {
                                                        // Retrieve the value of ait_requestedpaymentamount attribute from each entity
                                                        var requestedPaymentAmount = entity["ait_requestedpaymentamount"];

                                                        // Convert the retrieved value to a number and add it to the sum
                                                        sumRequestedPaymentAmounts += parseFloat(requestedPaymentAmount);
                                                    });

                                                    // Add the current requested payment amount
                                                    sumRequestedPaymentAmounts += CurrentrequestedPaymentAmount;
                                                    console.log("Sum of Requested Payment Amounts:", sumRequestedPaymentAmounts);

                                                    // Check if the sumRequestedPaymentAmount exceeds subprogramcapamount
                                                    if (sumRequestedPaymentAmounts > subprogramcapamount) {
                                                        // Show error notification
                                                        Xrm.Page.ui.setFormNotification('Requested Amount Exceeds Sub Program Cap Amount', 'ERROR');
                                                        // Set ait_requestedpaymentamount to NULL
                                                        Xrm.Page.getAttribute("ait_requestedpaymentamount").setValue(null);
                                                    } else {
                                                        console.log("Sum of requested payment amount is within Sub Program Cap Amount.");
                                                        // Clear any previous error notifications
                                                        Xrm.Page.ui.clearFormNotification();
                                                    }
                                                } else {
                                                    console.log("No payment records found for calculation.");
                                                    // Set sumRequestedPaymentAmounts to 0
                                                    sumRequestedPaymentAmounts = CurrentrequestedPaymentAmount;

                                                    // Continue with the remaining logic
                                                    // Check if the sumRequestedPaymentAmount exceeds subprogramcapamount
                                                    if (sumRequestedPaymentAmounts > subprogramcapamount) {
                                                        // Show error notification
                                                        Xrm.Page.ui.setFormNotification('Requested Amount Exceeds Sub Program Cap Amount', 'ERROR');
                                                        // Set ait_requestedpaymentamount to NULL
                                                        Xrm.Page.getAttribute("ait_requestedpaymentamount").setValue(null);
                                                    } else {
                                                        console.log("Sum of requested payment amount is within Sub Program Cap Amount.");
                                                        // Clear any previous error notifications
                                                        Xrm.Page.ui.clearFormNotification();
                                                    }
                                                }
                                            },
                                            function (error) {
                                                console.log("Error retrieving payment records:", error.message);
                                            }
                                        );
                                    },
                                    function (error) {
                                        console.log("Error retrieving Sub Program cap amount:", error.message);
                                    }
                                );
                            }
                        },
                        function (error) {
                            console.log("Error retrieving Sub Program ID:", error.message);
                        }
                    );
                }
            },
            function (error) {
                console.log("Error retrieving Financial Cap Type:", error.message);
            }
        );
    } else {
        console.log("Program is not selected.");
    }
}

////////////////////////////////////////////////////////////////////////////////

// Function to The Master Program Associated with the Program Lookup record
function ShowHideMasterProgram(executionContext) {
    var formContext = executionContext.getFormContext();
    var aitProgramValue = formContext.getAttribute("ait_program").getValue();
    console.log("Program Value: " + aitProgramValue);

    if (aitProgramValue) {
        // Format the aitProgramValue similar to the programidstringFormatted
        var aitProgramIdFormatted = aitProgramValue[0].id.replace('{', '').replace('}', '');
        console.log("Formatted Program ID: " + aitProgramIdFormatted);

        Xrm.WebApi.retrieveRecord("ait_program", aitProgramIdFormatted, "?$select=ait_name,_ait_masterprogram_value").then(
            function success(result) {
                console.log(result);

                if (result._ait_masterprogram_value) {
                    var lookup = [{
                        id: result["_ait_masterprogram_value"],
                        name: result["_ait_masterprogram_value@OData.Community.Display.V1.FormattedValue"],
                        entityType: result["_ait_masterprogram_value@Microsoft.Dynamics.CRM.lookuplogicalname"]
                    }];
                    formContext.getAttribute("ait_masterprogram").setValue(lookup);

                    // Show the ait_masterprogram field
                    formContext.getControl("ait_masterprogram").setVisible(true);
                } else {
                    // Clear the field if there is no master program
                    formContext.getAttribute("ait_masterprogram").setValue(null);
                    
                    // Hide the ait_masterprogram field
                    formContext.getControl("ait_masterprogram").setVisible(false);
                }
            },
            function (error) {
                console.log(error.message);
            }
        );
    } else {
        // Clear the field if aitProgramValue is null or undefined
        formContext.getAttribute("ait_masterprogram").setValue(null);

        // Hide the ait_masterprogram field
        formContext.getControl("ait_masterprogram").setVisible(false);
    }
}

