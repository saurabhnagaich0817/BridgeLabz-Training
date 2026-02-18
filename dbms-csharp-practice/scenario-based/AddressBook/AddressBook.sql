CREATE DATABASE AddressBook
GO
USE AddressBook
GO

CREATE TABLE Contacts
(
    ContactId INT IDENTITY PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Address VARCHAR(100),
    City VARCHAR(50),
    State VARCHAR(50),
    Zip VARCHAR(10),
    Phone VARCHAR(15),
    Email VARCHAR(100)
)
GO

INSERT INTO Contacts VALUES
('Amit','Sharma','Street 1','Delhi','Delhi','110001','9991112222','amit@gmail.com'),
('Ravi','Kumar','Street 2','Noida','UP','201301','8882223333','ravi@gmail.com'),
('Neha','Singh','Street 3','Agra','UP','282001','7773334444','neha@gmail.com')
GO


CREATE PROC sp_AddContact
@FirstName VARCHAR(50),
@LastName VARCHAR(50),
@Address VARCHAR(100),
@City VARCHAR(50),
@State VARCHAR(50),
@Zip VARCHAR(10),
@Phone VARCHAR(15),
@Email VARCHAR(100)
AS
INSERT INTO Contacts
VALUES(@FirstName,@LastName,@Address,@City,@State,@Zip,@Phone,@Email)
GO

CREATE PROC sp_UpdateContact
@ContactId INT,
@FirstName VARCHAR(50),
@LastName VARCHAR(50),
@City VARCHAR(50)
AS
UPDATE Contacts
SET FirstName=@FirstName,LastName=@LastName,City=@City
WHERE ContactId=@ContactId
GO

CREATE PROC sp_DeleteContact
@ContactId INT
AS
DELETE FROM Contacts WHERE ContactId=@ContactId
GO

CREATE PROC sp_ViewAll
AS SELECT * FROM Contacts
GO

CREATE PROC sp_SearchCity
@City VARCHAR(50)
AS SELECT * FROM Contacts WHERE City=@City
GO

CREATE PROC sp_SearchState
@State VARCHAR(50)
AS SELECT * FROM Contacts WHERE State=@State
GO

CREATE PROC sp_CountCity
@City VARCHAR(50)
AS SELECT COUNT(*) FROM Contacts WHERE City=@City
GO

CREATE PROC sp_CountState
@State VARCHAR(50)
AS SELECT COUNT(*) FROM Contacts WHERE State=@State
GO

CREATE PROC sp_SortName
AS SELECT * FROM Contacts ORDER BY FirstName
GO

CREATE PROC sp_SortCity
AS SELECT * FROM Contacts ORDER BY City
GO

CREATE PROC sp_SortState
AS SELECT * FROM Contacts ORDER BY State
GO

CREATE OR ALTER PROCEDURE sp_CountCity
    @City VARCHAR(50)
AS
BEGIN
    SELECT COUNT(*) 
    FROM Contacts
    WHERE City = @City
END

CREATE OR ALTER PROCEDURE sp_CountState
    @State VARCHAR(50)
AS
BEGIN
    SELECT COUNT(*) 
    FROM Contacts
    WHERE State = @State
END


CREATE TABLE Contacts
(
 ContactId INT IDENTITY PRIMARY KEY,
 FirstName VARCHAR(50),
 LastName VARCHAR(50),
 Address VARCHAR(100),
 City VARCHAR(50),
 State VARCHAR(50),
 Zip VARCHAR(10),
 Phone VARCHAR(20),
 Email VARCHAR(100)
)



-- ADD
CREATE OR ALTER PROC sp_AddContact
@FirstName VARCHAR(50),
@LastName VARCHAR(50),
@Address VARCHAR(100),
@City VARCHAR(50),
@State VARCHAR(50),
@Zip VARCHAR(10),
@Phone VARCHAR(20),
@Email VARCHAR(100)
AS
INSERT INTO Contacts
VALUES(@FirstName,@LastName,@Address,@City,@State,@Zip,@Phone,@Email)

-- UPDATE
CREATE OR ALTER PROC sp_UpdateContact
@ContactId INT,
@FirstName VARCHAR(50),
@LastName VARCHAR(50),
@City VARCHAR(50)
AS
UPDATE Contacts
SET FirstName=@FirstName,
    LastName=@LastName,
    City=@City
WHERE ContactId=@ContactId

-- DELETE
CREATE OR ALTER PROC sp_DeleteContact
@ContactId INT
AS
DELETE FROM Contacts WHERE ContactId=@ContactId

-- VIEW ALL
CREATE OR ALTER PROC sp_ViewAll
AS
SELECT * FROM Contacts

-- SEARCH CITY
CREATE OR ALTER PROC sp_SearchCity
@City VARCHAR(50)
AS
SELECT * FROM Contacts WHERE City=@City

-- SEARCH STATE
CREATE OR ALTER PROC sp_SearchState
@State VARCHAR(50)
AS
SELECT * FROM Contacts WHERE State=@State

-- SORT NAME
CREATE OR ALTER PROC sp_SortName
AS
SELECT * FROM Contacts ORDER BY FirstName

-- SORT CITY
CREATE OR ALTER PROC sp_SortCity
AS
SELECT * FROM Contacts ORDER BY City

-- SORT STATE  ✅ FIX
CREATE OR ALTER PROC sp_SortState
AS
SELECT * FROM Contacts ORDER BY State

-- COUNT CITY
CREATE OR ALTER PROC sp_CountCity
@City VARCHAR(50)
AS
SELECT COUNT(*) FROM Contacts WHERE City=@City

-- COUNT STATE
CREATE OR ALTER PROC sp_CountState
@State VARCHAR(50)
AS
SELECT COUNT(*) FROM Contacts WHERE State=@State



CREATE TABLE ContactLogs
(
    LogId INT IDENTITY PRIMARY KEY,
    ContactId INT,
    OperationType VARCHAR(20),
    OldData VARCHAR(MAX),
    NewData VARCHAR(MAX),
    ActionDate DATETIME DEFAULT GETDATE()
)
GO

CREATE OR ALTER TRIGGER trg_InsertContact
ON Contacts
AFTER INSERT
AS
BEGIN
    INSERT INTO ContactLogs(ContactId,OperationType,NewData)
    SELECT 
        i.ContactId,
        'INSERT',
        CONCAT(i.FirstName,' ',i.LastName,' | ',i.City,' | ',i.State)
    FROM inserted i
END
GO

CREATE OR ALTER TRIGGER trg_UpdateContact
ON Contacts
AFTER UPDATE
AS
BEGIN
    INSERT INTO ContactLogs(ContactId,OperationType,OldData,NewData)
    SELECT 
        d.ContactId,
        'UPDATE',
        CONCAT(d.FirstName,' ',d.LastName,' | ',d.City,' | ',d.State),
        CONCAT(i.FirstName,' ',i.LastName,' | ',i.City,' | ',i.State)
    FROM deleted d
    JOIN inserted i
    ON d.ContactId=i.ContactId
END
GO

CREATE OR ALTER TRIGGER trg_DeleteContact
ON Contacts
AFTER DELETE
AS
BEGIN
    INSERT INTO ContactLogs(ContactId,OperationType,OldData)
    SELECT 
        d.ContactId,
        'DELETE',
        CONCAT(d.FirstName,' ',d.LastName,' | ',d.City,' | ',d.State)
    FROM deleted d
END
GO

CREATE OR ALTER PROC sp_ViewLogs
AS
SELECT * FROM ContactLogs ORDER BY ActionDate DESC
GO
EXEC sp_AddContact 'Rohit','Gupta','Street 5','Agra','UP','282001','8888888888','rohit@gmail.com'
EXEC sp_UpdateContact 1,'Amit','Sharma','Noida'
EXEC sp_DeleteContact 3
EXEC sp_ViewLogs








