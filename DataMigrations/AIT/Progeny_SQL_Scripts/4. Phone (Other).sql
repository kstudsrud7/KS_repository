-- Before running, check for records with empty spaces instead of NULL
-- update Individual set PhoneMessage = NULL where PhoneMessage = ''
SELECT ID, PhoneMessage, 'Other' AS Type, 'Phone' AS ComType
FROM Individual
WHERE PhoneMessage IS NOT NULL 
AND LTRIM(RTRIM(PhoneMessage)) <> '' -- Check that PhoneMessage does not contain empty spaces
AND DeleteDate IS NULL;
