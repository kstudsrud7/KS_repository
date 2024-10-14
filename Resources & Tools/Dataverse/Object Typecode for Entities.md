The article explains how to retrieve the `ObjectTypeCode` and `LogicalName` for all entities in Dynamics CRM using the Web API. Here’s a brief summary:

1. **Login to Dynamics CRM**: Navigate to Settings -> Customizations.
2. **Copy the Instance Web API URL**: This URL is the Service Root URL, which looks like `https://[CRM ORG Name].api.crm9.dynamics.com/api/data/v9.1`.
3. **Construct the Query URL**: Append `/EntityDefinitions?$select=LogicalName,ObjectTypeCode` to the Service Root URL.
4. **Execute the Query**: Open the constructed URL in a browser to see the results.
5. **Filter Custom Entities**: To get only custom entities, use the filter `&$filter=ObjectTypeCode gt 9999`.

This method helps you easily access metadata for entities in both Dynamics CRM Online and On-premises environments¹(https://community.dynamics.com/blogs/post/?postid=62c35ed6-50df-4d10-8e3c-8bf7cc41c95a).

Source Article: https://arunpotti.com/2020/04/13/how-to-get-objecttypecode-logicalname-for-all-entities-in-dynamics-crm-using-web-api/