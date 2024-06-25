function toggleFieldsAndSections(executionContext) {
    var formContext = executionContext.getFormContext();

    // Get the value of the schoolType field
    var schoolType = formContext.getAttribute("ait_schooltype").getValue();
    console.log("School Type:", schoolType);

    // Get the value of the companyType field
    var companyType = formContext.getAttribute("ait_companytype").getValue();
    console.log("Company Type:", companyType);

    // Get the section
    var k12InfoSection = formContext.ui.tabs.get("{23f4edc8-4ac3-4c91-8cba-d00616c2121a}").sections.get("K12Info");
    if (!k12InfoSection) {
        console.error("Section 'K12Info' not found");
    }

    // Define the controls to show or hide
    var controlsToToggle = [
        "ait_gradesoffered",
        "ait_gradingperiods",
        "ait_gradingperiodother",
        "ait_transportationoffered",
        "ait_offersjomprogram"
    ];

    if (schoolType == 748120003 && companyType == 748120001) { // If schoolType equals K-12 and companyType equals Type A
        console.log("Condition met: schoolType is K-12 and companyType is Type A");

        // Show fields
        controlsToToggle.forEach(function(controlName) {
            var control = formContext.getControl(controlName);
            if (control) {
                control.setVisible(true);
                console.log("Showing field:", controlName);
            } else {
                console.error("Control not found:", controlName);
            }
        });

        // Show section
        if (k12InfoSection) {
            k12InfoSection.setVisible(true);
            console.log("Showing section: K12Info");
        }
    } else {
        console.log("Condition not met: Hiding fields and section");

        // Hide fields and clear values
        controlsToToggle.forEach(function(controlName) {
            var control = formContext.getControl(controlName);
            var attribute = formContext.getAttribute(controlName);
            if (control) {
                control.setVisible(false);
                console.log("Hiding field:", controlName);
            } else {
                console.error("Control not found:", controlName);
            }
            if (attribute) {
                attribute.setValue(null);
                console.log("Clearing value of field:", controlName);
            } else {
                console.error("Attribute not found:", controlName);
            }
        });

        // Hide section
        if (k12InfoSection) {
            k12InfoSection.setVisible(false);
            console.log("Hiding section: K12Info");
        }
    }
}
