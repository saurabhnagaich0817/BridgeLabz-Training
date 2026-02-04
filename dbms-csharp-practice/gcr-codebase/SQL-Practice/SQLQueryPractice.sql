-- ============================================
-- DATABASE CREATION
-- ============================================

CREATE DATABASE PracticeDB;
GO

USE PracticeDB;
GO

-- ============================================
-- DDL + DML + DQL PRACTICE
-- ============================================

CREATE TABLE Students(
    StudentID INT PRIMARY KEY,
    Name VARCHAR(50),
    Age INT,
    Department VARCHAR(30)
);

SELECT * FROM Students;

INSERT INTO Students VALUES
(1,'Rahul',20,'CSE'),
(2,'Amit',22,'IT'),
(3,'Neha',21,'ECE');

SELECT * FROM Students;

-- ALTER TABLE (ADD COLUMN)

ALTER TABLE Students
ADD Email VARCHAR(100);

SELECT * FROM Students;

-- UPDATE

UPDATE Students
SET Email='rahul@gmail.com'
WHERE StudentID=1;

UPDATE Students
SET Email='amit@gmail.com'
WHERE StudentID=2;

SELECT * FROM Students;

-- DELETE

DELETE FROM Students
WHERE StudentID=3;

SELECT * FROM Students;

-- ============================================
-- CREATE SECOND TABLE (PRIMARY KEY)
-- ============================================

CREATE TABLE Department(
    DeptID INT PRIMARY KEY,
    DeptName VARCHAR(50)
);

INSERT INTO Department VALUES
(1,'CSE'),
(2,'IT'),
(3,'ECE');

SELECT * FROM Department;

-- ============================================
-- FOREIGN KEY TABLE
-- ============================================

CREATE TABLE StudentDetails(
    StudentID INT PRIMARY KEY,
    Name VARCHAR(50),
    DeptID INT,
    FOREIGN KEY(DeptID) REFERENCES Department(DeptID)
);

INSERT INTO StudentDetails VALUES
(101,'Rahul',1),
(102,'Amit',2),
(103,'Neha',3);

SELECT * FROM StudentDetails;

-- ============================================
-- JOINS PRACTICE
-- ============================================

-- INNER JOIN
SELECT StudentDetails.Name, Department.DeptName
FROM StudentDetails
INNER JOIN Department
ON StudentDetails.DeptID = Department.DeptID;

-- LEFT JOIN
SELECT *
FROM StudentDetails
LEFT JOIN Department
ON StudentDetails.DeptID = Department.DeptID;

-- RIGHT JOIN
SELECT *
FROM StudentDetails
RIGHT JOIN Department
ON StudentDetails.DeptID = Department.DeptID;

-- FULL JOIN
SELECT *
FROM StudentDetails
FULL JOIN Department
ON StudentDetails.DeptID = Department.DeptID;

-- ============================================
-- TRUNCATE TABLE
-- ============================================

TRUNCATE TABLE Students;

-- ============================================
-- TCL COMMANDS
-- ============================================

BEGIN TRANSACTION;

UPDATE StudentDetails
SET Name='Riya'
WHERE StudentID=101;

ROLLBACK;

SELECT * FROM StudentDetails;

BEGIN TRANSACTION;

UPDATE StudentDetails
SET Name='Riya'
WHERE StudentID=101;

COMMIT;

SELECT * FROM StudentDetails;

-- ============================================
-- DCL COMMANDS
-- ============================================

CREATE LOGIN testuser
WITH PASSWORD='Test@123';

CREATE USER testuser
FOR LOGIN testuser;

GRANT SELECT,INSERT
ON StudentDetails
TO testuser;

REVOKE INSERT
ON StudentDetails
FROM testuser;

-- ============================================
-- NORMALIZATION PRACTICE
-- ============================================

-- 1NF
CREATE TABLE Student1NF(
    StudentID INT,
    Name VARCHAR(50),
    Subject VARCHAR(50)
);

INSERT INTO Student1NF VALUES
(1,'Rahul','DBMS'),
(1,'Rahul','OS');

SELECT * FROM Student1NF;

-- 2NF
CREATE TABLE Students2NF(
    StudentID INT PRIMARY KEY,
    Name VARCHAR(50)
);

CREATE TABLE Subjects2NF(
    SubjectID INT PRIMARY KEY,
    SubjectName VARCHAR(50)
);

-- 3NF
CREATE TABLE Dept3NF(
    DeptID INT PRIMARY KEY,
    DeptName VARCHAR(50)
);

CREATE TABLE Students3NF(
    StudentID INT PRIMARY KEY,
    Name VARCHAR(50),
    DeptID INT FOREIGN KEY REFERENCES Dept3NF(DeptID)
);

-- BCNF
CREATE TABLE CourseBCNF(
    CourseID INT PRIMARY KEY,
    CourseName VARCHAR(50)
);
