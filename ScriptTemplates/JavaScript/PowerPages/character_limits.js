// Add an event listener to the input field with the ID 'ydsp_routingnumber'
$('#ydsp_routingnumber').on('input', function() {
    // Inside the event listener, check the length of the input
    if (this.value.length > 9) {
        // If the input is longer than 9 characters, cut it down to the first 9 characters
        this.value = this.value.slice(0, 9);
    }
});

// Add an event listener to the input field with the ID 'ydsp_accountnumber'
$('#ydsp_accountnumber').on('input', function() {
    // Inside the event listener, check the length of the input
    if (this.value.length > 9) {
        // If the input is longer than 9 characters, cut it down to the first 9 characters
        this.value = this.value.slice(0, 9);
    }
});
