SELECT 
  IR.ParentIndividualID, 
  IR.ChildIndividualID
FROM 
  IndividualRelation AS IR 
  LEFT OUTER JOIN Individual AS Child ON IR.ChildIndividualID = Child.ID 
  LEFT OUTER JOIN Individual AS Parent ON IR.ParentIndividualID = Parent.ID 
WHERE 
  case when isnull([IR].[Status], '') = 'Adopted' 
  and Parent.Gender = 'M' then 'Adoptive Dad' when isnull([IR].[Status], '') = 'Adopted' 
  and Parent.Gender in ('F', 'U', '') then 'Adoptive Mom' when isnull([IR].[Status], '') = 'Issue' 
  and Parent.Gender = 'M' then 'Biological Dad' when isnull([IR].[Status], '') = 'Issue' 
  and Parent.Gender in ('F', 'U', '') then 'Biological Mom' when isnull([IR].[Status], '') = 'Step' 
  and Parent.Gender = 'M' then 'Step Dad' when isnull([IR].[Status], '') = 'Step' 
  and Parent.Gender in ('F', 'U', '') then 'Step Mom' else '' end = 'Biological Mom'
  AND Child.DeleteDate IS NULL 
