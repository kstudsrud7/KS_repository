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
  AND CustomField.ID IN ('65974E2E-A552-4121-A9FC-1376ED732448') 
  AND CustomFieldOption.Value <> 'N/A'
  AND IndividualID ='541340E1-C236-4D3F-B811-897EF0882A48'
