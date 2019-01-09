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
	Fødselsdato INT
);
Create Table Bil
(
	KundeID int,
	RegNr Varchar(7),
	Mærke Varchar(20),
	Model Varchar(20),
	Brændstoff Varchar(30),
	Oprettelsesdato Varchar(10),
	KmKørt Varchar(20),
	Årgang Int,
	Primary key(RegNr),
	Foreign key(KundeID) References Kunder (KundeID)
);
Create Table Værkstedsbesøg
(
	DatoAnkomst Varchar(6),
	DatoAfgang Varchar(6),
	Mekaniker Varchar(20),
	RegNr Varchar(7)
);