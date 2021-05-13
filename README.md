"# Cuidado-con-el-perro-.NET" 

Script BD Sql-server

CREATE DATABASE CuidadoConElPerro;
GO

-- En caso de borrar y que no deje
--USE master;
--GO
--ALTER DATABASE CuidadoConElPerro SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
--GO

--DROP DATABASE CuidadoConElPerro;

USE CuidadoConElPerro;
GO

CREATE TABLE Departamento
(
Id_Departamento INT IDENTITY PRIMARY KEY,
Nombre_Departamento VARCHAR(20)
);
GO

CREATE TABLE Talla
(
Id_Talla INT IDENTITY PRIMARY KEY,
Nombre_Talla VARCHAR(10),
Descripcion VARCHAR(100)
);
GO

CREATE TABLE Proovedor
(
Id_Proovedor INT IDENTITY PRIMARY KEY,
Nombre_Proovedor VARCHAR(20),
Telefono VARCHAR(12),
CHECK (Telefono LIKE '[0-9][0-9][0-9]-[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]')
);
GO

CREATE TABLE Prenda
(
Id_Prenda INT IDENTITY PRIMARY KEY,
Nombre_Prenda VARCHAR(100),
Genero VARCHAR(10),
Precio Money,
Cantidad INT,
Imagen IMAGE,
Descripcion VARCHAR(500),
Id_Talla INT,
Id_Departamento INT,
Id_Proovedor INT,
CONSTRAINT fk_Talla FOREIGN KEY (Id_Talla) REFERENCES Talla(Id_Talla),
CONSTRAINT fk_Departamento FOREIGN KEY (Id_Departamento) REFERENCES Departamento(Id_Departamento),
CONSTRAINT fk_Proovedor FOREIGN KEY (Id_Proovedor) REFERENCES Proovedor(Id_Proovedor)
);
GO

CREATE TABLE MetodoPago
(
Id_MetodoPago INT IDENTITY PRIMARY KEY,
Nombre VARCHAR(20)
);
GO

CREATE TABLE Rol
(
Id_Rol INT IDENTITY PRIMARY KEY,
Usuario VARCHAR(15)
);
GO

CREATE TABLE Empleado
(
Id_Empleado INT IDENTITY PRIMARY KEY,
Nombre_Empleado VARCHAR(100),
Usuario VARCHAR(50),
Contrasenia VARCHAR(8),
Imagen IMAGE,
Id_Rol int,
CONSTRAINT fk_Rol FOREIGN KEY (Id_Rol) REFERENCES Rol(Id_Rol),
CHECK (Contrasenia LIKE '[A-Za-z$0-9@][A-Za-z$0-9@][A-Za-z$0-9@][A-Za-z$0-9@][A-Za-z$0-9@][A-Za-z$0-9@]'),
);
GO

CREATE TABLE Domicilio
(
Id_Domicilio INT IDENTITY PRIMARY KEY,
Calle VARCHAR(50),
Estado VARCHAR(50),
Ciudad VARCHAR(50),
NumeroExt INT,
NumeroInt INT,
Pais VARCHAR(50),
CodigoPostal VARCHAR(5),
);
GO


-- ------------------------------------------------------------------

CREATE TABLE Cliente
(
ID_Cliente INT IDENTITY PRIMARY KEY,
Nom_Cliente VARCHAR(30),
Contrasenia VARCHAR(30),
Imagen IMAGE,
Telefono VARCHAR(12),
Id_Domicilio INT,
CONSTRAINT fk_Domicilio FOREIGN KEY (Id_Domicilio) REFERENCES Domicilio(Id_Domicilio),
CHECK (Telefono LIKE '[0-9][0-9][0-9]-[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'),
);
GO

CREATE TABLE Carrito
(
Id_Carrito INT IDENTITY PRIMARY KEY,
Id_Cliente INT,
Id_Prenda INT,
Cantidad INT,
CONSTRAINT fk_Prenda FOREIGN KEY (Id_Prenda) REFERENCES Prenda(Id_Prenda),
CONSTRAINT fk_Cliente FOREIGN KEY (Id_Cliente) REFERENCES Cliente(Id_Cliente)
);
GO

CREATE TABLE Orden
(
Id_Orden INT IDENTITY PRIMARY KEY,
Id_Cliente INT,
Id_MetodoPago INT,
Id_Carrito INT,
Total MONEY,
Fecha_Hora DATETIME,
CONSTRAINT fk_Cliente2 FOREIGN KEY (Id_Cliente) REFERENCES Cliente(Id_Cliente),
CONSTRAINT fk_MetodoPago FOREIGN KEY (Id_MetodoPago) REFERENCES MetodoPago(Id_MetodoPago),
CONSTRAINT fk_Carrito FOREIGN KEY (Id_Carrito) REFERENCES Carrito(Id_Carrito)
);
GO



-- ------------------------------------------------------------------

-- En caso de generar un diagrama y no deje

--ALTER DATABASE CuidadoConElPerro set TRUSTWORTHY ON; 
--GO 
--EXEC dbo.sp_changedbowner @loginame = N'sa', @map = false 
--GO 
--sp_configure 'show advanced options', 1; 
--GO 
--RECONFIGURE; 
--GO 
--sp_configure 'clr enabled', 1; 
--GO 
--RECONFIGURE; 
--GO
