# Custom Lookup Filtering in 2024

## Introduction
The article revisits the topic of custom lookup filtering in Power Pages / Power Apps Portals, addressing changes and improvements since 2019.

## Approach
- **Avoid OOB Modal Window**: Filtering in the out-of-the-box (OOB) modal window is ineffective due to pagination issues.
- **Custom Control**: Instead of using the OOB modal, create a custom control to handle lookup selection.

## Implementation Steps
1. **Form Metadata**: Previously suggested rendering lookups as dropdowns using Form Metadata, but this approach has server-side validation issues.
2. **Custom Control**: 
   - Keep the original lookup control hidden.
   - Create a custom control to present available options and populate the value back to the original control.
   - Ensure the submitted value is included in the original query view to avoid errors.

### Example Code for Custom Control

```javascript
// function that will return filtered response
// using Power Pages Web API
function getSampleFilteredResponse(filterCondition) {
  // webapi.safeAjax is a wrapper provided by Microsoft
  // to call Power Pages Web API (you need to manually add it to the page)
  // for the latest wrapper and sample please visit official documentation via link below
  // https://learn.microsoft.com/en-us/power-pages/configure/write-update-delete-operations#web-api-ajax-samples
  return webapi.safeAjax({
    type: "GET",
    url: `/_api/dwctst_countries?$select=dwctst_countryid,dwctst_name&$filter=startswith(dwctst_name,'${filterCondition}')`,
    contentType: "application/json",
    });
}

$(document).ready(async function () {
    const lookupToHideId = "dwctst_country";
    const lookupTableLogicalName = "dwctst_country";
    const idFieldName = "dwctst_countryid";
    const textFieldName = "dwctst_name";
    // hide original lookup
    $(`#${lookupToHideId}`).parent().hide();

    const customLookupId = "my_custom_lookup";
    // create custom select
    const customSelect = $(`<select class='form-control picklist' id='${customLookupId}'>`);
    // place custom select after existing lookup
    $(`#${lookupToHideId}`).parent().after(customSelect);

    // add default selected Select option
    // to mimic OOB select behavior
    customSelect.append(`<option selected="selected" value="" label="Select" aria-label="Select">Select</option>`);

    try {
        let results = await getSampleFilteredResponse("U");

        if (results.value.length > 0) {
            // create an option element for each result
            // and append it to custom select
            results.value.forEach(el =>
                customSelect.append(`<option value='${el[idFieldName]}'>${el[textFieldName]}</option>`)
            )
        }
    } catch (error) {
        // an error occured retrieving data
        // place your error processing logic here
        console.error(error);
    }

    // add onchange event to populate actual lookup
    customSelect.on("change", function () {
        // get selected id
        const selectedValue = customSelect.val();
        // get selected text
        const selectedValueLabel = $(`#${customLookupId} option:selected`).text();

        $(`#${lookupToHideId}`).val(selectedValue);
        $(`#${lookupToHideId}_entityname`).val(lookupTableLogicalName);
        $(`#${lookupToHideId}_name`).val(selectedValueLabel);

        // trigger change event on original lookup
        $(`#${lookupToHideId}`).trigger("change");
    });

});
