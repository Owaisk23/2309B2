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

SELECT * FROM students;

ALTER TABLE students change
NAME SNAME varchar(30) NOT NULL;

INSERT INTO students 
values (3, "Affan", 31, "male", "Quetta", "affan@gmail.com"),
(4, "Saad", 25, "male", "Hyd", "saad@outlook.com"),
(5, "Osama", 19, "male", "Multan", "osama@gmail.com"),
(6, "Javeria", 25, "female", "Hyd", "jia@gmail.com"),
(7, "Luqman", 35, "male", "Lhr", "luqman@gmail.com"),
(8, "Wajeeha", 24, "female", "Karachi", "wajeeha@gmail.com"),
(9, "Owais", 23, "male", "Karachi", "owaisk@gmail.com"),
(10, "Ashar", 27, "male", "Hyd", "ashar@gmail.com");


SELECT * FROM students
where AGE >= 27 OR CITY = "Multan";

SELECT * FROM students
where AGE >= 27 AND CITY = "Hyd";

SELECT * FROM students
where AGE between 25 AND 35;

SELECT * FROM students
where AGE between 25 AND 35
limit 2;

SELECT * FROM students
where CITY NOT IN ("Karachi");


SELECT * FROM students
where CITY NOT IN ("Isb", "Hyd", "Lhr");

update students
set CITY = "Swatt"
where ID = 4;

SELECT * FROM students
where AGE between 25 AND 35
order by ID desc;

SELECT * FROM students
where AGE between 20 AND 35
order by AGE asc;

-- AGGREGATE FUNCTION

SELECT min(AGE) as MIN_AGE from students; 
SELECT SNAME, GENDER, max(AGE) as MAX_AGE from students;
SELECT SUM(AGE) AS TOTALAGE from students;
SELECT AVG(AGE) AS AVGAGE FROM STUDENTS;
SELECT CONCAT(SNAME, " FROM ", CITY) AS STDDATA FROM STUDENTS;


create database item;
use item;
CREATE TABLE PAYMENTS( 
	ID int PRIMARY KEY AUTO_INCREMENT,
    PNAME varchar(50) NOT NULL,
    PDATE DATE NOT NULL,
    METHOD VARCHAR(50),
	AMOUNT int,
    CITY VARCHAR(50) NOT NULL
);
DROP TABLE PAYMENTS;
SELECT * FROM PAYMENTS;

INSERT INTO PAYMENTS(PNAME, PDATE, METHOD, AMOUNT, CITY)
VALUES ("Taha", "2024-02-29", "Jazzcash", 35000, "Karachi");


INSERT INTO PAYMENTS(PNAME, PDATE, METHOD, AMOUNT, CITY)
VALUES ("Adnan", "2024-02-25", "Easypaisa", 45000, "Multan");

INSERT INTO PAYMENTS(PNAME, PDATE, METHOD, AMOUNT, CITY)
VALUES ("Ali", "2024-02-29", "Cash", 25000, "Lahore"),
("Hamna", "2024-02-25", "Card", 45000, "Quetta"),
("Humais", "2024-02-29", "Easypaisa", 55000, "Karachi"),
("Farhan", "2024-02-27", "Paypal", 45000, "Sukkur"),
("Haris", "2024-02-25", "Easypaisa", 65000, "Islamabad");

update payments
set CITY = "Karachi"
where ID = 6;

SELECT * FROM PAYMENTS;

SELECT PDATE, SUM(AMOUNT) FROM PAYMENTS
WHERE PDATE = "2024-02-29";


SELECT CITY, SUM(AMOUNT) AS TOTALAMOUNT, COUNT(ID) AS COUNT
FROM PAYMENTS
GROUP BY CITY;

SELECT PDATE, SUM(AMOUNT) AS TOTALAMOUNT, COUNT(ID) AS COUNT
FROM PAYMENTS
GROUP BY PDATE;

SELECT CITY, SUM(AMOUNT) AS TOTALAMOUNT, COUNT(ID) AS COUNT
FROM PAYMENTS
GROUP BY CITY with rollup;


SELECT METHOD, SUM(AMOUNT) AS TOTALAMOUNT, COUNT(ID) AS COUNT, CITY
FROM PAYMENTS
GROUP BY METHOD
HAVING CITY = "Karachi" AND NOT METHOD = "Paypal";

DELETE FROM PAYMENTS
WHERE AMOUNT BETWEEN 30000 AND 50000;

truncate table payments;

SELECT * FROM PAYMENTS;

use products;

select * from PAYMENTS;

INSERT INTO PAYMENTS (PNAME,PDATE, METHOD,CITY,AMOUNT) VALUES
("ADNAN","2023-09-29","CASH","KARACHI",45000),
("BILAL","2023-09-29","CARD","LAHORE",30000),
("ZEESHAN","2023-09-30","JAZZCASH","ISLAMABAD",25000),
("SHARIQ","2023-09-28","PAYPAL", "LAHORE",15000),
("ABEEHA","2023-09-29","CASH","KARACHI",28000);

SELECT METHOD, sum(AMOUNT), COUNT(ID),CITY 
FROM PAYMENTS 
GROUP BY METHOD
HAVING  CITY="KARACHI"
AND NOT METHOD="CASH";

-- SUB QUERIES
SELECT AVG(AMOUNT) FROM PAYMENTS;

SELECT *,(SELECT AVG(AMOUNT) FROM PAYMENTS) AS AVERAGE_AMOUNT FROM PAYMENTS WHERE
AMOUNT <= (SELECT AVG(AMOUNT) FROM PAYMENTS);

SELECT * FROM PAYMENTS
WHERE ID IN (SELECT ID FROM PAYMENTS
WHERE  ID%2 != 0);







 















