CREATE TABLE dbo.JobRunHistory (
    JobName NVARCHAR(100) PRIMARY KEY,
    LastRunDateTime DATETIME
);

-- Initialize the table with the job name and a default date
INSERT INTO dbo.JobRunHistory (JobName, LastRunDateTime)
VALUES ('UpdateStudentBaseFromContactBase', '2099-01-01');


-----------------------------------

CREATE PROCEDURE UpdateStudentBaseFromContactBase
AS
BEGIN
    DECLARE @LastRunDateTime DATETIME;
    DECLARE @CurrentRunDateTime DATETIME;

    -- Get the last run date/time from the tracking table
    SELECT @LastRunDateTime = LastRunDateTime
    FROM dbo.JobRunHistory
    WHERE JobName = 'UpdateStudentBaseFromContactBase';

    -- Get the current date/time
    SET @CurrentRunDateTime = GETDATE();

    -- Declare temporary table to hold the data from ContactBase
    CREATE TABLE #TempContactBase
    (
        memberid NVARCHAR(50),
        firstname NVARCHAR(100),
        middlename NVARCHAR(100),
        lastname NVARCHAR(100),
        suffix NVARCHAR(50),
        nickname NVARCHAR(100),
        homephone NVARCHAR(50),
        mobilephone NVARCHAR(50),
        email NVARCHAR(100),
        membershipstatus NVARCHAR(100),
        gender NVARCHAR(50),
        birthdate DATE,
        residency NVARCHAR(100),
        maidenname NVARCHAR(100),
        emailaddress NVARCHAR(100),
        vendorid_1099 NVARCHAR(100),
        clan NVARCHAR(100),
        ssn NVARCHAR(100),
        ssnlast4 NVARCHAR(4),  -- Added for ait_SSNLast4
        address1 NVARCHAR(250)  -- Added for ait_Address1
    );

    -- Insert data from ContactBase into the temporary table
    INSERT INTO #TempContactBase
    SELECT   
          [ait_MemberID] AS memberid,
          [FirstName] AS firstname,
          [MiddleName] AS middlename,
          [LastName] AS lastname,
          [Suffix] AS suffix,
          [NickName] AS nickname,
          [Telephone2] AS homephone,
          [MobilePhone] AS mobilephone,
          [EMailAddress1] AS email,
          [ait_MembershipStatus] AS membershipstatus,
          [GenderCode] AS gender,
          DATEADD(day,1, [BirthDate]) AS birthdate,
          [ait_Residency] AS residency,
          [ait_MaidenName] AS maidenname,
          [EMailAddress1] AS emailaddress,
          [ait_1099VendorID] AS vendorid_1099,
          [ait_Clan] AS clan,
          [ait_SSN] AS ssn,
          RIGHT([ait_SSN], 4) AS ssnlast4,  -- Extracting last 4 digits for ait_SSNLast4
          [ait_Address1] AS address1 -- Assuming Address1_Line1 holds the address data
      FROM [SeminoleTribeofFlorida_MSCRM].[dbo].[ContactBase]
    WHERE [ModifiedOn] >= @LastRunDateTime;

    -- Update StudentBase with the data from the temporary table
    UPDATE sb
    SET 
        sb.ait_FirstName = tc.firstname,
        sb.ait_MiddleName = tc.middlename,
        sb.ait_LastName = tc.lastname,
        sb.ait_Suffix = tc.suffix,
        sb.ait_Nickname = tc.nickname,
        sb.ait_HomePhone = tc.homephone,
        sb.ait_MobilePhone = tc.mobilephone,
        sb.ait_Email = tc.emailaddress,
        sb.ait_MemberStatus = tc.membershipstatus,
        sb.ait_Gender = CASE 
                            WHEN tc.gender = '1' THEN 914600000
                            WHEN tc.gender = '2' THEN 914600001
                            ELSE NULL  -- Handle cases where gender is not 1 or 2
                        END,
        sb.ait_DateofBirth = tc.birthdate,
        --sb.ait_Reservation = tc.residency, -- Lookup confirmation needed for this field
        sb.ait_MaidenName = tc.maidenname,
        sb.ait_VendorID = tc.vendorid_1099,
        sb.ait_Clan = tc.clan,
        sb.ait_SSN = tc.ssn,  -- Updated for ait_SSN mapping
        sb.ait_SSNLast4 = tc.ssnlast4,  -- Updated for ait_SSNLast4 mapping
        sb.ait_Address1 = tc.address1,  -- Updated for ait_Address1 mapping
        -- Concatenating first name, middle name, and last name, trimming spaces in between
        sb.ait_name = LTRIM(RTRIM(CONCAT(tc.firstname, ' ', ISNULL(tc.middlename, ''), ' ', tc.lastname)))
    FROM [Education_MSCRM].[dbo].[ait_studentBase] sb
    INNER JOIN #TempContactBase tc ON sb.ait_MemberID COLLATE SQL_Latin1_General_CP1_CI_AS = tc.memberid COLLATE SQL_Latin1_General_CP1_CI_AS;

    -- Drop the temporary table
    DROP TABLE #TempContactBase;

    -- Update the tracking table with the current run date/time
    UPDATE dbo.JobRunHistory
    SET LastRunDateTime = @CurrentRunDateTime
    WHERE JobName = 'UpdateStudentBaseFromContactBase';
END;


-- Execute the stored procedure
EXEC UpdateStudentBaseFromContactBase;
