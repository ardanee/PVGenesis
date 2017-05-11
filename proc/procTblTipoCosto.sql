


GO
-- PROCEDIMIENTO PARA INSERTAR EN TABLE TIPO COSTO
CREATE PROCEDURE [dbo].[SpIuTipoCosto]
	@PidTipoCosto int,
	@Pnombre varchar(50),
	@Pusuario varchar(40)
AS
BEGIN
	IF EXISTS(SELECT 1 FROM TblTipoCosto WHERE idTipoCosto = @PidTipoCosto)
	BEGIN
		UPDATE TblTipoCosto SET nombre = @Pnombre, usuarioModificacion =@Pusuario
		WHERE idTipoCosto = @PidTipoCosto
	END
	ELSE
	BEGIN
		INSERT TblTipoCosto(nombre,usuarioCreacion)
		VALUES(@Pnombre,@Pusuario)
	END
END;
GO


GO
-- procedimiento para seleccionar registros de la tabla TipoCostos
CREATE PROCEDURE [dbo].[SpStipoTipoCosto]
	@Pcriterio varchar(50)
AS
BEGIN
SELECT idTipoCosto,nombre
	FROM TblTipoCosto
	WHERE nombre like '%'+ISNULL(@Pcriterio,nombre)+'%' order by nombre ASC
END;
GO


GO
-- PROCEDIMIENTO PARA ELIMINAR  TABLA tipo costo
CREATE PROCEDURE [DBO].[SpdTipoCosto]
	@PidTipoCosto int
AS
BEGIN
--Verifica si hay vehículos relacionados con el actual registro antes de borrar
	IF EXISTS(SELECT 1 FROM TblCostoVehiculo WHERE idTipoCosto= @PidTipoCosto)
	BEGIN
		RAISERROR ('No se puede eliminar porque actualmente hay costos que tienen asignado este tipo',16,1);
	END
	ELSE
	BEGIN
		DELETE TblTipoCosto WHERE idTipoCosto = @PidTipoCosto
	END
END;
GO


