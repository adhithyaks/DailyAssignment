create table JOBS(job_id int not null primary key,
job_title varchar(20),
min_salary money,
max_salary money);


create table DEPARTMENTS(department_id int not null primary key,
department_name varchar(10),
manager_id int,location_id int);





create table EMPLOYEES (employee_id int not null primary key,
first_name varchar(10),
last_name varchar(10),
email varchar(20),
phone_number int,
hire_date date,
job_id int ,
salary money,
commission_pct money,
manager_id int ,
department_id int
foreign key(job_id)references Jobs(job_id),foreign key(manager_id)references employees(employee_id),
foreign key(department_id)references DEPARTMENTS(department_id));
;













create table LOCATIONS(location_id int ,
street_address varchar(50),
postal_code int,
city varchar(20),
state_province varchar(10),
country_id int);





create table JOB_HISTORY(employee_id int,start_date date,
end_date date,job_id int,department_id int);







create table Countries(county_id int,
country_name varchar(10),
region_id int);

create table Regions(region_id int,
region_name varchar(20));
