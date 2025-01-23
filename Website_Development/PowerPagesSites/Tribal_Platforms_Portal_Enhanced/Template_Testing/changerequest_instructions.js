$(document).ready(function () {
    console.log('Document is ready. Initializing event listeners.');

    // Add event listener to the Change Request Type dropdown
    $('#ait_crtype').change(function () {
        const selectedValue = $(this).val(); // Get the selected GUID value
        console.log('Change Request Type selected:', selectedValue);

        if (selectedValue) {
            // Call the function to fetch data from Dataverse
            console.log('Fetching instructions for GUID:', selectedValue);
            fetchChangeRequestTypeInstructions(selectedValue);
        } else {
            console.log('No Change Request Type selected. Clearing instructions.');
            // Clear the instructions if no option is selected
            updateCustomInstructions('Please select a change request type to see instructions.');
        }
    });
});

/**
 * Fetches the change request type instructions from Dataverse.
 * @param {string} guid - The GUID of the selected change request type.
 */
function fetchChangeRequestTypeInstructions(guid) {
    const apiUrl = `/_api/ait_changerequesttype(${guid})?$select=ait_changerequesttypeinstructions`;

    console.log('Making API request to:', apiUrl);

    // Perform an AJAX request to Dataverse
    $.ajax({
        type: 'GET',
        url: apiUrl,
        headers: {
            'OData-MaxVersion': '4.0',
            'OData-Version': '4.0',
            'Accept': 'application/json',
        },
        success: function (data) {
            console.log('API request successful. Response:', data);

            const instructions = data.ait_changerequesttypeinstructions || 'No instructions available.';
            console.log('Fetched instructions:', instructions);
            updateCustomInstructions(instructions);
        },
        error: function (xhr, status, error) {
            console.error('Error during API request:', error);
            console.error('Status:', status);
            console.error('Response:', xhr.responseText);
            updateCustomInstructions('Error fetching instructions. Please try again later.');
        },
    });
}

/**
 * Updates the Custom Instructions element with the provided instructions.
 * @param {string} instructions - The instructions to display.
 */
function updateCustomInstructions(instructions) {
    console.log('Updating Custom Instructions with:', instructions);
    $('.Custom_Instructions').text(instructions);
}
