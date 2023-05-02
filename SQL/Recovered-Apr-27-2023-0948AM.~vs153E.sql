CREATE OR ALTER PROCEDURE sp_EmpId
@empid int,@sal money output
as
begin
select @sal = salary from EmpId where EmpId=@empid
end
