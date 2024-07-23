-- Before running, check for records with empty spaces instead of NULL
-- update Individual set Email = NULL where Email = ''
SELECT        ID, Email, 'Email' as CommunicationType, 'Home' as Type
FROM            Individual
WHERE        Email is not null and (LEN(LTRIM(RTRIM(Email))) > 0) AND deletedate is null;