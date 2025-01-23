$(document).ready(function() {
    // Retrieve the values from the URL parameters
    var urlParams = new URLSearchParams(window.location.search);
    var recordId = urlParams.get('id');
    var recordName = urlParams.get('name');
    var entityName = urlParams.get('entityname');

    // Set the program lookup field
    $("#ait_program_name").val(recordName);
    $("#ait_program").val(recordId);
    $("#ait_program_entityname").val(entityName);
});