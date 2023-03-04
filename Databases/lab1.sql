create database FishFarm


CREATE TABLE Fish
(Fid INT PRIMARY KEY IDENTITY,
Species varchar(50) DEFAULT 'Salmon',
)

CREATE TABLE Salary(
 SAid INT PRIMARY KEY,
 Amount INT UNIQUE NOT NULL,
 Bonus varchar(50),
)
DROP TABLE Salary
CREATE TABLE FishTanks(
 FTid INT PRIMARY KEY,
 Name varchar(50) NOT NULL,
 Quantity INT NOT NULL,
 No_Of_Fish INT,
)

CREATE TABLE Farms(
 FAid INT PRIMARY KEY IDENTITY,
 Name varchar(50) NOT NULL,
 City varchar(50) NOT NULL,
 No_Of_Employees INT,

)

CREATE TABLE FishInFishTanks(
 Fid INT FOREIGN KEY REFERENCES Fish(Fid) NOT NULL,
 FTid INT FOREIGN KEY REFERENCES FishTanks(FTid) NOT NULL,
 CONSTRAINT pk_Fish PRIMARY KEY (Fid, FTid)
)

CREATE TABLE Orders(
Oid INT PRIMARY KEY IDENTITY,
Fish_Quantity INT NOT NULL,
Price INT NOT NULL,
Fid INT FOREIGN KEY REFERENCES Fish(Fid)
)


CREATE TABLE Lakes(
Lid INT PRIMARY KEY IDENTITY,
Name varchar(50) NOT NULL,
City varchar(50) NOT NULL,
No_Of_Fishermen INT
)

CREATE TABLE FishInLakes(
 Fid INT FOREIGN KEY REFERENCES Fish(Fid) NOT NULL,
 Lid INT FOREIGN KEY REFERENCES Lakes(Lid) NOT NULL,
 filAmount INT,
 CONSTRAINT pk_FishInLakes PRIMARY KEY (Fid, Lid)
)
DROP TABLE FishInLakes

CREATE TABLE Fishermen(
FMid INT PRIMARY KEY IDENTITY NOT NULL,
FMName varchar(50) NOT NULL,
Supply INT NOT NULL,
SAid INT FOREIGN KEY REFERENCES Salary(SAid),
Lid INT FOREIGN KEY REFERENCES Lakes(Lid)
)
DROP TABLE Fishermen

CREATE TABLE Employee(
Eid INT PRIMARY KEY IDENTITY,
FAid INT REFERENCES Farms(FAid),
Name varchar(50) NOT NULL,
City varchar(50) NOT NULL,
Experience INT NOT NULL,
SAid INT REFERENCES Salary(SAid)
)
DROP TABLE Employee
CREATE TABLE Clients(
Cid INT FOREIGN KEY REFERENCES Orders(Oid),
Name varchar(50) NOT NULL,
Fidelity_Points INT,
CONSTRAINT pk_Clients PRIMARY KEY(Cid)
)

DROP DATABASE FishFarm