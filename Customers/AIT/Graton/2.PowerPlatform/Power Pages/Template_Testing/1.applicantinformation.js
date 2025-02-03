$(document).ready(function() {
    console.log("Document is ready");
    
    // Add event listener to Applicant self or other field
    if ($('#gr_applicationforselforother_').length) {
        console.log("Element found, attaching event listener");
        $('#gr_applicationforselforother_').change(onApplicantTypeChange);
    } else {
        console.log("Element not found");
    }

    // Trigger the condition for showing/hiding Student Lookup Field
    onApplicantTypeChange();
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