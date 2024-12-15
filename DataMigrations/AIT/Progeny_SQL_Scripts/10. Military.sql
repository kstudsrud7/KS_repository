SELECT        ID, FirstName, MiddleName, LastName, EnrollNumber, Veteran, VeteranServiceEraID, Enlisted, ServiceBranchID, ServiceFrom, ServiceTo, ServiceNotes, Disabled, PercentDisabled, DisabilityComments, 
                         'MilitaryVeteran' AS MilitaryStatus
FROM            Individual
WHERE        (Veteran = 1) and deletedate is null