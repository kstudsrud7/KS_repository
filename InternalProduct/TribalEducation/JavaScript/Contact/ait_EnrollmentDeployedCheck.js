// onLoad function for Education app
/**
 * Checks if the enrollment is deployed and locks certain fields on the Contact form.
 */
function EnrollmentDeployedCheck() {
    // Retrieve Tribal Enrollment Configuration Record
    Xrm.WebApi.retrieveMultipleRecords("ait_tribalenrollmentconfiguration","?$filter=ait_enrollmentdeployed eq true").then(
        function success(result) {
            console.log(result.entities); // Add console log of results
            if (result.entities.length > 0) {
                // Lock the following fields on the Contact
                //Xrm.Page.getControl("firstname").setDisabled(true);
                //Xrm.Page.getControl("middlename").setDisabled(true);
                //Xrm.Page.getControl("lastname").setDisabled(true);
                //Xrm.Page.getControl("suffix").setDisabled(true);
                //Xrm.Page.getControl("ait_ssn").setDisabled(true);
                //Xrm.Page.getControl("ait_birthrecord").setDisabled(true);
                //Xrm.Page.getControl("ait_deathrecord").setDisabled(true);
                //Xrm.Page.getControl("ait_gender").setDisabled(true);
                //Xrm.Page.getControl("ait_race").setDisabled(true);
                //Xrm.Page.getControl("ait_ethnicity").setDisabled(true);
                Xrm.Page.getControl("ait_tribalid").setDisabled(true);
                Xrm.Page.getControl("ait_tribe").setDisabled(true);
                Xrm.Page.getControl("ait_membershipstatus").setDisabled(true);
                // Add console logs for debugging
                console.log("Fields locked successfully.");
            }
        },
        function error(error) {
            console.log(error.message);
        }
    );
}
