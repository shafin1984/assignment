create database Bank;
create table Customers (
ID int identity (1,1) primary key,
customerName varchar(max),
email varchar(max),
accountNumber varchar(max),
openingDate date,
balance int default 0,
);
select * from Customers
drop table Customers

UPDATE Customers SET balance=balance + 10 WHERE accountNumber='11111111';
           

insert into Customers (customerName,email,accountNumber,openingDate)values ('Shafin','shafin@yahoo.com','stg-gul-002','2019-06-25');