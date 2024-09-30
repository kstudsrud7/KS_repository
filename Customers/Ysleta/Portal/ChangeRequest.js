/**
 * Power Pages Javascript for Change Request Form.
 * Initializes the document when ready.
 * - Hides the parent of elements with data-name="diagSection".
 * - Sets the max-width of elements with class "textarea" to 409px.
 * - Adds event listener to the change event of #ait_crtype.
 * - Adds input event listener to #ydsp_routingnumber to limit character length to 9.
 * - Triggers the condition for showing/hiding bank account information on form load.
 * - Applies client-side validation on #adx_attachfilerequired.
 */
$(document).ready(function() {
    $('[data-name="diagSection"]').parent().hide();
    
    // Only let them re-size the text box to the width of the form
    $(".textarea").css({
        "max-width": "409px"
    });
    
    // If we want to just disable all re-sizing use this:
    // $(".textarea").css({"resize":"none"});
    
    // Add event listener to the change event of ait_crtype
    $('#ait_crtype').change(onDisplaySectionChange);

    // Add event listeners to the input fields for character limit
    $('#ydsp_routingnumber').on('input', function() {
        if (this.value.length > 9) {
            this.value = this.value.slice(0, 9);
        }
    });

    // Trigger the condition for showing/hiding bank account information when the form loads
    onDisplaySectionChange();

    // Apply Client Side Validation on adx_attachfilerequired
    if (window.jQuery) {
        (function ($) {
            $(document).ready(function () {
                if (typeof (Page_Validators) == 'undefined') return;
                
                // Create new validator
                var fileRequiredValidator = document.createElement('span');
                fileRequiredValidator.style.display = "none";
                fileRequiredValidator.id = "adx_attachfilerequiredValidator";
                fileRequiredValidator.controltovalidate = "adx_attachfilerequired";
                fileRequiredValidator.errormessage = "<a href='#adx_attachfilerequired_label'>REQUIRED: Please attach a filled-out EFT Direct Deposit Authorization Form along with a copy of a bank letter or voided check.";
                fileRequiredValidator.validationGroup = ""; // Set this if you have set ValidationGroup on the form
                fileRequiredValidator.initialvalue = "";
                fileRequiredValidator.evaluationfunction = function () {
                    var selectedValue = $('#ait_crtype').val();
                    if (selectedValue && selectedValue.includes("a6bc02dd-ccc5-ee11-9078-001dd80ad099")) {
                        var fileAttachedPath = $("#AttachFile").val();
                        if (fileAttachedPath == null || fileAttachedPath == undefined || fileAttachedPath == "") {
                            return false;
                        } else {
                            return true;
                        }
                    } else {
                        return true; // No validation needed if ait_crtype is not "a6bc02dd-ccc5-ee11-9078-001dd80ad099"
                    }
                };
                // Add the new validator to the page validators array:
                Page_Validators.push(fileRequiredValidator);
                // Wire-up the click event handler of the validation summary link
                $("a[href='#adx_attachfilerequired_label']").on("click", function () { scrollToAndFocus('adx_attachfilerequired_label','adx_attachfilerequired'); });
            });
        }(window.jQuery));
    }
});

// Show / Hide Bank Account Information Fields
/**
 * Event handler for showing or hiding bank account information fields based on the selected value of #ait_crtype.
 * - Shows the bank account information fields if the selected value includes "a6bc02dd-ccc5-ee11-9078-001dd80ad099".
 * - Hides the bank account information fields otherwise.
 * - Updates the HTML content of #AttachFileLabel based on the selected value.
 */
function onDisplaySectionChange() {
    var selectedValue = $('#ait_crtype').val();
    if (selectedValue && selectedValue.includes("a6bc02dd-ccc5-ee11-9078-001dd80ad099")) {
        $('#ydsp_bankaccounttype').parent().parent().show();
        $('#ydsp_routingnumber').parent().parent().show();      
        $('#ydsp_accountnumber').parent().parent().show();
        $('#ydsp_bankname').parent().parent().show();
        $('#adx_attachfilerequired').prop('required', true);
        $("#AttachFileLabel").html(`Please attach a filled-out EFT Direct Deposit Authorization Form along with a copy of a bank letter or voided check.
        For questions, please send an email to <a href="mailto:finance@ydsp-nsn.gov">finance@ydsp-nsn.gov</a> or call (915) 859-7913.<br>
        <a href="https://www.ysletadelsurpueblo.org/documents/steps-to-change-banking-info" target="_blank">Steps to Change Banking Information</a><br>
        <a href="https://www.ysletadelsurpueblo.org/documents/electronic-funds-transfer-form" target="_blank">Electronic Funds Transfer form</a>`);
    } else {
        $('#ydsp_bankaccounttype').parent().parent().hide();
        $('#ydsp_routingnumber').parent().parent().hide();
        $('#ydsp_accountnumber').parent().parent().hide();
        $('#ydsp_bankname').parent().parent().hide();
        $('#adx_attachfilerequired').prop('required', false);
        $("#AttachFileLabel").html("Please attach a file");
    }
}

