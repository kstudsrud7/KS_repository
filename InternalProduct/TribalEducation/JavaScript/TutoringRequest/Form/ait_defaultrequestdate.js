
/**
 * Sets the default value for the 'ait_requestdate' field to today's date if it doesn't have a value yet.
 */
function defaultRequestDate() {
    // Get the 'ait_requestdate' field
    var requestDateField = Xrm.Page.getAttribute("ait_requestdate");

    // If the field exists and doesn't have a value yet
    if (requestDateField != null && requestDateField.getValue() == null) {
        // Set the default value to today's date
        requestDateField.setValue(new Date());
    }
}
