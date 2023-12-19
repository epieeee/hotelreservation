Create Database datares
use datares
Drop table  Reservation2
create table accouts
(
firstname varchar(100),
lastame varchar(100),
pass varchar(100)
)
create table account
(
firstname varchar(100),
pass varchar(100)
)
create table Admin1
(
firstname varchar(100), 
pass varchar(100)
)

Create Table Reservation
(
Room Varchar(100),
InDate Varchar(100),
OutDate Varchar(100),
Fname Varchar(50),
Lname varchar(50),
Price Int,
TypePayment Varchar(100)
)
Create Table Reservation2
(
Room Varchar(100),
InDate Varchar(100),
OutDate Varchar(100),
Fname Varchar(50),
Lname varchar(50),
Price INT,
TypePayment Varchar(100)
)
Create Table Reservation3
(
Num int,
Room Varchar(100),
InDate Varchar(100),
OutDate Varchar(100),
Fname Varchar(50),
Lname varchar(50),
Price INT,
TypePayment Varchar(100)
)
Create Table Reservation4
(
Num int,
Room Varchar(100),
Inmonths Varchar(100),
Indays Varchar(100),
Outmonths Varchar(100),
Outdays Varchar(100),
Fname Varchar(50),
Lname varchar(50),
Price INT,
TypePayment Varchar(100)
)
Create Table Reservation5
(
Num int,
Room Varchar(100),
Inmonths Varchar(100),
Indays int,
Outmonths Varchar(100),
Outdays Int,
Fname Varchar(50),
Lname varchar(50),
Price INT,
TypePayment Varchar(100),
Pending Varchar(50)
)
Create Table Reservation8
(
Num int,
Room Varchar(100),
Inmonths Varchar(100),
Indays int,
Fname Varchar(50),
Lname varchar(50),
Price INT,
TypePayment Varchar(100)
)

Create Table Reservation6
(
Num int,
Room Varchar(100),
Inmonths Varchar(100),
Indays varchar,
Outmonths Varchar(100),
Outdays varchar,
Fname Varchar(50),
Lname varchar(50),
Price varchar,
TypePayment Varchar(100),
Position Varchar(50)
)
Create Table Reserve
(
Num int,
Room Varchar(100),
Inmonths Varchar(100),
Indays varchar,
Outmonths Varchar(100),
Outdays varchar,
Fname Varchar(50),
Lname varchar(50),
Price varchar,
TypePayment Varchar(100),
Position Varchar(50)
)
Create Table Reservation9
(
Num int,
Room Varchar(100),
Inmonths Varchar(100),
Indays int,
Outmonths Varchar(100),
Outdays Int,
Fname Varchar(50),
Lname varchar(50),
Price INT,
TypePayment Varchar(100),
Pending Varchar(50)
)
Create Table Reservation10
(
Num int,
Room Varchar(100),
Inmonths Varchar(100),
Indays int,
Outmonths Varchar(100),
Outdays Int,
Fname Varchar(50),
Lname varchar(50),
Price INT,
TypePayment Varchar(100),
Position Varchar(50)
)
Create Table Res1
(
Num int,
Room Varchar(100),
Inmonths Varchar(100),
Indays int,
Outmonths Varchar(100),
Outdays Int,
Fname Varchar(50),
Lname varchar(50),
Price INT,
TypePayment Varchar(100),
Position Varchar(50)
)

INSERT INTO admin1(firstname,pass) VALUES ('adm','chherry')
INSERT INTO admin1(firstname,pass) VALUES ('Admin','Cherry')

Select * From account
select * From Admin1
select * From Reservation5
DROP TABLE  Reservation3
EXEC sp_rename
'Reservation5.Lname',
'Position',
'Column'

