/*-- Создание базы данных
CREATE DATABASE CafeDB;
GO
*/
-- Использование созданной базы данных
USE CafeDB;
GO
/*
-- Создание таблицы Dishes (блюда)
CREATE TABLE Dishes (
    DishID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(40) NOT NULL,
    Type NVARCHAR(30) NOT NULL,
    MenuPrice DECIMAL(10,2) NOT NULL DEFAULT 0,
    OutputAmount INT DEFAULT 0,
    Units NVARCHAR(4) CHECK (Units IN ('g.', 'ml.', 'st.')),
    Available BIT,
    Composition TEXT,
    Photo IMAGE
);
GO

-- Создание таблицы Workers (сотрудники)
CREATE TABLE Workers (
    WorkerID INT IDENTITY(1,1) PRIMARY KEY,
    LastName NVARCHAR(30) NOT NULL,
    FirstName NVARCHAR(30) NOT NULL,
    MiddleName NVARCHAR(30),
    Position NVARCHAR(30) NOT NULL,
    Gender NVARCHAR(10) CHECK (Gender IN ('male', 'female')),
    MaritalStatus NVARCHAR(20) CHECK (MaritalStatus IN ('married', 'in marriage', 'single', 'not married')),
    Children NVARCHAR(15) CHECK (Children IN ('yes', 'no'))
);
GO

-- Создание таблицы Sales (продажи)
CREATE TABLE Sales (
    SaleID INT IDENTITY(1,1) PRIMARY KEY,
    SaleDate DATETIME,
    WorkerID INT FOREIGN KEY REFERENCES Workers(WorkerID) NOT NULL,
    TableNumber NVARCHAR(10)
);
GO

-- Создание таблицы DishSale (продано)
CREATE TABLE DishSale (
    SaleID INT,
    DishID INT,
    Quantity INT NOT NULL DEFAULT 1,
    Price DECIMAL(10,2) NOT NULL DEFAULT 0,
    Discount DECIMAL(5,2) NOT NULL DEFAULT 0,
    PRIMARY KEY (SaleID, DishID),
    FOREIGN KEY (SaleID) REFERENCES Sales(SaleID),
    FOREIGN KEY (DishID) REFERENCES Dishes(DishID)
);
GO
*/

/*
INSERT INTO Dishes (Name, Type, MenuPrice, OutputAmount, Units, Available, Composition, Photo)
VALUES 
('Borsch', 'Soups', 5.99, 1, 'g.', 1, 'Potatoes, beets, meat', (SELECT BulkColumn FROM OPENROWSET(BULK 'C:\Users\ASUS\Downloads\kartinki-borshh-21.jpg', SINGLE_BLOB) as img)),
('Pizza', 'Pizzas', 12.99, 1, 'g.', 1, 'Dough, cheese, tomatoes', (SELECT BulkColumn FROM OPENROWSET(BULK 'C:\Users\ASUS\Downloads\pizzad2.jpg', SINGLE_BLOB) as img)),
('Caesar Salad', 'Salads', 8.99, 1, 'g.', 1, 'Chicken, lettuce leaves, parmesan, sauce', (SELECT BulkColumn FROM OPENROWSET(BULK 'C:\Users\ASUS\Downloads\salata-tsezar-s-kurits-2.jpg', SINGLE_BLOB) as img)),
('Pasta Carbonara', 'Pastas', 10.99, 1, 'g.', 1, 'Spaghetti, bacon, eggs, cream, cheese', (SELECT BulkColumn FROM OPENROWSET(BULK 'C:\Users\ASUS\Downloads\bcOZHdvHU8A.jpg', SINGLE_BLOB) as img)),
('Sushi with Salmon', 'Sushi and Rolls', 15.99, 1, 'st.', 1, 'Rice, salmon', (SELECT BulkColumn FROM OPENROWSET(BULK 'C:\Users\ASUS\Downloads\convert.jpg', SINGLE_BLOB) as img)),
('Steak', 'Hot Dishes', 20.99, 1, 'g.', 1, 'Beef, spices', (SELECT BulkColumn FROM OPENROWSET(BULK 'C:\Users\ASUS\Downloads\1660804014_6-6.jpg', SINGLE_BLOB) as img)),
('Cheesecake', 'Desserts', 7.99, 1, 'g.', 1, 'Cottage cheese, eggs, sugar', (SELECT BulkColumn FROM OPENROWSET(BULK 'C:\Users\ASUS\Downloads\1694490294_3-22.jpg', SINGLE_BLOB) as img));
*/


/*
INSERT INTO Workers (LastName, FirstName, MiddleName, Position, Gender, MaritalStatus, Children)
VALUES 
('Smith', 'John', 'David', 'Waiter', 'male', 'married', 'yes'),
('Johnson', 'Emily', 'Anne', 'Chef', 'female', 'single', 'no'),
('Williams', 'Michael', 'Lee', 'Bartender', 'male', 'in marriage', 'yes'),
('Jones', 'Jessica', 'Nicole', 'Manager', 'female', 'single', 'no'),
('Brown', 'Christopher', 'Thomas', 'Cook', 'male', 'not married', 'no'),
('Davis', 'Sarah', 'Elizabeth', 'Hostess', 'female', 'married', 'yes');
*/

/*
INSERT INTO Sales (SaleDate, WorkerID, TableNumber)
VALUES 
('2024-03-22 08:30:00', 1, 'Table 1'),
('2024-03-22 12:15:00', 2, 'Table 3'),
('2024-03-22 13:45:00', 3, 'Table 2'),
('2024-03-22 17:30:00', 1, 'Table 5'),
('2024-03-22 19:00:00', 4, 'Table 4'),
('2024-03-22 20:45:00', 5, 'Table 6');
*/


/*
INSERT INTO DishSale (SaleID, DishID, Quantity, Price, Discount)
VALUES 
(1, 7, 1, 5.99, 0),
(2, 8, 1, 12.99, 0),
(3, 9, 1, 8.99, 0),
(4, 10, 1, 10.99, 0),
(5, 11, 1, 15.99, 0),
(6, 12, 1, 20.99, 0);
*/