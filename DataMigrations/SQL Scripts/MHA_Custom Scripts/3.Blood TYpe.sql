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
  AND CustomField.ID IN ('DCD89CAC-A5EE-4EAD-8FE3-6F3876704DAF') 
  AND CustomFieldOption.Value <> 'N/A'


