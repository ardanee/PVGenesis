go
-- Procedimiento para insertar tabla marca
IF OBJECT_ID('DBPV.SpIuLinea', 'P') IS NOT NULL
	DROP PROCEDURE dbpv.SpIuLinea;
GO
CREATE PROCEDURE [dbo].[SpIuLinea]
	@PidLinea int,
	@Pnombre varchar(50),
	@Pusuario varchar(40),
	@PidMarca int
AS
BEGIN
	IF EXISTS(SELECT 1 FROM TblLinea WHERE idLinea = @PidLinea)
	BEGIN
		UPDATE TblLinea SET nombre = @Pnombre, usuarioModificacion =@Pusuario, idMarca = @PidMarca
		WHERE idLinea = @PidLinea
	END
	ELSE
	BEGIN
		INSERT TblLinea(nombre,usuarioCreacion,idMarca)
		VALUES(@Pnombre,@Pusuario,@pidMarca)
	END
END;
go



 go
-- Procedimiento para seleccionar tabla marca
IF OBJECT_ID('DBPV.SpsLinea', 'P') IS NOT NULL
	DROP PROCEDURE dbpv.SpsMarca;
GO
CREATE PROCEDURE [dbo].[SpsLinea]
	@Pcriterio varchar(50)
AS
BEGIN
 SELECT tbLinea.idLinea as idLinea, tbMarca.nombre as marca, tbLinea.nombre as linea, tbMarca.idMarca as idMarca
 FROM TblLinea as tbLinea
 JOIN TblMarca as tbMarca
 ON tbLinea.idMarca = tbMarca.idMarca
 WHERE tbLinea.nombre LIKE '%'+ISNULL(@Pcriterio,tbLinea.nombre)+'%' order by tbLinea.nombre ASC
END;
go
 
 
 
 go
-- PROCEDIMIENTO PARA ELIMINAR  TABLA MARCA
CREATE PROCEDURE [DBO].[SpdLinea]
	@PidLinea int
AS
BEGIN
--Verifica si hay vehículos relacionados con el actual registro antes de borrar
	IF EXISTS(SELECT 1 FROM TblVehiculo WHERE idLinea= @PidLinea)
	BEGIN
		RAISERROR ('No se puede eliminar porque actualmente hay vehículos que tienen asignado este tipo',16,1);
	END
	ELSE
	BEGIN
		DELETE TblLinea WHERE idLinea = @PidLinea
	END
END;
go
