// The following logic is using Microsoft Dynamics CRM Client API Reference for model-driven apps
// The function retrieves the emergency contact's phone number
// The following comments are the steps to conduct in the JavaScript

// On form load, retrieve the value from the attribute field 'ait_emergencycontactname'
// Store 'ait_emergencycontactname' value as a variable 'emergencyContactId'
// Then conduct a Xrm.WebApi.retrieveRecord from the entity 'ait_studentcontact' and filter by the emergencyContactId, $select=ait_contact
// Store the 'ait_contact' value as a variable 'contactId'
// Then conduct a Xrm.WebApi.retrieveRecord from the entity 'contact' and filter by the contactId, $select=ait_primaryphone
// With the value from 'ait_primaryphone', update the attribute 'ait_emergencycontactphonenumber' on the form with the value from 'ait_primaryphone'

// This function will be triggered when D365 Form loads
function populateEmergencyContactPhoneNumber() {
    // Retrieve the value from attribute field 'ait_emergencycontactname'
    var emergencyContactId = Xrm.Page.getAttribute("ait_emergencycontactname").getValue()[0].id.replace('{', '').replace('}', '');
    console.log("Emergency Contact ID:", emergencyContactId);

    // Conduct a Xrm.WebApi.retrieveRecord from the entity 'ait_StudentContact' and filter by the emergencyContactId
    var studentContact = Xrm.WebApi.retrieveRecord("ait_studentcontact", emergencyContactId, "?$select=ait_name&$expand=ait_contact_value($select=ait_primaryphone)").then(
        function success(result) {
            console.log("Retrieved Values: " + result.name + " " + result.ait_contact + " " + result.ait_primaryphone);
    
        });
}


// This function will be triggered when D365 Form loads
function populateEmergencyContactPhoneNumber() {
    // Retrieve the value from attribute field 'ait_emergencycontactname'
    var emergencyContactId = Xrm.Page.getAttribute("ait_emergencycontactname").getValue()[0].id.replace('{', '').replace('}', '');
    console.log("Emergency Contact ID:", emergencyContactId);

    // Conduct a Xrm.WebApi.retrieveRecord from the entity 'ait_StudentContact' and filter by the emergencyContactId
    Xrm.WebApi.retrieveRecord("ait_studentcontact", emergencyContactId, "?$select=ait_name&$expand=ait_contact($select=contactid,fullname)").then(
        function success(result) {
            console.log("Retrieved Values: " + result.ait_name + ", Contact ID: " + result.ait_contact.contactid + ", Contact Name: " + result.ait_contact.fullname);
        },
        function (error) {
            console.log(error.message);
            // handle error conditions
        }
    );
}