SELECT 
  IndividualCustomFieldValue.IndividualID, 
  CustomField.Name AS CustomFieldName, 
  CustomFieldOption.Value, 
  CustomField.LinkTable 
FROM 
  IndividualCustomFieldValue 
  INNER JOIN CustomFieldOption ON IndividualCustomFieldValue.Value = CustomFieldOption.Value 
  RIGHT OUTER JOIN CustomField ON CustomFieldOption.CustomFieldID = CustomField.ID 
WHERE 
  IndividualID IS NOT NULL 
  AND CustomField.ID IN ('C221CA43-B0FE-49C8-AE91-9EE425015E31','7182DC85-5657-48BD-AC0E-03365658C9BD') 
  AND CustomFieldOption.Value <> 'N/A'
  --AND IndividualID ='9B73AAFD-7993-4005-AFE9-DD9E6E48E21E'
