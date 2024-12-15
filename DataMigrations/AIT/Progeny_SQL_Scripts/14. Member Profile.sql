SELECT 
    Individual.ID, 
    Individual.ID AS MemberProfileGUID, 
    Individual.FederalVoter, 
    EnrollNumber AS TribalID, 
    StatusCode.Text AS EnrollStatusText, 
    Individual.MiddleName, 
    Individual.LastName,  
    CASE  
        WHEN Individual.EnrollDate = '9999-12-31' THEN NULL
        WHEN Individual.EnrollDate = '01/01/0001' THEN NULL
        WHEN Individual.EnrollDate = '' THEN NULL
        ELSE CONVERT(varchar(10), Individual.EnrollDate, 120)
    END AS EnrollDate,
    Individual.EnrollNumber, 
    Individual.EnrollNote, 
    Individual.EnrollStatus, 
    Individual.Relinquished,  
    CASE  
        WHEN Individual.RelinquishedDate = '9999-12-31' THEN NULL
        WHEN Individual.RelinquishedDate = '01/01/0001' THEN NULL
        ELSE CONVERT(varchar(10), Individual.RelinquishedDate, 120)
    END AS RelinquishedDate,
    Individual.RelinquishedFrom, 
    Individual.RelinquishedTo, 
    'Relinquish' AS Type, 
    'Approve' AS ChangeStatus, 
    CONCAT('From: ', Individual.RelinquishedFrom, ' To: ', Individual.RelinquishedTo) AS Description 
FROM 
    Individual 
    LEFT OUTER JOIN StatusCode ON Individual.EnrollStatus = StatusCode.ID 
WHERE 
    Individual.DeleteDate IS NULL


