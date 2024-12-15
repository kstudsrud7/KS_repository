SELECT DISTINCT
    CASE
        WHEN ISNULL(IndividualName.Type, 0) = 1 THEN 'Married Name'
        WHEN ISNULL(IndividualName.Type, 0) = 2 THEN 'Official Name Change'
        WHEN ISNULL(IndividualName.Type, 0) = 3 THEN 'Indian Name'
        WHEN ISNULL(IndividualName.Type, 0) = 4 THEN 'Given Name'
        WHEN ISNULL(IndividualName.Type, 0) = 5 THEN 'Paternity'
        WHEN ISNULL(IndividualName.Type, 0) = 6 THEN 'Legal Guardianship'
        WHEN ISNULL(IndividualName.Type, 0) = 7 THEN 'Adoption Decree'
        WHEN ISNULL(IndividualName.Type, 0) = 8 THEN 'Ward'
        WHEN ISNULL(IndividualName.Type, 0) = 9 THEN 'Nickname'
        WHEN ISNULL(IndividualName.Type, 0) = 10 THEN 'Alias'
        WHEN ISNULL(IndividualName.Type, 0) = 11 THEN 'Maiden Name'
        WHEN ISNULL(IndividualName.Type, 0) = 12 THEN 'SSN Name'
        ELSE 'Unknown'
    END AS Type
FROM
    IndividualName
LEFT OUTER JOIN
    Individual AS I ON IndividualName.IndividualID = I.ID
WHERE
    I.DeleteDate IS NULL;