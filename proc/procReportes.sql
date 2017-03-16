GO
-- SELECCION DE VEHICULOS GENERAL
ALTER PROCEDURE [dbo].[SpSVehiculosCotizacion]
	@Pcriterio varchar(50)
As
BEGIN
	SELECT 
	vlo.idVehiculo as idVehiculo, tvlo.nombre AS tipoVehiculo,
	mca.nombre As marca, lna.nombre AS linea, vlo.modelo AS modelo,
	vlo.placa AS placa, vlo.color AS color, 
	CASE 
		WHEN vlo.estado = 0
		then 'Activo'
		else 'Vendido'
	END as estado,
	vlo.fechaIngreso AS fechaIngreso,
	vlo.observaciones, 
	vlo.precioVenta
	FROM TblVehiculo AS vlo
	LEFT outer JOIN dbo.TblLinea AS lna
	ON lna.idLinea = vlo.idLinea
	left outer JOIN dbo.TblMarca as mca
	ON mca.idMarca = lna.idMarca
	left JOIN dbo.TblTipoVehiculo as tvlo
	ON tvlo.idTipoVehiculo = vlo.idTipoVehiculo
	WHERE 
	(vlo.placa LIKE '%'+ISNULL(@Pcriterio,vlo.placa)+'%' OR
	vlo.color LIKE '%'+ISNULL(@Pcriterio,vlo.color)+'%' OR
	vlo.modelo LIKE '%'+ISNULL(@Pcriterio,vlo.modelo)+'%' OR
	lna.nombre LIKE '%'+ISNULL(@Pcriterio,lna.nombre)+'%' OR
	mca.nombre LIKE '%'+ISNULL(@Pcriterio,mca.nombre)+'%') and
	vlo.estado = 0
END;
GO	


GO
-- REPORTE VEHICULOS DISPONIBLES
CREATE PROCEDURE [dbo].[SpSVehiculoReporte]
As
BEGIN
	SELECT 
	vlo.idVehiculo as 'CODIGO', 
	vlo.placa AS PLACA, tvlo.nombre AS 'TIPO',
	mca.nombre As MARCA, lna.nombre AS LINEA, vlo.modelo AS MODELO,
	vlo.color AS COLOR, 
	CASE 
		WHEN vlo.estado = 0
		then 'Activo'
		else 'Vendido'
	END as ESTADO,
	convert(date,vlo.fechaIngreso,103) AS 'FECHA INGRESO',
	vlo.observaciones AS OBSERVACIONES, 
	convert(varchar(50),CAST((select SUM(monto) from TblCostoVehiculo as costo WHERE costo.idVehiculo = vlo.idVehiculo) AS MONEY),1) as COSTOS,
	convert(varchar(50),cast((vlo.precioVenta) as money),1) AS 'PRECIO VENTA'
	FROM TblVehiculo AS vlo
	LEFT outer JOIN dbo.TblLinea AS lna
	ON lna.idLinea = vlo.idLinea
	left outer JOIN dbo.TblMarca as mca
	ON mca.idMarca = lna.idMarca
	left JOIN dbo.TblTipoVehiculo as tvlo
	ON tvlo.idTipoVehiculo = vlo.idTipoVehiculo
	WHERE 
	vlo.estado = 0;
	END;		
GO




GO
-- SELECCION DE DETALLE DE UN VEHICULO PARA COTIZACION
CREATE PROCEDURE [dbo].[SpSvehiculoCtn]
	@idVehiculo varchar(50)
As
BEGIN
	SELECT 
	vlo.idVehiculo as idVehiculo, 
	tvlo.nombre AS TipoVehiculo,
	mca.nombre As marca,
	lna.nombre AS linea, 
	vlo.modelo AS modelo,
	vlo.placa AS placa, 
	vlo.color AS color, 
	vlo.estado AS estado,
	vlo.fechaIngreso AS fechaIngreso,
	vlo.transmision AS transmision,
	vlo.cc ,
	vlo.cilindros,
	vlo.ton ,
	vlo.puertas,
	vlo.asientos,
	vlo.ac,
	vlo.origen,
	vlo.precioVenta,
	vlo.combustible
	FROM TblVehiculo AS vlo
	LEFT outer JOIN dbo.TblLinea AS lna
	ON lna.idLinea = vlo.idLinea
	left outer JOIN dbo.TblMarca as mca
	ON mca.idMarca = lna.idMarca
	left JOIN dbo.TblTipoVehiculo as tvlo
	ON tvlo.idTipoVehiculo = vlo.idTipoVehiculo
	WHERE vlo.idVehiculo = @idVehiculo	and vlo.estado = 0;
END;	
GO


----------------------------------------------------------------------------------------------





create table TblWCotizacion(
numeroCotizacion varchar(30),
nombreCliente varchar(60),
idVehiculo int,
precioNegociado decimal(18,2),
cuotas int,
enganche decimal(18,2),
cuotaMensual decimal(18,2),
totalFinanciado decimal(18,2),
sucursal varchar(120),
telefonoSucursal varchar(20),
forma varchar(60),
validez int,
usuario varchar(40),
fecha date default getdate()
);


GO
ALTER PROCEDURE SpIuCotizacion
@Pusuario varchar(40),
@PidVehiculo int, ------
@Pcliente varchar(60),------
@Penganche decimal(18,2),----
@Pcuotas int,-----
@Pcuotamensual decimal(18,2),
@PprecioNegociado decimal(18,2),
@Psucursal varchar(60),----
@Ptelefono varchar(30),----
@PformaPago varchar(30),----
@PtotalFinanciado decimal(18,2),
@Pvalidez int
AS select * from TblParametro
BEGIN
DECLARE 
@vNumeroCotizacion VARCHAR(30),@eMensaje varchar(120)
BEGIN TRANSACTION
	BEGIN TRY
		SET @vNumeroCotizacion = (SELECT CONVERT(INT,valor) FROM TblParametro WHERE idParametro = 2 )+1 
		UPDATE TblParametro SET valor =@vNumeroCotizacion WHERE idParametro = 2
		INSERT INTO TblWCotizacion(numeroCotizacion,nombreCliente,idVehiculo,precioNegociado,cuotas,enganche,
							cuotaMensual,totalFinanciado,sucursal,telefonoSucursal,forma,usuario,validez)
							values(REPLACE(STR((@vNumeroCotizacion), 7),' ','0'),@Pcliente,@PidVehiculo,@PprecioNegociado,@Pcuotas,@Penganche,
							@Pcuotamensual,@PtotalFinanciado,@Psucursal,@Ptelefono,@PformaPago,@Pusuario,@Pvalidez);
		SELECT (@vNumeroCotizacion) AS numeroCotizacion;		
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		set @eMensaje = 'Error: '+(SELECT ERROR_MESSAGE())
		RAISERROR (@eMensaje,16,1);
	END CATCH
END;
GO



GO
alter PROCEDURE SpRptCotizacion
@PnumeroCotizacion varchar(30)
AS
BEGIN
	SELECT 		
		(select us.nombre from TblSecUsuario 
		as us WHERE us.usuario = cotizacion.usuario) as agente,--*****
		cotizacion.nombreCliente as cliente,
		cotizacion.cuotaMensual as cuotaMensual, --****************
		cotizacion.sucursal as sucursal,--****************************
		cotizacion.telefonoSucursal as telefono,--****************************
		cotizacion.forma as formaPago,--***************************
		cotizacion.cuotas as cuotas,--***************************
		cotizacion.enganche as enganche,--**********************
		cotizacion.totalFinanciado as totalFinanciado,--********************
		cotizacion.precioNegociado as precioNegociado,
		m.nombre marca, li.nombre linea, tv.nombre tipo,
		v.modelo, v.color,v.cc,v.cilindros,v.asientos, v.puertas,
		case 
			WHEN v.transmision = 0
			then 'Automatico'
			else 'Manual'
		end as transmision,
		case 
			when v.ac = 0
			then 'SI'
			else 'NO'
		end as ac,
		case
			when v.combustible = 0
			then 'Gasolina'
			else 'Diesel'
		end as combustible,
		(DATENAME(WEEKDAY,cotizacion.fecha)
		+ ' ' + DATENAME(WEEK,cotizacion.fecha)
		+ ' de ' + DATENAME(MONTH,cotizacion.fecha) 
		+ ' de ' + DATENAME(YEAR,cotizacion.fecha)) as fecha,
		(1) as cantidad,
		('Precio del Vehiculo') as descripcionDetalle,
		v.precioVenta as precioVenta,
		cotizacion.validez,
		cotizacion.numeroCotizacion
		FROM TblWCotizacion AS cotizacion
		INNER JOIN TblVehiculo as v
		ON v.idVehiculo = cotizacion.idVehiculo
		INNER JOIN TblTipoVehiculo as tv
		ON v.idTipoVehiculo = tv.idTipoVehiculo
		INNER JOIN TblLinea as li
		ON li.idLinea = v.idLinea
		INNER JOIN TblMarca as m
		ON m.idMarca = v.idMarca
		WHERE cotizacion.numeroCotizacion = @PnumeroCotizacion;
END;
GO



GO
alter PROCEDURE SpsCotizacion
@Pcriterio varchar(30)
AS
BEGIN
		SELECT
		cotizacion.numeroCotizacion ,
		cotizacion.nombreCliente as cliente,
		--cotizacion.cuotaMensual as cuotaMensual, --****************
		cotizacion.sucursal as sucursal,--****************************
		cotizacion.telefonoSucursal as telefono,--****************************
		(convert(varchar(10),(v.idVehiculo)) + ', '+ tv.nombre+', ' + m.nombre +', ' + li.nombre +', ' + v.placa + ', ' + v.cc) descripcion,
		cotizacion.forma as formaPago,--***************************
		v.precioVenta as precioVenta,
		cotizacion.precioNegociado as precioNegociado,
		--cotizacion.cuotas as cuotas,--***************************
		--cotizacion.enganche as enganche,--**********************
		cotizacion.totalFinanciado as totalFinanciado,--********************
		cotizacion.validez
		FROM TblWCotizacion AS cotizacion
		INNER JOIN TblVehiculo as v
		ON v.idVehiculo = cotizacion.idVehiculo
		INNER JOIN TblTipoVehiculo as tv
		ON v.idTipoVehiculo = tv.idTipoVehiculo
		INNER JOIN TblLinea as li
		ON li.idLinea = v.idLinea
		INNER JOIN TblMarca as m
		ON m.idMarca = v.idMarca WHERE
		cotizacion.nombreCliente LIKE '%'+ISNULL(@Pcriterio,cotizacion.nombreCliente)+'%' OR
		cotizacion.numeroCotizacion LIKE '%'+ISNULL(@Pcriterio,cotizacion.numeroCotizacion)+'%'
END;
GO







GO
-- REPORTE VENTA
alter procedure SpsReporteVentaPorFecha
	@PfechaIncio date,
	@PfechaFin date,
	@PformaVenta varchar(15)
AS
BEGIN
	SELECT venta.idVenta as CODIGO, 
	(SELECT usuario.nombre FROM TblSecUsuario as usuario WHERE usuario.usuario = venta.usuarioCreacion) AS VENDEDOR,
	cliente.nombre as CLIENTE,  tipoV.nombre as TIPO,marca.nombre as MARCA,linea.nombre as LINEA,
	convert(varchar(15),venta.fechaCreacion,103) as FECHA,
	CASE
		WHEN venta.cantidadCuotas > 0
		THEN 'Crédito'
		ELSE 'Contado'
	END as FORMA,
	--(isnull((select SUM(monto) from TblCostoVehiculo as costo WHERE costo.idVehiculo = vehiculo.idVehiculo ),0)) as INVERSION,
	vehiculo.precioVenta as PRECIO_VENTA,
	venta.valorVenta VALOR_VENTA,
	VENTA.enganche AS ENGANCHE,
	VENTA.cantidadCuotas AS CUOTAS,
	VENTA.cuota AS VALOR_CUOTA,
	VENTA.montoInicial AS VALOR_FINANCIADO,
	CASE 
	WHEN venta.cuota < 1
		THEN (0.00)
		ELSE 
			((isnull(venta.montoInicial,0)) - (isnull((select SUM(monto) from TblPago as pago where pago.idVenta = venta.idVenta),0)))
	END as SALDO,
	CASE 
	WHEN venta.cuota < 1
		THEN 
			(ISNULL(venta.valorVenta,0))
		ELSE 
			(isnull((select SUM(monto) from TblPago as tp WHERE tp.idVenta = venta.idVenta),0) + isnull(venta.enganche,0))
	END as PAGADO
	--PRECIO VENTA
	--ENGANCHE
	--CUOTAS 
	--SALDO
	--VALOR FINANCIADO
	--VALOR CUOTA
	-- DESCUENTO
	--(isnull((select SUM(monto) from TblPago as tp WHERE tp.idVenta = venta.idVenta),0) + isnull(venta.montoInicial,0)) as montoPagado,
	--convert(varchar(15),(SELECT DATEADD(month,venta.cantidadCuotas,venta.fechaCreacion)),103) AS fechaUltimaCuota, venta.cantidadCuotas
	--(venta.cantidadCuotas - (select count(1) from TblPago as tp WHERE tp.idVenta = venta.idVenta)) as cuotasRestantes,
	--(tipoV.nombre + ', ' + marca.nombre + ', ' + linea.nombre + ', '+ cast(vehiculo.modelo as varchar(6)) +', cc: '+ isnull(vehiculo.cc,0) + ', '+ vehiculo.color) as descripcion,
	FROM TblVenta AS venta
	INNER JOIN TblCliente as cliente
	ON venta.dpi = cliente.dpi
	INNER JOIN TblVehiculo vehiculo
	ON vehiculo.idVehiculo = venta.idVehiculo
	INNER JOIN TblTipoVehiculo tipoV
	ON tipoV.idTipoVehiculo = vehiculo.idTipoVehiculo
	INNER JOIN TblMarca marca
	ON marca.idMarca = vehiculo.idMarca
	INNER JOIN TblLinea linea
	ON linea.idLinea = vehiculo.idLinea
	WHERE venta.fechaCreacion BETWEEN 
	CONVERT(Varchar(10),@PfechaIncio,103) and 
	CONVERT(Varchar(10),@PfechaFin,103) and 
	(CASE WHEN venta.cantidadCuotas > 0 THEN 'Crédito' ELSE 'Contado' END) LIKE '%'+ISNULL(@PformaVenta,(CASE WHEN venta.cantidadCuotas > 0 THEN 'Crédito' ELSE 'Contado' END))+'%'
END;
go














