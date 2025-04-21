JUAN SEBASTIAN MEJIA GOMEZ
S4AN




Creación de las tablas que se usaran en este proyecto



USE Supermarket;

CREATE TABLE Categories
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    name CHAR(50) NOT NULL,
    description CHAR(100) NOT NULL
);
GO

INSERT INTO Categories (name, description) VALUES ('Lácteos', 'Productos derivados de la leche');
INSERT INTO Categories (name, description) VALUES ('Panadería', 'Productos de pan y repostería');


//se debe de crear primero esta tabla para poder crear la tabla "Products" ya que esta ultima la referencia para crear la llave foránea 



USE Supermarket;

CREATE TABLE Products
(
    id INT IDENTITY(100000,1) PRIMARY KEY,
    name NVARCHAR(50) NOT NULL,
    price INT NOT NULL,
    stock INT NOT NULL,
    category_id INT NOT NULL,
    FOREIGN KEY (category_id) REFERENCES Categories(id)
)
go

INSERT INTO Products (name, price, stock, category_id) VALUES ('Leche', 4000, 20, 100000);
INSERT INTO Products (name, price, stock, category_id) VALUES ('Pan', 1500, 30, 100001);






USE Supermarket;

CREATE TABLE Customers
(
    customer_id INT IDENTITY(100000,1) PRIMARY KEY,
    document_number NVARCHAR(20) NOT NULL,
    first_name NVARCHAR(50) NOT NULL,
    last_name NVARCHAR(50) NOT NULL,
    address NVARCHAR(100) NOT NULL,
    birthday DATE NOT NULL,
    phone_number NVARCHAR(20) NOT NULL,
    email NVARCHAR(100) NOT NULL
);
GO

INSERT INTO Customers 
VALUES
('123456789', 'Juan', 'Mejía', 'Calle 123 #45-67', '1998-04-18', '3101234567', 'juan@email.com'),
('987654321', 'Laura', 'Gómez', 'Carrera 9 #12-34', '2000-08-15', '3209876543', 'laura@email.com');