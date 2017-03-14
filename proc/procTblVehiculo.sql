

GO
-- SELECCION DE VEHICULOS GENERAL
CREATE PROCEDURE [dbo].[SpSVehiculo]
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
	vlo.placa LIKE '%'+ISNULL(@Pcriterio,vlo.placa)+'%' OR
	vlo.color LIKE '%'+ISNULL(@Pcriterio,vlo.color)+'%' OR
	vlo.modelo LIKE '%'+ISNULL(@Pcriterio,vlo.modelo)+'%' OR
	lna.nombre LIKE '%'+ISNULL(@Pcriterio,lna.nombre)+'%' OR
	mca.nombre LIKE '%'+ISNULL(@Pcriterio,mca.nombre)+'%'	
END;
GO	
	
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
-- PROCEDIMIENTO PARA ELIMINAR UN VEHICULO NO SE ELIMINA SI ES DEPENDENCIA DE OTRO REGISTRO
CREATE PROCEDURE [DBO].[SpdVehiculo]
	@pidVehiculo int
AS
BEGIN
Declare
@eMensaje varchar(50)
--Verifica si hay vehículos relacionados con el actual registro antes de borrar
	IF EXISTS(SELECT 1 FROM TblVenta WHERE idVehiculo= @pidVehiculo)
	BEGIN
		RAISERROR ('No se puede eliminar porque actualmente hay ventas que tienen asignado este Vehiculo',16,1);
	END
	ELSE
	BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
	select * from TblCostoVehiculo;
		DELETE TblCostoVehiculo Where idVehiculo = @pidVehiculo;
		DELETE TblVehiculo WHERE idVehiculo = @pidVehiculo;
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		set @eMensaje = 'Error: '+(SELECT ERROR_MESSAGE())
		RAISERROR (@eMensaje,16,1);
	END CATCH
	END
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





GO
-- SELECCION PARA EDICION DE UN VEHICULO
CREATE PROCEDURE [DBO].[SpsUnVehiculo]
@PidVehiculo int,
@Pplaca varchar(15)
AS
BEGIN
	IF @PidVehiculo != ''
	BEGIN
		SELECT * FROM TblVehiculo WHERE idVehiculo = @PidVehiculo;
	END
	ELSE
	BEGIN
		SELECT * FROM TblVehiculo WHERE placa = @Pplaca;
	END
END;
GO




GO
-- VEHICULOS DISPONIBLES PARA VENTA
CREATE PROCEDURE [DBO].[SpSVehiculosVenta]
@Pcriterio varchar(30)
As
BEGIN 		
SELECT vlo.idVehiculo as idVehiculo,
		(tvlo.nombre + ', ' + mca.nombre + ', ' + lna.nombre + ', '+ cast(vlo.modelo as varchar(6)) +', cc: '+ vlo.cc + ', '+ vlo.color) as descripcion, 
		vlo.placa AS placa, 
 		--vlo.color AS color, 
 		CONVERT(date,vlo.fechaIngreso,103) as fechaIngreso,
		--vlo.fechaIngreso AS fechaIngreso,
 		vlo.observaciones,
 		CONVERT(varchar(50),cast((vlo.precioVenta) as money),1) as monto
		FROM TblVehiculo AS vlo
		LEFT outer JOIN dbo.TblLinea AS lna
		ON lna.idLinea = vlo.idLinea
		left outer JOIN dbo.TblMarca as mca
		ON mca.idMarca = lna.idMarca
		left JOIN dbo.TblTipoVehiculo as tvlo
		ON tvlo.idTipoVehiculo = vlo.idTipoVehiculo WHERE
		(vlo.placa LIKE '%'+ISNULL(@Pcriterio,vlo.placa)+'%' OR
		vlo.color LIKE '%'+ISNULL(@Pcriterio,vlo.color)+'%' OR
		vlo.modelo LIKE '%'+ISNULL(@Pcriterio,vlo.modelo)+'%' OR
		lna.nombre LIKE '%'+ISNULL(@Pcriterio,lna.nombre)+'%' OR
		mca.nombre LIKE '%'+ISNULL(@Pcriterio,mca.nombre)+'%') AND
		vlo.estado = 0
END;
GO



GO
-- DETALLE DE UN VEHICULO PARA AGREGAR A A VENTA POR MEDIO DE SU PLACA
CREATE PROCEDURE [DBO].[SpSVehiculoInfo]
@Pplaca	varchar(15)
As
BEGIN 
SELECT vlo.idVehiculo as idVehiculo,
		(tvlo.nombre + ', ' + mca.nombre + ', ' + lna.nombre + ', '+ cast(vlo.modelo as varchar(6)) +', cc: '+ vlo.cc + ', '+ vlo.color) as descripcion, 
		vlo.placa AS placa, 
 		--vlo.color AS color, 
		vlo.fechaIngreso AS fechaIngreso,
 		vlo.observaciones,
		vlo.precioVenta  as monto	
		FROM TblVehiculo AS vlo
		LEFT outer JOIN dbo.TblLinea AS lna
		ON lna.idLinea = vlo.idLinea
		left outer JOIN dbo.TblMarca as mca
		ON mca.idMarca = lna.idMarca
		left JOIN dbo.TblTipoVehiculo as tvlo
		ON tvlo.idTipoVehiculo = vlo.idTipoVehiculo WHERE
		vlo.placa = @Pplaca and vlo.estado <> 1;
END;
GO




GO
-- CREACION DE TIPO DE DATO, PARA MANEJO DE COSTOS DE UN VEHICULO
CREATE TYPE dbo.tvpCostos AS TABLE(
	id varchar(5),
	tag varchar(30),
	monto varchar(20),
	observaciones varchar(MAX),
	idTipoCosto int
);
GO


GO
-- INSERTAR O ACTUALIZAR VEHICULO
CREATE PROCEDURE [dbo].SpIuVehiculo
	@Ptcostos tvpCostos READONLY,
	@PidVehiculo int,
	@PidTipoVehiculo int,
	@PidMarca int,
	@PidLinea int, 
	@Pmodelo int,
	@Pplaca varchar(15),
	@Pchasis varchar(50),
	@Pcolor varchar(50),
	@Pasientos varchar(2),
	@Ppuertas varchar(5),
	@Ptransmision varchar(5),
	@Pmotor varchar(50),
	@Pcc varchar(50),
	@Pcilindros varchar(5),
	@Pvin varchar(50),
	@Pton varchar(5),
	@Pobservaciones varchar(2500),
	@Pac varchar(5),
	@Ppropietario varchar(150),
	@PnitPropietario varchar(25),
	@PdireccionPropietario varchar(225),
	@Ppoliza varchar(50),
	@PfechaIngreso date,
	@PprecioVenta decimal(18,2),
	@Porigen varchar(5),
	@Pusuario varchar(40),
	@Pcombustible varchar(2)
AS
BEGIN
DECLARE
@eMensaje varchar(50),
@idV int
	BEGIN TRANSACTION
	BEGIN TRY
		IF EXISTS(SELECT 1 FROM TblVehiculo WHERE idVehiculo = @PidVehiculo)
		BEGIN	
		select * from TblVehiculo
			UPDATE TblVehiculo SET
				combustible = @Pcombustible,
				placa = @Pplaca,
				idTipoVehiculo = @PidTipoVehiculo,
				idMarca = @PidMarca,
				idLinea = @PidLinea,
				modelo = @Pmodelo,
				color = @Pcolor,
				chasis = @Pchasis,
				cc = @Pcc,
				cilindros = @Pcilindros,
				ton = @Pton,
				asientos = @Pasientos,
				motor = @Pmotor,
				vin = @Pvin,
				propietario = @Ppropietario,
				nitPropietario = @PnitPropietario,
				direccionPropietario = @PdireccionPropietario,
				poliza = @Ppoliza,
				fechaIngreso = @PfechaIngreso,
				observaciones = @Pobservaciones,
				precioVenta = @PprecioVenta,
				usuarioModificacion = @Pusuario,
				puertas = @Ppuertas,
				transmision = @Ptransmision,
				ac = @Pac,
				origen = @Porigen
				WHERE idVehiculo = @PidVehiculo;
				IF( SELECT COUNT(1) FROM @Ptcostos ) > 0
					begin
					MERGE TblCostoVehiculo AS ooput
					USING @Ptcostos AS iiput
					ON (ooput.idCostoVehiculo = iiput.id)
					WHEN NOT MATCHED BY TARGET
						THEN INSERT(idVehiculo,idTipoCosto,etiquetaCosto,observaciones,monto,usuarioCreacion) 
						VALUES(@PidVehiculo,iiput.idTipoCosto,iiput.tag, iiput.observaciones,(CAST(isnull(iiput.monto,0) as decimal(18,2))),@Pusuario)
					WHEN MATCHED 
						THEN UPDATE SET 
						etiquetaCosto = iiput.tag, monto = iiput.monto, observaciones = iiput.observaciones,
						idTipoCosto = iiput.idTipoCosto, usuarioModificacion = @Pusuario;
					--OUTPUT $action, Inserted.*, Deleted.*;
					--commit;
					--ROLLBACK TRAN;
					end;
				ELSE
					begin;
					DELETE FROM TblCostoVehiculo WHERE idVehiculo = @PidVehiculo;
					end;
			--ACTUALIZAR VEHICULO
			--UPDATE TblMarca SET nombre = @Pnombre, usuarioModificacion =@Pusuario
			--WHERE idMarca = @PidMarca
			--RAISERROR ('HELLO WORLD uupdate',16,1);
		END
		ELSE
		BEGIN
			INSERT INTO TblVehiculo(combustible,placa,idTipoVehiculo,idMarca,idLinea,modelo,color,chasis,cc,cilindros,ton,asientos,
					motor,vin,propietario,nitpropietario,direccionPropietario,poliza,fechaIngreso,observaciones,precioVenta,
					estado,puertas,transmision,ac,origen,usuarioCreacion) 
					values(@Pcombustible,@Pplaca,@PidTipoVehiculo,@PidMarca,@PidLinea,@Pmodelo,@Pcolor,@Pchasis,@Pcc,@Pcilindros,@Pton,@Pasientos,
					@Pmotor,@Pvin,@Ppropietario,@PnitPropietario,@PdireccionPropietario,@Ppoliza,@PfechaIngreso,@Pobservaciones,@PprecioVenta,
					'0',@Ppuertas,@Ptransmision,@Pac,@Porigen,@Pusuario);
			SET @idV = (select IDENT_CURRENT('TblVehiculo'));
			IF( SELECT COUNT(1) FROM @Ptcostos ) > 0
				begin
				INSERT INTO TblCostoVehiculo(idVehiculo,idTipoCosto,etiquetaCosto,observaciones,monto,usuarioCreacion)
					select @idV,t.idTipoCosto,t.tag, t.observaciones,(CAST(isnull(t.monto,0) as decimal(18,2))),@Pusuario from @Ptcostos as t;
				end;				
			-- INSERTAR VEHICULO
			-- INSERT TblMarca(nombre,usuarioCreacion)
			-- VALUES(@Pplaca,@Pusuario)
			--RAISERROR ('HELLO WORLD',16,1);
			
		END
	COMMIT
	
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		set @eMensaje = 'Proc: '+(SELECT ERROR_MESSAGE())
		RAISERROR (@eMensaje,16,1);
		
	END CATCH
END;
GO




GO
-- DETALLE DE UN VEHICULO PARA COTIZACION
-- Recibir nombre de cliente
-- recibir enganche 
-- recibir cantidad de cuotas
-- recibir sucursal
-- recibir telefono
-- recibir forma de pago
-- recibir usuario

CREATE PROCEDURE [dbo].[SpsCotizacionVehiculo]
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
@PtotalFinanciado decimal(18,2)
AS
BEGIN
SELECT 
(select us.nombre from TblSecUsuario 
as us WHERE us.usuario = @Pusuario) as agente,--*****
(@Pcliente) as cliente,
@Pcuotamensual as cuotaMensual, --****************
(@Psucursal) as sucursal,--****************************
(@Ptelefono) as telefono,--****************************
(@PformaPago) as formaPago,--***************************
(@Pcuotas) as cuotas,--***************************
(@Penganche) as enganche,--**********************
(@PtotalFinanciado) as totalFinanciado,--********************
(@PprecioNegociado) as precioNegociado,
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
(DATENAME(WEEKDAY,GETDATE())
+ ' ' + DATENAME(WEEK,GETDATE())
+ ' de ' + DATENAME(MONTH,GETDATE()) 
+ ' de ' + DATENAME(YEAR,GETDATE())) as fecha,
(1) as cantidad,
('Precio del Vehiculo') as descripcionDetalle,
v.precioVenta as precioVenta
FROM TblVehiculo as v
INNER JOIN TblTipoVehiculo as tv
ON v.idTipoVehiculo = tv.idTipoVehiculo
INNER JOIN TblLinea as li
ON li.idLinea = v.idLinea
INNER JOIN TblMarca as m
ON m.idMarca = v.idMarca
WHERE v.idVehiculo = @PidVehiculo;
END;
GO
