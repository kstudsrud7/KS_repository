-- Before running, check for records with empty spaces instead of NULL
-- update Individual set PhoneVoice = NULL where PhoneVoice = ''
SELECT   ID, PhoneVoice, PhoneConfidential, 'Home' as Type, 'Phone' as ComType, CAST(0 AS bit) AS [Primary]
FROM            Individual
WHERE        (PhoneVoice IS NOT NULL) AND deletedate is null