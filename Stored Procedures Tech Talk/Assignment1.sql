CREATE DATABASE ShoppingCartDb

USE ShoppingCartDb

CREATE TABLE ShoppingCartDb.dbo.Users
(
		UserId INT PRIMARY KEY,
		UserName VARCHAR(20),
		Password VARCHAR(20),
		Contact INT,
		City VARCHAR(20)
);

INSERT INTO Users VALUES(7369,'SMITH','CLERK',1600, 'Hyd');
INSERT INTO Users VALUES(7499,'ALLEN','SALESMAN',800,'Hyd');
INSERT INTO Users VALUES(7319,'WARD','SALESMAN',1250,'Chn');
INSERT INTO Users VALUES(7566,'JONES','MANAGER',2975,'Chn');
INSERT INTO Users VALUES(7567,'BONES','MANAGER',2975,'Bgl');

CREATE TABLE ShoppingCartDb.dbo.Products
(
		ProductId INT PRIMARY KEY,
		Name VARCHAR(20) NOT NULL,
		InStock INT NOT NULL,
		UnitPrice INT NOT NULL,
		Category VARCHAR(20) NOT NULL
);
INSERT INTO Products VALUES(6369,'Phone',10,5000,'Gadgets');
INSERT INTO Products VALUES(6269,'Laptop',20,55000,'Gadgets');
INSERT INTO Products VALUES(6169,'Tab',20,15000,'Gadgets');
INSERT INTO Products VALUES(6469,'Shirt',10,1500,'Clothes');
INSERT INTO Products VALUES(6869,'T Shirt',50,500,'Clothes');
INSERT INTO Products VALUES(6569,'Sweater',0,1500,'Clothes');
INSERT INTO Products VALUES(6669,'Desktop',0,500,'Gadgets');


CREATE TABLE Cart(
		Id INT PRIMARY KEY,
		CartId INT NOT NULL,
		Quantity INT NOT NULL,
		ProductId INT FOREIGN KEY
		REFERENCES Products(ProductId)
);

INSERT INTO Cart VALUES(5369,1369,10,6269);
INSERT INTO Cart VALUES(5469,1369,3,6169);
INSERT INTO Cart VALUES(5169,1369,2,6469);
INSERT INTO Cart VALUES(5769,1369,1,6869);
INSERT INTO Cart VALUES(5969,1369,8,6369);

select * from Products;

select ProductId, Name, Category from Products ORDER BY Category;

select * from Products where InStock=0;

select * from Products where UnitPrice>1000 and UnitPrice<10000;

select * from Products ORDER BY ProductId;



select * from Cart where CartId=1369;

select * from Cart where ProductId=6269;



select * from Users;

select * from Users where contact=1250;

select * from Users ORDER BY UserId DESC;


create procedure sp_simplep
as  
begin  
select * from Products where Name='Phone'  
end


exec sp_simplep

CREATE PROCEDURE sp_Select
AS
SELECT * FROM Products
GO;

EXEC sp_Select;



create procedure sp_inserting_record
@val1 int,
@val2 VARCHAR(20),
@val3 int,
@val4 int,
@val5 VARCHAR(20)
as  
begin  
insert into Products VALUES(@val1,@val2,@val3,@val4,@val5);
end


exec sp_inserting_record @val1=4361, @val2='Earpods', @val3=3, @val4=2000, @val5='Gadgets';


create procedure sp_outp(@Name varchar(10) output)
as
begin
select Name from Products where ProductId=6669
end

declare @en varchar(10)
exec sp_outp @Name=@en output
print @en

create procedure sp_inout(@name varchar(20) out, @id int)
as
begin
select Name from Products where ProductId=@id
end

declare @en varchar(10)
exec sp_inout @en,6369
print @en


CREATE PROCEDURE sp_Procedure
    @first_name varchar(20),
    @last_name  varchar(20)
AS
BEGIN
    SELECT @first_name , @last_name;
END
GO

EXEC My_Procedure 'Susmith', 'Reddy';

ALTER PROCEDURE sp_Procedure
    @first_name varchar(20),
    @last_name  varchar(20)
AS
BEGIN
    SELECT  @last_name + ', ' + @first_name;
END

EXEC My_Procedure 'Susmith', 'Reddy';

DROP PROCEDURE IF EXISTS dbo.pr;


