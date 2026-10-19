USE [DbCore]
ALTER PROCEDURE SP_AGREGAR_PRODUCTOS(
@Producto VARCHAR(50),
@Stock INT,
@IdCategoria INT,
@Precio DECIMAL(18,2)
)AS BEGIN
INSERT INTO PRODUCTOS(Producto,Stock,IdCategoria,Precio)
VALUES(@Producto,@Stock,@IdCategoria,@Precio)
END

ALTER PROCEDURE SP_ACTUALIZAR_PRODUCTOS(
@IdProducto INT,
@Producto VARCHAR(50),
@Stock INT,
@IdCategoria INT,
@Precio DECIMAL(18,2)
)AS BEGIN
UPDATE PRODUCTOS SET Producto = @Producto , Stock = @Stock , IdCategoria = @IdCategoria , Precio = @Precio
WHERE IdProducto = @IdProducto
END

ALTER PROCEDURE SP_ELIMINAR_PRODUCTOS
@IdProducto INT
AS BEGIN
 UPDATE PRODUCTOS
    SET Activo = 0
    WHERE IdProducto = @IdProducto;
END