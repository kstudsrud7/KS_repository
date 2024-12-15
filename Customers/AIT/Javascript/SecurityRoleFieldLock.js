function lockOrUnlockFields(executionContext) {
    var formContext = executionContext.getFormContext(); // Get the form context
    var userRoles = Xrm.Utility.getGlobalContext().userSettings.roles; // Get the logged-in user's roles
    var roleTeamUser = "FCP Tribal Education Team User"; // Role to check for lock
    var rolePowerUser = "FCP Tribal Education Power User"; // Role to check for unlock
    var roleCreateContact = "FCP Tribal Education Create Contact"; // Another role to check for unlock
    
    var hasTeamUserRole = false;
    var hasAdditionalRole = false;
    
    // Iterate through the user's roles and check for the desired roles
    userRoles.forEach(function(role) {
        var roleName = role.name;

        if (roleName === roleTeamUser) {
            hasTeamUserRole = true; // Found the 'Team User' role
        }
        if (roleName === rolePowerUser || roleName === roleCreateContact) {
            hasAdditionalRole = true; // Found one of the additional roles
        }
    });

    if (hasTeamUserRole && !hasAdditionalRole) {
        // Lock all fields if user has only 'Team User' role
        formContext.ui.controls.forEach(function(control) {
            if (control.getControlType() !== "subgrid") { // Avoid locking subgrids
                control.setDisabled(true);
            }
        });
    } else if (hasAdditionalRole) {
        // Unlock all fields if user has additional roles
        formContext.ui.controls.forEach(function(control) {
            if (control.getControlType() !== "subgrid") { // Avoid unlocking subgrids
                control.setDisabled(false);
            }
        });
    }
}
