CREATE DATABASE "2309B2";

CREATE TABLE Employee(
	empId int PRIMARY KEY identity(1,1),
	empName varchar(255) NOT NULL,
	designation varchar(255) NOT NULL,
	salary int NOT NULL,
	city varchar(70) NOT NULL,
	deptId int
);

SELECT * FROM Employee;

INSERT INTO Employee(empName, designation, salary, city, deptId) VALUES 
('Ayan', 'MERN Developer', 230000, 'Khi', null),
('Ahsan', 'Angular Developer', 130000, 'Isb', null),
('Luqman', 'Flutter Developer', 30000, 'Lhr', null),
('Huzaifa', 'Python Developer', 67000, 'Khi', null),
('Sami', 'DotNET Developer', 130000, 'Isb', null),
('Fiza', 'Laravel Developer', 57000, 'Lhr', null),
('Hussain', 'Angular Developer', 73000, 'Isb', null);

SELECT DISTINCT city From Employee;

-- UPDATE

update Employee set salary=300000 where city='Lhr';

update Employee set empName='Hassan', designation='Wordpress Developer' where empId=7;

-- DELETE
DELETE FROM Employee where empName='Moin';

TRUNCATE TABLE Employee;

DROP Table Employee;

-- WHERE Clause

SELECT empName, designation FROM Employee where designation='MERN Developer';

-- NOT
SELECT empName, designation FROM Employee where NOT designation='Angular Developer';

-- AND

SELECT empName, designation, salary FROM Employee where designation = 'Angular Developer' AND salary <= 100000;

SELECT empName, designation, salary FROM Employee where NOT designation = 'Angular Developer' AND salary <= 100000;

-- OR

SELECT empName, designation, salary FROM Employee where designation = 'Angular Developer' OR salary <= 100000;

SELECT empName, designation, salary FROM Employee where NOT designation = 'Angular Developer' OR salary <= 100000;

-- BETWEEN
SELECT * FROM Employee where empId between 3 AND 5;

-- Like
SELECT * FROM Employee where designation like '%t%'; 

-- In
SELECT * FROM Employee where city IN ('Lhr');

-- Clauses ORDER BY
SELECT * FROM Employee order by empName asc;

SELECT * FROM Employee order by empId desc;

-- TOP
SELECT TOP 2 * FROM Employee;

SELECT TOP 50 percent * FROM Employee;

-- aggregate functions
SELECT * FROM Employee;

SELECT COUNT(empName) as total_emp FROM Employee;

SELECT MIN(salary) as Min_Salary FROM Employee;

SELECT MAX(salary) as Max_Salary FROM Employee;

SELECT SUM(salary) as Total_Salary From Employee;

SELECT AVG(salary) as Avg_Salary FROM Employee;

SELECT CONCAT(empName, ' is assigned as a ', designation, ' has a salary about ', salary) as Emp_Details FROM Employee;

-- Sub Queries

SELECT * FROM Employee where salary < (SELECT AVG(salary) as Avg_Salary FROM Employee);

-- GROUP BY CLAUSE
SELECT CITY, COUNT(empId) as WORKER FROM Employee GROUP BY city;

SELECT CITY, MAX(salary) as MAX_Salary FROM Employee GROUP BY city;

SELECT CITY, SUM(salary) as TOTAL_Salary FROM Employee GROUP BY city;






