create database stdprocedure;

use stdprocedure;

create table students(
	stdid int primary key,
    fname varchar(30),
    lname varchar(30),
    age int
);

insert into students 
values (1, "Ali", "Khan", 22),
(2, "Arham", "Khan", 23),
(3, "Alyan", "Khan", 24),
(4, "Bilal", "Khan", 21),
(5, "Abduallah", "Khan", 27),
(6, "Osama", "Khan", 25),
(7, "Affan", "Khan", 26),
(8, "Luqman", "Khan", 32),
(9, "Sami", "Khan", 29),
(10, "Ayan", "Khan", 22),
(11, "Hanzala", "Khan", 28);


call std_details(32);