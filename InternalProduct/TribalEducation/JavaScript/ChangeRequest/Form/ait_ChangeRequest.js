/***********************************************************/
// onLoad event function
function onLoadChangeRequest() {

    var loadActions = function () {
        AITFormLibrary.AddOnChange('ait_city_approved', onChangeCity);
        AITFormLibrary.AddOnChange('ait_stateprovince_approved', onChangeState);
        AITFormLibrary.AddOnChange('ait_zipcode_approved', this.onChangeZipCode);
        AITFormLibrary.AddOnChange('ait_crtype', onChangeChangeRequestType);
        AITFormLibrary.AddOnChange('ait_contact', onChangeContact);
        AITFormLibrary.AddOnChange('ait_approvalstatus', onChangeApprovalStatus);
        AITFormLibrary.AddOnChange('ait_crtype', hideShowSectionsBasedOnAddressTypeLookup); 

    }
    onScriptReady('AITFormLibrary', loadActions);
    hideShowSectionsBasedOnAddressTypeLookup(); 
    this.setTabVisibility();
    this.setAddressTypeEditability();
    this.setRecordsCreatedVisibility();
    this.setAddressEditability();
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
// If the zip code changes try and set the city.
var updateZipCode = true;
function onChangeZipCode() {
    if (updateZipCode) {
        var lookupId = AITFormLibrary.GetLookupId('ait_zipcode_approved');
        if (!AITLibrary.IsNullOrEmpty(lookupId)) {
            var recordData = AITAddressLibrary.GetZipCodeRecord(lookupId);
            if (recordData != null) {
                updateZipCode = false;
                AITFormLibrary.SetLookupValueEntityRef('ait_city_approved', recordData.ait_city);
                updateZipCode = true;
            }
        }
    }
}

/***********************************************************/
// Handle updates to other fields when City changes on form
function onChangeCity() {
    var lookupId = AITFormLibrary.GetLookupId('ait_city_approved');
    if (!AITLibrary.IsNullOrEmpty(lookupId)) {
        var recordData = AITAddressLibrary.GetCityRecord(lookupId);
        if (recordData != null) {
            AITFormLibrary.SetLookupValueEntityRef('ait_stateprovince_approved', recordData.ait_stateprovince);
            this.onChangeState();
        }

        if (updateZipCode) {
            var zipCodes = AITAddressLibrary.GetZipCodesForCity(lookupId);
            var isZipCurrent = false;

            // Update the zip code for the new city, unless one of the city zip codes is already displayed
            if (!AITLibrary.IsNullOrEmpty(AITFormLibrary.GetLookupId('ait_zipcode_approved'))) {
                for (var i = 0; i < zipCodes.length; i++) {
                    if (AITLibrary.AreGuidsEqual(zipCodes[i].ait_zipcodecityId, AITFormLibrary.GetLookupId('ait_zipcode_approved'))) {
                        isZipCurrent = true;
                        break;
                    }
                }
            }
            if (!isZipCurrent) {
                AITFormLibrary.SetFieldValue('ait_zipcode_approved', null);
                if (zipCodes != null && zipCodes.length == 1) {
                    var zipCode = zipCodes[0];
                    updateZipCode = false;
                    AITFormLibrary.SetLookupValue('ait_zipcode_approved', zipCode.ait_zipcodecityId, zipCode.ait_name, 'ait_zipcodecity')
                    updateZipCode = true;
                }
            }
        }
    }
}


/***********************************************************/
// Handle updates to other fields when State changes on form
function onChangeState() {
    var lookupId = AITFormLibrary.GetLookupId('ait_stateprovince_approved');
    if (lookupId != '' && lookupId != null) {

        var recordData = AITAddressLibrary.GetStateRecord(lookupId);
        if (recordData != null) {
            AITFormLibrary.SetLookupValueEntityRef('ait_country', recordData.ait_countryregion);
        }
    }
}

/***********************************************************/
// Change the tab being viewed when selecting a Change Request Type
function onChangeChangeRequestType() {
    if (!AITLibrary.IsNullOrEmpty(AITFormLibrary.GetLookupId('ait_contact'))){
        AITFormLibrary.SetTabVisible('tab_general', false);
        setTabVisibility();
    }
}

/***********************************************************/
// Change the tab being viewed when selecting a Contact
function onChangeContact() {
    if (!AITLibrary.IsNullOrEmpty(AITFormLibrary.GetLookupId('ait_crtype'))){
        AITFormLibrary.SetTabVisible('tab_general', false);
        setTabVisibility();
    }
}

/***********************************************************/
// Handles updates to other fields when Status Code changes on form
function onChangeApprovalStatus() {
    AITDateLibrary.SetFieldToday('ait_statuschangedate');

    // Lock fields once a change request is approved
    this.setAddressEditability();
    this.setAddressTypeEditability();
}

function hideShowSectionsBasedOnAddressTypeLookup() {
    var changeRequestLookup = AITFormLibrary.GetLookupName('ait_crtype'); 
    if (changeRequestLookup == "Contact Information") {
        AITFormLibrary.SetSectionVisible('tab_changerequest','tab_changerequest_section_requested_electronicaddress_userentered',true); 
        AITFormLibrary.SetSectionVisible('tab_changerequest','tab_changerequest_section_requestedaddress_userentered',true); 
        AITFormLibrary.SetSectionVisible('tab_changerequest','tab_changerequest_section_contactinformationrecordscreated',true); 
        AITFormLibrary.SetSectionVisible('tab_changerequest','tab_changerequest_section_approvedelectronicaddress',true); 
        AITFormLibrary.SetSectionVisible('tab_changerequest','tab_changerequest_section_approvedaddress',true); 

        AITFormLibrary.SetSectionVisible('tab_changerequest','tab_changerequest_section_household_member_change',false); 

    } else if (changeRequestLookup == "Household Member") {
        AITFormLibrary.SetSectionVisible('tab_changerequest','tab_changerequest_section_household_member_change',true); 

        AITFormLibrary.SetSectionVisible('tab_changerequest','tab_changerequest_section_requested_electronicaddress_userentered',false); 
        AITFormLibrary.SetSectionVisible('tab_changerequest','tab_changerequest_section_requestedaddress_userentered',false); 
        AITFormLibrary.SetSectionVisible('tab_changerequest','tab_changerequest_section_contactinformationrecordscreated',false); 
        AITFormLibrary.SetSectionVisible('tab_changerequest','tab_changerequest_section_approvedelectronicaddress',false); 
        AITFormLibrary.SetSectionVisible('tab_changerequest','tab_changerequest_section_approvedaddress',false); 

    } else {
        AITFormLibrary.SetSectionVisible('tab_changerequest','tab_changerequest_section_requested_electronicaddress_userentered',false); 
        AITFormLibrary.SetSectionVisible('tab_changerequest','tab_changerequest_section_requestedaddress_userentered',false); 
        AITFormLibrary.SetSectionVisible('tab_changerequest','tab_changerequest_section_contactinformationrecordscreated',false); 
        AITFormLibrary.SetSectionVisible('tab_changerequest','tab_changerequest_section_approvedelectronicaddress',false); 
        AITFormLibrary.SetSectionVisible('tab_changerequest','tab_changerequest_section_approvedaddress',false); 
        AITFormLibrary.SetSectionVisible('tab_changerequest','tab_changerequest_section_household_member_change',false); 
    }
}


/***********************************************************/
// Indicates whether the create address button should be available; referenced by the Ribbon Workbench
function enableCreateAddressButton() {
    var doEnable = false;

    if (AITFormLibrary.GetLookupName('ait_crtype') == 'Contact Information') {
        doEnable = true;
    }

    return doEnable;
}

/***********************************************************/
// Executes the Create address functionality; this is the button command action in the Ribbon Workbench
function buttonUpdateInformation() {

    // Save any changes the user has made so the plugin code can get them from the database
    Xrm.Page.data.save().then(function () {

        var notificationId = 'buttonCreateAddress';
        Xrm.Page.ui.clearFormNotification(notificationId);

        if (!this.isApproved()) {
            Xrm.Page.ui.setFormNotification('Approval Status must be set to Approved to create address.', 'WARNING', notificationId);
            return;
        }

        //var addressType = AITFormLibrary.GetFieldValue('ait_changerequestaddresstype');
        //if (AITLibrary.IsNullOrEmpty(addressType)) {
            //Xrm.Page.ui.setFormNotification('Change Request Address Type must be selected to create address.', 'WARNING', notificationId);
            //return;
        //}

        if (!AITLibrary.IsNullOrEmpty(AITFormLibrary.GetFieldValue('ait_physicaladdress')) ||
                !AITLibrary.IsNullOrEmpty(AITFormLibrary.GetFieldValue('ait_phone_electronicaddress')) ||
                !AITLibrary.IsNullOrEmpty(AITFormLibrary.GetFieldValue('ait_email_electronicaddress'))) 
        {
            var isOK = confirm("An address has already been created, do you want to create another?");
            if (isOK == false){
                return;
            }
        }

        Xrm.Page.ui.setFormNotification('Address is being created.', 'INFO', notificationId);

        Process.callAction("ait_ChangeRequestUpdate",
            [{
                key: "Target",
                type: Process.Type.EntityReference,
                value: new Process.EntityReference(Xrm.Page.data.entity.getEntityName(), Xrm.Page.data.entity.getId())
            }],
            function (params) {
                // Success
                var message = '';
                Xrm.Page.ui.setFormNotification('Address has been created.' + message, 'INFO', notificationId);
                Xrm.Page.data.refresh();
            },
            function (e, t) {
                // Error
                var message = e + "\n" + t;
                Xrm.Utility.alertDialog('Create Address: ' + message);
                Xrm.Page.ui.setFormNotification('Error while creating address', 'INFO', notificationId);
                AITDebugLibrary.Write(message);
            });

        AITFormLibrary.SetSectionVisible('tab_profile', 'tab_profile_section_recordscreated', true);
    });
}

/***********************************************************/
// Sets the visibility of tabs according to the Change Request Type
function setTabVisibility() {
    var lookupId = AITFormLibrary.GetLookupId('ait_crtype');
    if (!AITLibrary.IsNullOrEmpty(lookupId)) {
        var recordData = AITAddressLibrary.GetChangeRequestTypeRecord(lookupId);
        if (recordData != null) {
            AITFormLibrary.SetTabVisible(recordData.ait_CEFormTabName, true);
            AITFormLibrary.SetTabVisible('tab_notesandtimeline', true);
        }
        else {
            AITFormLibrary.SetTabVisible('tab_general', true);
        }
    }
    else {
        AITFormLibrary.SetTabVisible('tab_general', true);
    }

    AITFormLibrary.SetFieldDisabled('ait_reasonforchange', this.isFromPortal());
}

/***********************************************************/
// Sets the visibility of the Records created fields
function setRecordsCreatedVisibility() {
    var existsRecordsCreated = (!AITLibrary.IsNullOrEmpty(AITFormLibrary.GetFieldValue('ait_physicaladdress')) ||
        !AITLibrary.IsNullOrEmpty(AITFormLibrary.GetFieldValue('ait_phone_electronicaddress')) ||
        !AITLibrary.IsNullOrEmpty(AITFormLibrary.GetFieldValue('ait_email_electronicaddress')));

    AITFormLibrary.SetSectionVisible('tab_profile', 'tab_profile_section_recordscreated', existsRecordsCreated);
}

/***********************************************************/
// Sets the editability of the Address Type field
function setAddressTypeEditability() {
    var isFromPortal = this.isFromPortal();
    var isApproved = this.isApproved();

    AITFormLibrary.SetFieldDisabled('ait_changerequestaddresstype', isFromPortal || isApproved);
}

/***********************************************************/
// Sets the editability of user entered and approved address fields
function setAddressEditability() {
    var isFromPortal = this.isFromPortal();
    var isApproved = this.isApproved();

    AITFormLibrary.SetSectionDisabled('tab_profile', 'tab_profile_section_userentered', isFromPortal || isApproved);
    AITFormLibrary.SetSectionDisabled('tab_profile', 'tab_profile_section_electronic_userentered', isFromPortal || isApproved);
    AITFormLibrary.SetSectionDisabled('tab_profile', 'tab_profile_section_approved', isApproved);
    AITFormLibrary.SetSectionDisabled('tab_profile', 'tab_profile_section_electronic_approved', isApproved);
}

function isFromPortal() {
    return (AITFormLibrary.GetFieldValue('ait_changerequestsource') == 750000000 /* Portal */);
}

function isApproved() {
    return (AITFormLibrary.GetFieldValue('ait_approvalstatus') == ApprovalStatus.Approved);
}

var ApprovalStatus = {
    New: 750000000,
    NeedMoreInformation: 750000001,
    Approved: 750000002,
    Denied: 750000003,
}