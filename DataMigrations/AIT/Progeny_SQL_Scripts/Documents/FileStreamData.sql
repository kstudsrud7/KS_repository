SELECT 
  ImageID AS RowID,
  IndividualDocument.ID, 
  IndividualDocument.Type, 
  IndividualDocument.Format, 
  IndividualDocument.FilestreamImage AS ImageData, 
  IndividualDocument.IndividualID, 
  IndividualDocument.SecurityEntityID, 
  REPLACE(
    REPLACE(
      REPLACE(
        REPLACE(
          REPLACE(
            REPLACE(
              REPLACE(
                REPLACE(
                  REPLACE(
                    LTRIM(
                      RTRIM(IndividualDocument.Title)
                    ), 
                    '"', '_'
                  ),
                  '*', '_'
                ),
                ':', '_'
              ),
              '<', '_'
            ),
            '>', '_'
          ),
          '?', '_'
        ),
        '/', '_'
      ),
      '\', '_'
    ),
    '|', '_'
  ) AS Title,
  REPLACE(
    LTRIM(
      RTRIM(IndividualDocument.Description)
    ), 
    '/', 
    '_'
  ) AS Description, 
  IndividualDocument.Thumbnail, 
  IndividualDocument.Scale, 
  IndividualDocument.ViewPositionX, 
  IndividualDocument.ViewPositionY, 
  IndividualDocument.IsDefault, 
  I.Suffix 
FROM 
  IndividualDocument 
  LEFT OUTER JOIN Individual AS I ON IndividualDocument.IndividualID = I.ID 
WHERE 
  IndividualDocument.Image IS NULL
  AND IndividualID = '97c66a82-e356-4db7-a172-48f580a8728f'
  AND ImageID BETWEEN 1 AND 10000
ORDER BY 
  ImageID;
