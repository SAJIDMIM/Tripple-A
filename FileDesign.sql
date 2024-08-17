create database Tripple_A;
use Tripple_A

create table UserLogin(userId int primary key identity(1,1),user_type varchar(25)not null,username varchar(50)not null,Email varchar(100)not null,
user_password varchar(60)not null,user_confirm_password varchar(60)not null);

select * from UserLogin;

--create table ForgotVerification( VerifyId int identity (1,1),Email varchar(100)not null,code int not null);

--select * from ForgotVerification;
--drop table  ForgotVerification;

--create table Adminlogin_Detail(adminId int primary key identity (1,1),Type varchar(25) not null,username varchar(50)not null,admin_Password varchar(60)not null);

--drop table admin_Logindetail;
--select * from Adminlogin_Detail;
--drop table Adminlogin_Detail;

--delete Adminlogin_Detail;
--insert into Adminlogin_Detail (Type,username,admin_Password) values ('Ordinary','ordinaryAdmin','pwdadmin');
--insert into Adminlogin_Detail (Type,username,admin_Password) values ('Director','directorAdmin','pwdDirectoradmin');


select Type, username, admin_Password from Adminlogin_Detail ;

create table admin(adminId int primary key identity(1,1),user_type varchar(25)not null,username varchar(50) not null,password varchar(60) not null);


insert into admin values('Ordinary','ordinaryAdmin','pwdadmin');
insert into admin values('Director','directorAdmin','pwdDirectoradmin');

select * from admin;


--admin Profile table
create table adminProfile (adminId varchar(20) primary key,Name varchar(50) not null,DoB Date not null,Gender varchar(10) not null,email varchar(100)not null,Type varchar(20) not null,username varchar(50) not null,password varchar(60) not null,adminPhoto varbinary(max));

--create table Job(publish_Id varchar(25) primary key,Job_Title varchar(50) not null,jobType varchar(100) not null,Job_Description varchar(100)not null);

--select * from Job;
--drop table Job;

--Director Part

--Verify Stock 
create table VerifyStock(stock_Id varchar(15) primary key,stockDescription varchar(100)not null,Quantity int not null,Street varchar(100) not null,City varchar(50) not null,PostalCode int not null,AuditDate Date not null,LastAuditDate Date not null,Comment varchar(100));

drop table VerifyStock;
select * from VerifyStock;


--stock table
create table Stock(stockId varchar(15) primary key,stockName varchar(50)not null,stockType varchar(25)not null,stockQuantity int not null,City varchar(30)not null,Street varchar(50)not null,Code int not null,cost float not null,SupplierName varchar(50)not null,reorderLevel varchar (15)not null,stockDate DateTime not null,lastUpdatedDate DateTime);
select * from Stock;

--Predict Table
create table PredictInventory(inventoryForecastId varchar(15) primary key,stockId varchar(15) not null,Quantity int not null,Sale varchar(35) not null,demandInventory varchar(30)not null,Reorder Bit not null,LeadTime DateTime not null,SafetyStock varchar(45) not null,cost float,foreign key (stockId) references  Stock (stockId));
drop table PredictInventory;
select * from PredictInventory;
--HR part
create table Job(post_Id varchar(25) primary key,Job_Title varchar(50) not null,jobType varchar(100) not null,Job_Description varchar(100)not null);

--drop table Job;
select * from Job;
--drop table postJob;


--Leave Request
--create table Employee (employeeId varchar(25) primary key,userType varchar(15) not null,firstName varchar(30) not null,lastName varchar(30) not null,position varchar(15) not null,department varchar(15) not null,DateJoined Date not null,Salary float,Retirement bit);

--sample record for Employee Table
insert into Employee values('E1','HR','sajid','Iqbal','Human Resource','All','2024/02/19',180000.00,'True');
select * from Employee;


--Leave Request
create table Leave(leaveRequestId int primary key identity(1,1),employeeId varchar(25)not null,userType varchar(15)not null,firstName varchar(30)not null,lastName varchar(30)not null,leaveStartDate Date not null,leaveEndDate Date not null,LeaveType varchar(15)not null,reason varchar(100)not null);

drop table Leave;
delete Leave;
select * from Leave;

--create table Employee (employeeId varchar(25) primary key,userType varchar(15) not null,firstName varchar(30) not null,lastName varchar(30) not null,position varchar(15) not null,department varchar(15) not null,DateJoined Date not null,Salary float,Retirement bit);
--drop table Employee;

--Retirement Plan
create table RetirementPlan (retirementId varchar(20) primary key,employeeId varchar(25) not null,firstName varchar(30) not null,lastName varchar(30) not null,position varchar(15) not null,retireType varchar(25) not null,DateJoined Date not null,expectedDate Date not null,contribution varchar(25) not null,foreign key(employeeId) references Employee(employeeId));
--drop table RetirementPlan;





--SELECT firstName, lastName, position FROM Employee WHERE employeeId = 'E1'

select * from RetirementPlan;


--create table Employees
-- Create the Employees table


CREATE TABLE Employees (
    employeeId varchar(25) primary key,
    firstName VARCHAR(50) not null,
    lastName VARCHAR(30) not null,
    empType VARCHAR(50) not null,
    actorId VARCHAR(25) not null,
    position VARCHAR(50) not null,
    department VARCHAR(50) not null,
    DateJoined DATE not null,
    Salary DECIMAL(10, 2) not null,
    Retirement VARCHAR(3) not null,
	supervisorId VARCHAR(25) NOT NULL,
	digitalMarketerId VARCHAR(25) NOT NULL,
	accountantId VARCHAR(25) NOT NULL,
    storekeeperId VARCHAR(25) NULL,
    salesRepId VARCHAR(25) NULL,
    cashierId VARCHAR(25) NULL
);
INSERT INTO Employees (employeeId, firstName, lastName, empType, actorId, position, department, dateJoined, salary, retirement)
VALUES (1, 'John', 'Doe', 'full-time', 'cashier', 'Sales', 'Retail', '2022-01-01', 50000.00, 0);

INSERT INTO Employees (employeeId, firstName, lastName, empType, actorId, cashierId, position, department, dateJoined, salary, retirement)
VALUES (2, 'John', 'Doe', 'full-time', 'cashier', 'cashier', 'Sales', 'Retail', '2022-01-01', 50000.00, 0);


select * from Employees;
  delete from Employees;
  delete from DigitalMarketer;
  select * from Cashier;
--drop table Employees;
select * from DigitalMarketer;
SELECT * FROM Accountant;
DELETE FROM Supervisor;
select * from Supervisor;

   CREATE TABLE Storekeeper (
    storekeeperId VARCHAR(25) PRIMARY KEY,  -- Make sure this is the correct data type for your ID
    employeeId varchar(25) not null,  -- Make sure this is the correct data type for your ID
    -- Add any other relevant columns
);


drop table Storekeeper;
CREATE TABLE SaleRepresentive (
    saleRepId VARCHAR(25) PRIMARY KEY,  -- Make sure this is the correct data type for your ID
    employeeId varchar(25) not null,  -- Make sure this is the correct data type for your ID
    -- Add any other relevant columns
);
select * from SaleRepresentive;
drop table SaleRepresentive;

CREATE TABLE Cashier (
    cashierId VARCHAR(25) PRIMARY KEY,  -- Make sure this is the correct data type for your ID
    employeeId varchar(25) not null,  -- Make sure this is the correct data type for your ID
    -- Add any other relevant columns
);
--drop table Cashier;


   CREATE TABLE Supervisor (
    supervisorId VARCHAR(25) PRIMARY KEY,  -- Make sure this is the correct data type for your ID
    employeeId varchar(25) not null,  -- Make sure this is the correct data type for your ID
    -- Add any other relevant columns
);
select * from Supervisor;
drop table Supervisor;

select * from Employees;
delete from Employees;

select * from DigitalMarketer;
delete from DigitalMarketer;
   CREATE TABLE DigitalMarketer (
    digitalMarketerId VARCHAR(25) PRIMARY KEY,  -- Make sure this is the correct data type for your ID
    employeeId varchar(25) not null,  -- Make sure this is the correct data type for your ID
    -- Add any other relevant columns
);


   CREATE TABLE Accountant (
    accountantId VARCHAR(25) PRIMARY KEY,  -- Make sure this is the correct data type for your ID
    employeeId varchar(25) not null,  -- Make sure this is the correct data type for your ID
    -- Add any other relevant columns
);


select * from DigitalMarketer;
delete from DigitalMarketer;


 SELECT firstName, lastName, empType, actorId, position, department, DateJoined, Salary, Retirement
            FROM Employees
            WHERE employeeId = 'E1';