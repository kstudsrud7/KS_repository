SELECT ID,  EnrollNumber as TribalID,  FirstName, MiddleName, LastName, Suffix, Gender, Ethnicity, EthnicCategory, RaceStatus, EnrollNumber, SSN, Height, Hair, 
Birthdate, BirthCity, BirthState, BirthCountry, BirthLocation, 
CASE 
    WHEN ISNULL(Individual.[BirthOnFile], 0) = 1 THEN 'Yes'
    WHEN ISNULL(Individual.[BirthOnFile], 0) = 2 THEN 'No'
    ELSE NULL 
END AS BirthOnFile,
		Concat(BirthCity, ' ', BirthState, ' ', BirthCountry, ' ', BirthLocation) as Description
,
CASE
	WHEN MaritalStatus = 0 THEN 'Unknown'
	WHEN MaritalStatus = 1 THEN 'Common Law'
	WHEN MaritalStatus = 2 THEN 'Divorced'
	WHEN MaritalStatus = 3 THEN 'Single, Never Married'
	WHEN MaritalStatus = 4 THEN 'Married / Remarried'
	WHEN MaritalStatus = 5 THEN 'Separated'
	WHEN MaritalStatus = 7 THEN 'Widowed'
	WHEN MaritalStatus = 8 THEN 'Domestic Partner'
	WHEN MaritalStatus = 9 THEN 'Civil Union'
ELSE NULL
END AS MaritalStatus,
CASE
	WHEN Eyes = 'Dichromatic' THEN '750000007'
ELSE Eyes
END AS Eyes,
CASE
	WHEN Weight = '74`br' THEN '74'
	WHEN Weight = '9.9' THEN '10'
	WHEN Weight = '152.5' THEN '153'
	WHEN Weight = '6.4' THEN '6'
	WHEN Weight = '27in' THEN '27'
	WHEN Weight = '195 Lb' THEN '195'
	WHEN Weight = '16.5' THEN '17'
	WHEN Weight = '93 Lb' THEN '93'
ELSE Weight
END AS Weight
FROM Individual 
WHERE deletedate IS NULL
AND ID = 'B0E9ECE0-343E-4BC0-952C-EF35D772E5E0'