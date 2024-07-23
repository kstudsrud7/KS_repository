SELECT 
    I.ID AS IndividualID, 
    I.FirstName, 
    I.LastName, 
    I.EnrollNumber,
    BF1.Fraction AS TotalBloodBQ,
    BF2.Fraction AS TotalTribeBloodBQ
FROM   
    Individual AS I
LEFT JOIN 
    BloodFraction AS BF1 ON I.TotalBlood = BF1.Numerator
LEFT JOIN 
    BloodFraction AS BF2 ON I.TotalTribeBlood = BF2.Numerator
WHERE 
    I.DeleteDate IS NULL
    AND ((I.TotalBlood IS NOT NULL OR BF1.Fraction IS NOT NULL AND BF1.Fraction != 'N/A')
    OR (I.TotalTribeBlood IS NOT NULL OR BF2.Fraction IS NOT NULL AND BF2.Fraction != 'N/A'))
	AND I.ID = 'acd67e6a-efdf-447d-8dd3-f25b5833e58d'
