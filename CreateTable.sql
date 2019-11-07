Create Database ProductsDB
Go

Use ProductsDB
Go

Create table Categories
(
	ID int primary key identity,
	Name nvarchar(50)
)
Go

create table Products
(
	ID int primary key identity,
	Name nvarchar(50),
	Price int,
	Category_Id int foreign key References Categories(ID)
)
Go