create database stdsdata;

use stdsdata;

create table students(
ID INT PRIMARY KEY,
NAME varchar(30) NOT NULL,
AGE INT NOT NULL check (AGE >= 18),
GENDER varchar(20) NOT NULL,
CITY VARCHAR(20) default "Karachi",
EMAIL varchar(50) NOT NULL unique
);

select * from students;

INSERT INTO students 
values (1, "Taha", 22, "male", "Isb", "taha@gmail.com");

INSERT INTO students(ID, NAME, AGE, GENDER, EMAIL) 
values (2, "Rohaan", 22, "male", "rohaan@outlook.com");



