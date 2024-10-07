
/***********************************************************/
// onLoad event function
function onLoadStudentClass() {

    var loadActions = function () {
        onLoadHideOrShowKto12Section(); 
        CheckClassroomCapacity();

        AITFormLibrary.AddOnChange('ait_classgradelevel', this.onLoadHideOrShowKto12Section); 
        AITFormLibrary.AddOnChange('ait_classroomdetail', this.CheckClassroomCapacity); 
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

function onLoadHideOrShowKto12Section() {
    var gradeLevel = AITFormLibrary.GetFieldValue('ait_classgradelevel'); 
    if (gradeLevel == 748120005 || gradeLevel == 748120006 || gradeLevel == 748120007 || gradeLevel == 748120008 || gradeLevel == 748120009 || gradeLevel == 748120010 || 
        gradeLevel == 748120011 || gradeLevel == 748120012 || gradeLevel == 748120013 || gradeLevel == 748120014 || gradeLevel == 748120015 || gradeLevel == 748120016 || 
        gradeLevel == 748120017 ) {
        AITFormLibrary.SetSectionVisible("GENERAL_TAB", "GENERAL_TAB_section_3", true); 
        AITFormLibrary.SetSectionVisible("GENERAL_TAB", "GENERAL_TAB_section_4", false); 
        AITFormLibrary.SetFieldValue("ait_dualenrollment", 0); 
    } else {
        if (gradeLevel == 748120018 || gradeLevel == 748120019 || gradeLevel == 748120020 || gradeLevel == 748120021 || gradeLevel == 748120022 || gradeLevel == 748120023 || gradeLevel == 748120024 ) {
            AITFormLibrary.SetSectionVisible("GENERAL_TAB", "GENERAL_TAB_section_3", false); 
            AITFormLibrary.SetSectionVisible("GENERAL_TAB", "GENERAL_TAB_section_4", true); 
            AITFormLibrary.SetFieldValue("ait_creditsattempted", null); 
            AITFormLibrary.SetFieldValue("ait_creditsearned", null); 
            AITFormLibrary.SetFieldValue("ait_withdrawndropped", null); 
        } else {
            AITFormLibrary.SetSectionVisible("GENERAL_TAB", "GENERAL_TAB_section_3", false); 
            AITFormLibrary.SetSectionVisible("GENERAL_TAB", "GENERAL_TAB_section_4", false); 
            AITFormLibrary.SetFieldValue("ait_dualenrollment", 0); 
            AITFormLibrary.SetFieldValue("ait_creditsattempted", null); 
            AITFormLibrary.SetFieldValue("ait_creditsearned", null); 
            AITFormLibrary.SetFieldValue("ait_withdrawndropped", null); 
        }
    }
}

function CheckClassroomCapacity() {

    var classroomHasMetCapacityWarning = 'ClassroomCapacity'; 
    Xrm.Page.ui.clearFormNotification(classroomHasMetCapacityWarning);
    var classroomDetail = AITFormLibrary.GetFieldValue('ait_classroomdetail'); 
    if (classroomDetail != null) {
        if (AITFormLibrary.GetLookupId('ait_classroomdetail') != null) {
            var classroomRecord = Xrm.WebApi.retrieveRecord("ait_classroomdetail", AITFormLibrary.GetLookupId('ait_classroomdetail')).then(
                function success (result) {
                    if (result != null) {
                        if (result["ait_atcapacity"] == 748120000) {
                            Xrm.Page.ui.setFormNotification('Error: The classroom chosen is at capacity. Please choose another classroom or change status of the request to Waitlisted.', 'WARNING', classroomHasMetCapacityWarning);
                        } 
                    }
                }, 
                function (error){
                    console.log(error.message); 
                }); 
            
        }
    }
}

/***********************************************************/
// Retrieve Student Class
function showHideClassroomDetails(executionContext) {
    var formContext = executionContext.getFormContext();
    var classroomdetail = formContext.getAttribute("ait_classroomdetail").getValue();

    console.log("Execution context:", executionContext);
    console.log("Form context:", formContext);
    console.log("Classroom detail attribute value:", classroomdetail);

    // Check if classroomid is not null
    if (classroomdetail != null) {
        // Format classroomid to pass it to the retrieveRecord function
        var classroomidstringFormatted = classroomdetail[0].id.replace('{', '').replace('}', '');
        console.log("Formatted classroom ID:", classroomidstringFormatted);

        Xrm.WebApi.retrieveRecord("ait_classroomdetail", classroomidstringFormatted, "?$select=_ait_academicterm_value,_ait_schoolyear_value,_ait_school_value").then(
            function success(result) {
                console.log("Retrieve record result:", result);

                var academicterm = result._ait_academicterm_value;
                var schoolyear = result._ait_schoolyear_value;
                var school = result._ait_school_value;

                console.log("Academic term value:", academicterm);
                console.log("School year value:", schoolyear);
                console.log("School value:", school);

                // If related School on Classroom Detail is blank, show School on Student Class form, otherwise hide
                if (!school) {
                    formContext.getControl("ait_school").setVisible(true);
                    console.log("School control is visible");
                } else {
                    formContext.getControl("ait_school").setVisible(false);
                    formContext.getAttribute("ait_school").setValue(null);
                    console.log("School control is hidden and value cleared");
                }

                // If related Academic Year on Classroom Detail is blank, show Academic Year on Student Class form, otherwise hide
                if (!schoolyear) {
                    formContext.getControl("ait_academicyear").setVisible(true);
                    console.log("Academic year control is visible");
                } else {
                    formContext.getControl("ait_academicyear").setVisible(false);
                    formContext.getAttribute("ait_academicyear").setValue(null);
                    console.log("Academic year control is hidden and value cleared");
                }

                // If related Academic Term on Classroom Detail is blank, show Academic Term on Student Class form, otherwise hide
                if (!academicterm) {
                    formContext.getControl("ait_academicterm").setVisible(true);
                    console.log("Academic term control is visible");
                } else {
                    formContext.getControl("ait_academicterm").setVisible(false);
                    formContext.getAttribute("ait_academicterm").setValue(null);
                    console.log("Academic term control is hidden and value cleared");
                }
            },
            function (error) {
                console.log("Retrieve record error:", error.message);
                // Handle error conditions
            }
        );
    } else {
        console.log("Classroom detail is null");
        // If classroomdetail is null, ensure all fields are visible as a fallback
        formContext.getControl("ait_school").setVisible(true);
        formContext.getControl("ait_academicyear").setVisible(true);
        formContext.getControl("ait_academicterm").setVisible(true);
        console.log("All controls set to visible as fallback");
    }
}

/***********************************************************/
