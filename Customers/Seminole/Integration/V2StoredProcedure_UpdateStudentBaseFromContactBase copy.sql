CREATE TABLE [Education_MSCRM].[dbo].[JobRunHistory] (
    JobName NVARCHAR(100) PRIMARY KEY,
    LastRunDateTime DATETIME
);

-- Initialize the table with the job name and a default date
INSERT INTO [Education_MSCRM].[dbo].[JobRunHistory] (JobName, LastRunDateTime)
VALUES ('UpdateStudentBaseFromContactBase', '1999-01-01');


-----------------------------------
USE [Education_MSCRM]
-- Create the stored procedure under the dbo schema in Education_MSCRM database
CREATE PROCEDURE [dbo].[STOF.UpdateStudentBaseFromMysticContactBase]
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
          ContactBase.ait_MemberID AS memberid,
          ContactBase.FirstName AS firstname,
          ContactBase.MiddleName AS middlename,
          ContactBase.LastName AS lastname,
          ContactBase.Suffix AS suffix,
          ContactBase.NickName AS nickname,
          ContactBase.Telephone2 AS homephone,
          ContactBase.MobilePhone AS mobilephone,
          ContactBase.EMailAddress1 AS email,
          ContactBase.ait_MembershipStatus AS membershipstatus,
          ContactBase.GenderCode AS gender,
          DATEADD(day, 1, ContactBase.BirthDate) AS birthdate,
          ait_reservationBase.ait_name COLLATE SQL_Latin1_General_CP1_CI_AS AS residency,  -- Updated to pull residency name with collation
          ContactBase.ait_MaidenName AS maidenname,
          ContactBase.EMailAddress1 AS emailaddress,
          ContactBase.ait_1099VendorID AS vendorid_1099,
          ContactBase.ait_Clan AS clan,
          ContactBase.ait_SSN AS ssn,
          RIGHT(ContactBase.ait_SSN, 4) AS ssnlast4,  -- Extracting last 4 digits for ait_SSNLast4
          ContactBase.ait_Address1 AS address1
    FROM 
        [SeminoleTribeofFlorida_MSCRM].[dbo].[ContactBase] 
    INNER JOIN 
        [SeminoleTribeofFlorida_MSCRM].[dbo].[ait_reservationBase] 
        ON ContactBase.ait_Residency = ait_reservationBase.ait_reservationId
    WHERE 
        ContactBase.ModifiedOn >= @LastRunDateTime;

    -- Update StudentBase with the data from the temporary table
    -- Update StudentBase with the data from the temporary table
-- Update StudentBase with the data from the temporary table
-- Update StudentBase with the data from the temporary table
UPDATE sb
SET 
    sb.ait_FirstName = tc.firstname COLLATE SQL_Latin1_General_CP1_CI_AS,
    sb.ait_MiddleName = tc.middlename COLLATE SQL_Latin1_General_CP1_CI_AS,
    sb.ait_LastName = tc.lastname COLLATE SQL_Latin1_General_CP1_CI_AS,
    sb.ait_Suffix = tc.suffix COLLATE SQL_Latin1_General_CP1_CI_AS,
    sb.ait_Nickname = tc.nickname COLLATE SQL_Latin1_General_CP1_CI_AS,
    sb.ait_HomePhone = tc.homephone COLLATE SQL_Latin1_General_CP1_CI_AS,
    sb.ait_MobilePhone = tc.mobilephone COLLATE SQL_Latin1_General_CP1_CI_AS,
    sb.ait_Email = tc.emailaddress COLLATE SQL_Latin1_General_CP1_CI_AS,
    sb.ait_MemberStatus = tc.membershipstatus COLLATE SQL_Latin1_General_CP1_CI_AS,
    sb.ait_Gender = CASE 
                        WHEN tc.gender = '1' THEN 914600000
                        WHEN tc.gender = '2' THEN 914600001
                        ELSE NULL  -- Handle cases where gender is not 1 or 2
                    END,
    sb.ait_DateofBirth = tc.birthdate,
    sb.ait_MaidenName = tc.maidenname COLLATE SQL_Latin1_General_CP1_CI_AS,
    sb.ait_VendorID = tc.vendorid_1099 COLLATE SQL_Latin1_General_CP1_CI_AS,
    sb.ait_Clan = tc.clan COLLATE SQL_Latin1_General_CP1_CI_AS,
    sb.ait_SSN = tc.ssn COLLATE SQL_Latin1_General_CP1_CI_AS,  -- Updated for ait_SSN mapping
    sb.ait_SSNLast4 = tc.ssnlast4 COLLATE SQL_Latin1_General_CP1_CI_AS,  -- Updated for ait_SSNLast4 mapping
    sb.ait_Address1 = tc.address1 COLLATE SQL_Latin1_General_CP1_CI_AS,  -- Updated for ait_Address1 mapping
    
    -- Update sb.ait_name by concatenating first name, middle name, last name, and suffix if it's not blank
    sb.ait_name = LTRIM(RTRIM(CONCAT(
        tc.firstname COLLATE SQL_Latin1_General_CP1_CI_AS, ' ', 
        ISNULL(tc.middlename COLLATE SQL_Latin1_General_CP1_CI_AS, ''), ' ', 
        tc.lastname COLLATE SQL_Latin1_General_CP1_CI_AS, 
        CASE 
            WHEN ISNULL(tc.suffix, '') <> '' THEN ' ' + tc.suffix COLLATE SQL_Latin1_General_CP1_CI_AS
            ELSE '' 
        END))),

    -- Update sb.ait_Reservation (GUID) using the corresponding ait_reservationId based on the string residency name
    sb.ait_Reservation = ar.ait_reservationId  -- Match by residency name and update with GUID

FROM 
    [Education_MSCRM].[dbo].[ait_studentBase] sb
INNER JOIN 
    #TempContactBase tc 
    ON sb.ait_MemberID COLLATE SQL_Latin1_General_CP1_CI_AS = tc.memberid COLLATE SQL_Latin1_General_CP1_CI_AS
LEFT JOIN 
    [Education_MSCRM].[dbo].[ait_reservationBase] ar
    ON ar.ait_name COLLATE SQL_Latin1_General_CP1_CI_AS = tc.residency COLLATE SQL_Latin1_General_CP1_CI_AS;  -- Matching tc.residency string with ait_reservationBase.ait_name

    -- Drop the temporary table
    DROP TABLE #TempContactBase;

    -- Update the tracking table with the current run date/time
    UPDATE [Education_MSCRM].[dbo].[JobRunHistory]
    SET LastRunDateTime = @CurrentRunDateTime
    WHERE JobName = 'UpdateStudentBaseFromContactBase';
END;



-- Execute the stored procedure
USE [Education_MSCRM];
GO
-- Execute the stored procedure
EXEC [dbo].[STOF_UpdateStudentBaseFromMysticContactBase];

