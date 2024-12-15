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
  AND CustomField.ID IN ('54555D52-1528-427F-9497-D321A134AA61') 
  AND CustomFieldOption.Value <> 'N/A'


