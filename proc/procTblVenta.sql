

EXEC SpsVenta @PCRITERIO =''
GO
-- VENTAS REALIZADAS
ALTER procedure SpsVenta
	@PCriterio varchar(40)
AS
BEGIN
	select venta.idVenta as idVenta,
	 venta.fechaCreacion as fecha, 
	 venta.valorVenta as montoVenta, 
	 cliente.nombre as cliente,
	 venta.rutaDocumento1 as adjunto1, venta.rutaDocumento2 as adjunto2,
	 (tipoV.nombre + ', ' + marca.nombre + ', ' + linea.nombre + ', '+ cast(vehiculo.modelo as varchar(6)) +', cc: '+ isnull(vehiculo.cc,0) + ', '+ vehiculo.color) as descripcion,
	 CASE
		WHEN venta.cantidadCuotas > 0
		THEN 'Crédito'
		ELSE 'Contado'
	END as FORMA
	 from tblVenta as venta
	 inner join TblCliente as cliente
	 on venta.dpi = cliente.dpi
	 INNER JOIN TblVehiculo as vehiculo
	 ON vehiculo.idVehiculo = venta.idVehiculo
	 INNER JOIN TblTipoVehiculo tipoV
	ON tipoV.idTipoVehiculo = vehiculo.idTipoVehiculo
	INNER JOIN TblMarca marca
	ON marca.idMarca = vehiculo.idMarca
	INNER JOIN TblLinea linea
	ON linea.idLinea = vehiculo.idLinea
	WHERE venta.dpi = cliente.dpi and (
	venta.fechaCreacion LIKE '%'+ISNULL(@Pcriterio,venta.fechaCreacion)+'%' OR
	venta.idVenta LIKE '%'+ISNULL(@Pcriterio,venta.idVenta)+'%' OR
	venta.dpi LIKE '%'+ISNULL(@Pcriterio,venta.dpi)+'%' OR
	venta.diaPago LIKE '%'+ISNULL(@Pcriterio,venta.diaPago)+'%' OR
	venta.idVehiculo LIKE '%'+ISNULL(@Pcriterio,venta.idVehiculo)+'%')
END;
GO


GO
select * from TblVenta
-- Procedimeiento para agregar una venta
ALTER PROCEDURE [dbo]. SpIuVenta
@PidVenta int,
@PidVehiculo int,
@PvalorVenta decimal(18,2),
@Penganche decimal(18,2),
@PcantidadCuotas int,
@PCuota decimal(18,2),
@PdiaPago int,
@Pr1Nombre varchar(50),@Pr1Telefono varchar(50),@Pr1Direccion varchar(50),
@Pr2Nombre varchar(50),@Pr2Telefono varchar(50),@Pr2Direccion varchar(50),
@Pr3Nombre varchar(50),@Pr3Telefono varchar(50),@Pr3Direccion varchar(50),
@PrutaDocumento1 varchar(max),@PrutaDocumento2 varchar(max),
@Pusuario varchar(40),
@PclNombre varchar(50),@PclNit varchar(25),@PclDpi varchar(13),@PclDireccion varchar(50),@PclTelefono varchar(50),@PclCorreo varchar(50),@PcldpiU varchar(13),
@Pfecha date
As 
BEGIN
DECLARE 
@eMensaje varchar(50)
BEGIN TRANSACTION
	BEGIN TRY
		IF NOT EXISTS(SELECT 1 FROM TblVenta WHERE idVenta = @PidVenta)
		BEGIN
		exec SpIuCliente @PdpiU = @PcldpiU,@Pnit = @PclNit, @Pnombre = @PclNombre, @Pdpi = @PclDpi,@Pdireccion = @PclDireccion,@Ptelefonos = @PclTelefono,
			@Pcorreo  = @PclCorreo, @Pusuario = @Pusuario;
			INSERT INTO TblVenta(
						idVehiculo,dpi,valorVenta,enganche,
						cantidadCuotas,cuota,diaPago,
						r1Nombre,r1Telefono,r1Direccion,
						r2Nombre,r2Telefono,r2Direccion,
						r3Nombre,r3Telefono,r3Direccion,
						rutaDocumento1,rutaDocumento2,
						usuarioCreacion,fecha)
						VALUES(
						@PidVehiculo,@PclDpi,@PvalorVenta,@Penganche,
						@PcantidadCuotas,@PCuota,@PdiaPago,
						@Pr1Nombre,@Pr1Telefono,@Pr1Direccion,
						@Pr2Nombre,@Pr2Telefono,@Pr2Direccion,
						@Pr3Nombre,@Pr3Telefono,@Pr3Direccion,
						@PrutaDocumento1,@PrutaDocumento2,
						@Pusuario,@Pfecha); 
			UPDATE TblVehiculo set estado = 1 WHERE idVehiculo = @PidVehiculo;
		END
	COMMIT
	select IDENT_CURRENT('TblVenta') as idVenta;
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		set @eMensaje = (SELECT ERROR_MESSAGE())
		RAISERROR (@eMensaje,16,1);
	END CATCH
	select '0' as idVenta;
END;
GO


GO
-- DETALLE COMPLETO DE UNA VENTA
CREATE procedure [dbo].SpsUnaVenta
@PidVenta int
AS
BEGIN
select 
venta.idVenta idVenta,
venta.usuarioCreacion nombreVendedor,
cliente.nombre nombreCliente,
cliente.direccion direccionCliente,
cliente.nit nitCliente,
marca.nombre marcaVehiculo,
linea.nombre lineaVehiculo,
vehiculo.modelo modeloVehiculo,
tipoVehiculo.nombre tipoVehiculo,
vehiculo.cilindros cilindrosVehiculo,
vehiculo.puertas puertasVehiculo,
vehiculo.color  colorVehiculo,
vehiculo.placa placasVehiculo,
vehiculo.chasis noChasis,
vehiculo.cc ccVehiculo,
venta.valorVenta totalVenta,
venta.montoInicial montoInicial,
venta.enganche,
venta.cantidadCuotas noCuotas,
venta.cuota montoCuota,
venta.diaPago
 from TblVenta venta
 INNER JOIN TblVehiculo vehiculo
 ON vehiculo.idVehiculo = venta.idVehiculo
 INNER JOIN TblMarca marca
 ON vehiculo.idMarca = marca.idMarca
 INNER JOIN TblTipoVehiculo tipoVehiculo
 ON tipoVehiculo.idTipoVehiculo = vehiculo.idTipoVehiculo
 INNER JOIN TblLinea linea
 ON linea.idLinea = vehiculo.idLinea
 INNER JOIN TblCliente cliente
 ON cliente.dpi = venta.dpi
 where idVenta = @PidVenta
END;
GO


GO
-- VENTA PARA EDITAR 
CREATE PROCEDURE [dbo].[SpSUnaVentaEdicion]
@PidVenta int
as 
BEGIN
select 
(tipoV.nombre + ', ' + marca.nombre + ', ' + linea.nombre + ', '+ cast(vehiculo.modelo as varchar(6)) +', cc: '+ vehiculo.cc + ', '+ vehiculo.color) as descripcion,
vehiculo.idVehiculo, vehiculo.placa, vehiculo.precioVenta,
venta.valorVenta, venta.cuota,venta.diaPago,venta.enganche, venta.cantidadCuotas,venta.idVenta,venta.r1Direccion,venta.r1Nombre,
venta.r1Telefono,venta.r2Direccion, venta.r2Nombre,venta.r2Telefono,venta.r3Direccion, venta.r3Nombre,venta.r3Telefono,
venta.fechaCreacion,
cliente.nombre, cliente.dpi,cliente.direccion,cliente.telefonos,cliente.correoElectronico,
CASE 
	WHEN enganche = 0
	then 0.00
	else (venta.valorVenta - enganche )
END as saldo
from TblVenta as venta 
INNER JOIN TblVehiculo as vehiculo
ON venta.idVehiculo = vehiculo.idVehiculo
INNER JOIN TblCliente cliente
ON venta.dpi = cliente.dpi
INNER JOIN TblLinea linea
ON linea.idLinea = vehiculo.idLinea
INNER JOIN TblMarca marca
ON marca.idMarca = vehiculo.idMarca
INNER JOIN TblTipoVehiculo tipoV
ON vehiculo.idTipoVehiculo = tipoV.idTipoVehiculo
WHERE venta.idVenta = @PidVenta
END;
GO
