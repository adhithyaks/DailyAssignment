DECLARE @empid INT
DECLARE @salary INT
DECLARE @grandsalary INT

SET @grandsalary = 0

DECLARE emp_cursor CURSOR FOR 
SELECT empid, salary FROM Emp

OPEN emp_cursor

FETCH NEXT FROM emp_cursor INTO @empid, @salary

WHILE @@FETCH_STATUS = 0
BEGIN
  SET @grandsalary = @grandsalary + @salary
  FETCH NEXT FROM emp_cursor INTO @empid, @salary
END

CLOSE emp_cursor
DEALLOCATE emp_cursor

SELECT @grandsalary as GrandSalary

select * from EmpId;

create table Emp(empid int,
salary int);

select * from Emp;

