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

// Call the function when the form loads
Xrm.Page.data.entity.addOnLoad(paymentRequestMasterFilters);
