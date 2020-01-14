--books stored procedures
go
create proc selectAllBooks
as
begin 
select * from [dbo].[books]
end


go
create proc selectBookById @book_id int
as
begin 
select * from [dbo].[books] where book_id=@book_id
end

go
create proc insertNewBook @bTitle varchar(225), @bAuthor varchar(225), @bPrice float, @bAvailable varchar(25), @bPublisherId int
as
begin 
insert into [dbo].[books] (title, author, price, available, publisher_id)
values (@bTitle, @bAuthor, @bPrice, @bAvailable, @bPublisherId)
end

go
create proc deleteBookById @book_id int
as
begin 
delete from [dbo].[books] where book_id=@book_id
end


------------------------------------------------------------------------------------------


-- publishers stored procedures
go
create proc selectAllPublishers
as
begin 
select * from [dbo].[publisher]
end


go
create proc selectPublisherById @publisher_id int
as
begin 
select * from [dbo].[publisher]  where pub_id=@publisher_id
end


go
create proc insertNewPublisher @pName varchar(225), @PAddress varchar(225)
as
begin 
insert into [dbo].[publisher] (pub_name, pub_address)
values (@pName, @PAddress)
end

go
create proc deletePublisherById @PId int
as
begin 
delete from [dbo].[publisher] where pub_id=@PId
end

-----------------------------------------------------------------------------

-- Members stored procedures
go
create proc selectAllMembers
as
begin 
select * from [dbo].[member]
end


go
create proc selectMemberById @member_id int
as
begin 
select * from [dbo].[member]  where mem_id=@member_id
end


go
create proc insertNewMember @MName varchar(225), @MAddress varchar(225), @MSubscribeDate date, @MExpiryDate date
as
begin 
insert into [dbo].[member] (mem_name, mem_address, mem_subscribe_date, mem_expiry_date)
values (@MName, @MAddress, @MSubscribeDate, @MExpiryDate)
end

go
create proc deleteMemberById @MId int
as
begin 
delete from [dbo].[member] where mem_id=@MId
end

-----------------------------------------------------------------------------