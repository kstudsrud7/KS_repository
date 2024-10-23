-- Verify Collation is the same between Mystic & Education
-- Check service to see if SQL Server Agent is running
-- Start, search, 'SQL Server Agent'
-- Delete Existing JobRunHistory in MASTER
-- Delete Existing UpdateStudentBaseFromMysticContactBase in MASTER

-- Proceed to Next Steps

CREATE TABLE [Education_MSCRM].[dbo].[STOF_JobRunHistory] (
    JobName NVARCHAR(100) PRIMARY KEY,
    LastRunDateTime DATETIME
);

-- Initialize the table with the job name and a default date
INSERT INTO [Education_MSCRM].[dbo].[STOF_JobRunHistory] (JobName, LastRunDateTime)
VALUES ('STOF_UpdateStudentBaseFromContactBase', '1999-01-01');

-- SELECT Education_MSCRM Database

CREATE PROCEDURE STOF_UpdateStudentBaseFromMysticContactBase
AS
BEGIN
    DECLARE @LastRunDateTime DATETIME;
    DECLARE @CurrentRunDateTime DATETIME;

    -- Get the last run date/time from the tracking table
    SELECT @LastRunDateTime = LastRunDateTime
    FROM dbo.STOF_JobRunHistory
    WHERE JobName = 'STOF_UpdateStudentBaseFromContactBase';

    -- Get the current date/time
    SET @CurrentRunDateTime = GETDATE();

    -- Declare temporary table to hold the data from ContactBase
    CREATE TABLE #TempContactBase (
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
        DATEADD(day, 1, [BirthDate]) AS birthdate,
        ait_reservationBase.ait_name COLLATE SQL_Latin1_General_CP1_CI_AS AS residency,  -- Updated to pull residency name with collation
        [ait_MaidenName] AS maidenname,
        [EMailAddress1] AS emailaddress,
        [ait_1099VendorID] AS vendorid_1099,
        [ait_Clan] AS clan,
        [ait_SSN] AS ssn,
        RIGHT([ait_SSN], 4) AS ssnlast4,  -- Extracting last 4 digits for ait_SSNLast4
        [ait_Address1] AS address1  -- Assuming Address1_Line1 holds the address data
    FROM 
        [SeminoleTribeofFlorida_MSCRM].[dbo].[ContactBase]
    INNER JOIN 
        [SeminoleTribeofFlorida_MSCRM].[dbo].[ait_reservationBase] 
        ON ContactBase.ait_Residency = ait_reservationBase.ait_reservationId
    WHERE 
        ContactBase.ModifiedOn >= @LastRunDateTime;

    -- Update StudentBase with the data from the temporary table
    UPDATE sb
    SET 
        sb.ait_FirstName = tc.firstname COLLATE Latin1_General_CI_AI,
        sb.ait_MiddleName = tc.middlename COLLATE Latin1_General_CI_AI,
        sb.ait_LastName = tc.lastname COLLATE Latin1_General_CI_AI,
        sb.ait_Suffix = tc.suffix COLLATE Latin1_General_CI_AI,
        sb.ait_Nickname = tc.nickname COLLATE Latin1_General_CI_AI,
        sb.ait_HomePhone = tc.homephone COLLATE Latin1_General_CI_AI,
        sb.ait_MobilePhone = tc.mobilephone COLLATE Latin1_General_CI_AI,
        sb.ait_Email = tc.emailaddress COLLATE Latin1_General_CI_AI,
        sb.ait_MemberStatus = tc.membershipstatus COLLATE Latin1_General_CI_AI,
        sb.ait_Gender = CASE 
                            WHEN tc.gender = '1' THEN 914600000
                            WHEN tc.gender = '2' THEN 914600001
                            ELSE NULL  -- Handle cases where gender is not 1 or 2
                        END,
        sb.ait_DateofBirth = tc.birthdate,
        sb.ait_MaidenName = tc.maidenname COLLATE Latin1_General_CI_AI,
        sb.ait_VendorID = tc.vendorid_1099 COLLATE Latin1_General_CI_AI,
        sb.ait_Clan = tc.clan COLLATE Latin1_General_CI_AI,
        sb.ait_SSN = tc.ssn COLLATE Latin1_General_CI_AI,  -- Updated for ait_SSN mapping
        sb.ait_SSNLast4 = tc.ssnlast4 COLLATE Latin1_General_CI_AI,  -- Updated for ait_SSNLast4 mapping
        sb.ait_Address1 = tc.address1 COLLATE Latin1_General_CI_AI,  -- Updated for ait_Address1 mapping

        -- Concatenating first name, middle name, and last name, trimming spaces in between
        sb.ait_name = LTRIM(RTRIM(CONCAT(
            tc.firstname COLLATE Latin1_General_CI_AI, 
            ' ', 
            ISNULL(tc.middlename COLLATE Latin1_General_CI_AI, ''), 
            ' ', 
            tc.lastname COLLATE Latin1_General_CI_AI,
            CASE 
                WHEN ISNULL(tc.suffix, '') <> '' THEN ' ' + tc.suffix COLLATE Latin1_General_CI_AI 
                ELSE '' 
            END
        ))),

        -- Update sb.ait_Reservation (GUID) using the corresponding ait_reservationId based on the string residency name
        sb.ait_Reservation = ar.ait_reservationId  -- Match by residency name and update with GUID

    FROM 
        [Education_MSCRM].[dbo].[ait_studentBase] sb
    INNER JOIN 
        #TempContactBase tc 
        ON sb.ait_MemberID COLLATE SQL_Latin1_General_CP1_CI_AI = tc.memberid COLLATE SQL_Latin1_General_CP1_CI_AI
    LEFT JOIN 
        [Education_MSCRM].[dbo].[ait_reservationBase] ar
        ON ar.ait_name COLLATE SQL_Latin1_General_CP1_CI_AI = tc.residency COLLATE SQL_Latin1_General_CP1_CI_AI;  -- Matching tc.residency string with ait_reservationBase.ait_name

    -- Drop the temporary table
    DROP TABLE #TempContactBase;

    -- Update the tracking table with the current run date/time
    UPDATE [Education_MSCRM].[dbo].[STOF_JobRunHistory]
    SET LastRunDateTime = @CurrentRunDateTime
    WHERE JobName = 'STOF_UpdateStudentBaseFromContactBase';
END;

-- Execute the stored procedure
EXEC [Education_MSCRM].[dbo].[STOF_UpdateStudentBaseFromMysticContactBase];

-- Create SQL Server JOB "STOF_UpdateStudentBaseFromContactBase" to RUN AT 1:30 AM

-- Execute the following command step: EXEC [Education_MSCRM].[dbo].[STOF_UpdateStudentBaseFromMysticContactBase];
