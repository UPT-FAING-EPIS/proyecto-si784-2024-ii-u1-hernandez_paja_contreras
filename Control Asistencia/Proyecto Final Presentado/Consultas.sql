USE db_Asistencia
GO

-- Crear vista V_Empleados
CREATE VIEW V_Empleados
AS
SELECT *
FROM Empleado
GO

-- Crear vista V_Asistencias
CREATE VIEW V_Asistencias
AS
SELECT a.IdAsistencia, e.Nombre, a.FechaAsistencia, a.HoraEntrada, a.HoraSalida
FROM Asistencia AS a
INNER JOIN Empleado AS e
ON a.IdEmpleado = e.IdEmpleado
GO

-- Ejecutar consulta en vista V_Empleados
SELECT * FROM V_Empleados

-- Ejecutar consulta en vista V_Asistencias
SELECT * FROM V_Asistencias