//Co-Pilot Prompt...
//On a dynamics 365 form I want to retrived the attribute value of 'ait_emergencycontactname' look field.
// with that value I want to run a retrieve record to query the 'ait_studentcontact' entity
// Here is the following odata expression to help retreive it: https://tribaleducationbase.crm.dynamics.com/api/data/v9.2/ait_studentcontacts?$expand=ait_Contact($select=ait_primaryphone)&$filter=(ait_studentcontactid eq 'ait_emergencycontactname value') and (ait_Contact/contactid ne null)
// after retriving it, I want to capture the ait_primaryphone value and update the current record field 'ait_emergencycontactphonenumber
//Add console logs after each of the prompts for bug tracking


function populateEmergencyContactPhoneNumber() {
    var emergencyContactName = Xrm.Page.getAttribute("ait_emergencycontactname").getValue();
    console.log("Emergency Contact Name: ", emergencyContactName)
    if (emergencyContactName) {
        var contactId = emergencyContactName[0].id.replace("{", "").replace("}", "");
        console.log("Contact ID: ",contactId);
        var entityName = "ait_studentcontact";
        console.log("Entity: ",entityName);
        var entityId = contactId;
        console.log("EntityID: ",entityId);
        var expandQuery = "?$expand=ait_Contact($select=ait_primaryphone)";
        console.log("EQ: ",expandQuery);
        Xrm.WebApi.retrieveRecord(entityName, entityId, expandQuery).then(
            function success(result) {
                console.log("Retrive Record: ", result);
                if (result && result.ait_Contact) {
                    var primaryPhone = result.ait_Contact.ait_primaryphone; // Lookup to contact, and grabs attribute
                    if (primaryPhone) {
                        Xrm.Page.getAttribute("ait_emergencycontactphonenumber").setValue(primaryPhone);
                    } else {
                        // Handle if primary phone is not available
                    }
                } else {
                    // Handle if no record found
                }
            },
            function error(error) {
                // Handle error
            }
        );
    } else {
        // Handle if emergency contact name is not selected
    }
}
