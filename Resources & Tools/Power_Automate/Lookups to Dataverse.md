Table Logical Name + s

OOB Table
contacts/
accoutns/

Custom Table

sss_lookup/xxx

sss_lookup(xxxx)

![alt text](assets/image.png)




output of contacts Returned email

if(empty(first(outputs('List_Contact_by_EmailAddress1')?['body/value'])?['contactid']), null

concat(‘accounts(‘, outputs('List_Contact_by_EmailAddress1')?['body/value'])?['contactid'],’)’))