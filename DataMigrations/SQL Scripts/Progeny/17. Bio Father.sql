SELECT 
  IR.ParentIndividualID, 
  IR.ChildIndividualID
FROM 
  IndividualRelation AS IR 
  LEFT OUTER JOIN Individual AS Child ON IR.ChildIndividualID = Child.ID 
  LEFT OUTER JOIN Individual AS Parent ON IR.ParentIndividualID = Parent.ID 
WHERE 
  CASE 
    WHEN ISNULL([IR].[Status], '') = 'Adopted' AND Parent.Gender = 'M' THEN 'Adoptive Dad' 
    WHEN ISNULL([IR].[Status], '') = 'Adopted' AND Parent.Gender IN ('F', 'U', '') THEN 'Adoptive Mom' 
    WHEN ISNULL([IR].[Status], '') = 'Issue' AND Parent.Gender = 'M' THEN 'Biological Dad' 
    WHEN ISNULL([IR].[Status], '') = 'Issue' AND Parent.Gender IN ('F', 'U', '') THEN 'Biological Mom' 
    WHEN ISNULL([IR].[Status], '') = 'Step' AND Parent.Gender = 'M' THEN 'Step Dad' 
    WHEN ISNULL([IR].[Status], '') = 'Step' AND Parent.Gender IN ('F', 'U', '') THEN 'Step Mom' 
    ELSE '' 
  END = 'Biological Dad'
  AND Child.DeleteDate IS NULL 
