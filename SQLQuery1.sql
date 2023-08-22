create database AdvancedDB
use AdvancedDB

create table Employees
(EmployeeId int primary key,
FirstName nvarchar(50),
LastName nvarchar(50),
BirthDate date,
Salary decimal)

create table Products
(ProductId int primary key,
ProductName nvarchar(50),
Description nvarchar(200),
Price money,
ReleaseDate datetime)

create table Orders
(OrderId int primary key,
OrderDate datetime,
Quantity smallint,
Discount float,
IsShipped bit)

select * from Employees
select * from Products
select * from Orders