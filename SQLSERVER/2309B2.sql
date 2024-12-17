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

-- having
SELECT designation, COUNT(empId) as workers FROM Employee GROUP BY designation
having designation = 'Angular Developer';

CREATE TABLE Departments(
	deptId int PRIMARY KEY identity(1,1),
	deptName nvarchar(50) NOT NULL
);

INSERT INTO Departments VALUES ('Admin'), ('Development Team'), ('Tech Support'), ('HR'), ('SQAs'); 

select * from Employee;

truncate table Employee;

DROP table Employee;

CREATE TABLE Employee(
	empId int PRIMARY KEY identity(1,1),
	empName varchar(255) NOT NULL,
	designation varchar(255) NOT NULL,
	salary int NOT NULL,
	city varchar(70) NOT NULL,
	deptId int,
	FOREIGN KEY (deptId) REFERENCES Departments(deptId)
);

INSERT INTO Employee(empName, designation, salary, city, deptId) VALUES 
('Ayan', 'MERN Developer', 230000, 'Khi', 2),
('Taha', 'Flutter Developer', 30000, 'Lhr', 2),
('Rayyan', 'Network Head', 30000, 'Lhr', 3),
('Talha', 'Admin Head', 30000, 'Lhr', 1),
('Ahsan', 'HR Assistant', 130000, 'Isb', 4),
('Luqman', 'Flutter Developer', 30000, 'Lhr', 2),
('Huzaifa', 'Python Developer', 67000, 'Khi', 2),
('Sami', 'DotNET Developer', 130000, 'Isb', 2),
('Hassan', 'HR Head', 57000, 'Lhr', 4),
('Fiza', 'Laravel Developer', 57000, 'Lhr', 2),
('Usman', 'Admin', 57000, 'Lhr', 1),
('Hussain', 'Angular Developer', 73000, 'Isb', 2);

INSERT INTO Employee(empName, designation, salary, city, deptId) VALUES 
('Rizwan', 'Network Assistant', 230000, 'Khi', Null),
('Qadir', 'Admin Assistant', 30000, 'Lhr', Null);

--INNER JOIN

SELECT * FROM Employee as emp INNER JOIN Departments as d on emp.deptId = d.deptId;

-- LEFT JOIN
SELECT * FROM Employee as emp LEFT JOIN Departments as d on emp.deptId = d.deptId;

SELECT * FROM Departments as d LEFT JOIN Employee as emp on d.deptId = emp.deptId;
-- RIGHT JOIN
SELECT * FROM Employee as emp RIGHT JOIN Departments as d on emp.deptId = d.deptId;

-- FULL OUTER JOIN
SELECT emp.*, d.deptName FROM Employee as emp FULL OUTER JOIN Departments as d on emp.deptId = d.deptId;

-- VIEWS

SELECT * FROM Employee;

CREATE VIEW [EmpDetails]
AS
SELECT empName, designation FROM Employee;

SELECT * FROM EmpDetails;

CREATE VIEW [empDeptName]
AS
SELECT deptName FROM Departments;

SELECT * FROM empDeptName;


CREATE VIEW [empDetailwithDept]
AS
SELECT emp.empName, emp.designation, d.deptName FROM Employee as emp INNER JOIN Departments as d on emp.deptId = d.deptId;

SELECT * FROM empDetailwithDept;

--DCL DATA CONTROL LANGUAGE

SELECT * FROM sys.sql_logins;

CREATE LOGIN DEV_EMP WITH Password = '555';
CREATE USER DEV_EMP FROM LOGIN DEV_EMP;

SELECT * FROM Employee;

-- GRANT

GRANT SELECT on dbo.Employee To DEV_EMP;
GRANT DELETE, UPDATE on dbo.Employee To DEV_EMP;

GRANT INSERT on dbo.Employee TO DEV_EMP;

REVOKE DELETE on dbo.Employee to DEV_EMP;


-- Stored Procedure

CREATE PROCEDURE SeeEmp
AS
BEGIN
SELECT * FROM Employee
END;


SeeEmp;

ALTER PROCEDURE SeeEmp
AS
BEGIN
SELECT * FROM Employee where city = 'Khi'
END;

SeeEmp;

CREATE PROCEDURE AddEmp @eName varchar(255), @desig varchar(100), @sal int, @city varchar(60), @dptId int
AS
BEGIN
INSERT INTO Employee VALUES (@eName, @desig,@sal, @city, @dptId)
SELECT * FROM Employee
END;

AddEmp @eName = 'Owais', @desig = 'Software Developer', @sal = 45000, @city = 'Khi', @dptId = 2;

AddEmp @eName = 'Sajida', @desig = 'DotNet Developer', @sal = 145000, @city = 'Hyd', @dptId = 2;

Drop PROCEDURE SeeEmp;

-- indexes 

create index empname_index
On Employee(empName,salary);

SELECT *FROM Employee WITH(INDEX(empname_index))
select * from Employees where empName='Owais';

drop index employee.empname_index;




-- Triggers

 -- for
 CREATE TRIGGER AddEmp_trigger 
 On Employee
 for INSERT
 as
 BEGIN
 print('a new employee added successfully.')
 END;

 INSERT INTO Employee(empName,designation,salary,city,deptId) VALUES
('Taha ','Mob developer', 58788, 'swat',1);


 -- alter
 ALTER TRIGGER AddEmp_trigger 
 On Employee
 for INSERT
 as
 BEGIN
SELECT * FROM inserted;
 END;

 --Creating audit table
 CREATE TABLE EmpLogs(
 logid int Primary key identity(1,1),
 ActionPerformed nvarchar(255)
 );
 SELECT * FROM EmpLogs;


 SELECT * into Test from Employees;
 SELECT * From Test;

 -- Maintaining logs on tables

  create TRIGGER AddEmp_trigger 
 On Employees
 AFTER INSERT
 as
 BEGIN
DECLARE @Id int, @name varchar(50)
SELECT @Id=id, @name=empName FROM inserted
INSERT INTO EmpLogs VALUES(@name+' having Id = '+ CAST(@Id as varchar(6)) +' is added at '+ cast(GETDATE() as varchar(30)))
 END;


 -- instead of

 SELECT * from Employee;
 Alter TABLE Employee ADD emp_status int default(1) not null;


 CREATE Trigger Soft_Delete
 On Employee
 INSTEAD OF DELETE
 AS
 BEGIN
 DECLARE @ID int
 SELECT @ID=id from Deleted
 Update Employee set emp_status=0 where id=@ID
 END;

 DELETE from Employee where id=15;


 -- Update Trigger
 ALTER Trigger Update_Employees
 On Employees
 for Update
 as
 begin
DECLARE @Id int
DECLARE @Newname varchar(60), @Oldname varchar(60)
DECLARE @Newsalary int,  @Oldsalary int
DECLARE @NewDesignation varchar(60),@OldDesignation varchar(60)
DECLARE @Newdeptid int,  @Olddeptid int
DECLARE @Newcity varchar(60), @Oldcity varchar(60)
DECLARE @AuditString varchar(255)

SELECT * into #Temptable from inserted
WHILE(exists (SELECT id from #Temptable))
begin
SELECT @Id=id, @Newname=empName, @Newsalary=salary, @NewDesignation=designation,@Newcity=city,@Newdeptid=deptId FROM #Temptable
SELECT  @Oldname=empName, @Oldsalary=salary, @OldDesignation=designation,@Oldcity=city,@Olddeptid=deptId FROM deleted where id=@Id
SET @AuditString =''
SET @AuditString ='An employee having id = '+ CAST(@Id as varchar(6))+' on '+  CAST(GETDATE() as varchar(30))+' is changed '
if(@Oldname <> @Newname)
SET @AuditString = @AuditString + ' its name from '+@Oldname +' to '+ @Newname

if(@Oldsalary <> @Newsalary)
SET @AuditString = @AuditString + ' its salary from '+CAST(@Oldsalary as varchar(10)) +' to '+CAST(@Newsalary as varchar(10))

if(@OldDesignation <> @NewDesignation)
SET @AuditString = @AuditString + ' its designation from '+@OldDesignation +' to '+ @NewDesignation

if(@Oldcity <> @Newcity)
SET @AuditString = @AuditString + ' its city from '+@Oldcity +' to '+ @Newcity

if(@Olddeptid <> @Newdeptid)
SET @AuditString = @AuditString + ' its deptid from '+CAST(@Olddeptid as varchar(10)) +' to '+CAST(@Newdeptid as varchar(10))
 Insert into Emplogs values(@AuditString)
 DELETE FROM #Temptable where id=@Id
end
 end;


 select * from Employees;
 update Employees set city='karachi' where id > 4;
 select * from Emplogs;

 -- Transactions 
 -- ddl- data definition language (create , alter, drop)
 -- dml-data manipulation language (insert,update,delete, select)
 -- dcl-data control languages (grant/revoke)
 -- tcl- transaction control language. (ROLLBACK/ COMMIT)

 -- ACID properties.
 
-- A => Atomicity -- all the steps are fully completed or not a single step will execute.
-- C => Consistency -- all the nodes in a network should be aware of the transaction.
-- I => Isolation -- one transaction's info should not be known to another transaction.
-- D => Durability -- changes after transaction should be saved.

-- Integrity
Begin Transaction
Update Employees set empName='Khurram' where id= 1;
Commit Transaction;-- save changes

Rollback Transaction;-- wapis

BEGIN TRANSACTION
BEGIN try 
Update Employees set empName='chakwal' where id= 1/0;
print('Commited Successfully.')
COMMIT TRANSACTION
End try
BEGIN catch
print('Rolled back Successfully.')
Rollback Transaction
END catch;












