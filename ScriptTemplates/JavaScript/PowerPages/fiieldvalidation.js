// Check if jQuery is available
if (window.jQuery) {
    (function ($) {
        // Run the script when the document is ready
        $(document).ready(function () {
            // If Page_Validators is undefined, stop the script
            if (typeof (Page_Validators) == 'undefined') return;

            // Create new validator
            var fileRequiredValidator = document.createElement('span');
            fileRequiredValidator.style.display = "none"; // Hide the validator
            fileRequiredValidator.id = "adx_attachfilerequiredValidator"; // Set the ID of the validator
            fileRequiredValidator.controltovalidate = "adx_attachfilerequired"; // Set the control to validate
            // Set the error message
            fileRequiredValidator.errormessage = "<a href='#adx_attachfilerequired_label'>REQUIRED: Please attach a filled-out EFT Direct Deposit Authorization Form along with a copy of a bank letter or voided check.<br> For questions, please send an email to finance@ydsp-nsn.gov or call (915) 859-7913.";
            fileRequiredValidator.validationGroup = ""; // Set this if you have set ValidationGroup on the form
            fileRequiredValidator.initialvalue = ""; // Set the initial value

            // Define the validation rule
            fileRequiredValidator.evaluationfunction = function () {
                // Get the selected value
                var selectedValue = $('#ait_crtype').val();
                // If the selected value is "a6bc02dd-ccc5-ee11-9078-001dd80ad099"
                if (selectedValue && selectedValue.includes("a6bc02dd-ccc5-ee11-9078-001dd80ad099")) {
                    // Get the file path
                    var fileAttachedPath = $("#AttachFile").val();
                    // If no file is attached, return false (invalid)
                    if (fileAttachedPath == null || fileAttachedPath == undefined || fileAttachedPath == "") {
                        return false;
                    }
                    // If a file is attached, return true (valid)
                    else {
                        return true;
                    }
                } else {
                    // If the selected value is not "a6bc02dd-ccc5-ee11-9078-001dd80ad099", return true (valid)
                    return true;
                }
            };

            // Add the new validator to the page validators array
            Page_Validators.push(fileRequiredValidator);

            // Wire-up the click event handler of the validation summary link
            $("a[href='#adx_attachfilerequired_label']").on("click", function () { scrollToAndFocus('adx_attachfilerequired_label','adx_attachfilerequired'); });
        });
    }(window.jQuery));
}