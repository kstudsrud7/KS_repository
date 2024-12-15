select ID,HouseholdHead,LastName,FirstName,BirthDate from individual
where HouseholdHead = 1 AND deletedate IS NULL
