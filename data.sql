create database QuanLyQuanAnNhanh
go

use QuanLyQuanAnNhanh
go

--Food
--Table
--FoodCategory
--Account
--Bill
--BillInfo

create table TableFood
(
	id int identity primary key,
	name nvarchar(100) not null default N'Bàn chưa có tên',
	status nvarchar(100) not null default N'Trống',  --trong hoac co nguoi
)
go

create table Account
(
	UserName nvarchar(100) primary key,
	--DisplayName nvarchar(100) not null default N'Storm',
	PassWord nvarchar(100) not null default 0,
	type int not null default 0,  -- 1: admin, 0: staff
)
go

create table FoodCategory
(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa đặt tên',
)
go

create table Food
(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa đặt tên',
	idCategory int not null,
	price float not null default 0,

	foreign key (idCategory) references dbo.FoodCategory(id), 
)
go

create table Bill
(
	id int identity primary key,
	DateCheckIn Date not null default getdate(),
	DateCheckOut Date,
	idTable int not null,
	status int not null default 0,  --1: da thanh toan, 0: chua thanh toan

	foreign key (idTable) references dbo.TableFood(id),
)
go

create table BillInfo
(
	id int identity primary key,
	idBill int not null,
	idFood int not null,
	count int not null default 0,

	foreign key (idBill) references dbo.Bill(id),
	foreign key (idFood) references dbo.Food(id),
)
go

insert into dbo.Account (UserName, PassWord, type)
values ( N'admin', N'admin',1)

insert into dbo.Account (UserName, PassWord, type)

values ( N'staff',N'staff',0)

go

---

create proc USP_GetAccountByUserName
@userName nvarchar(100)
as 
begin 
	select * from dbo.Account where UserName = @userName
end
go

create proc USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
as
begin
	select * from dbo.Account where UserName = @userName and PassWord = @passWord
end
go

--- Thêm bàn

declare @i int = 1

while @i < 21
begin
	insert dbo.TableFood (name) values (N'Bàn ' + cast(@i as nvarchar(100)))
	set @i = @i+1
end
go

create proc USP_GetTableList
as select * from dbo.TableFood
go

--exec dbo.usp_GetTableList

-- Thêm category
insert into FoodCategory (name) values (N'Chicken')
insert into FoodCategory (Name) values (N'Pizza')
insert into FoodCategory (Name) values (N'Hamburger')
insert into FoodCategory (Name) values (N'Drinks')
insert into FoodCategory (Name) values (N'Combo')
go

-- Thêm food
insert into Food (Name, idCategory, Price) values (N'Đùi gà truyền thống', 1, 39000)
insert into Food (Name, idCategory, Price) values (N'Đùi gà chiên', 1, 39000)
insert into Food (Name, idCategory, Price) values (N'Cánh gà chiên', 1, 39000)
insert into Food (Name, idCategory, Price) values (N'Gà sốt cay', 1, 110000)
insert into Food (Name, idCategory, Price) values (N'Pizza hải sản', 2, 89000)
insert into Food (Name, idCategory, Price) values (N'Pizza gà thái', 2, 89000)
insert into Food (Name, idCategory, Price) values (N'Pizza bò', 2, 89000)
insert into Food (Name, idCategory, Price) values (N'Pizza xúc xích', 2, 89000)
insert into Food (Name, idCategory, Price) values (N'Pizza nhiệt đới', 2, 89000)
insert into Food (Name, idCategory, Price) values (N'Burger vị bò', 3, 40000)
insert into Food (Name, idCategory, Price) values (N'Burger vị gà', 3, 35000)
insert into Food (Name, idCategory, Price) values (N'Sinh tố cam', 4, 14000)
insert into Food (Name, idCategory, Price) values (N'Sinh tố dâu', 4, 10000)
insert into Food (Name, idCategory, Price) values (N'Trà sữa truyền thống', 4, 18000)
insert into Food (Name, idCategory, Price) values (N'Trà sữa Chocolate', 4, 22000)
insert into Food (Name, idCategory, Price) values (N'Trà sữa Matcha', 4, 20000)
insert into Food (Name, idCategory, Price) values (N'Trà sữa Việt quất', 4, 24000)
insert into Food (Name, idCategory, Price) values (N'Nước ngọt các loại', 4, 15000)
insert into Food (Name, idCategory, Price) values (N'Combo Burger gà + Coca', 5, 45000)
insert into Food (Name, idCategory, Price) values (N'Combo đùi gà truyền thống + Coca', 5, 55000)
insert into Food (Name, idCategory, Price) values (N'Combo Pizza hải sản + Coca', 5, 100000)
go

-- add information into Bill
insert into Bill (DateCheckIn, idTable) values (GETDATE(), 1)
insert into Bill (DateCheckIn, idTable) values (GETDATE(), 2)
insert into Bill (DateCheckIn, idTable) values (GETDATE(), 3)
go

-- add information into BillInfo
insert into BillInfo (idBill, idFood, count) values (1, 1, 2)
insert into BillInfo (idBill, idFood, count) values (1, 3, 3)
insert into BillInfo (idBill, idFood, count) values (2, 2, 1)
insert into BillInfo (idBill, idFood, count) values (3, 5, 1)
insert into BillInfo (idBill, idFood, count) values (2, 4, 2)
go

-- Bill's procedure
create proc USP_InsertBill
@idTable int
as
	insert dbo.Bill (DateCheckIn, DateCheckOut, idTable, status) values (GETDATE(), null, @idTable, 0)
go

-- Bill Info's procedure
create proc USP_InsertBillInfo
@idBill int, @idFood int, @count int
as
begin
	declare @isExistBillInfo int
	declare @foodCount int = 1

	select @isExistBillInfo = id, @foodCount = count from dbo.BillInfo where idBill = @idBill and idFood = @idFood

	if (@isExistBillInfo > 0)
	begin
		declare @newCount int = @foodCount + @count
		if (@newCount > 0)
			update BillInfo set Count = @foodCount + @count where idFood = @idFood
		else 
			delete BillInfo where idBill = @idBill and idFood = @idFood
	end
	else
	begin 
		insert BillInfo (idBill, idFood, count) values (@idBill, @idFood, @count)
	end
end
go

delete BillInfo
delete Bill


-- end Bill's procedure
create trigger UTG_UpdateBillInfo
on BillInfo for insert
as
begin
	declare @idBill int
	select @idBill = idBill from inserted

	declare @idTable int
	select @idTable = idTable from Bill where id = @idBill and status = 0

	declare @count int
	select @count = COUNT(*) from BillInfo where idBill = @idBill

	if (@count > 0)
		update TableFood set Status = N'Có người' where id = @idTable
	else
		update TableFood set Status = N'Trống' where id = @idTable
end
go

create trigger UTG_UpdateBill
on Bill for update
as
begin
	declare @idBill int
	select @idBill = ID from inserted
	declare @idTable int
	select @idTable = idTable from Bill where id = @idBill
	declare @amount int = 0
	select @amount = COUNT(*) from Bill where idTable = @idTable and Status = 0
	if (@amount = 0)
		update TableFood set Status = N'Trống' where ID = @idTable
end
go

alter table Bill add totalPrice float

delete BillInfo
delete Bill
go

create proc USP_GetListBillByDate
@checkIn date, @checkOut date
as
begin
	select t.name as [Tên bàn], b.totalPrice as [Tổng tiền], DateCheckIn as [Thời gian vào], DateCheckOut as [Thời gian ra]
	from Bill as b, TableFood as t
	where DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1 AND t.id = b.idTable
end
go

create proc USP_UpdateAccount
@userName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
as
begin
	declare @isRightPass int = 0
	select @isRightPass = COUNT(*) from Account where UserName = @userName and Password = @password
	if (@isRightPass = 1)
	begin
		if (@newPassword <> null or @newPassword <> '')
			begin
				update Account set Password = @newPassword where UserName = @userName
			end
	end
end
go
