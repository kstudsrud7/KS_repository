/*when the document is ready...*/
$(document).ready(function (){
    /*when the entitylist is loaded...*/
   $(".entitylist.entity-grid").on("loaded", function () { 
       /*for each ait_name td cell...*/
       $(this).children(".view-grid").find("td[data-attribute='ait_name']").each(function (i, e){
            /*get the href contents from the <a> tag*/
            var currentURL= $(this).children("a").attr('href');
            /*get the text from the Service Request Type cell on the same row*/
            var currentSRT = $(this).siblings("td[data-attribute='ait_servicerequesttype']").text();
            /*append the Service Request Type to the URL*/
            $(this).children("a").attr("href", appendServiceRequestTypeToURL(currentURL, currentSRT));
        });
    });
});

function appendServiceRequestTypeToURL(originalURL, serviceRequestType){
 return originalURL.concat("&srt=", serviceRequestType);
}
