--procedimiento almacenados
--CREATE PROCEDURE SP_UsuarioCantidad
--AS
--BEGIN
--    select nivel,count(nivel)as Cantidad,
--    round((count(nivel)*100)/(SELECT COUNT(*)
--    FROM Usuario),2)as Porcentaje
--    FROM Usuario
--    GROUP BY nivel
--END
----Ejecutar un procedimiento 
--EXEC SP_UsuarioCantidad	



--procedimiento Login
CREATE PROCEDURE SP_LoginUsuario
@pusuario varchar(50),
@ppassword varchar(50)
AS
BEGIN
BEGIN TRAN
BEGIN TRY
    select u.IdUsuario,e.Apellido,e.Nombre,
    u.Nombre as usuario,u.Nivel,u.Estado
    FROM Usuario as u
    INNER JOIN Empleado as e 
    ON
    u.IdEmpleado = e.IdEmpleado
    WHERE    u.Nombre = @pusuario AND u.Clave = @ppassword;
COMMIT
END TRY
BEGIN CATCH
ROLLBACK
END CATCH
END

--Ejecutar el SP Login
EXEC SP_LoginUsuario 'juanperez','contrasena123'
EXEC SP_LoginUsuario 'erodriguez','1234'
SELECT * FROM Empleado
SELECT * FROM Usuario



CREATE PROCEDURE SP_Asistencia_Empleado
	@buscar varchar(50)
AS
BEGIN
    SELECT A.IdAsistencia, E.Nombre AS Nombre, E.Apellido,A.FechaAsistencia, A.HoraEntrada, A.HoraSalida
    FROM Empleado AS E
    INNER JOIN Asistencia AS A ON A.IdEmpleado = E.IdEmpleado
    WHERE E.Nombre LIKE '%' + @buscar + '%' OR E.Apellido LIKE '%' + @buscar + '%'
END


EXEC SP_Asistencia_Empleado 'juan'--marca



	




