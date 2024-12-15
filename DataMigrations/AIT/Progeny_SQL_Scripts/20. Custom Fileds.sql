Select * from Individual

Select * from IndividualMailLink

Select * from IndividualStructureLink

Select * from Structure

SELECT        IndividualCustomFieldValue.IndividualID, CustomField.Name AS CustomFieldName, CustomFieldOption.Value, CustomField.LinkTable
FROM            IndividualCustomFieldValue INNER JOIN
                         CustomFieldOption ON IndividualCustomFieldValue.Value = CustomFieldOption.Value RIGHT OUTER JOIN
                         CustomField ON CustomFieldOption.CustomFieldID = CustomField.ID
ORDER BY Name

SELECT        Event.ID, Event.EventTypeID, Event.Title, Event.Description, Event.Date, Event.RequireSignature, Event.RequirePrint, Event.MinimumAge, Event.MagstripeEncoding, Event.LockOwnerID, ET.Description AS Type
FROM            Event LEFT OUTER JOIN
                         EventType AS ET ON Event.EventTypeID = ET.ID

SELECT        EventType.Description, IEA.EventID, Count (IEA.IndividualID) AS NUMrecrods, Event.Title
FROM            IndividualEventAttendance AS IEA INNER JOIN
                         Event ON IEA.EventID = Event.ID INNER JOIN
                         EventType ON Event.EventTypeID = EventType.ID  Group by EventType.Description

SELECT EventType.Description, IEA.EventID, COUNT(IEA.IndividualID) AS NUMrecords
FROM IndividualEventAttendance AS IEA
INNER JOIN Event ON IEA.EventID = Event.ID
INNER JOIN EventType ON Event.EventTypeID = EventType.ID  
GROUP BY EventType.Description, IEA.EventID
