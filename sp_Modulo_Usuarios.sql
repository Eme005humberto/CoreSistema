USE [DbCore]
--PROCEDIMIENTO ALMACENADO PARA AGREGAR USUARIOS
CREATE PROCEDURE SP_AGREGAR_USUARIOS
@NombreCompleto VARCHAR(100),
@DUI VARCHAR(12),
@Usuario VARCHAR(100),
@Clave VARCHAR(100),
@Telefono VARCHAR(11),
@IdCargo INT,
@Activo BIT
AS BEGIN
IF EXISTS (SELECT 1 FROM USUARIOS WHERE Usuario = @Usuario AND Clave = @Clave)
BEGIN
   SELECT 0 AS Resultado,
         'El usuario ya existe' AS Mensaje;
   RETURN;
END
INSERT INTO USUARIOS(NombreCompleto,DUI,Usuario,Clave,Telefono,IdCargo,Activo)
VALUES(@NombreCompleto,@DUI,@Usuario,@Clave,@Telefono,@IdCargo,@Activo)
END

CREATE PROCEDURE SP_ACTUALIZAR_USUARIOS
@IdUsuario INT,
@NombreCompleto VARCHAR(100),
@DUI VARCHAR(12),
@Usuario VARCHAR(100),
@Clave VARCHAR(100),
@Telefono VARCHAR(11),
@IdCargo INT,
@Activo BIT
AS BEGIN
IF EXISTS (SELECT 1 FROM USUARIOS WHERE IdUsuario = @IdUsuario)
BEGIN
    UPDATE USUARIOS SET NombreCompleto = @NombreCompleto, DUI = @DUI , Usuario = @Usuario , Clave = @Clave ,
	Telefono = @Telefono , IdCargo = @IdCargo , Activo = @Activo WHERE IdUsuario = @IdUsuario
END
END

CREATE PROCEDURE SP_ELIMINAR_USUARIOS
@IdUsuario INT
AS BEGIN
DELETE FROM USUARIOS WHERE IdUsuario = @IdUsuario
END