--Activar la Base de Datos
USE db_Asistencia
GO

-- Registro para la tabla Empleado
INSERT INTO Empleado (Dni, Nombre, Apellido, Email, Celular, Direccion, Estado)
VALUES ('12345678', 'Juan', 'Perez', 'juanperez@example.com', '1234567890', 'Calle Principal 123', 'A')
INSERT INTO Empleado (Dni, Nombre, Apellido, Email, Celular, Direccion, Estado)
values ('12345618','Enrique','Lanchipa Valencia','elanchipa@upt.pe','952364852','Av. Bolognesi 15847','A')
INSERT INTO Empleado (Dni, Nombre, Apellido, Email, Celular, Direccion, Estado)
values ('22445566','Elard','Rodriguez Marca','erodriguez@virtual.upt.pe','970154895','Calle Deustua S/N','A')
INSERT INTO Empleado (Dni, Nombre, Apellido, Email, Celular, Direccion, Estado)
values ('12378925','Liliana','Vega Bernal','lvega@gmail.com','9985254852','AV. Capanique 18545','A')

-- Registro para la tabla Asistencia
INSERT INTO Asistencia (IdEmpleado, Nombre, FechaAsistencia, HoraEntrada, HoraSalida)
VALUES (1, 'Juan Perez', '2023-06-25', '08:00:00', '17:00:00')

-- Registro para la tabla Usuario
INSERT INTO Usuario (IdEmpleado, Nombre, Clave, Nivel, Estado)
VALUES (1, 'juanperez', 'contrasena123', 'admin', 1)
INSERT INTO Usuario (IdEmpleado, Nombre, Clave, Nivel, Estado)
VALUES (2, 'Juanmamani', '321654123', 'usuario',1)
-- Registro para la tabla Horarios
INSERT INTO Usuario (IdEmpleado, Nombre, Clave, Nivel, Estado)
VALUES (2, 'luisardo', '123654123', 'usuario',1)

-- Registro para la tabla Puestos
INSERT INTO Puestos (NombrePuesto, Descripcion)
VALUES ('Desarrollador de Software', 'Responsable del desarrollo de software y aplicaciones')

-- Registro para la tabla Departamentos
INSERT INTO Departamentos (NombreDepartamento, Descripcion)
VALUES ('Tecnología', 'Departamento encargado de la infraestructura tecnológica')



--Listar todos los registros de las tablas
SELECT * FROM Empleado
GO
SELECT * FROM Asistencia
GO
select * from Usuario
go
select * from Horarios
go
select * from Puestos
go
select * from Departamentos
go
