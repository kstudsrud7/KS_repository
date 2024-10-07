//Based on the field ait_educationapplicationtype, show and hide tabs on the form

function showHideTabs(executionContext) {
    var formContext = executionContext.getFormContext();

    var educationApplicationType = formContext.getAttribute("ait_educationapplicationtype").getValue();
    console.log("Education Application Type:", educationApplicationType);
    var applicationReverification = formContext.getAttribute("ait_applicationreverification").getValue();
    console.log("Application Reverification:", applicationReverification);


    var tabsToHide = [2, 3, 4, 5]; // Array of tab numbers to hide by default
    var tabToShow;

    if (educationApplicationType === 748120000 && applicationReverification === 748120000) { //Application Type = Pre-School & Application/Reverification = Application
        tabToShow = 2;
    } else if (educationApplicationType === 748120003 && applicationReverification === 748120000) { //Application Type = K-12 & Application/Reverification = Application
        tabToShow = 3;
    } else if (educationApplicationType === 748120004 && applicationReverification === 748120000) {//Application Type = Higher Ed & Application/Reverification = Application
        tabToShow = 4;
    } else if (educationApplicationType === 748120004 && applicationReverification === 748120001) {//Application Type = Pre-School & Application/Reverification = Reverification
        tabToShow = 5;
    }

    tabsToHide.splice(tabsToHide.indexOf(tabToShow), 1); // Remove the tab to show from tabsToHide array

    // Show/Hide tabs based on logic
    formContext.ui.tabs.forEach(function(tab, index) {
        if (tabsToHide.includes(index + 1)) { // Tabs are 1-indexed
            tab.setVisible(false);
            console.log("Hiding tab:", index + 1);
        } else if (tabToShow === index + 1) {
            tab.setVisible(true);
            console.log("Showing tab:", index + 1);
        }
    });
}




