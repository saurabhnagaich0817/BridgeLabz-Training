--Store Procedure -->  A Stored Procedure is a set of SQL commands saved inside the database with a name.
--Syntax--> 
--CREATE PROCEDURE PROCEDURENAME
--AS 
--BEGIN
-- SQL Statements
-- END

--SYNTAX WITH PARAMETERS
--CREATE PROCEDURE ProcedureName
--@param datatypes
--AS 
--BEGIN  
-- SQL Statements
-- END


CREATE DATABASE SP_PracticeDB;
USE SP_PracticeDB;

CREATE TABLE Students(
StudentID INT PRIMARY KEY,
NAME VARCHAR(50),
AGE INT,
DEPARTMENT VARCHAR(50),
);


--CREATING PROCEDURE
CREATE PROCEDURE sp_InsertStudent
@id INT,
@name VARCHAR(50),
@age INT,
@dept VARCHAR(50)
AS
BEGIN 
INSERT INTO Students
VALUES(@id,@name,@age,@dept)
END

EXEC sp_InsertStudent 1,'saurabh',20,'CSE';
EXEC sp_InsertStudent 2,'Amit',22,'IT';
SELECT * FROM Students;

--Stored Procedure for SELECT
CREATE PROCEDURE sp_GetStudents
AS
BEGIN
 SELECT * FROM Students
END
EXEC sp_GetStudents;

--Stored Procedure for UPDATE
CREATE PROCEDURE sp_UpdateStudent
@id INT,
@age INT
AS 
BEGIN 
UPDATE Students
SET Age =@age
WHERE StudentID=@id
END

EXEC sp_UpdateStudent 1,25;
--Stored Procedure for DELETE
CREATE PROCEDURE sp_DeleteStudent
 @id INT
AS
BEGIN
 DELETE FROM Students
 WHERE StudentID=@id
END

EXEC sp_DeleteStudent 2;


SELECT * FROM Students;


--DCL   FOR STORE PROCEDURE 

USE SP_PracticeDB;
 
 --Create Login (One Time)
CREATE LOGIN testuser
WITH PASSWORD = 'Test@123';

--Create User in SAME Database

CREATE USER testuser
FOR LOGIN testuser;


--Stored Procedure for GRANT
CREATE PROCEDURE sp_GrantPermission
AS
BEGIN
 GRANT SELECT, INSERT ON Students TO testuser;
END

EXEC sp_GrantPermission


--Stored Procedure for REVOKE

CREATE PROCEDURE sp_RevokePermission
AS
BEGIN
 REVOKE INSERT ON Students FROM testuser;
END

EXEC sp_RevokePermission;


--DQL COMMANDS
--Stored Procedure
--CREATE PROCEDURE sp_SelectAll
--AS
--BEGIN
-- SELECT * FROM Students;
--END
--GO

--where
CREATE PROCEDURE sp_SelectWhere
@id INT
AS
BEGIN
SELECT * FROM Students WHERE StudentID=@id;
END
EXEC sp_SelectWhere 1;

--ORDER BY

CREATE PROCEDURE sp_OrderByAge
AS
BEGIN
 SELECT * FROM Students ORDER BY Age;
END

--DISTINCT
CREATE PROCEDURE sp_DistinctDept
AS
BEGIN
 SELECT DISTINCT Department FROM Students;
END
GO

--GROUP BY + COUNT
CREATE PROCEDURE sp_GroupByDept
AS
BEGIN
 SELECT Department, COUNT(*) AS Total
 FROM Students
 GROUP BY Department;
END
--DDL COMMANDS

--CREATE
CREATE PROCEDURE sp_CreateDemoTable
AS
BEGIN
 CREATE TABLE Demo(
   ID INT,
   Name VARCHAR(50)
 );
END


--ALTER (ADD)
CREATE PROCEDURE sp_AlterAdd
AS
BEGIN
 ALTER TABLE Demo ADD Age INT;
END
GO

--ALTER (RENAME COLUMN)
CREATE PROCEDURE sp_AlterRename
AS
BEGIN
 EXEC sp_rename 'Demo.Name','FullName','COLUMN';
END
GO

--TRUNCATE
CREATE PROCEDURE sp_TruncateDemo
AS
BEGIN
 TRUNCATE TABLE Demo;
END
GO

--DROP
CREATE PROCEDURE sp_DropDemo
AS
BEGIN
 DROP TABLE Demo;
END

--TCL COMMANDS

--COMMIT
CREATE PROCEDURE sp_TCLCommit
AS
BEGIN
 BEGIN TRANSACTION;
 UPDATE Students SET Age=25 WHERE StudentID=1;
 COMMIT;
END
GO

--ROLLBACK
CREATE PROCEDURE sp_TCLRollback
AS
BEGIN
 BEGIN TRANSACTION;
 UPDATE Students SET Age=35 WHERE StudentID=1;
 ROLLBACK;
END
GO

--SAVEPOINT

--(SQL Server uses SAVE TRANSACTION)

CREATE PROCEDURE sp_SavePoint
AS
BEGIN
 BEGIN TRANSACTION;

 UPDATE Students SET Age=28 WHERE StudentID=1;

 SAVE TRANSACTION S1;

 UPDATE Students SET Age=40 WHERE StudentID=2;

 ROLLBACK TRANSACTION S1;

 COMMIT;
END

--TRIGGERS  

SELECT * FROM Students;

CREATE TABLE StudentLog(
 LogID INT IDENTITY(1,1) PRIMARY KEY,
 StudentID INT,
 ActionType VARCHAR(20),
 ActionDate DATETIME
);


--INSERT TRIGGER
--Syntax --..  CREATE TRIGGER trigger_name
--ON table_name
--AFTER INSERT
--AS
--BEGIN
-- -- logic
--END


CREATE TRIGGER trg_InsertStudent
ON Students
AFTER INSERT
AS
BEGIN
 INSERT INTO StudentLog(StudentID,ActionType,ActionDate)
 SELECT StudentID,'INSERT',GETDATE()
 FROM inserted;
END


--Test Trigger

INSERT INTO Students
VALUES (5,'Neha',21,'CSE','neha@gmail.com');





--UPDATE TRIGGER

--Syntax  
--CREATE TRIGGER trigger_name
--ON table_name
--AFTER UPDATE
--AS
--BEGIN
--END

CREATE TRIGGER trg_UpdateStudent
ON Students
AFTER UPDATE
AS
BEGIN
 INSERT INTO StudentLog(StudentID,ActionType,ActionDate)
 SELECT StudentID,'UPDATE',GETDATE()
 FROM inserted;
END

UPDATE Students
SET Age = 23
WHERE StudentID = 1;

SELECT * FROM StudentLog;

--DELETE TRIGGER

--Syntax -- >> CREATE TRIGGER trigger_name
--ON table_name
--AFTER DELETE
--AS
--BEGIN
--END
CREATE TRIGGER trg_DeleteStudent
ON Students
AFTER DELETE
AS
BEGIN
 INSERT INTO StudentLog(StudentID,ActionType,ActionDate)
 SELECT StudentID,'DELETE',GETDATE()
 FROM deleted;
END

DELETE FROM Students
WHERE StudentID = 5;
SELECT * FROM StudentLog;

SELECT * FROM inserted;
SELECT * FROM deleted;









