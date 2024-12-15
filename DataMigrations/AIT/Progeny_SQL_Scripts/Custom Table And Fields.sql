SELECT 
  CustomField.Name AS CustomFieldName, 
  CustomFieldOption.Value, 
  CustomField.LinkTable,
  CustomField.ID
FROM 
  CustomFieldOption 
  RIGHT OUTER JOIN CustomField ON CustomFieldOption.CustomFieldID = CustomField.ID 
Where 
  Value IS NOT NULL 
ORder by 
  CustomFieldName
