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
numeroCotizacion int,
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
create PROCEDURE SpIuCotizacion
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
AS
BEGIN
DECLARE 
@vNumeroCotizacion VARCHAR(30),@eMensaje varchar(120)
BEGIN TRANSACTION
	BEGIN TRY
		SET @vNumeroCotizacion = REPLACE(STR(((SELECT CONVERT(INT,valor) FROM TblParametro WHERE idParametro = 2 )+1), 7),' ','0')
		UPDATE TblParametro SET valor =@vNumeroCotizacion WHERE idParametro = 2
		INSERT INTO TblWCotizacion(numeroCotizacion,nombreCliente,idVehiculo,precioNegociado,cuotas,enganche,
							cuotaMensual,totalFinanciado,sucursal,telefonoSucursal,forma,usuario,validez)
							values(@vNumeroCotizacion,@Pcliente,@PidVehiculo,@PprecioNegociado,@Pcuotas,@Penganche,
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
		cotizacion.nombreCliente as cliente,
		--cotizacion.cuotaMensual as cuotaMensual, --****************
		cotizacion.sucursal as sucursal,--****************************
		cotizacion.telefonoSucursal as telefono,--****************************
		cotizacion.forma as formaPago,--***************************
		--cotizacion.cuotas as cuotas,--***************************
		--cotizacion.enganche as enganche,--**********************
		cotizacion.totalFinanciado as totalFinanciado,--********************
		cotizacion.precioNegociado as precioNegociado,
		(convert(varchar(10),(v.idVehiculo)) + ', '+ tv.nombre+', ' + m.nombre +', ' + li.nombre +', ' + v.placa + ', ' + v.cc) descripcion,
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
		ON m.idMarca = v.idMarca WHERE
		cotizacion.nombreCliente LIKE '%'+ISNULL(@Pcriterio,cotizacion.nombreCliente)+'%' OR
		cotizacion.numeroCotizacion LIKE '%'+ISNULL(@Pcriterio,cotizacion.numeroCotizacion)+'%'
END;
GO

