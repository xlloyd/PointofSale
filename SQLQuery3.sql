﻿CREATE TABLE products
(
    pID int primary key identity,
    pName varchar(50),
    pPrice float,
    CategoryID int,
    pImage image
)

