// 
$(document).ready(function () {
    $("#unsubmitted-applications").on("loaded", ".entitylist.entity-grid", function () {
        $(this).children(".view-grid").find("tr").each(function () {
            // Log the current row for debugging
            console.log("Unsubmitted Applications - Current Row:", $(this));

            // Select the action menu container based on its structure and attributes
            var actionMenuContainer = $(this).find("td[aria-label='action menu']");

            // Log the action menu container for debugging
            console.log("Unsubmitted Applications - Action Menu Container:", actionMenuContainer);

            if (actionMenuContainer.length) {
                // Create the new button element
                var newButton = $("<a>", {
                    href: "/Enrollment-Application-Edit/?id=" + $(this).data("id"),
                    class: "btn btn-success",
                    text: "Complete"
                });

                // Log the new button element for debugging
                console.log("Unsubmitted Applications - New Button Element:", newButton);

                // Replace the action menu with the new button
                actionMenuContainer.empty().append(newButton);

                // Log the updated action menu container for debugging
                console.log("Unsubmitted Applications - Updated Action Menu Container:", actionMenuContainer);
            } else {
                console.error("Unsubmitted Applications - Action menu container not found in row index " + $(this).index() + ":", $(this));
            }
        });
    });
});