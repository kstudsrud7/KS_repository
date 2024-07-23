SELECT 
  Individual.ID, 
  Individual.ID AS MemberProfileGUID, 
  Individual.FederalVoter, 
  EnrollNumber as TribalID, 
  StatusCode.Text AS EnrollStatusText, 
  Individual.MiddleName, 
  Individual.LastName, 
  Individual.EnrollDate, 
  Individual.EnrollNumber, 
  Individual.EnrollNote, 
  Individual.EnrollStatus, 
  Individual.Relinquished, 
  Individual.RelinquishedDate, 
  Individual.RelinquishedFrom, 
  Individual.RelinquishedTo, 
  'Relinquish' AS Type, 
  'Approve' AS ChangeStatus, 
  { fn CONCAT(
    'From: ' + Individual.RelinquishedFrom, 
    ' To: ' + Individual.RelinquishedTo
  ) } AS Description 
FROM 
  Individual 
  LEFT OUTER JOIN StatusCode ON Individual.EnrollStatus = StatusCode.ID 
WHERE 
  DeleteDate IS null 




SELECT StatusCode.Text AS EnrollStatusText, COUNT(*) AS TotalCount
FROM Individual
LEFT OUTER JOIN StatusCode ON Individual.EnrollStatus = StatusCode.ID
WHERE Individual.DeleteDate IS NULL
GROUP BY StatusCode.Text




SELECT 
  Individual.ID, 
  Individual.ID AS MemberProfileGUID, 
  Individual.FederalVoter, 
  EnrollNumber as TribalID, 
  StatusCode.Text AS EnrollStatusText, 
  Individual.MiddleName, 
  Individual.LastName,  
         CASE  
           WHEN Individual.EnrollDate = '12/31/9999' THEN ''
           ELSE CAST(Individual.EnrollDate as varchar(10))
       END AS EnrollDate,
  Individual.EnrollNumber, 
  Individual.EnrollNote, 
  Individual.EnrollStatus, 
  Individual.Relinquished,  
           CASE  
           WHEN Individual.RelinquishedDate = '12/31/9999' THEN ''
           ELSE CAST(Individual.RelinquishedDate as varchar(10))
       END AS RelinquishedDate,
  Individual.RelinquishedFrom, 
  Individual.RelinquishedTo, 
  'Relinquish' AS Type, 
  'Approve' AS ChangeStatus, 
  { fn CONCAT(
    'From: ' + Individual.RelinquishedFrom, 
    ' To: ' + Individual.RelinquishedTo
  ) } AS Description 
FROM 
  Individual 
  LEFT OUTER JOIN StatusCode ON Individual.EnrollStatus = StatusCode.ID 
WHERE 
  EnrollNumber IS NOT NULL AND Individual.DeleteDate IS NULL



