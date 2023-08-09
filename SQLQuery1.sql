CREATE DATABASE tutorial;
use tutorial;
CREATE TABLE form
(
userid INT PRIMARY KEY,
Name VARCHAR(25),
DOB  DATE,
age VARCHAR(3),
gender VARCHAR(10),
mobile VARCHAR(10),
email varchar(25),
address varchar(50),
state varchar (25),
city varchar(25),
password varchar(10)
);
use tutorial;
INSERT INTO form(userid)VALUES(1);
select * FROM form;
