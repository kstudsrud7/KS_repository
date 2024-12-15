-- Before running, check for records with empty spaces instead of NULL
-- update Individual set PhoneMobile = NULL where PhoneMobile = ''
SELECT  ID, PhoneMobile, PhoneConfidential, 'Mobile' as Type, cast(1 as bit) as [Primary], 'Phone' as ComType
FROM            Individual
WHERE        (PhoneMobile IS NOT NULL) AND (LEN(LTRIM(RTRIM(PhoneMobile))) > 0) AND deletedate is null;