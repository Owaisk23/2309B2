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

use 2309b2;

ALTER TABLE EMPLOYEE
MODIFY COLUMN emp_email varchar(40);

SELECT * FROM EMPLOYEE;

ALTER TABLE EMPLOYEE
MODIFY COLUMN emp_email varchar(40)
AFTER emp_lname;

ALTER TABLE EMPLOYEE
DROP column emp_email;

insert into employee
values(1, "Ayan", "Shakeel", 99.24, "2017-07-20");

insert into employee
values(2, "Daniyal", "Sajid", 84.1, "2018-11-12"),
(3, "Hanzala", "Kashif", 74.12, "2016-05-26"),
(4, "Sami", "Fareed", 44.12, "2019-10-17"),
(5, "Ahsan", "Ahmed", 54.14, "2017-09-28"),
(6, "Abdullah", "Hanif", 77.12, "2023-07-10"),
(7, "Hunain", "Jaffer", 64.1, "2022-06-27");

select * from employee;


insert into employee
values(8, "Hussain", "Zeeshan", 90.11, "2017-02-20");

insert into employee(emp_id, emp_fname, emp_lname)
values(9, "Abdul", "Rafay");

truncate table employee;


select emp_fname, emp_hourlypay from employee;

select * from employee
where emp_id = 3;

select * from employee
where emp_hourlypay < 70;

select * from employee
where emp_hiredate >= "2017-07-29";

insert into employee 
values(10, "Ashar", "Ahmed", 99.55, "2022-08-06");

select * from employee
where emp_fname = "Ayan";

select * from employee
where emp_lname = "Ahmed";

select * from employee
where emp_hiredate IS NULL;








