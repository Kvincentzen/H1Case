Use master
create database H1Case
GO
Use H1Case
GO

Create Table Kunder
(
	KundeID INT NOT NULL Primary key,
	Navn VARCHAR(30),
	Adresse VARCHAR (50),
	F�dselsdato INT
);
Create Table Bil
(
	KundeID int,
	RegNr Varchar(7),
	M�rke Varchar(20),
	Model Varchar(20),
	Br�ndstoff Varchar(30),
	Oprettelsesdato Varchar(10),
	KmK�rt Varchar(20),
	�rgang Int,
	Primary key(RegNr),
	Foreign key(KundeID) References Kunder (KundeID)
);
Create Table V�rkstedsbes�g
(
	DatoAnkomst Varchar(6),
	DatoAfgang Varchar(6),
	Mekaniker Varchar(20),
	RegNr Varchar(7)
);