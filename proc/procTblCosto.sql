
GO
-- PROCEDIMIENTO UTILIZADO PARA SELECCIONAR LOS COSTOS DE UN VEHICULO EN ESPECIFICO
CREATE PROCEDURE [dbo].[SpSCostoVehiculo]
	@PidVehiculo varchar(50)
As
BEGIN
	SELECT costoVeh.idCostoVehiculo as id, costoVeh.etiquetaCosto as tag, tipoCosto.nombre as tipoCosto,
	monto, costoVeh.observaciones, tipoCosto.idTipoCosto 
	FROM TblCostoVehiculo as costoVeh, TblTipoCosto tipoCosto 
	WHERE 
	costoVeh.idTipoCosto = tipoCosto.idTipoCosto and
	idVehiculo = @PidVehiculo
END;	
GO