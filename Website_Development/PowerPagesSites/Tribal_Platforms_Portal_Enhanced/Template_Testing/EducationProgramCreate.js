$(document).ready(function() {
    // Retrieve the values from the URL parameters
    var urlParams = new URLSearchParams(window.location.search);
    var recordId = urlParams.get('id');
    var recordName = urlParams.get('name');
    var entityName = urlParams.get('entityname');
    //Contact Lookup Variable
    var contactName = "{{user.fullname}}";
    var contactId = "{{user.id}}";
    var contactEntity = "contact";
    
    // Add event listener to the Applicant Type dropdown
    if ($('#gr_applicationforselforother_').length) {
        console.log("Element found, attaching event listener");
        $('#gr_applicationforselforother_').change(onApplicantTypeChange);
    } else {
        console.log("Element not found");
    }

    // Trigger the condition for showing/hiding Student Lookup Field
    onApplicantTypeChange();

    // Set the program lookup field
    $("#ait_program_name").val(recordName);
    $("#ait_program").val(recordId);
    $("#ait_program_entityname").val(entityName);

    // Set the contact lookup field
    $("#gr_contactstudent_name").val(contactName);
    $("#gr_contactstudent").val(contactId);
    $("#gr_contactstudent_entityname").val(contactEntity)
});

function onApplicantTypeChange() {
    var selectedValue = $('#gr_applicationforselforother_').val();
    console.log("Applicant type changed, selected value: " + selectedValue);
    if (selectedValue == "750000000") { // Self
        console.log("Hiding student profile field");
        $('#ait_studentprofileid').parent().parent().hide();
    } else if (selectedValue == "750000001") { // Other
        console.log("Showing student profile field");
        $('#ait_studentprofileid').parent().parent().show();
    } else if (selectedValue == null || selectedValue === "") { // Null or empty
        console.log("Hiding student profile field due to null or empty value");
        $('#ait_studentprofileid').parent().parent().hide();
    }
}