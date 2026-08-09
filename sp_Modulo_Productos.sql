CREATE PROCEDURE SP_AGREGAR_PRODUCTOS(
@Producto VARCHAR(50),
@Stock INT,
@IdCategoria INT
)AS BEGIN
INSERT INTO PRODUCTOS(Producto,Stock,IdCategoria)
VALUES(@Producto,@Stock,@IdCategoria)
END

CREATE PROCEDURE SP_ACTUALIZAR_PRODUCTOS(
@IdProducto INT,
@Producto VARCHAR(50),
@Stock INT,
@IdCategoria INT
)AS BEGIN
UPDATE PRODUCTOS SET Producto = @Producto , Stock = @Stock , IdCategoria = @IdCategoria 
WHERE IdProducto = @IdProducto
END

CREATE PROCEDURE SP_ELIMINAR_PRODUCTOS
@IdProducto INT
AS BEGIN
DELETE FROM PRODUCTOS WHERE IdProducto = @IdProducto
END