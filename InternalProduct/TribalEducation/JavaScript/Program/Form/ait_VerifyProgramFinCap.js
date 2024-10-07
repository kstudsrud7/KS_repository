function VerifyProgramFinCap() {
    // Get Payment Request Field Values
    var paymentrequestid = Xrm.Page.data.entity.getId();
    console.log("PaymentRequestID:", paymentrequestid);
    var programid = Xrm.Page.getAttribute("ait_program").getValue(); // Get lookup value of ait_program
    console.log("Program:", programid);
    var CurrentrequestedPaymentAmount = Xrm.Page.getAttribute("ait_requestedpaymentamount").getValue(); // Get Requested Payment Amount Value
    console.log("Requested Payment Amount:", CurrentrequestedPaymentAmount);

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
                                "<condition attribute='ait_paymentstatus' operator='ne' value='914600002' />" +
                                "</filter>" +
                                "<link-entity name='ait_program' from='ait_programid' to='ait_program' link-type='inner' alias='Program'>" +
                                "<filter>" +
                                "<condition attribute='ait_programid' operator='eq' value='" + programidstringFormatted + "' />" +
                                "</filter>" +
                                "</link-entity>" +
                                "</entity>" +
                                "</fetch>";
                            console.log("Standard FetchXML:", fetchXml);

                            // Execute FetchXML query
                            Xrm.WebApi.retrieveMultipleRecords("ait_payment", "?fetchXml=" + fetchXml).then(
                                function success(result) {
                                    var sumRequestedPaymentAmounts = 0;

                                    if (result.entities.length > 0) {
                                        result.entities.forEach(function(entity) {
                                            // Retrieve the value of ait_requestedpaymentamount attribute from each entity
                                            var requestedPaymentAmount = entity["ait_requestedpaymentamount"];

                                            // Convert the retrieved value to a number and add it to the sum
                                            sumRequestedPaymentAmounts += parseFloat(requestedPaymentAmount) + CurrentrequestedPaymentAmount;
                                        });

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
                                function(error) {
                                    console.log("Error retrieving payment records:", error.message);
                                }
                            );
                        },
                        function(error) {
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
                                ;

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
                                            "</filter>" +
                                            "<link-entity name='ait_program' from='ait_programid' to='ait_program' link-type='inner' alias='Program'>" +
                                            "<filter>" +
                                            "<condition attribute='ait_programid' operator='eq' value='" + programidstringFormatted + "' />" +
                                            "</filter>" +
                                            "</link-entity>" +
                                            "</entity>" +
                                            "</fetch>";
                                        console.log("Sub Program FetchXML:", fetchXml);

                                        // Execute FetchXML query
                                        Xrm.WebApi.retrieveMultipleRecords("ait_payment", "?fetchXml=" + fetchXml).then(
                                            function success(result) {
                                                var sumRequestedPaymentAmounts = 0;

                                                if (result.entities.length > 0) {
                                                    result.entities.forEach(function(entity) {
                                                        // Retrieve the value of ait_requestedpaymentamount attribute from each entity
                                                        var requestedPaymentAmount = entity["ait_requestedpaymentamount"];

                                                        // Convert the retrieved value to a number and add it to the sum
                                                        sumRequestedPaymentAmounts += parseFloat(requestedPaymentAmount) + CurrentrequestedPaymentAmount;
                                                    });

                                                    console.log("Sum of Requested Payment Amounts:", sumRequestedPaymentAmounts);

                                                    // Check if the sumRequestedPaymentAmount exceeds programCapAmount
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
                                            function(error) {
                                                console.log("Error retrieving payment records:", error.message);
                                            }
                                        );
                                    },
                                    function(error) {
                                        console.log("Error retrieving Sub Program cap amount:", error.message);
                                    }
                                );
                            }
                        },
                        function(error) {
                            console.log("Error retrieving Sub Program ID:", error.message);
                        }
                    );
                }
            },
            function(error) {
                console.log("Error retrieving Financial Cap Type:", error.message);
            }
        );
    } else {
        console.log("Program is not selected.");
    }
}
