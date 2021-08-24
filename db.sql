create database if not exists db_ironMountain;

use db_ironMountain;

create table dbo_empleados(
	EmployeeID int not null primary key,
    LastName varchar(50) not null,
    FirstName varchar(30) not null,
    DOB date
);

