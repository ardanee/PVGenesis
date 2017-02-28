/*
Aramirez
13/02/2016
-Se agregó columna fecha
-La columna montonInicial se estableció como campo calculado (valorVenta - enganche)
*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.TblVenta
	DROP CONSTRAINT FK_TblVenta_TblVehiculo
GO
ALTER TABLE dbo.TblVehiculo SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.TblVenta
	DROP CONSTRAINT FK_TblVenta_TblCliente
GO
ALTER TABLE dbo.TblCliente SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.TblVenta
	DROP CONSTRAINT DF__TblVenta__fechaC__2645B050
GO
ALTER TABLE dbo.TblVenta
	DROP CONSTRAINT DF__TblVenta__comput__2739D489
GO
ALTER TABLE dbo.TblVenta
	DROP CONSTRAINT DF__TblVenta__aplica__282DF8C2
GO
CREATE TABLE dbo.Tmp_TblVenta
	(
	idVenta int NOT NULL IDENTITY (1, 1),
	idVehiculo int NULL,
	fecha date NULL,
	dpi char(13) NULL,
	valorVenta decimal(18, 2) NULL,
	enganche decimal(18, 2) NULL,
	montoInicial  AS valorVenta-enganche,
	cantidadCuotas tinyint NULL,
	cuota decimal(18, 2) NULL,
	diaPago tinyint NULL,
	r1Nombre varchar(50) NULL,
	r1Telefono varchar(20) NULL,
	r1Direccion varchar(255) NULL,
	r2Nombre varchar(50) NULL,
	r2Telefono varchar(20) NULL,
	r2Direccion varchar(255) NULL,
	r3Nombre varchar(50) NULL,
	r3Telefono varchar(20) NULL,
	r3Direccion varchar(255) NULL,
	rutaDocumento1 varchar(MAX) NULL,
	rutaDocumento2 varchar(MAX) NULL,
	fechaCreacion datetime NULL,
	usuarioCreacion varchar(40) NULL,
	computadoraCreacion varchar(40) NULL,
	aplicacionCreacion varchar(50) NULL,
	fechaModificacion datetime NULL,
	usuarioModificacion varchar(40) NULL,
	computadoraModificacion varchar(40) NULL,
	aplicacionModificacion varchar(50) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_TblVenta SET (LOCK_ESCALATION = TABLE)
GO
ALTER TABLE dbo.Tmp_TblVenta ADD CONSTRAINT
	DF__TblVenta__fechaC__2645B050 DEFAULT (getdate()) FOR fechaCreacion
GO
ALTER TABLE dbo.Tmp_TblVenta ADD CONSTRAINT
	DF__TblVenta__comput__2739D489 DEFAULT (host_name()) FOR computadoraCreacion
GO
ALTER TABLE dbo.Tmp_TblVenta ADD CONSTRAINT
	DF__TblVenta__aplica__282DF8C2 DEFAULT (app_name()) FOR aplicacionCreacion
GO
SET IDENTITY_INSERT dbo.Tmp_TblVenta ON
GO
IF EXISTS(SELECT * FROM dbo.TblVenta)
	 EXEC('INSERT INTO dbo.Tmp_TblVenta (idVenta, idVehiculo, dpi, valorVenta, enganche, cantidadCuotas, cuota, diaPago, r1Nombre, r1Telefono, r1Direccion, r2Nombre, r2Telefono, r2Direccion, r3Nombre, r3Telefono, r3Direccion, rutaDocumento1, rutaDocumento2, fechaCreacion, usuarioCreacion, computadoraCreacion, aplicacionCreacion, fechaModificacion, usuarioModificacion, computadoraModificacion, aplicacionModificacion)
		SELECT idVenta, idVehiculo, dpi, valorVenta, enganche, cantidadCuotas, cuota, diaPago, r1Nombre, r1Telefono, r1Direccion, r2Nombre, r2Telefono, r2Direccion, r3Nombre, r3Telefono, r3Direccion, rutaDocumento1, rutaDocumento2, fechaCreacion, usuarioCreacion, computadoraCreacion, aplicacionCreacion, fechaModificacion, usuarioModificacion, computadoraModificacion, aplicacionModificacion FROM dbo.TblVenta WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_TblVenta OFF
GO
ALTER TABLE dbo.TblPago
	DROP CONSTRAINT FK_TblPago_TblVenta
GO
DROP TABLE dbo.TblVenta
GO
EXECUTE sp_rename N'dbo.Tmp_TblVenta', N'TblVenta', 'OBJECT' 
GO
ALTER TABLE dbo.TblVenta ADD CONSTRAINT
	PK_TblVenta PRIMARY KEY CLUSTERED 
	(
	idVenta
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.TblVenta ADD CONSTRAINT
	FK_TblVenta_TblCliente FOREIGN KEY
	(
	dpi
	) REFERENCES dbo.TblCliente
	(
	dpi
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.TblVenta ADD CONSTRAINT
	FK_TblVenta_TblVehiculo FOREIGN KEY
	(
	idVehiculo
	) REFERENCES dbo.TblVehiculo
	(
	idVehiculo
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
CREATE trigger [dbo].[TrgUpdTblVenta] on dbo.TblVenta for update as
BEGIN
	UPDATE a
	SET
	computadoraModificacion = host_name(),
	aplicacionModificacion = app_name(),
	fechaModificacion = getdate()
	FROM TblVenta a INNER JOIN  inserted I  ON    a.idVenta = i.idVenta
END
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.TblPago ADD CONSTRAINT
	FK_TblPago_TblVenta FOREIGN KEY
	(
	idVenta
	) REFERENCES dbo.TblVenta
	(
	idVenta
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.TblPago SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
