Get-SPOSiteScriptFromWeb -WebURL https://stokesoftwaresolutions523.sharepoint.com/sites/Stoke_Software_Customer_Template_V1 -IncludeBranding -IncludeTheme -IncludeRegionalSettings -IncludeLinksToExportedItems -IncludeSiteExternalSharingCapability -IncludedLists ("Shared%20Documents","Lists/Project%20Calendar","Lists/Progress%20tracker%20list","Lists/Issue%20tracker%20list")


#Read more: https://www.sharepointdiary.com/2019/11/sharepoint-online-create-site-design-from-existing-site.html#ixzz8rU4sOKVU

#Define Parameters
$AdminSiteUrl= "https://stokesoftwaresolutions523-admin.sharepoint.com"
$SiteURL = "https://stokesoftwaresolutions523.sharepoint.com"
  
#Connect to SharePoint Admin Center
Connect-SPOService -Url $AdminSiteUrl
  
#Get the site schema to a variable
$SiteSchema = Get-SPOSiteScriptFromWeb -WebURL $SiteURL -IncludeBranding -IncludeTheme -IncludeRegionalSettings -IncludeSiteExternalSharingCapability -IncludedLists ("Shared%20Documents","Lists/Project%20Calendar","Lists/Progress%20tracker%20list","Lists/Issue%20tracker%20list")  
#Add site schema as Site Script
$SiteScript = Add-SPOSiteScript -Title "Stoke Customer Tempalte V1" -Content $SiteSchema
  
#Create a Site Design for Team Site template from site script output
$SiteDesign = Add-SPOSiteDesign -Title "Stoke Customer Tempalte V1" -WebTemplate 64 -SiteScripts $SiteScript.Id



# Define Parameters
$AdminSiteUrl = "https://stokesoftwaresolutions523-admin.sharepoint.com"
$SiteURL = "https://stokesoftwaresolutions523.sharepoint.com/sites/Stoke_Software_Customer_Template_V1"

# Connect to SharePoint Admin Center
Connect-SPOService -Url $AdminSiteUrl

# Get the site schema to a variable
$SiteSchema = Get-SPOSiteScriptFromWeb -WebURL $SiteURL -IncludeBranding -IncludeTheme -IncludeRegionalSettings -IncludeLinksToExportedItems -IncludeSiteExternalSharingCapability -IncludedLists ("Shared%20Documents", "Lists/Project%20Calendar", "Lists/Progress%20tracker%20list", "Lists/Issue%20tracker%20list", "Lists/Action%20items", "Lists/Issues%20&%20blockers")

# Manually add home page and navigation settings to the site schema
$HomePageUrl = "/sites/Stoke_Software_Customer_Template_V1/SitePages/Home.aspx"
$NavigationSettings = @"
[
    {
        "verb": "setSiteLogo",
        "url": "$HomePageUrl"
    },
    {
        "verb": "addNavLink",
        "url": "/sites/Stoke_Software_Customer_Template_V1/Lists/Progress%20tracker%20list",
        "displayName": "Progress Tracker",
        "isWebRelative": true
    },
    {
        "verb": "addNavLink",
        "url": "/sites/Stoke_Software_Customer_Template_V1/Lists/Issue%20tracker%20list",
        "displayName": "Issue Tracker",
        "isWebRelative": true
    },
    {
        "verb": "addNavLink",
        "url": "/sites/Stoke_Software_Customer_Template_V1/Lists/Action%20items",
        "displayName": "Action Items",
        "isWebRelative": true
    },
    {
        "verb": "addNavLink",
        "url": "/sites/Stoke_Software_Customer_Template_V1/Lists/Issues%20&%20blockers",
        "displayName": "Issues & Blockers",
        "isWebRelative": true
    }
]
"@

$SiteSchema += $NavigationSettings

# Add site schema as Site Script
$SiteScript = Add-SPOSiteScript -Title "Stoke Customer Template V2" -Content $SiteSchema

# Create a Site Design for Team Site template from site script output
$SiteDesign = Add-SPOSiteDesign -Title "Stoke Customer Template V2" -WebTemplate 64 -SiteScripts $SiteScript.Id

# Output the Site Design ID
Write-Host "Site Design ID: $($SiteDesign.Id)"


# Delete a site script by ID
$SiteScriptId = "457156ad-e133-4a61-ab0a-932712e107e2"
Remove-SPOSiteScript -Identity $SiteScriptId
# Delete a site script by ID
$SiteScriptId = "f62f997c-fb7e-4b5d-8269-695dd656271a"
Remove-SPOSiteScript -Identity $SiteScriptId

$SiteDesignId = "f0391abc-466c-4e17-942f-1bd2b8023d26"
Remove-SPOSiteDesign -Identity $SiteDesignId

$SiteDesignId = "8fc03ec1-81f7-434b-8741-c86962d2287b"
Remove-SPOSiteDesign -Identity $SiteDesignId

$SiteDesignId = "bfeea639-f870-4e91-93bb-9db14b6cc972"
Remove-SPOSiteDesign -Identity $SiteDesignId

Install-Module -Name PnP.PowerShell
$SiteUrl = "https://stokesoftwaresolutions523.sharepoint.com/sites/WillistonStateCollege"
Connect-PnPOnline -Url $SiteUrl -UseWebLogin