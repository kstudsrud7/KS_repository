SELECT 
  IndividualCustomFieldValue.IndividualID, 
  CustomField.Name AS CustomFieldName, 
  CustomFieldOption.Value, 
  CustomField.LinkTable 
FROM 
  IndividualCustomFieldValue 
  INNER JOIN CustomFieldOption ON IndividualCustomFieldValue.Value = CustomFieldOption.Value 
  RIGHT OUTER JOIN CustomField ON CustomFieldOption.CustomFieldID = CustomField.ID
