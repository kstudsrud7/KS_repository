// Function to retrieve a record and handle the form based on the retrieved values
function showhidedetails(executionContext) {
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

                switch(aitFinancialType) 
                {
                    case 750000000: // None
                        tab.setVisible(false);
                        break;
                    case 750000002: // Master Program
                    case 748120001: // Sub Program
                        tab.setVisible(true);
                        break;
                    case 750000001: // Standard
                        tab.setVisible(true);
                        var section = tab.sections.get("financialcap_section_4");
                        section.setVisible(false);
                        break;
                }
            })
            .catch(function(error) {
                console.log(error.message);
            });
        }
}

// Call the function on form load
showhidedetails(executionContext);