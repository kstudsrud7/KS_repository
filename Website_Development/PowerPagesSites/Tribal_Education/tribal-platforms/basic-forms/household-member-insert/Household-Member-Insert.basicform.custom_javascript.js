$(document).ready(function() {
    $('[data-name="diagSection"]').parent().hide();
//Only let them re-size the text box to the width of the form
    $(".textarea").css({"max-width":"409px"});
//If we want to just disable all re-sizing use this:
//$(".textarea").css({"resize":"none"});
});
