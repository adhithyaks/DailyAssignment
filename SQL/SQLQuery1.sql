create trigger empname on EmpId
after insert
as
select 'row created'


select * from EmpId

insert into EmpId(empid,empname,salary,gender) values(8,'raj',500000,'f');