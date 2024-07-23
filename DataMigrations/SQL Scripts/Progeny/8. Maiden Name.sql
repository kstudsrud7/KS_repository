select  I.ID,CONCAT( I.ID,'MaidenName') AS MHAID, I.MaidenName, 'Maiden Name' as Type
from Individual I
where  isnull(I.MaidenName, '') <> '' and deletedate is null