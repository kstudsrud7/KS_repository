SELECT 
  Individual.ID, 
  Individual.FirstName, 
  EnrollNumber as TribalID, 
  Individual.MiddleName, 
  Individual.LastName, 
  Individual.EnrollDate, 
  Individual.EnrollNumber, 
  Individual.EnrollNote, 
  Individual.EnrollStatus, 
  StatusCode.Text AS EnrollStatusText ,
  Individual.Relinquished, 
  CASE  
    WHEN Individual.RelinquishedDate = '12/31/9999' THEN ''
    ELSE Individual.RelinquishedDate
  END AS RelinquishedDate,
  Individual.RelinquishedFrom, 
  Individual.RelinquishedTo, 
  'Approve' AS ChangeStatus, 
  { fn CONCAT(
    'From: ' + Individual.RelinquishedFrom, 
    ' To: ' + Individual.RelinquishedTo
  ) } AS Description FROM 
  Individual 
  LEFT OUTER JOIN StatusCode ON Individual.EnrollStatus = StatusCode.ID 
WHERE 
  (Individual.Relinquished = 1) 
  and DeleteDate is null AND EnrollNumber IS NOT NULL  


