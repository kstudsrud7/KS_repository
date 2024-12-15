// Wait until the form is fully loaded
$(document).ready(function() {
    // Replace these with the logical names of your fields
    var conditionField = "ait_hasgraduationtermyearchanged";
    var targetField = "ait_graduationterm";

    // Hide the target field by default
    $("table[data-name='" + targetField + "']").hide();

    // Monitor changes in the condition field
    $("input[data-name='" + conditionField + "']").change(function() {
        var conditionValue = $(this).val(); // Get the value of the condition field

        if (conditionValue === 1) {
            // Show the target field
            $("table[data-name='" + targetField + "']").show();
        } else {
            // Hide the target field
            $("table[data-name='" + targetField + "']").hide();
        }
    });
});