create database Dynamically_loading
use Dynamically_loading

create table tbl_employee
(
emp_id int primary key identity,
emp_name varchar(50) not null,
emp_email varchar(50) not null,
emp_contact varchar(50) not null,
emp_exp varchar(50) not null,
)

insert into tbl_employee values ('Asad','asad@gmail.com', '0345289541', 5)
insert into tbl_employee values ('Najam','Najam@gmail.com', '034528564', 3)
insert into tbl_employee values ('Khursheed','Khursheed@gmail.com', '034525256', 2)