
GO
-- LISTADO DE CLIENTES
CREATE PROCEDURE [dbo].[SpSCliente]
	@Pcriterio varchar(50)
AS
BEGIN
	SELECT cl.nit, cl.direccion, cl.nombre as nombres , cl.dpi, cl.telefonos, cl.correoElectronico from TblCliente as cl
	WHERE cl.dpi like '%'+ISNULL(@Pcriterio,cl.dpi)+'%'
	 OR cl.nombre  like '%'+ISNULL(@Pcriterio,cl.nombre)+'%'
	 OR cl.nit like '%'+ISNULL(@Pcriterio,cl.nit )+'%'

END;
GO





GO
--INSERTAR Y ACTUALIZAR CLIENTE
CREATE PROCEDURE [dbo].[SpIuCliente]
	@PdpiU char(13),
	@Pnit varchar(25),
	@Pnombre varchar(50),
	@Pdpi char(13),
	@Pdireccion varchar(250),
	@Ptelefonos varchar(50),
	@Pcorreo varchar(50),
	@Pusuario int	
AS
BEGIN
	IF EXISTS(SELECT 1 FROM TblCliente WHERE dpi = @PdpiU)
	BEGIN
		UPDATE TblCliente SET nombre = @Pnombre, dpi = @Pdpi, correoElectronico = @Pcorreo, telefonos = @Ptelefonos,
		direccion = @Pdireccion, usuarioModificacion =@Pusuario
		WHERE dpi = @PdpiU
	END
	ELSE
	BEGIN
		INSERT TblCliente(dpi,nit,nombre,direccion,telefonos, correoElectronico,usuarioCreacion)
		VALUES(@Pdpi,@Pnit,@Pnombre,@Pdireccion,@Ptelefonos,@Pcorreo,@Pusuario)
	END
END;
GO



GO
-- PROCEDIMIENTO PARA ELIMINAR CLIENTE
CREATE PROCEDURE [DBO].[SpdCliente]
	@Pdpi varchar(13)
AS
BEGIN
--Verifica si hay vehículos relacionados con el actual registro antes de borrar
	IF EXISTS(SELECT 1 FROM TblVenta WHERE dpi= @Pdpi)
	BEGIN
		RAISERROR ('No se puede eliminar porque actualmente el otros registros dependen de este cliente',16,1);
	END
	ELSE
	BEGIN
		DELETE TblCliente WHERE dpi = @Pdpi
	END
END;
GO



GO
create PROCEDURE [dbo].[SpSunCliente]
@Pnit varchar(15)
AS
BEGIN
SELECT dpi,nit,nombre,direccion,telefonos,correoElectronico FROM TblCliente WHERE nit = @PNit;
END;
GO