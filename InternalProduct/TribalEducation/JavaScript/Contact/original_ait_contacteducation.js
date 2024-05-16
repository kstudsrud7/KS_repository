/***********************************************************/
// onLoad event function
function onLoadContactEducation() {

    var loadActions = function () {
        AITFormLibrary.AddOnChange('ait_startdate', onChangeVerifyDates);
        AITFormLibrary.AddOnChange('ait_enddate', onChangeVerifyDates);
        onLoadHideOrShowChangeRequestTab();
        onLoadHideOrShowDegreesQualificationsTab();
        AITFormLibrary.AddOnChange('ait_contacttype', onLoadHideOrShowDegreesQualificationsTab); 
        onLoadLockOrUnlockTribalIDField();
        onLoadLockOrUnlockMemberStatusField(); 
        onLoadLockOrUnlockTribeField();
        onLoadLockOrUnlockEthnicityField();

        AITFormLogicLibrary.InitializeChildForm('ait_contact');

    }

    onScriptReady('AITFormLibrary', loadActions);
}

//onScriptReady checks to make sure that a resource is available
function onScriptReady(name, callback) {

    var interval = 10;
    window.setTimeout(function () {
        if (window[name]) {
            callback(window[name]);
        } else {
            window.setTimeout(arguments.callee, interval);
        }
    }, interval);

}

/***********************************************************/
// Verify start date is before end date.
function onChangeVerifyDates() {
    AITDateLibrary.SetStartEndDateNotification('ait_startdate', 'ait_enddate');
}

/***********************************************************/
// onLoad function for Education app.
// If Enrollment is deployed, show Change Request tab.
function onLoadHideOrShowChangeRequestTab() {
    var tribalEnrollmentConfigRecordMissing = 'MissingRecord';
    Xrm.Page.ui.clearFormNotification(tribalEnrollmentConfigRecordMissing);
    Xrm.WebApi.retrieveMultipleRecords("ait_tribalenrollmentconfiguration").then(
        function success(result) {
            if (result != null && result.entities.length >= 1) {
                var tribalEnrollmentConfigRecord = result.entities[0];
                if (tribalEnrollmentConfigRecord.ait_enrollmentdeployed == true) {
                    AITFormLibrary.SetTabVisible("ChangeRequests", true); 
                } else {
                    AITFormLibrary.SetTabVisible("ChangeRequests", false); 
                }
            }
            else {
                Xrm.Page.ui.setFormNotification('Error: Missing Tribal Enrollment Configuration Record. Please ask your administrator.', 'WARNING', tribalEnrollmentConfigRecordMissing);
            }
        },
        function (error) {
            console.log(error.message);
        })
}

/***********************************************************/
// onLoad function for Education app.
// 
function onLoadHideOrShowDegreesQualificationsTab() {
    var contactType = AITFormLibrary.GetFieldValue('ait_contacttype'); 
    if (contactType != 748120004) {
        AITFormLibrary.SetTabVisible('Degrees_Qualifications', false); 
    } else {
        AITFormLibrary.SetTabVisible('Degrees_Qualifications', true); 
    }
}


/***********************************************************/
// onLoad function for Education app.
// If Education is deployed, lock/unlock Tribal ID field.
function onLoadLockOrUnlockTribalIDField() {
    var tribalEnrollmentConfigRecordMissing = 'MissingRecord';
    Xrm.Page.ui.clearFormNotification(tribalEnrollmentConfigRecordMissing);
    Xrm.WebApi.retrieveMultipleRecords("ait_tribalenrollmentconfiguration").then(
        function success(result) {
            if (result != null && result.entities.length >= 1) {
                var tribalEnrollmentConfigRecord = result.entities[0];
                if (tribalEnrollmentConfigRecord.ait_enrollmentdeployed == true) {
                    AITFormLibrary.SetFieldDisabled("ait_tribalid", true, false); 
                } else {
                    //Need to develop a way to check if Education is stand-alone
                    AITFormLibrary.SetFieldDisabled("ait_tribalid", false, false); 
                }
            }
            else {
                Xrm.Page.ui.setFormNotification('Error: Missing Tribal Enrollment Configuration Record. Please ask your administrator.', 'WARNING', tribalEnrollmentConfigRecordMissing);
            }
        },
        function (error) {
            console.log(error.message);
        })
}

/***********************************************************/
// onLoad function for Education app.
// If Enrollment is deployed, lock or unlock Member Status field.
function onLoadLockOrUnlockMemberStatusField() {
    var tribalEnrollmentConfigRecordMissing = 'MissingRecord';
    Xrm.Page.ui.clearFormNotification(tribalEnrollmentConfigRecordMissing);
    Xrm.WebApi.retrieveMultipleRecords("ait_tribalenrollmentconfiguration").then(
        function success(result) {
            if (result != null && result.entities.length >= 1) {
                var tribalEnrollmentConfigRecord = result.entities[0];
                if (tribalEnrollmentConfigRecord.ait_enrollmentdeployed == true) {
                    AITFormLibrary.SetFieldDisabled("ait_membershipstatus", true, false); 
                } else {
                    //Need to develop a way to check if Education is stand-alone
                    AITFormLibrary.SetFieldDisabled("ait_membershipstatus", false, false); 
                }
            }
            else {
                Xrm.Page.ui.setFormNotification('Error: Missing Tribal Enrollment Configuration Record. Please ask your administrator.', 'WARNING', tribalEnrollmentConfigRecordMissing);
            }
        },
        function (error) {
            console.log(error.message);
        })
}

/***********************************************************/
// onLoad function for Education app.
// If Enrollment is deployed, lock or unlock Tribe field.
function onLoadLockOrUnlockTribeField() {
    var tribalEnrollmentConfigRecordMissing = 'MissingRecord';
    Xrm.Page.ui.clearFormNotification(tribalEnrollmentConfigRecordMissing);
    Xrm.WebApi.retrieveMultipleRecords("ait_tribalenrollmentconfiguration").then(
        function success(result) {
            if (result != null && result.entities.length >= 1) {
                var tribalEnrollmentConfigRecord = result.entities[0];
                if (tribalEnrollmentConfigRecord.ait_enrollmentdeployed == true) {
                    AITFormLibrary.SetFieldDisabled("ait_tribe", true, false); 
                } else {
                    //Need to develop a way to check if Education is stand-alone
                    AITFormLibrary.SetFieldDisabled("ait_tribe", false, false); 
                }
            }
            else {
                Xrm.Page.ui.setFormNotification('Error: Missing Tribal Enrollment Configuration Record. Please ask your administrator.', 'WARNING', tribalEnrollmentConfigRecordMissing);
            }
        },
        function (error) {
            console.log(error.message);
        })
}

/***********************************************************/
// onLoad function for Education app.
// If Enrollment is deployed, lock or unlock Ethnicity field.
function onLoadLockOrUnlockEthnicityField() {
    var tribalEnrollmentConfigRecordMissing = 'MissingRecord';
    Xrm.Page.ui.clearFormNotification(tribalEnrollmentConfigRecordMissing);
    Xrm.WebApi.retrieveMultipleRecords("ait_tribalenrollmentconfiguration").then(
        function success(result) {
            if (result != null && result.entities.length >= 1) {
                var tribalEnrollmentConfigRecord = result.entities[0];
                if (tribalEnrollmentConfigRecord.ait_enrollmentdeployed == true) {
                    AITFormLibrary.SetFieldDisabled("ait_ethnicity", true, false); 
                } else {
                    //Need to develop a way to check if Education is stand-alone
                    AITFormLibrary.SetFieldDisabled("ait_ethnicity", false, false); 
                }
            }
            else {
                Xrm.Page.ui.setFormNotification('Error: Missing Tribal Enrollment Configuration Record. Please ask your administrator.', 'WARNING', tribalEnrollmentConfigRecordMissing);
            }
        },
        function (error) {
            console.log(error.message);
        })
}



