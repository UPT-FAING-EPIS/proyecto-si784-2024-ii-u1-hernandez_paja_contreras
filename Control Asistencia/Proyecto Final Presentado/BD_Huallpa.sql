-- Crear Base de Datos
CREATE DATABASE db_Asistencia
GO
--Poner Activa la Base de Datos
USE db_Asistencia
GO
-- Crear Tablas

-- Tabla Empleado
IF (NOT EXISTS (SELECT 1 FROM sys.tables WHERE NAME = 'Empleado'))
CREATE TABLE Empleado(
	IdEmpleado int identity(1,1) NOT NULL PRIMARY KEY,
	Dni char(8) NOT NULL UNIQUE,
	Nombre varchar(100) NOT NULL,
	Apellido varchar(150) NOT NULL,
	Email varchar(100) NOT NULL UNIQUE,
	Celular varchar(11) NOT NULL,
	Direccion text NULL,
	Estado char(1) NOT NULL
)
GO
-- Tabla Usuario
IF (NOT EXISTS (SELECT 1 FROM sys.tables WHERE NAME = 'Asistencia'))
CREATE TABLE Asistencia(
	IdAsistencia int identity(1,1) NOT NULL PRIMARY KEY,
	IdEmpleado int NOT NULL,
	Nombre varchar(30) NOT NULL UNIQUE,
	FechaAsistencia DATE,
    HoraEntrada TIME,
    HoraSalida TIME
	FOREIGN KEY (IdEmpleado) REFERENCES Empleado
)
GO
-- Tabla Usuario
IF (NOT EXISTS (SELECT 1 FROM sys.tables WHERE NAME = 'Usuario'))
CREATE TABLE Usuario(
	IdUsuario int identity(1,1) NOT NULL PRIMARY KEY,
	IdEmpleado int NOT NULL,
	Nombre varchar(30) NOT NULL UNIQUE,
	Clave varchar(100) NOT NULL,
	Nivel varchar(15) NOT NULL,
	Estado int NOT NULL
	FOREIGN KEY (IdEmpleado) REFERENCES Empleado
)
GO

-- Tabla Categoria
IF (NOT EXISTS (SELECT 1 FROM sys.tables WHERE NAME = 'Horarios'))
CREATE TABLE Horarios(
	IdHorario int identity(1,1) NOT NULL PRIMARY KEY, --AUTOINCREMENTABLE
	IdEmpleado int NOT NULL,
	FechaInicio DATE,
    FechaFin DATE,
    HoraEntrada TIME,
    HoraSalida TIME,
	FOREIGN KEY(IdEmpleado) REFERENCES Empleado
)
GO

--DROP TABLE Categoria

--1 Tabla Producto
IF (NOT EXISTS (SELECT 1 FROM sys.tables WHERE NAME = 'Puestos'))
CREATE TABLE Puestos
(
	IdPuesto int identity(1,1) NOT NULL,
	NombrePuesto VARCHAR(50),
    Descripcion VARCHAR(100)
	PRIMARY KEY (IdPuesto)
)
GO

-- Tabla Pedido
IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE NAME = 'Departamentos')
CREATE TABLE Departamentos(
    IdDepartamento int identity(1,1) NOT NULL,
    NombreDepartamento VARCHAR(50),
    Descripcion VARCHAR(100),
    PRIMARY KEY(IdDepartamento)
)
GO

