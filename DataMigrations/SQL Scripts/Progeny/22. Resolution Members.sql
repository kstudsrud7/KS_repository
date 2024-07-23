--Resolution Members
SELECT  
    ID AS MemberProfileID,
	CASE 
        WHEN ResolutionNumber IS NULL OR ResolutionNumber = '' THEN 'N/A'
        ELSE UPPER(ResolutionNumber)
    END AS ResolutionNumber,
    CASE  
        WHEN ResolutionDate = '01/01/0001' THEN NULL
        WHEN ResolutionDate = '1900-01-01 00:00:00.0000000' THEN NULL
        ELSE CONVERT(VARCHAR(10), ResolutionDate, 120)
    END AS ResolutionDate
FROM 
    Individual
WHERE 
    deletedate IS NULL
	AND ID = '75C80775-4116-4353-9ACE-0B189C9C7BB3'