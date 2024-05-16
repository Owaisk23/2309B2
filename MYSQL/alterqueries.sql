use 2309b2;

create table employee(
	emp_id int,
    emp_fname varchar(25),
    emp_lname varchar(25),
	emp_hourlypay decimal(5,2),
    emp_hiredate date
);

select * from employee;

insert into employee 
values (1, "Luqman", "Aslam", 99.2, "2020-10-22");

drop table employee;

truncate table employee;

RENAME TABLE employee To workers;

rename table workers To employee;

alter table employee
add email varchar(30);

select * from employee;

alter table employee
rename column email to emp_email;

