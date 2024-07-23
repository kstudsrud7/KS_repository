SELECT      ID, ID as BirthRecordGUID, FirstName, MiddleName, LastName, EnrollStatus, Deceased, DeathCity, DeathDate,

	Case when deathdate = '9999-12-31 00:00:00.0000000' then NULL
		when deathdate = '1911-11-11 00:00:00.0000000' then NULL
		when deathdate = '1901-01-01 00:00:00.0000000' then NULL
		else deathdate end as DeathDateNew, 
		


 DeathState, DeathCountry, DeathLocation, 
	case when isnull(Individual.[DeathOnFile],0)=1 then 'Yes'
		when isnull(Individual.[DeathOnFile],0)=2 then 'No'
		else null end as DeathOnFile,
		Concat(DeathCity,' ' , DeathState,' ',DeathCountry, ' ', DeathLocation) as Description

FROM            Individual
WHERE Deceased = 1 and deletedate is null