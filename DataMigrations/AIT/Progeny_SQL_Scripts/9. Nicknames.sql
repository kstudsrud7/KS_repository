SELECT        Concat(IndividualName.ID,'NickName') AS MHAID,IndividualName.IndividualID, CONCAT(First, ' ', Middle, ' ', Last) as Name, CASE WHEN isnull(IndividualName.Type, 0) 
                         = 1 THEN 'Married Name' WHEN isnull(IndividualName.Type, 0) = 2 THEN 'Official Name Change' WHEN isnull(IndividualName.Type, 0) = 3 THEN 'Indian Name' WHEN isnull(IndividualName.Type, 0) 
                         = 4 THEN 'Given Name' WHEN isnull(IndividualName.Type, 0) = 5 THEN 'Paternity' WHEN isnull(IndividualName.Type, 0) = 6 THEN 'Legal Guardianship' WHEN isnull(IndividualName.Type, 0) 
                         = 7 THEN 'Adoption Decree' WHEN isnull(IndividualName.Type, 0) = 8 THEN 'Ward' WHEN isnull(IndividualName.Type, 0) = 9 THEN 'Nickname' WHEN isnull(IndividualName.Type, 0) 
                         = 10 THEN 'Alias' WHEN isnull(IndividualName.Type, 0) = 11 THEN 'Maiden Name' WHEN isnull(IndividualName.Type, 0) = 12 THEN 'SSN Name' ELSE 'Unknown' END AS Type
FROM            IndividualName LEFT OUTER JOIN
                         Individual AS I ON IndividualName.IndividualID = I.ID
Where I.DeleteDate is null