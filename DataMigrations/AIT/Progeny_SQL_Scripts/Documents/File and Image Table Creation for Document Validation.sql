-- Following Scripts create tables for Filestream & Image type files from Progeny. This assits in PowerBI Document Migration

-- Create Table IndividualDocumentImageAIT
CREATE TABLE IndividualDocumentImageAIT (
  RowID INT
);

INSERT INTO IndividualDocumentImageAIT (RowID)
SELECT 
  ImageID AS RowID
FROM 
  IndividualDocument 
  LEFT OUTER JOIN Individual AS I ON IndividualDocument.IndividualID = I.ID 
WHERE 
  IndividualDocument.Image IS NOT NULL
  AND I.DeleteDate IS NULL
ORDER BY 
  ImageID;

-- Create Table IndividualDocumentFileStreamAIT
CREATE TABLE IndividualDocumentFileStreamAIT (
  RowID INT
);

INSERT INTO IndividualDocumentFileStreamAIT (RowID)
SELECT 
  ImageID AS RowID
FROM 
  IndividualDocument 
  LEFT OUTER JOIN Individual AS I ON IndividualDocument.IndividualID = I.ID 
WHERE 
  IndividualDocument.Image IS NULL
  AND I.DeleteDate IS NULL
ORDER BY 
  ImageID;
