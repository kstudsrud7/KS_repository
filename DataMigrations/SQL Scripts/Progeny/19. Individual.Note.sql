SELECT 
  IndividualNote.ID AS NoteID,  
  IndividualNote.IndividualID, 
  IndividualNote.CreateDate, 
  IndividualNote.NoteBody AS NoteText, 
  I.FirstName, 
  I.MiddleName, 
  I.LastName, 
  'Imported note by ' + IndividualNote.CreateBy AS Title 
FROM 
  IndividualNote AS MP 
  RIGHT OUTER JOIN Individual AS I ON MP.ID = I.ID 
  RIGHT OUTER JOIN IndividualNote ON I.ID = IndividualNote.IndividualID 
WHERE 
  (I.DeleteDate IS NULL)
