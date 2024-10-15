create database Tripple_A;
use Tripple_A

create table UserLogin(userId int primary key identity(1,1),user_type varchar(25)not null,username varchar(50)not null,Email varchar(100)not null,
user_password varchar(60)not null,user_confirm_password varchar(60)not null);

--drop table UserLogin;
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


--select Type, username, admin_Password from Adminlogin_Detail ;

CREATE TABLE Admin(
    adminId int PRIMARY KEY IDENTITY(1,1),
    user_type varchar(25) NOT NULL,
    username varchar(50) NOT NULL,
    password varchar(60) NOT NULL,
    firstName varchar(50) NULL,
	lastName varchar(50) NULL,
    doB date NULL,
    gender varchar(10) NULL,
    email varchar(100) NULL,
    adminPhoto binary(1000) NULL
);
--drop table admin;
INSERT INTO Admin (user_type, username, password, firstName, lastName, doB, gender, email)
VALUES 
    ('Ordinary', 'ordinaryAdmin', 'pwdadmin', 'Sajid', 'Iqbal', '2002-06-29', 'Male', 'admin@example.com');
insert into admin (user_type,username,password) values('Director','directorAdmin','pwdDirectoradmin');

select * from Admin;

SELECT user_type FROM Admin WHERE adminId = 1;

--admin part
--view account references UserLogin table
--Minimum Stock references stock table
--stock price references stock table
--Director Part



--stock table
create table Stock(stockId varchar(15) primary key,stockName varchar(50)not null,stockType varchar(25)not null,stockQuantity int not null,stockWeight varchar(20) not null,Location varchar(100) not null,cost float not null,SupplierName varchar(50)not null,reorderLevel int not null,stockDate Date not null,lastUpdatedDate Date,stockDescription varchar(100));
UPDATE Stock
SET stockQuantity = 11
WHERE stockId = 'S1';


INSERT INTO Stock (stockId, stockName, stockType, stockQuantity, stockWeight, Location, cost, SupplierName, reorderLevel, stockDate, lastUpdatedDate, stockDescription)
VALUES ('S001', 'Apple', 'Fruit', 150, '5kg', 'Aisle 1', 30.50, 'FreshFarms Ltd', 50, '2024-09-29', '2024-09-28', 'Fresh red apples');

INSERT INTO Stock (stockId, stockName, stockType, stockQuantity, stockWeight, Location, cost, SupplierName, reorderLevel, stockDate, lastUpdatedDate, stockDescription)
VALUES ('S002', 'Bread', 'Bakery', 100, '2kg', 'Aisle 3', 20.00, 'BakerBest Ltd', 30, '2024-09-28', '2024-09-28', 'Organic whole wheat bread');

INSERT INTO Stock (stockId, stockName, stockType, stockQuantity, stockWeight, Location, cost, SupplierName, reorderLevel, stockDate, lastUpdatedDate, stockDescription)
VALUES ('S003', 'Milk', 'Dairy', 200, '2L', 'Refrigerated Section', 15.00, 'DairyFresh Suppliers', 80, '2024-09-27', '2024-09-28', 'Full cream milk');

INSERT INTO Stock (stockId, stockName, stockType, stockQuantity, stockWeight, Location, cost, SupplierName, reorderLevel, stockDate, lastUpdatedDate, stockDescription)
VALUES ('S004', 'Rice', 'Grain', 75, '10kg', 'Aisle 4', 60.00, 'GrainMasters Ltd', 25, '2024-09-26', '2024-09-27', 'Premium long grain rice');

INSERT INTO Stock (stockId, stockName, stockType, stockQuantity, stockWeight, Location, cost, SupplierName, reorderLevel, stockDate, lastUpdatedDate, stockDescription)
VALUES ('S005', 'Chicken', 'Meat', 50, '5kg', 'Refrigerated Section', 75.00, 'MeatWorld', 20, '2024-09-25', '2024-09-26', 'Boneless chicken breast');

INSERT INTO Stock (stockId, stockName, stockType, stockQuantity, stockWeight, Location, cost, SupplierName, reorderLevel, stockDate, lastUpdatedDate, stockDescription)
VALUES ('S006', 'Orange Juice', 'Beverages', 120, '1L', 'Beverages Section', 10.00, 'JuiceProducers Ltd', 40, '2024-09-24', '2024-09-25', 'Freshly squeezed orange juice');

INSERT INTO Stock (stockId, stockName, stockType, stockQuantity, stockWeight, Location, cost, SupplierName, reorderLevel, stockDate, lastUpdatedDate, stockDescription)
VALUES ('S007', 'Pasta', 'Grain', 90, '500g', 'Aisle 5', 12.00, 'ItalianFoods Co.', 30, '2024-09-23', '2024-09-24', 'Durum wheat pasta');

select * from Stock;
--delete from Item;
--delete from Product;
--delete from Customer;
--delete from Sale;
--delete from Stock;
--delete from  CustomerOrder;
--delete from Cart;
--delete from Stock;
--DROP TABLE Stock;

select * from Stock;
--drop table Stock;

--create item table
create table Item (itemId varchar(25) primary key,itemName varchar(50) not null,Description varchar(100) not null,department varchar(50) not null,Quantity int not null,unitprice float not null,totalprice float not null,Category varchar(50) not null,manufactureDate Date not null,expiryDate Date not null,manufacturer varchar(50) not null);

select * from  Item;

--delete from Item;

-- Insert Apples
INSERT INTO Item (itemId, itemName, Description, department, Quantity, unitprice, totalprice, Category, manufactureDate, expiryDate, manufacturer)
VALUES ('I1', 'Apple Juice', 'Fresh red apples', 'Fruits', 150, 30.50, 150 * 30.50,'Fruit', '2024-09-29', '2025-09-29', 'FreshFarms Ltd');

-- Insert Whole Wheat Bread
INSERT INTO Item (itemId, itemName, Description, department, Quantity, unitprice, totalprice, Category, manufactureDate, expiryDate, manufacturer)
VALUES ('I2', 'Whole Wheat Bread', 'Organic whole wheat bread', 'Bakery', 100, 20.00, 100 * 20.00, 'Bakery', '2024-09-28', '2025-03-28', 'BakerBest Ltd');

-- Insert Milk 2L
INSERT INTO Item (itemId, itemName, Description, department, Quantity, unitprice, totalprice, Category, manufactureDate, expiryDate, manufacturer)
VALUES ('I3', 'Milk 2L', 'Full cream milk', 'Dairy', 200, 15, 200 * 15, 'Dairy', '2024-09-27', '2024-10-27', 'DairyFresh Suppliers');

-- Insert Rice 10kg
INSERT INTO Item (itemId, itemName, Description, department, Quantity, unitprice, totalprice, Category, manufactureDate, expiryDate, manufacturer)
VALUES ('I4', 'Rice 10kg', 'Premium long grain rice', 'Grains', 75, 60, 75 * 60, 'Grain', '2024-09-26', '2025-09-26', 'GrainMasters Ltd');

-- Insert Chicken Breast
INSERT INTO Item (itemId, itemName, Description, department, Quantity, unitprice, totalprice, Category, manufactureDate, expiryDate, manufacturer)
VALUES ('I5', 'Chicken Drumsticks', 'Boneless chicken breast', 'Meat', 50, 75.00, 50 * 75.00, 'Meat', '2024-09-25', '2024-10-05', 'MeatWorld');

-- Insert Orange Juice 1L
INSERT INTO Item (itemId, itemName, Description, department, Quantity, unitprice, totalprice, Category, manufactureDate, expiryDate, manufacturer)
VALUES ('I6', 'Orange Juice 1L', 'Freshly squeezed orange juice', 'Beverages', 120, 10.00, 120 * 10.00, 'Beverages', '2024-09-24', '2024-10-24', 'JuiceProducers Ltd');

-- Insert Pasta 500g
INSERT INTO Item (itemId, itemName, Description, department, Quantity, unitprice, totalprice, Category, manufactureDate, expiryDate, manufacturer)
VALUES ('I7', 'Pasta 500g', 'Durum wheat pasta', 'Grains', 90, 12.00, 90 * 12.00, 'Grain', '2024-09-23', '2025-03-23', 'ItalianFoods Co.');




--create product table

create table Product (productId varchar(25) primary key, productName varchar(50) not null, category varchar(30) not null, Quantity int not null, Description varchar(100) not null, price float not null);
--drop table Product;

-- Insert Apples
INSERT INTO Product (productId, productName, category, Quantity, Description, price)
VALUES ('P001', 'Apple Red Flavour Category', 'Fruit', 150, 'Fresh red apples', 30.50);

-- Insert Whole Wheat Bread
INSERT INTO Product (productId, productName, category, Quantity, Description, price)
VALUES ('P002', 'Wheat Bread', 'Bakery', 100, 'Organic whole wheat bread', 20.00);

-- Insert Milk 2L
INSERT INTO Product (productId, productName, category, Quantity, Description, price)
VALUES ('P003', 'Pack of Milk', 'Dairy', 200, 'Full cream milk', 15);

-- Insert Rice 10kg
INSERT INTO Product (productId, productName, category, Quantity, Description, price)
VALUES ('P004', 'Rice 10kg Pack', 'Grain', 75, 'Premium long grain rice', 60);

-- Insert Chicken Breast
INSERT INTO Product (productId, productName, category, Quantity, Description, price)
VALUES ('P005', 'Pre-Packaged Whole Chicken', 'Meat', 50, 'Boneless chicken breast', 75.00);

-- Insert Orange Juice 1L
INSERT INTO Product (productId, productName, category, Quantity, Description, price)
VALUES ('P006', 'Bottle of Orange Juice 1L', 'Beverages', 120, 'Freshly squeezed orange juice', 10.00);

-- Insert Pasta 500g
INSERT INTO Product (productId, productName, category, Quantity, Description, price)
VALUES ('P007', 'Box of Pasta 500g', 'Grain', 90, 'Durum wheat pasta', 12.00);

 


select * from Product;
select * from Stock;


create table Customer (customerId varchar(20),customerName varchar(50) not null, DoB date not null, Gender varchar(10) not null, Email varchar(100) not null, City varchar(30) not null,Street varchar(30) not null,PostalCode int not null, mobile varchar(10) primary key, Type varchar(20) not null, MemberStatus varchar(10) not null);
--drop table Customer;

-- Insert customer records with 'Normal' or 'Loyalty' as Tye
-- Insert customer records with Sri Lankan standards
INSERT INTO Customer (customerId, customerName, DoB, Gender, Email, City, Street, PostalCode, mobile, Type, MemberStatus)
VALUES
('C1', 'John Doe', '1985-01-15', 'Male', 'john.doe@example.lk', 'Colombo', 'Galle Rd', 00100, '0771234567', 'Normal', 'Active'),
('C2', 'Jane Smith', '1990-02-20', 'Female', 'jane.smith@example.lk', 'Kandy', 'Peradeniya Rd', 20000, '0782345678', 'Loyalty', 'Active'),
('C3', 'Alice Johnson', '1975-03-10', 'Female', 'alice.johnson@example.lk', 'Galle', 'Matara Rd', 80000, '0773456789', 'Normal', 'Inactive'),
('C4', 'Bob Williams', '1982-04-05', 'Male', 'bob.williams@example.lk', 'Jaffna', 'Stanley Rd', 40000, '0784567890', 'Loyalty', 'Active'),
('C5', 'Chris Evans', '1991-05-12', 'Male', 'chris.evans@example.lk', 'Matara', 'Beach Rd', 81000, '0775678901', 'Normal', 'Active'),
('C6', 'Eva Green', '1987-06-25', 'Female', 'eva.green@example.lk', 'Negombo', 'Katunayake Rd', 11500, '0786789012', 'Loyalty', 'Inactive'),
('C7', 'David Jones', '1978-07-30', 'Male', 'david.jones@example.lk', 'Kurunegala', 'Kandy Rd', 60000, '0777890123', 'Normal', 'Active'),
('C8', 'Lucy Hale', '1983-08-10', 'Female', 'lucy.hale@example.lk', 'Anuradhapura', 'New Town Rd', 50000, '0788901234', 'Loyalty', 'Active'),
('C9', 'Michael Stone', '1995-09-15', 'Male', 'michael.stone@example.lk', 'Ratnapura', 'Main St', 70000, '0779012345', 'Normal', 'Inactive'),
('C10', 'Sara Paul', '1992-10-22', 'Female', 'sara.paul@example.lk', 'Trincomalee', 'Dockyard Rd', 31000, '0780123456', 'Loyalty', 'Active'),
('C11', 'Eric Wilson', '1980-11-17', 'Male', 'eric.wilson@example.lk', 'Colombo', 'Duplication Rd', 00200, '0771122334', 'Normal', 'Inactive'),
('C12', 'Sophie Turner', '1993-12-11', 'Female', 'sophie.turner@example.lk', 'Kandy', 'Hill St', 20000, '0782233445', 'Loyalty', 'Active'),
('C13', 'Kevin Durant', '1976-01-05', 'Male', 'kevin.durant@example.lk', 'Galle', 'Wakwella Rd', 80000, '0773344556', 'Normal', 'Active'),
('C14', 'Maria Rodriguez', '1988-02-19', 'Female', 'maria.rodriguez@example.lk', 'Jaffna', 'Point Pedro Rd', 40000, '0784455667', 'Loyalty', 'Inactive'),
('C15', 'Natalie Portman', '1981-03-22', 'Female', 'natalie.portman@example.lk', 'Matara', 'Tangalle Rd', 81000, '0775566778', 'Normal', 'Active'),
('C16', 'Chris Pratt', '1990-04-14', 'Male', 'chris.pratt@example.lk', 'Kurunegala', 'Dambulla Rd', 60000, '0786677889', 'Loyalty', 'Active'),
('C17', 'Scarlett Johansson', '1984-05-28', 'Female', 'scarlett.johansson@example.lk', 'Anuradhapura', 'Kuttampokuna Rd', 50000, '0777788990', 'Normal', 'Inactive'),
('C18', 'Paul Rudd', '1989-06-07', 'Male', 'paul.rudd@example.lk', 'Ratnapura', 'Pelmadulla Rd', 70000, '0788899001', 'Loyalty', 'Active'),
('C19', 'Gal Gadot', '1992-07-15', 'Female', 'gal.gadot@example.lk', 'Trincomalee', 'Kandy Rd', 31000, '0779900112', 'Normal', 'Active'),
('C20', 'Emma Watson', '1985-08-25', 'Female', 'emma.watson@example.lk', 'Negombo', 'Colombo Rd', 11500, '0780011223', 'Loyalty', 'Inactive'),
('C21', 'Tom Hardy', '1977-09-30', 'Male', 'tom.hardy@example.lk', 'Colombo', 'Havelock Rd', 00100, '0771122335', 'Normal', 'Active'),
('C22', 'Chris Hemsworth', '1983-10-17', 'Male', 'chris.hemsworth@example.lk', 'Kandy', 'Katugasthota Rd', 20000, '0782233446', 'Loyalty', 'Active'),
('C23', 'Jennifer Lawrence', '1991-11-29', 'Female', 'jennifer.lawrence@example.lk', 'Galle', 'Gintota Rd', 80000, '0773344557', 'Normal', 'Inactive'),
('C24', 'Hugh Jackman', '1974-12-13', 'Male', 'hugh.jackman@example.lk', 'Jaffna', 'Navaly Rd', 40000, '0784455668', 'Loyalty', 'Active'),
('C25', 'Margot Robbie', '1994-01-23', 'Female', 'margot.robbie@example.lk', 'Matara', 'Weligama Rd', 81000, '0775566779', 'Normal', 'Active'),
('C26', 'Dwayne Johnson', '1980-02-04', 'Male', 'dwayne.johnson@example.lk', 'Kurunegala', 'Puttalam Rd', 60000, '0786677890', 'Loyalty', 'Inactive'),
('C27', 'Zendaya Coleman', '1997-03-15', 'Female', 'zendaya.coleman@example.lk', 'Anuradhapura', 'Rambewa Rd', 50000, '0777788901', 'Normal', 'Active'),
('C28', 'Tom Holland', '1996-04-11', 'Male', 'tom.holland@example.lk', 'Ratnapura', 'Kuruwita Rd', 70000, '0788899012', 'Loyalty', 'Active'),
('C29', 'Robert Downey Jr.', '1965-05-29', 'Male', 'robert.downey@example.lk', 'Trincomalee', 'China Bay Rd', 31000, '0779900123', 'Normal', 'Inactive'),
('C30', 'Mark Ruffalo', '1967-06-07', 'Male', 'mark.ruffalo@example.lk', 'Negombo', 'Marawila Rd', 11500, '0780011234', 'Loyalty', 'Active');



select * from Customer;
--delete from Customer;




--create sale table
CREATE TABLE Sale (
    saleId INT IDENTITY(1,1) PRIMARY KEY,
    productId VARCHAR(25) NOT NULL,
    productName VARCHAR(50) NOT NULL,
    price FLOAT NOT NULL,
    Quantity INT NOT NULL,
    saleStartDate DATE NOT NULL,
	saleEndDate DATE NOT NULL,
    priceCalculate FLOAT NOT NULL,
    discount FLOAT NOT NULL,
    payMethod VARCHAR(30) NOT NULL,
    mobile VARCHAR(10) NOT NULL,
    customerName VARCHAR(50) NOT NULL,
    FOREIGN KEY (productId) REFERENCES Product(productId),
    FOREIGN KEY (mobile) REFERENCES Customer(mobile) -- Correct foreign key reference
);
--drop table Sale;
select * from Sale;
delete sale;
--drop table Sale;
-- Insert sale records for 30 days
INSERT INTO Sale (productId, productName, price, Quantity, saleStartDate, saleEndDate, priceCalculate, discount, payMethod, mobile, customerName)
VALUES 
('P001', 'Apple Red Flavour Category', 30.50, 10, '2024-09-01', '2024-09-05', 10 * 30.50, 5.00, 'Credit Card', '0771234567', 'John Doe'),
('P002', 'Wheat Bread', 20.00, 5, '2024-09-02', '2024-09-06', 5 * 20.00, 2.00, 'Cash', '0782345678', 'Jane Smith'),
('P003', 'Pack of Milk', 15.00, 8, '2024-09-03', '2024-09-07', 8 * 15.00, 1.50, 'Mobile Payment', '0773456789', 'Alice Johnson'),
('P004', 'Rice 10kg Pack', 60.00, 2, '2024-09-04', '2024-09-08', 2 * 60.00, 3.00, 'Debit Card', '0784567890', 'Bob Williams'),
('P005', 'Pre-Packaged Chicken', 75.00, 4, '2024-09-05', '2024-09-09', 4 * 75.00, 7.50, 'Credit Card', '0775678901', 'Chris Evans'),
('P006', 'Bottle of Orange Juice 1L', 10.00, 12, '2024-09-06', '2024-09-10', 12 * 10.00, 1.20, 'Cash', '0786789012', 'Eva Green'),
('P007', 'Box of Pasta 500g', 12.00, 15, '2024-09-07', '2024-09-11', 15 * 12.00, 1.80, 'Mobile Payment', '0777890123', 'David Jones');

-- Repeat similar insertions with varied dates, quantities, and discounts for 30 days

--delete from Sale;

--SELECT stockName,stockType,stockQuantity,stockDate,lastUpdatedDate,reorderLevel FROM Stock WHERE stockId = 'S001';
--Predict Table
--create table PredictInventory(inventoryForecastId varchar(15) primary key,stockId varchar(15) not null,Quantity int not null,Sale varchar(35) not null,demandInventory varchar(30)not null,Reorder Bit not null,LeadTime DateTime not null,SafetyStock varchar(45) not null,cost float,foreign key (stockId) references  Stock (stockId));
--drop table PredictInventory;
--select * from PredictInventory;



--HR part
create table Job(post_Id varchar(25) primary key,Job_Title varchar(50) not null,jobType varchar(100) not null,Job_Description varchar(100)not null,Date Date not null);

--drop table Job;
select * from Job;
--drop table postJob;


--Leave Request
--create table Employee (employeeId varchar(25) primary key,userType varchar(15) not null,firstName varchar(30) not null,lastName varchar(30) not null,position varchar(15) not null,department varchar(15) not null,DateJoined Date not null,Salary float,Retirement bit);

--sample record for Employee Table
insert into Employee values('E1','HR','sajid','Iqbal','Human Resource','All','2024/02/19',180000.00,'True');
select * from Employee;
select * from Leave;
select * from HealthInsurance;
--Leave Request
create table Leave(leaveRequestId int primary key identity(1,1),employeeId varchar(25)not null,userType varchar(15)not null,firstName varchar(30)not null,lastName varchar(30)not null,leaveStartDate Date not null,leaveEndDate Date not null,LeaveType varchar(15)not null,reason varchar(100)not null);

--drop table Leave;
delete Leave;
select * from Leave;

--create table Employee (employeeId varchar(25) primary key,userType varchar(15) not null,firstName varchar(30) not null,lastName varchar(30) not null,position varchar(15) not null,department varchar(15) not null,DateJoined Date not null,Salary float,Retirement bit);
--drop table Employee;

--Retirement Plan
create table RetirementPlan (retirementId varchar(20) primary key,employeeId varchar(25) not null,firstName varchar(30) not null,lastName varchar(30) not null,position varchar(15) not null,retireType varchar(25) not null,DateJoined Date not null,expectedDate Date not null,contribution varchar(25) not null,foreign key(employeeId) references Employee(employeeId));
--drop table RetirementPlan;


select * from RetirementPlan;


--SELECT firstName, lastName, position FROM Employee WHERE employeeId = 'E1'

select * from RetirementPlan;
--delete from RetirementPlan;
--Health Insurance Table

CREATE TABLE HealthInsurance (
    HealthInsuranceID INT PRIMARY KEY IDENTITY(1,1),
	employeeId varchar(25) NOT NULL,
    firstName VARCHAR(50) NOT NULL,
	lastName VARCHAR(50) NOT NULL,
    Type VARCHAR(25) NOT NULL,
    Description VARCHAR(100) NOT NULL,
    EffectiveDate DATE NOT NULL,
    ExpiryDate DATETIME NOT NULL,
    PremiumAmount FLOAT NOT NULL,
    deductibleAmount FLOAT NOT NULL,
    RenewalOption VARCHAR(30) NOT NULL,
	foreign key(employeeId) references Employee(employeeId)

);
--drop table HealthInsurance;

select * from HealthInsurance;
--create table Employees
-- Create the Employees table


CREATE TABLE Employee (
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
	supervisorId VARCHAR(25) NULL,
	digitalMarketerId VARCHAR(25) NULL,
	accountantId VARCHAR(25) NULL,
    storekeeperId VARCHAR(25) NULL,
    salesRepId VARCHAR(25) NULL,
    cashierId VARCHAR(25) NULL
);

select * from Employee;
select * from Product;
select * from Stock;


select * from CustomerOrder;

select * from Item;
--delete from Employee;
--delete from Interview;
--delete from BankAccount;
--delete from RetirementPlan;
--delete from HealthInsurance;

CREATE TABLE Interview (
    InterviewId INT PRIMARY KEY IDENTITY(1,1),
    employeeId VARCHAR(25),
    firstName VARCHAR(50),
    lastName VARCHAR(30),
    Date DATE,
	endDate DATE,
    Location VARCHAR(100),
    Type VARCHAR(50),
    Status VARCHAR(50),
    scheduleEmail VARCHAR(100),
    FOREIGN KEY (employeeId) REFERENCES Employee(employeeId)
);
--drop table Interview;
select * from Interview;
select * from Job;
--drop table Employee;
select * from Employee;
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


--drop table Storekeeper;
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

select * from Employee;
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


--Supervisor Part
CREATE TABLE CustomerService (
    customerServiceId INT PRIMARY KEY IDENTITY,
    mobile VARCHAR(10),
    customerName VARCHAR(50),
    Type VARCHAR(25),
    responseTime DATETIME,
    feedback VARCHAR(100),
    FOREIGN KEY (mobile) REFERENCES Customer(mobile)
);
--drop table CustomerService;
select * from CustomerService;


CREATE TABLE MarketingPromotion (
  markPromotion_Id VARCHAR(25) PRIMARY KEY,
  markertPromotionName VARCHAR(50) NOT NULL,
  startDate DATE NOT NULL,
  endDate DATE NOT NULL,
  discount FLOAT NOT NULL,
  offer VARCHAR(50) NOT NULL,
  emailMarketing VARCHAR(100) NOT NULL,
  contentMarketing VARCHAR(50) NOT NULL,
  inStorePromotion VARCHAR(50) NOT NULL,
  condition VARCHAR(100) NOT NULL
);

select * from MarketingPromotion;

CREATE TABLE Marketing (
    marketingId VARCHAR(25) PRIMARY KEY,
    marketingName VARCHAR(50) NOT NULL,
    startDate DATETIME NOT NULL,
	endDate DATETIME NOT NULL,
    type VARCHAR(30) NOT NULL,
    USP VARCHAR(100) NOT NULL,
    pricing FLOAT NOT NULL,
    FAQs VARCHAR(MAX) NULL,
    contactNumber VARCHAR(10) NOT NULL
);

select * from Marketing;
--drop table Marketing;
--drop table Promotion;

--Accountant part
CREATE TABLE BankAccount (
    accountNumber VARCHAR(50) PRIMARY KEY,
    accountType VARCHAR(50) NOT NULL,
    Salary FLOAT NOT NULL,
    employeeId VARCHAR(25) NOT NULL,
    employeeName VARCHAR(50) NOT NULL,
    bankName VARCHAR(50) NOT NULL,
    branch VARCHAR(50) NOT NULL,
    openingDate DATE NOT NULL,
    accountStatus VARCHAR(50) NOT NULL,
    FOREIGN KEY (employeeId) REFERENCES Employee(employeeId)
);
select * from BankAccount;

select * from Stock;

--Sale Part
CREATE TABLE Delivery (
    DeliverId VARCHAR(20) PRIMARY KEY,
    deliveryName VARCHAR(50) NOT NULL,
    contactNumber VARCHAR(10) NOT NULL,
    deliveryAddress VARCHAR(100) NOT NULL,
    deliveryType VARCHAR(20) NOT NULL,
    availableStatus VARCHAR(10) NOT NULL
);
select * from Delivery;

--drop table Delivery;
--delete from Delivery;

CREATE TABLE Supplier (
    supplierId VARCHAR(20) PRIMARY KEY,
    supplierName VARCHAR(50) NOT NULL,
    mobile VARCHAR(10) NOT NULL,
    Company VARCHAR(100) NOT NULL,
    productType VARCHAR(50) NOT NULL,
    deliverySchedule DATE NOT NULL,
    payTerm VARCHAR(50) NOT NULL,
    comment VARCHAR(max) NULL
);
select * from Supplier;


--Cashier part
CREATE TABLE Refund (
    refundId VARCHAR(20) PRIMARY KEY,
    mobile VARCHAR(10) NOT NULL,
    customerName VARCHAR(50) NOT NULL,
    productId VARCHAR(25) NOT NULL,
    productName VARCHAR(50) NOT NULL,
    refundDate DATE NOT NULL,
    Type VARCHAR(30) NOT NULL,
    refundAmount FLOAT NOT NULL,
    originalPrice FLOAT NOT NULL,
    reason VARCHAR(100) NOT NULL,
    itemCondition VARCHAR(50) NOT NULL,
    CONSTRAINT FK_Refund_Mobile FOREIGN KEY (Mobile) REFERENCES Customer(Mobile),
    CONSTRAINT FK_Refund_ProductId FOREIGN KEY (productId) REFERENCES Product(ProductId)
);

--drop table Refund;
CREATE TABLE CustomerOrder (
    orderId VARCHAR(20) PRIMARY KEY,
    mobile VARCHAR(10) NOT NULL,
    customerName VARCHAR(50) NOT NULL,
    productId VARCHAR(25) NOT NULL,
    productName VARCHAR(50) NOT NULL,
    itemId VARCHAR(25) NOT NULL,
    itemName VARCHAR(50) NOT NULL,
    Quantity INT NOT NULL,
    unitprice FLOAT NOT NULL,
    discount FLOAT NOT NULL,
    tax FLOAT NOT NULL,
    totalprice FLOAT NOT NULL,
    paymentMethod VARCHAR(50) NOT NULL,
    payDate DATE NOT NULL,
    status VARCHAR(10) NOT NULL,
	stockId VARCHAR(15) NOT NULL,
	stockName VARCHAR(50) NOT NULL,
    FOREIGN KEY (mobile) REFERENCES Customer(mobile),
    FOREIGN KEY (productId) REFERENCES Product(productId),
    FOREIGN KEY (itemId) REFERENCES Item(itemId),
	FOREIGN KEY (stockId) REFERENCES Stock(stockId)
);

ALTER TABLE CustomerOrder
ALTER COLUMN status VARCHAR(50); -- or any appropriate length


Select * from CustomerOrder;
--DELETE FROM CustomerOrder;
--drop table CustomerOrder;
Select * from Item;

select * from Item;
--DELETE FROM Item;
--drop table Item;
select * from Product;

select * from Refund;
select * from Stock;


CREATE TABLE Cart (
    addCartId INT PRIMARY KEY IDENTITY(1,1),
    customerName VARCHAR(50) NOT NULL,
    productName VARCHAR(50) NOT NULL,
    itemName VARCHAR(50) NOT NULL,
    Quantity INT NOT NULL,
    unitprice FLOAT NOT NULL,
    discount FLOAT NOT NULL,
    tax FLOAT NOT NULL,
    totalprice FLOAT NOT NULL,
    payDate DATE NOT NULL,
    paymentMethod VARCHAR(50) NOT NULL,
    stockName VARCHAR(50) NOT NULL,
    orderId VARCHAR(20) NOT NULL,
	FOREIGN KEY (orderId) REFERENCES CustomerOrder(orderId)
);
--drop table AddtoCart;

Select * from Cart;

--delete cart;