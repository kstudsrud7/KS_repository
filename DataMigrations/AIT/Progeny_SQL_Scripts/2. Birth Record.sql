SELECT 
    ID, 
    ID AS BirthRecordGUID, 
    CASE  
        WHEN Birthdate = '12/31/9999' THEN ''
        WHEN Birthdate = '1900-01-01 00:00:00.0000000' THEN ''
        ELSE CAST(Birthdate AS VARCHAR(10))
    END AS BirthDate, 
    BirthCity, 
    BirthState, 
    BirthCountry, 
    BirthLocation, 
    CASE  
        WHEN ISNULL(Individual.[BirthOnFile], 0) = 1 THEN 'Yes'
        WHEN ISNULL(Individual.[BirthOnFile], 0) = 2 THEN 'No'
        ELSE NULL 
    END AS BirthOnFile,
    CASE  
        WHEN BirthCountry = 'USA' THEN 'United States'
        WHEN BirthCountry = 'United States of America' THEN 'United States'
        WHEN BirthCountry = 'Unitd States' THEN 'United States'
        WHEN BirthCountry = 'U S A' THEN 'United States'
        WHEN BirthCountry = 'Us' THEN 'United States'
        WHEN BirthCountry = 'Unitd States' THEN 'United States'
        WHEN BirthCountry = 'U' THEN 'United States'
        WHEN BirthCountry = 'United Staes' THEN 'United States'
        WHEN BirthCountry = 'U. S. A.' THEN 'United States'
        WHEN BirthCountry = 'Unitedstates' THEN 'United States'
        WHEN BirthCountry = 'Untied States' THEN 'United States'
        WHEN BirthCountry = 'U. S. A' THEN 'United States'
        WHEN BirthCountry = 'Puerto Rico' THEN 'United States'
        WHEN BirthCountry = 'U. S.' THEN 'United States'
        WHEN BirthCountry = ' US' THEN 'United States'
        WHEN BirthCountry = 'NC' THEN 'United States'
        ELSE BirthCountry
    END AS Country,
    LEFT(CONCAT(BirthCity, ' ', BirthState, ' ', BirthCountry, ' ', BirthLocation), 100) AS Description
FROM Individual 
WHERE deletedate IS NULL 
--AND ID = '5ca9f918-8aeb-4981-b48c-7746403fe62b';
