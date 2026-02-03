# Database Setup (SQL Server)

This project uses **Microsoft SQL Server** as the database engine.

---

## Setup Instructions

Execute the following SQL script in **SQL Server Management Studio (SSMS)**.

---

## Create Tables and Seed Data

```sql
-- Create table for car types
CREATE TABLE dbo.TypesOfCars (
    id INT IDENTITY(1,1) NOT NULL,
    name NVARCHAR(50) NOT NULL,
    CONSTRAINT PK_TypesOfCars PRIMARY KEY (id)
);

-- Insert initial car types
INSERT INTO dbo.TypesOfCars (name) VALUES
('Toyota'),
('Honda'),
('Ford'),
('BMW'),
('Hyundai');

-- Verify car types
SELECT * FROM dbo.TypesOfCars;

-- Create table for car rental records
CREATE TABLE dbo.CarRentalRecord (
    id INT IDENTITY(1,1) NOT NULL,
    CustomerName NVARCHAR(100) NOT NULL,
    DateRented DATETIME NOT NULL,
    DateReturned DATETIME NULL,
    Cost DECIMAL(10,2) NOT NULL,
    TypeOfCar INT NOT NULL,

    CONSTRAINT PK_CarRentalRecord PRIMARY KEY (id),
    CONSTRAINT FK_CarRentalRecord_TypesOfCars
        FOREIGN KEY (TypeOfCar)
        REFERENCES dbo.TypesOfCars(id)
);
