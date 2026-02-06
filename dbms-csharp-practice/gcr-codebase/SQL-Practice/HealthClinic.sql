CREATE DATABASE HealthClinic;
USE HealthClinic;

--creating table  
CREATE TABLE Specialty(
    specialty_id INT IDENTITY PRIMARY KEY,
    specialty_name VARCHAR(100) UNIQUE NOT NULL
);

CREATE TABLE Patient(
    patient_id INT IDENTITY PRIMARY KEY,
    name VARCHAR(100),
    dob DATE,
    phone VARCHAR(15) UNIQUE,
    email VARCHAR(100) UNIQUE,
    address VARCHAR(200),
    blood_group VARCHAR(10),
    created_at DATETIME DEFAULT GETDATE()
);

CREATE TABLE Doctor(
    doctor_id INT IDENTITY PRIMARY KEY,
    name VARCHAR(100),
    contact VARCHAR(15),
    consultation_fee DECIMAL(10,2),
    specialty_id INT,
    is_active BIT DEFAULT 1,
    FOREIGN KEY(specialty_id)
    REFERENCES Specialty(specialty_id)
);

CREATE TABLE Appointment(
    appointment_id INT IDENTITY PRIMARY KEY,
    patient_id INT,
    doctor_id INT,
    appointment_date DATE,
    appointment_time TIME,
    status VARCHAR(20),
    FOREIGN KEY(patient_id)
    REFERENCES Patient(patient_id) ON DELETE CASCADE,
    FOREIGN KEY(doctor_id)
    REFERENCES Doctor(doctor_id) ON DELETE CASCADE
);

CREATE TABLE Visit(
    visit_id INT IDENTITY PRIMARY KEY,
    appointment_id INT,
    visit_date DATE,
    diagnosis VARCHAR(200),
    notes VARCHAR(200),
    FOREIGN KEY(appointment_id)
    REFERENCES Appointment(appointment_id) ON DELETE CASCADE
);

CREATE TABLE Prescription(
    prescription_id INT IDENTITY PRIMARY KEY,
    visit_id INT,
    medicine_name VARCHAR(100),
    dosage VARCHAR(50),
    duration VARCHAR(50),
    FOREIGN KEY(visit_id)
    REFERENCES Visit(visit_id) ON DELETE CASCADE
);

CREATE TABLE Bill(
    bill_id INT IDENTITY PRIMARY KEY,
    visit_id INT,
    total_amount DECIMAL(10,2),
    payment_status VARCHAR(20),
    bill_date DATE,
    FOREIGN KEY(visit_id)
    REFERENCES Visit(visit_id) ON DELETE CASCADE
);

CREATE TABLE Payment(
    payment_id INT IDENTITY PRIMARY KEY,
    bill_id INT,
    payment_mode VARCHAR(50),
    payment_date DATE,
    amount DECIMAL(10,2),
    FOREIGN KEY(bill_id)
    REFERENCES Bill(bill_id) ON DELETE CASCADE
);

CREATE TABLE Audit_Log(
    log_id INT IDENTITY PRIMARY KEY,
    table_name VARCHAR(50),
    action VARCHAR(20),
    record_id INT,
    user_name VARCHAR(50),
    action_time DATETIME DEFAULT GETDATE()
);
--applying triggers 
CREATE TRIGGER trg_patient_audit
ON Patient
AFTER INSERT,UPDATE,DELETE
AS
INSERT INTO Audit_Log
SELECT 'Patient','DATA CHANGE',patient_id,SYSTEM_USER,GETDATE()
FROM inserted;

--applying procedure 
CREATE PROCEDURE RegisterPatient
@name VARCHAR(100),
@dob DATE,
@phone VARCHAR(15),
@email VARCHAR(100),
@address VARCHAR(200),
@blood_group VARCHAR(10)
AS
INSERT INTO Patient
VALUES(@name,@dob,@phone,@email,@address,@blood_group,GETDATE());

CREATE PROCEDURE BookAppointment
@patient INT,
@doctor INT,
@date DATE,
@time TIME
AS
INSERT INTO Appointment
VALUES(@patient,@doctor,@date,@time,'SCHEDULED');

CREATE PROCEDURE RecordVisit
@appointment_id INT,
@diagnosis VARCHAR(200),
@notes VARCHAR(200)
AS
BEGIN
BEGIN TRANSACTION
INSERT INTO Visit
VALUES(@appointment_id,GETDATE(),@diagnosis,@notes)
UPDATE Appointment SET status='COMPLETED'
WHERE appointment_id=@appointment_id
COMMIT
END;

INSERT INTO Specialty VALUES('Cardiology');
INSERT INTO Specialty VALUES('Dermatology');

INSERT INTO Doctor VALUES('Dr Sharma','9999999999',500,1,1);
INSERT INTO Doctor VALUES('Dr Neha','8888888888',400,2,1);

EXEC RegisterPatient
'Rahul','2001-01-01','7777777777',
'rahul@gmail.com','Delhi','O+';

EXEC RegisterPatient
'Amit','2000-05-05','6666666666',
'amit@gmail.com','Noida','B+';

EXEC BookAppointment 1,1,'2026-02-07','10:00';
EXEC BookAppointment 2,2,'2026-02-07','11:00';

EXEC RecordVisit 1,'Fever','Take rest';
EXEC RecordVisit 2,'Skin Allergy','Use ointment';

INSERT INTO Prescription
VALUES(1,'Paracetamol','2 Times','3 Days');
INSERT INTO Prescription
VALUES(2,'Skin Cream','Once Daily','5 Days');

INSERT INTO Bill VALUES(1,500,'UNPAID',GETDATE());
INSERT INTO Bill VALUES(2,400,'PAID',GETDATE());

INSERT INTO Payment VALUES(2,'Cash',GETDATE(),400);


SELECT * FROM Patient;
SELECT * FROM Doctor;
SELECT * FROM Appointment;
SELECT * FROM Visit;
SELECT * FROM Prescription;
SELECT * FROM Bill;
SELECT * FROM Payment;
SELECT * FROM Audit_Log;

