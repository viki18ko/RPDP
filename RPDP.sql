CREATE DATABASE RPDP;

CREATE TABLE Position
(
	ID INT IDENTITY (1,1) PRIMARY KEY,
	Name NVARCHAR(255) NOT NULL UNIQUE
);

CREATE TABLE Class
(
	ID INT IDENTITY (1,1) PRIMARY KEY,
	Number INT NOT NULL UNIQUE
);

CREATE TABLE Employee
(
	ID INT IDENTITY (1,1) PRIMARY KEY,
	Surname NVARCHAR(50) NOT NULL,
	Name NVARCHAR(50) NOT NULL,
	Patronymic NVARCHAR(50) NOT NULL,
	IdPosition INT NOT NULL FOREIGN KEY
	REFERENCES Position(ID),
	StartDate DATE,
	IdClass INT FOREIGN KEY
	REFERENCES Class(ID),
	IdInstructor INT FOREIGN KEY
	REFERENCES Employee(ID)
);

CREATE TABLE [Route]
(
	ID INT IDENTITY (1,1) PRIMARY KEY,
	Number INT NOT NULL UNIQUE
);

CREATE TABLE TypeCar
(
	ID INT IDENTITY (1,1) PRIMARY KEY,
	[Type] NVARCHAR (50) NOT NULL UNIQUE
);

CREATE TABLE TypeRegistrar
(
	ID INT IDENTITY (1,1) PRIMARY KEY,
	[Type] NVARCHAR (50) NOT NULL UNIQUE
);

CREATE TABLE Registrar
(
	ID INT IDENTITY (1,1) PRIMARY KEY,
	Number NVARCHAR(50) NOT NULL UNIQUE,
	IdTypeRegistrar INT NOT NULL FOREIGN KEY REFERENCES TypeRegistrar(ID),
	ManufactureDate DATE,
	Busy CHAR(1) NOT NULL DEFAULT '0'
);

CREATE TABLE Car
(
	ID INT IDENTITY (1,1) PRIMARY KEY,
	Number NVARCHAR(50) NOT NULL UNIQUE,
	IdTypeCar INT NOT NULL FOREIGN KEY
	REFERENCES TypeCar(ID),
	IdRegistrar INT NOT NULL FOREIGN KEY REFERENCES Registrar(ID),
	Busy CHAR(1) NOT NULL DEFAULT '0'
);

CREATE TABLE AmountCar
(
	ID INT IDENTITY (1,1) PRIMARY KEY,
	Number INT NOT NULL UNIQUE
);

CREATE TABLE Train
(
	ID INT IDENTITY (1,1) PRIMARY KEY,
	IdAmountCar INT NOT NULL FOREIGN KEY
	REFERENCES AmountCar(ID)
);

CREATE TABLE Composition
(
	ID INT IDENTITY (1,1) PRIMARY KEY,
	IdTrain INT NOT NULL FOREIGN KEY
	REFERENCES Train(ID),
	IdCar INT NOT NULL FOREIGN KEY
	REFERENCES Car(ID)
);


insert into TypeRegistrar([Type])
values('1'),('2'),('3');
insert into Registrar(Number, IdTypeRegistrar)
values('10',1),('20',2),('30',3);

select *
from Registrar

select *
from Composition;

select *
from Car;

select *
from Train;

delete from Composition
where ID in(10,11);
delete from train
where id in (11,12);