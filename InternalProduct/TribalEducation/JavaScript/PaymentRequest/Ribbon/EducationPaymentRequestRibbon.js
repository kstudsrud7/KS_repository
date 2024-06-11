//Hide '+ New Payment Request Button
function financialTabCheck(executionContext) {
    var flag = true;
    console.log("Initial flag value: ", flag);
    
    var formContext = executionContext.getFormContext();
    console.log("Form context retrieved.");

    var tab = formContext.ui.tabs.get("financialcap");
    console.log("Tab retrieved: ", tab);

    var displayState = tab.getDisplayState();
    console.log("Tab display state: ", displayState);

    if (displayState === "expanded") {
        flag = false;
        console.log("Tab is expanded, setting flag to: ", flag);
    } else {
        flag = true;
        console.log("Tab is not expanded, setting flag to: ", flag);
    }

    console.log("Final flag value: ", flag);
    return flag;
}
