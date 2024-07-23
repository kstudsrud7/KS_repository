--First Query is for Total Calcualtions at the Individual Level
Select
	Individual.ID,
	Concat(Individual.FirstName,' ', Individual.LastName) AS Member,
	TotalTribe.Fraction AS TotalTribeFraction,
	Total.Fraction AS TotalFraction,
	StatusCode.Text AS EnrollmentStatus
From
	Individual 
	Left Outer Join BloodFraction AS TotalTribe ON Individual.TotalTribeBlood = TotalTribe.Numerator
	Left Outer Join BloodFraction AS Total ON Individual.TotalBlood = Total.Numerator
	LEFT OUTER JOIN StatusCode ON Individual.EnrollStatus = StatusCode.ID 
	--Where Individual.Id ='fc38f89c-20db-4bdc-8c85-6fc8e8c69dd0' --Henry: '746afddd-3d04-4da0-af60-41b6461e2a32'
	
--Second Query is for Individual Related BQ Records w/ Tribes

SELECT
    Individual.ID AS INDIVIDUALID,
    IndividualCulture.EthnicityID AS TribeID,
    IndividualCulture.CultureID,
    IndividualCulture.ID AS BQID,
    CONCAT(Individual.FirstName, ' ', Individual.LastName) AS Member,
    BloodFraction.Fraction AS BQFraction,
    CASE 
        WHEN IndividualCulture.EthnicityID = 'e89c5fa6-2a69-489e-8138-bb7dc4eb4701' THEN 'Minnesota Chippewa Tribe, Minnesota (Six component reservations)'
        ELSE Ethnicity.RegisterName
    END AS Tribe,
    Culture.Name AS Culture
FROM
    Individual
    LEFT OUTER JOIN IndividualCulture ON Individual.ID = IndividualCulture.IndividualID
    LEFT OUTER JOIN Ethnicity ON IndividualCulture.EthnicityID = Ethnicity.ID
    LEFT OUTER JOIN BloodFraction ON IndividualCulture.Quantum = BloodFraction.Numerator
    LEFT OUTER JOIN Culture ON IndividualCulture.CultureID = Culture.ID
WHERE
    Individual.DeleteDate IS NULL
    AND Ethnicity.ID IS NOT NULL
    AND BloodFraction.Fraction IS NOT NULL
    AND BloodFraction.Fraction != 'N/A'
ORDER BY
    Member;




