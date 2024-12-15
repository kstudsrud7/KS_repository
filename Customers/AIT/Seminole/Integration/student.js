/// <reference path="../Libraries/ait_AitCoreLibraries.js">
/// <reference path="../Libraries/ait_AitCommon.js">

var libraryLoadCount = {
    count: 0,
    rerun: 1
}

// This will be set in the onLoad function
// Required by Core Library methods.
let myFC = null;
var initalLoadDone = false;

var Student = {
    /***********************************************************/
    // onLoad event function
    onLoad: function (inExecutionContext) {
        myFC = inExecutionContext.getFormContext();
        Student.onScriptReady('AITEntityLibrary,AITFormLibrary,SDK', Student.loadActions);
    },

    onScriptReady: function (name, callback) {
        var interval = 10;
        window.setTimeout(function () {
            var areLibrariesLoaded = true;
            var libraries = name.split(',');
            for (var i = 0; i < libraries.length; i++) {
                var libraryName = libraries[i];
                if (!window[libraryName]) {
                    areLibrariesLoaded = false;
                    this.libraryLoadCount.count++;
                    if (this.libraryLoadCount.count === 1500) {
                        var message = String.format("Cannot load library: {0} ({1}), some features may not function without all libraries loaded.", libraryName, this.libraryLoadCount.rerun);
                        AITFormLibrary.SetFormNotification(message, 'WARNING', 'onScriptReady');
                        this.libraryLoadCount.count = 0;
                        this.libraryLoadCount.rerun++;
                        if (this.libraryLoadCount.rerun === 100000) {
                            this.libraryLoadCount.rerun = 0;
                        }
                    }
                    break;
                }
            }

            if (areLibrariesLoaded === true) {

                AITFormLibrary.ClearFormNotification('onScriptReady');
                callback();
            } else {
                window.setTimeout(arguments.callee, interval);
            }
        },
            interval);
    },

    loadActions: function () {
        AITFormLibrary.AddOnChange('ait_dateofbirth', Student.setAgeFromBirthdate);
        AITFormLibrary.AddOnChange('ait_ssn', Student.socialSecurityChange);
        AITFormLibrary.AddOnChange('ait_homephone', function () { AITFieldLibrary.FormatPhoneNumber('ait_homephone') });
        AITFormLibrary.AddOnChange('ait_mobilephone', function () { AITFieldLibrary.FormatPhoneNumber('ait_mobilephone') });
        AITFormLibrary.AddOnChange('ait_memberid', Student.updateMemberIdInformation);

        Xrm.Page.getAttribute("ait_ssnlast4").setSubmitMode("always");

        // this method is in AitCommon.js
        AITCommon.AddEventToGridRefresh("Student_Addresses", Student.ReLoadStudent);
    },

    ReLoadStudent: function () {
        var homeAddressField = Xrm.Page.getAttribute("ait_address1");
        var schoolAddressField = Xrm.Page.getAttribute("ait_address2");
        var homeMailingAddressField = Xrm.Page.getAttribute("ait_address1mailingaddress");
        var schoolMailingAddressField = Xrm.Page.getAttribute("ait_address2mailingaddress");
        var homeAddressOptionSetValue = 914600000;
        var schoolAddressOptionSetValue = 914600001;
        if (true === initalLoadDone) {
            // update individual fields, not the entire form since we could lose amounts
            var studentId = _id;
            var homeStudentAddressData = Student.GetStudentAddressData(studentId, homeAddressOptionSetValue);
            var schoolStudentAddressData = Student.GetStudentAddressData(studentId, schoolAddressOptionSetValue);
            // home address contains data, refresh those fields with new values
            if (homeStudentAddressData !== null) {
                homeAddressField.setSubmitMode("never");
                homeAddressField.setValue(homeStudentAddressData.ait_Address);
                homeMailingAddressField.setSubmitMode("never");
                homeMailingAddressField.setValue(homeStudentAddressData.ait_MailingAddress);
            }
            // field has a value, but now needs to be nulled out
            else if (homeAddressField.getValue() !== null
                && homeStudentAddressData === null) {
                homeAddressField.setSubmitMode("never");
                homeAddressField.setValue(null);
                homeMailingAddressField.setSubmitMode("never");
                homeMailingAddressField.setValue(0);
            }
            // school address contains data, refresh those fields with new values
            if (schoolStudentAddressData !== null) {
                schoolAddressField.setSubmitMode("never");
                schoolAddressField.setValue(schoolStudentAddressData.ait_Address);
                schoolMailingAddressField.setSubmitMode("never");
                schoolMailingAddressField.setValue(schoolStudentAddressData.ait_MailingAddress);
            }
            // field has a value, but now needs to be nulled out
            else if (schoolAddressField.getValue() !== null
                && schoolStudentAddressData === null) {
                schoolAddressField.setSubmitMode("never");
                schoolAddressField.setValue(null);
                schoolMailingAddressField.setSubmitMode("never");
                schoolMailingAddressField.setValue(0);
            }
        }
        initalLoadDone = true;
    },


    updateMemberIdInformation: function () {

        // if organization configuration is not set up with the Seminole Tribe of Florida record, don't try to update Member ID information
        if (false === Student.VerifyOrganizationConfiguration()) {
            return;
        }

        var oField = Xrm.Page.getAttribute("ait_memberid");
        var memberId = oField.getValue();
        if (null !== memberId) {


            Xrm.Utility.confirmDialog("Do you want to validate and update member information based on data entered in MySTIC? This will override any existing information for the current student.",
                function () {
                    // Callback that happens when user clicks OK.
                    Student.updateMemberIdInformationAction()
                },
                function () {
                    // Callback that happens when user clicks Cancel.
                    AITFormLibrary.ClearFormNotification('1');
                    return;
                });
        } else {
            AITFormLibrary.ClearFormNotification('1');
        }
    },

    updateField: function (fieldName, oField, valueName) {
        var originalValue = oField.getValue();
        var originalText = originalValue;
        var valueText = valueName;
        var valueObject = new Array();

        if (fieldName === "membershipstatus") {
            var TMSMemberOptionSetValue = 914600000;
            var TMSNonMemberOptionSetValue = 914600001;
            var TMSPendingOptionSetValue = 914600002;
            var TMSRelinquishedOptionSetValue = 914600004;
            var TMSDeceasedOptionSetValue = 914600003;
            var TMSIndependentOptionSetValue = 914600005;
            var TMSEmployeeOptionSetValue = 914600006;

            var EDUMemberOptionSetValue = 914600000;
            var EDUNonMemberOptionSetValue = 914600001;
            var EDUPendingOptionSetValue = 914600002;
            var EDURelinquishedOptionSetValue = 914600003;
            var EDUDeceasedOptionSetValue = 914600004;
            var EDUIndependentOptionSetValue = 914600005;

            // need to convert the optionsetvalue to the text representation
            if (valueName === TMSMemberOptionSetValue) {
                valueText = "Member";
                valueName = EDUMemberOptionSetValue;
            }
            else if (valueName === TMSNonMemberOptionSetValue) {
                valueText = "Non-Member";
                valueName = EDUNonMemberOptionSetValue;
            }
            else if (valueName === TMSPendingOptionSetValue) {
                valueText = "Pending";
                valueName = EDUPendingOptionSetValue;
            }
            else if (valueName === TMSRelinquishedOptionSetValue) {
                valueText = "Relinquished";
                valueName = EDURelinquishedOptionSetValue;
            }
            else if (valueName === TMSDeceasedOptionSetValue) {
                valueText = "Deceased";
                valueName = EDUDeceasedOptionSetValue;
            }
            else if (valueName === TMSIndependentOptionSetValue) {
                valueText = "Independent";
                valueName = EDUIndependentOptionSetValue;
            }
            else if (valueName === TMSEmployeeOptionSetValue) {
                // No matching Member Status in Education for Employee
                valueText = "Non-Member";
                valueName = EDUNonMemberOptionSetValue;
            }

            // need to convert the optionsetvalue to the text representation
            if (originalValue === EDUMemberOptionSetValue) {
                originalText = "Member";
            }
            else if (originalValue === EDUNonMemberOptionSetValue) {
                originalText = "Non-Member";
            }
            else if (originalValue === EDUPendingOptionSetValue) {
                originalText = "Pending";
            }
            else if (originalValue === EDURelinquishedOptionSetValue) {
                originalText = "Relinquished";
            }
            else if (originalValue === EDUDeceasedOptionSetValue) {
                originalText = "Deceased";
            }
            else if (originalValue === EDUIndependentOptionSetValue) {
                originalText = "Independent";
            }
        }

        if (fieldName === "gender") {
            var TMSMaleOptionSetValue = 1;
            var TMSFemaleOptionSetValue = 2;

            var EDUMaleOptionSetValue = 914600000;
            var EDUFemaleOptionSetValue = 914600001;

            // need to convert the optionsetvalue to the text representation
            if (valueName === TMSMaleOptionSetValue) {
                valueText = "Male";
                valueName = EDUMaleOptionSetValue;
            }
            else if (valueName === TMSFemaleOptionSetValue) {
                valueText = "Female";
                valueName = EDUFemaleOptionSetValue;
            }

            // need to convert the optionsetvalue to the text representation
            if (originalValue === EDUMaleOptionSetValue) {
                originalText = "Male";
            }
            else if (originalValue === EDUFemaleOptionSetValue) {
                originalText = "Female";
            }
        }

        if (fieldName === "birthdate") {
            if (null === originalValue) {
                originalText = null;
                originalValue = null;
            }
            else {
                originalText = ("00" + (originalValue.getMonth() + 1)).slice(-2) + "/" + ("00" + originalValue.getDate()).slice(-2) + "/" + originalValue.getFullYear();
                originalValue = new Date(originalText);
            }
            valueText = new Date(valueText);
            valueText = ("00" + (valueText.getMonth() + 1)).slice(-2) + "/" + ("00" + valueText.getDate()).slice(-2) + "/" + valueText.getFullYear();
            valueName = new Date(valueText);
        }

        if (fieldName === "residency") {
            if (valueName === "Orlando" || valueName === "Tribal-Wide") {
                // No matching Reservation in Education for Orlando or Tribal-Wide
                valueName = null;
            }
            else {
                if (null === originalValue) {
                    originalText = null;
                }
                else {
                    originalText = originalValue[0].name;
                }

                var entityName = 'getReservation';
                var filter = String.format("?$select=ait_reservationId,ait_name&$filter=ait_name eq '{0}'", valueName);
                var reservations = AITEntityLibrary.GetMultipleRecords("ait_reservation", filter, entityName)
                for (var i = 0; i < reservations.length; i++) {
                    var reservation = reservations[0];
                    valueObject[0] = new Object();
                    valueObject[0].id = "{" + reservation.ait_reservationId + "}";
                    valueObject[0].name = reservation.ait_name;
                    valueObject[0].entityType = "ait_reservation";
                }
            }
        }

        if (null === valueObject[0] || typeof valueObject[0] === 'undefined') {
            // if simple field
            if (null !== valueText && null === originalText) {
                oField.setSubmitMode("always");
                oField.setValue(valueName);
            }
            else if (null !== valueText && valueText.toUpperCase() !== originalText.toUpperCase()) {
                var text = "For " + fieldName + ", do you want to replace the original value of '" + originalText + "' with the new value of '" + valueText + "'?";
                Xrm.Utility.confirmDialog(text,
                    function () {
                        oField.setSubmitMode("always");
                        oField.setValue(valueName);
                    },
                    function () {
                    });
            }
            else if (null === valueText && null !== originalText) {
                var text = "For " + fieldName + ", do you want to remove the original value of '" + originalText + "'?";
                Xrm.Utility.confirmDialog(text,
                    function () {
                        oField.setSubmitMode("always");
                        oField.setValue(null);
                    },
                    function () {
                    });
            }
        }
        else {
            // if complex field
            if (null !== valueText && null === originalText) {
                oField.setSubmitMode("always");
                oField.setValue([{ id: valueObject[0].id, name: valueObject[0].name, entityType: valueObject[0].entityType }]);
            }
            else if (null !== valueText && valueText.toUpperCase() !== originalText.toUpperCase()) {
                var text = "For " + fieldName + ", do you want to replace the original value of '" + originalText + "' with the new value of '" + valueText + "'?";
                Xrm.Utility.confirmDialog(text,
                    function () {
                        oField.setSubmitMode("always");
                        oField.setValue([{ id: valueObject[0].id, name: valueObject[0].name, entityType: valueObject[0].entityType }]);
                    },
                    function () {
                    });
            }
            else if (null === valueText && null !== originalText) {
                var text = "For " + fieldName + ", do you want to remove the original value of '" + originalText + "'?";
                Xrm.Utility.confirmDialog(text,
                    function () {
                        oField.setSubmitMode("always");
                        oField.setValue(null);
                    },
                    function () {
                    });
            }
        }

        if (fieldName === "birthdate") {
            Student.setAgeFromBirthdate();
        }
    },

    updateMemberIdInformationAction: function () {
        var requestName = "ait_UpdateMemberIdInformationAction";
        var notificationID = 22

        var requestXML = "";
        requestXML += "<s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\">";
        requestXML += "  <s:Body>";
        requestXML += "<Execute xmlns=\"http://schemas.microsoft.com/xrm/2011/Contracts/Services\" xmlns:i=\"http://www.w3.org/2001/XMLSchema-instance\">";
        requestXML += "<request xmlns:a=\"http://schemas.microsoft.com/xrm/2011/Contracts\">";
        requestXML += "        <a:Parameters xmlns:b=\"http://schemas.datacontract.org/2004/07/System.Collections.Generic\">";
        requestXML += "          <a:KeyValuePairOfstringanyType>";
        requestXML += "            <b:key>memberid</b:key>";
        requestXML += "            <b:value i:type=\"c:string\" xmlns:c=\"http://www.w3.org/2001/XMLSchema\">" + Xrm.Page.getAttribute('ait_memberid').getValue() + "</b:value>";
        requestXML += "          </a:KeyValuePairOfstringanyType>"
        requestXML += "        </a:Parameters>";
        requestXML += "        <a:RequestId i:nil=\"true\" />";
        requestXML += "        <a:RequestName>" + requestName + "</a:RequestName>";
        requestXML += "      </request>";
        requestXML += "    </Execute>";
        requestXML += "  </s:Body>";
        requestXML += "</s:Envelope>";

        var req = new XMLHttpRequest();
        req.open("POST", AITEntityLibrary.GetServiceUrl(), false)
        req.setRequestHeader("Accept", "application/xml, text/xml, */*");
        req.setRequestHeader("Content-Type", "text/xml; charset=utf-8");
        req.setRequestHeader("SOAPAction", "http://schemas.microsoft.com/xrm/2011/Contracts/Services/IOrganizationService/Execute");
        
        //Debugging Code
        req.onreadystatechange = function() {
            if (req.readyState === 4) { // request is done
                if (req.status === 200) { // successfully
                    console.log(req.responseText);
                } else { // error occurred
                    console.error("Error: " + req.status + " - " + req.statusText);
                    console.error(req.responseText);
                }
            }
        };
        
        req.onerror = function() {
            console.error("Request failed");
        };
        //req.onreadystatechange = function () {
        
        req.send(requestXML);

        if (req.status === 200) {
            //extract return values
            var allKeys = req.responseXML.getElementsByTagName("b:key");
            var allValues = req.responseXML.getElementsByTagName("b:value");

            for (var i = 0; i < allKeys.length; i++) {
                var keyName = allKeys[i].lastChild.nodeValue;
                var valueName = allValues[i].textContent;
                if (keyName === "exists") {
                    AITFormLibrary.ClearNotification("ait_memberid");
                    if (valueName === "false") {
                        AITFormLibrary.SetFormNotification('Warning! Member ID does not exist.', 'WARNING', '1');
                        return
                    }
                }
                else if (keyName === "firstname") {
                    var oField = Xrm.Page.getAttribute("ait_firstname");
                    Student.updateField(keyName, oField, valueName);
                }
                else if (keyName === "middlename") {
                    var oField = Xrm.Page.getAttribute("ait_middlename");
                    Student.updateField(keyName, oField, valueName);
                }
                else if (keyName === "lastname") {
                    var oField = Xrm.Page.getAttribute("ait_lastname");
                    Student.updateField(keyName, oField, valueName);
                }
                else if (keyName === "suffix") {
                    var oField = Xrm.Page.getAttribute("ait_suffix");
                    Student.updateField(keyName, oField, valueName);
                }
                else if (keyName === "nickname") {
                    var oField = Xrm.Page.getAttribute("ait_nickname");
                    Student.updateField(keyName, oField, valueName);
                }
                else if (keyName === "homephone") {
                    var oField = Xrm.Page.getAttribute("ait_homephone");
                    Student.updateField(keyName, oField, valueName);
                }
                else if (keyName === "mobilephone") {
                    var oField = Xrm.Page.getAttribute("ait_mobilephone");
                    Student.updateField(keyName, oField, valueName);
                }
                else if (keyName === "email") {
                    var oField = Xrm.Page.getAttribute("ait_email");
                    Student.updateField(keyName, oField, valueName);
                }
                else if (keyName === "membershipstatus") {
                    var oField = Xrm.Page.getAttribute("ait_memberstatus");
                    Student.updateField(keyName, oField, valueName);
                }
                else if (keyName === "gender") {
                    var oField = Xrm.Page.getAttribute("ait_gender");
                    Student.updateField(keyName, oField, valueName);
                }
                else if (keyName === "birthdate") {
                    var oField = Xrm.Page.getAttribute("ait_dateofbirth");
                    Student.updateField(keyName, oField, valueName);
                }
                else if (keyName === "residency") {
                    var oField = Xrm.Page.getAttribute("ait_reservation");
                    Student.updateField(keyName, oField, valueName);
                }
            }
            AITFormLibrary.SetFormNotification("Information retrieved from MySTIC successfully.", "INFO", "MemberInfoRetrieve");
        }
        else {
            AITFormLibrary.SetFormNotification(req.statusText + "\n" + req.responseXML.getElementsByTagName("faultstring")[0].textContent, "ERROR", "MemberInfoRetrieve");
        }
    },

    setAgeFromBirthdate: function () {
        var birthday = AITFormLibrary.GetFieldValue("ait_dateofbirth"); //Get the Date of Birth value  
        var existingAge = AITFormLibrary.GetFieldValue("ait_age");

        if (birthday !== null) {
            var currentTime = new Date(); //Todays Date 
            var currentYear = currentTime.getFullYear();

            var diff = new Date(currentTime.getFullYear(), birthday.getMonth(), birthday.getDate());
            var age;

            //Check to see if Birthday has already passed
            if (diff <= currentTime) //If Birthday has already occurred   
            {
                age = currentTime.getFullYear() - birthday.getFullYear();
            }
            else //If Birthday has not already occurred  
            {
                age = currentTime.getFullYear() - birthday.getFullYear() - 1;
            }

            if (age !== existingAge) {
                Xrm.Page.getAttribute("ait_age").setSubmitMode("always");
                Xrm.Page.getAttribute("ait_age").setValue(age);
            }
        }
        else // field is null, set age to null
        {
            if (existingAge !== null) {
                Xrm.Page.getAttribute("ait_age").setSubmitMode("always");
                Xrm.Page.getAttribute("ait_age").setValue(null);
            }
        }
    },

    socialSecurityChange: function () {
        var notificationID = 22
        var oField = Xrm.Page.getAttribute('ait_ssn');
        var sAllNumeric = oField;
        if (typeof (oField) !== "undefined" && oField.getValue() !== null) {
            sAllNumeric = oField.getValue().replace(/[^0-9]/g, "");
            switch (sAllNumeric.length) {
                case 9:
                    //format SSN as 999-99-9999 
                    AITFormLibrary.ClearNotification('ait_ssn');
                    sFormattedSSNNumber = sAllNumeric.substr(0, 3) + "-" + sAllNumeric.substr(3, 2) + "-" + sAllNumeric.substr(5, 4);
                    oField.setValue(sFormattedSSNNumber);
                    oField.setSubmitMode("always");
                    break;
                default:
                    AITFormLibrary.SetNotification('ait_ssn', "SSN must contain 9 numbers.", notificationID)
                    break;
            }
        }
        else {
            AITFormLibrary.ClearNotification('ait_ssn');
        }
    },


    // Get the BirthDate for the student based on the lookup field passed in.
    GetStudentBirthDate: function (lookupField) {
        var birthDate;
        var studentField = AITFormLibrary.GetFieldValue(lookupField);

        if (studentField !== null) {
            var studentId = studentField[0].id;
            var studentData = Student.GetStudentData(studentId);
        }
        if (studentData !== null) {
            birthDate = studentData.ait_DateofBirth;
        }
        return birthDate;
    },

    // Get a student data record with the guid id passed in.
    GetStudentData: function (recordId) {

        var entityName = 'ait_student';
        var sub1fields = 'ait_SATScore,ait_ACTScore,ait_Age,ait_CheckDeliveryMethod,ait_DateofBirth,ait_VendorLocationCode,ait_VendorID,ait_MemberID,ait_Address1Street1,ait_Address1Street2,ait_Address1Street3,ait_Address1ZIPPostalCode,ait_Address1City,ait_Address1StateProvince,ait_Address1CountryRegion,ait_Address1MailingAddress';
        var sub2fields = 'ait_Reservation,ait_Address2Street1,ait_Address2Street2,ait_Address2Street3,ait_Address2ZIPPostalCode,ait_Address2City,ait_Address2StateProvince,ait_Address2CountryRegion,ait_Address2MailingAddress,ait_Address2MailingAddress';
        var fields = sub1fields + ',' + sub2fields;
        var methodName = "GetStudentData";

        var returnData = AITEntityLibrary.GetRecord(recordId, entityName, fields, methodName);
        return returnData;

    },

    // Get the active students
    GetActiveStudents: function () {
        var entityName = 'ait_student';
        var filter = String.format("?$select=ait_name,ait_studentId");
        var methodName = "GetActiveStudents";
        var returnData = AITEntityLibrary.GetMultipleRecords(entityName, filter, methodName);

        return returnData;
    },

    GetStudentAddressData: function (studentId, addressType) {

        var entityName = 'ait_studentaddress';
        var filter = String.format("?$select=ait_name,ait_studentaddressId,ait_AddressType,ait_Address,ait_MailingAddress,statecode&$filter=ait_Student/Id eq guid'{0}'", studentId);
        var methodName = "GetStudentAddressData";
        var addresses = AITEntityLibrary.GetMultipleRecords(entityName, filter, methodName);

        if (null === addresses) {
            return;
        }

        var thisAddress = null;
        for (var i = 0; i < addresses.length; i++) {
            var address = addresses[i];
            if (addressType === address.ait_AddressType.Value
                && address.statecode.Value === 0) {
                thisAddress = address;
            }
        }

        return thisAddress;
    },

    // Verify the Organization Configuration for Seminole Tribe of Florida exists
    VerifyOrganizationConfiguration: function () {
        var entityName = 'ait_organizationconfiguration';
        var filter = String.format("?$select=ait_name,ait_organizationconfigurationId,statecode");
        var methodName = "VerifyOrganizationConfiguration";
        var organizations = AITEntityLibrary.GetMultipleRecords(entityName, filter, methodName);

        var exists = false;

        if (null === organizations) {
            return exists;
        }

        for (var i = 0; i < organizations.length; i++) {
            var organization = organizations[i];
            if ("Seminole Tribe of Florida" === organization.ait_name
                && organization.statecode.Value === 0) {
                exists = true;
            }
        }

        return exists;
    }
}