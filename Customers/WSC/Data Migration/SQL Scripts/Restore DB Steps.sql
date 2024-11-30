-- Step 1: Create a Master Key if it does not already exist
-- This is necessary for encrypted backups or certificates.

-- Check if a master key already exists
IF NOT EXISTS (SELECT * FROM sys.symmetric_keys WHERE name = '##MS_ServiceMasterKey##')
BEGIN
    CREATE MASTER KEY ENCRYPTION BY PASSWORD = 'YourSecurePassword';
    PRINT 'Master Key created successfully.';
END
ELSE
BEGIN
    PRINT 'Master Key already exists.';
END
GO

-- Step 2: Verify the files in the backup (optional but recommended)
RESTORE FILELISTONLY
FROM DISK = 'C:\Certificates\03cb0689-60b8-4b2d-a03b-224cf4510983-20241119065410521-2024_11_19_070538.bak';
GO

-- Step 3: Restore the database with the correct file locations
-- Ensure that the directories exist and SQL Server has access to them.
RESTORE DATABASE [WSC]
FROM DISK = 'C:\Certificates\03cb0689-60b8-4b2d-a03b-224cf4510983-20241119065410521-2024_11_19_070538.bak'
WITH MOVE 'RE7_BLANK' TO 'C:\SQLData\WSC.mdf',
     MOVE 'RE7_bio' TO 'C:\SQLData\WSC_bio.mdf',
     MOVE 'RE7_gift' TO 'C:\SQLData\WSC_gift.mdf',
     MOVE 'RE7_index' TO 'C:\SQLData\WSC_index.mdf',
     MOVE 'RE7_temp' TO 'C:\SQLData\WSC_temp.mdf',
     MOVE 'RE7_BLANK_log' TO 'C:\SQLLogs\WSC_log.ldf';
GO

-- Step 4: Check the database and files to ensure everything restored correctly
SELECT name, physical_name AS CurrentLocation, state_desc
FROM sys.master_files
WHERE database_id = DB_ID('WSC');
GO
