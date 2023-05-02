create table SALESMANMASTER(salesmanno varchar(6),salesmanname varchar(20),address1 varchar(30),
address2 varchar(30),city varchar(20),pincode int,state varchar(20),salamt int,tgttoget int,
ytdsales int,remarks varchar(60));

create table SALESORDER(orderno varchar(6),clientno varchar(6),orderdate date,delyaddr varchar(25),
salesmanno varchar(6),delytype varchar(1),billedyn varchar(1),delydate date,orderstatus varchar(10));

create table SALESORDERDETAILS(orderno varchar(6),productno varchar(6),qtyordered int,qtydisp int,productrate int);