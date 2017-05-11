go
-- Procedimiento para insertar tabla marca
CREATE PROCEDURE [dbo].[SpIuMarca]
	@PidMarca int,
	@Pnombre varchar(50),
	@Pusuario varchar(40)
AS
BEGIN
	IF EXISTS(SELECT 1 FROM TblMarca WHERE idMarca = @PidMarca)
	BEGIN
		UPDATE TblMarca SET nombre = @Pnombre, usuarioModificacion =@Pusuario
		WHERE idMarca = @PidMarca
	END
	ELSE
	BEGIN
		INSERT TblMarca(nombre,usuarioCreacion)
		VALUES(@Pnombre,@Pusuario)
	END
END;
go


go
-- Procedimiento para seleccionar tabla marca

create PROCEDURE [dbo].[SpsMarca]
	@Pcriterio varchar(50)
AS
BEGIN
SELECT idMarca,nombre
	FROM TblMarca
	WHERE nombre like '%'+ISNULL(@Pcriterio,nombre)+'%' order by nombre ASC
END;
go
 
 
 
 go
-- PROCEDIMIENTO PARA ELIMINAR  TABLA MARCA
CREATE PROCEDURE [DBO].[SpdMarca]
	@PidMarca int
AS
BEGIN
--Verifica si hay vehículos relacionados con el actual registro antes de borrar
	IF EXISTS(SELECT 1 FROM TblVehiculo WHERE idMarca= @PidMarca)
	BEGIN
		RAISERROR ('No se puede eliminar porque actualmente hay vehículos que tienen asignado esta marca',16,1);
	END
	ELSE
	BEGIN
		DELETE Tblmarca WHERE idMarca = @PidMarca
	END
END;
go
