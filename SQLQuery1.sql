﻿create table tblMain
(
MainID int Primary key identity,
aDate date,
Time Varchar(15),
TableName varchar(10),
WaiterName varchar(15),
status varchar(15),
orderType varchar(15),
total float,
received float,
change float

)

Create table tblDetails
(
DetailID int Primary key identity,
MainID int,
proID int,
qty int,
price float,
amount float

)