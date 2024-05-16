/**
 * Handles the change event of the display section.
 */
function onDisplaySectionChange() {
    // Get the currently selected value of the dropdown menu with the ID 'ait_crtype'
    var selectedValue = $('#ait_crtype').val();

    // Check if the selected value is "a6bc02dd-ccc5-ee11-9078-001dd80ad099"
    if (selectedValue && selectedValue.includes("a6bc02dd-ccc5-ee11-9078-001dd80ad099")) {
        // If it is, show the fields 'ydsp_bankaccounttype', 'ydsp_routingnumber', 'ydsp_accountnumber', and 'ydsp_bankname'
        $('#ydsp_bankaccounttype').parent().parent().show();
        $('#ydsp_routingnumber').parent().parent().show();      
        $('#ydsp_accountnumber').parent().parent().show();
        $('#ydsp_bankname').parent().parent().show();

        // Also, make the field 'adx_attachfilerequired' required
        $('#adx_attachfilerequired').prop('required', true);
    } else {
        // If the selected value is not "a6bc02dd-ccc5-ee11-9078-001dd80ad099", hide the fields 'ydsp_bankaccounttype', 'ydsp_routingnumber', 'ydsp_accountnumber', and 'ydsp_bankname'
        $('#ydsp_bankaccounttype').parent().parent().hide();
        $('#ydsp_routingnumber').parent().parent().hide();
        $('#ydsp_accountnumber').parent().parent().hide();
        $('#ydsp_bankname').parent().parent().hide();

        // Also, make the field 'adx_attachfilerequired' not required
        $('#adx_attachfilerequired').prop('required', false);
    }
}