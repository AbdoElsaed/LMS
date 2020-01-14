create table books (
	book_id int identity(1, 1) primary key,
	title varchar(255),
	author varchar(255),
	price float,
	available varchar(25)
);
create table publisher (
	pub_id int identity(1, 1) primary key,
	pub_name varchar(255),
	pub_address varchar(255),
);

create table member (
	mem_id int identity(1, 1) primary key,
	mem_name varchar(255),
	mem_address varchar(255),
	mem_subscribe_date date,
	mem_expiry_date date,
);


create table borrowedBy (
	id int identity(1, 1) primary key,
	member_id int,
	book_id int,
	borrowing_date date,
	return_date date,
	foreign key (member_id) references member(mem_id),
	foreign key (book_id) references books(book_id)
)

select * from books

alter table books
add publisher_id int;

ALTER TABLE books
ADD FOREIGN KEY (publisher_id) REFERENCES publisher(pub_id);

go
create proc selectAllBooks
as
begin 
select * from [dbo].[books]
end

exec selectAllBooks

select * from books