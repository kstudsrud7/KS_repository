https://tachytelic.net/2021/11/power-automate-bulk-delete-dataverse/

The article explains how to use the Dataverse Batch API to bulk delete records from a Dataverse table using Power Automate. 

It highlights the limitations of using the Delete a row action in Power Automate, such as poor performance and high API action consumption. 

The batch method, although more complex to implement, is much more efficient, taking only 5 seconds to delete records and using a single API action. Utilizing App registration and WEB API

The article provides a detailed example of the HTTP Body for a batch operation that deletes multiple records, making it easier for users to implement this method in their own Power Automate flows.