/*
   lunes, 13 de febrero de 201712:10:24
   Usuario: 
   Servidor: MCTIPROGRA8
   Base de datos: DBPV
   Aplicación: 
*/

/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
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
ALTER TABLE dbo.TblPago
	DROP CONSTRAINT FK_TblPago_TblVenta
GO
ALTER TABLE dbo.TblVenta SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.TblVenta', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.TblVenta', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.TblVenta', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.TblPago
	DROP CONSTRAINT FK_TblPago_TblMetodoPago
GO
ALTER TABLE dbo.TblMetodoPago SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.TblMetodoPago', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.TblMetodoPago', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.TblMetodoPago', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.TblPago
	DROP CONSTRAINT DF__TblPago__fechaCr__2CF2ADDF
GO
ALTER TABLE dbo.TblPago
	DROP CONSTRAINT DF__TblPago__computa__2DE6D218
GO
ALTER TABLE dbo.TblPago
	DROP CONSTRAINT DF__TblPago__aplicac__2EDAF651
GO
CREATE TABLE dbo.Tmp_TblPago
	(
	idPago int NOT NULL IDENTITY (1, 1),
	idVenta int NULL,
	monto decimal(18, 2) NULL,
	fecha datetime NULL,
	numeroCuota int NULL,
	idMetodoPago int NULL,
	observaciones varchar(MAX) NULL,
	rutaAdjunto varchar(MAX) NULL,
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
ALTER TABLE dbo.Tmp_TblPago SET (LOCK_ESCALATION = TABLE)
GO
ALTER TABLE dbo.Tmp_TblPago ADD CONSTRAINT
	DF__TblPago__fechaCr__2CF2ADDF DEFAULT (getdate()) FOR fechaCreacion
GO
ALTER TABLE dbo.Tmp_TblPago ADD CONSTRAINT
	DF__TblPago__computa__2DE6D218 DEFAULT (host_name()) FOR computadoraCreacion
GO
ALTER TABLE dbo.Tmp_TblPago ADD CONSTRAINT
	DF__TblPago__aplicac__2EDAF651 DEFAULT (app_name()) FOR aplicacionCreacion
GO
SET IDENTITY_INSERT dbo.Tmp_TblPago ON
GO
IF EXISTS(SELECT * FROM dbo.TblPago)
	 EXEC('INSERT INTO dbo.Tmp_TblPago (idPago, idVenta, monto, fecha, idMetodoPago, observaciones, rutaAdjunto, fechaCreacion, usuarioCreacion, computadoraCreacion, aplicacionCreacion, fechaModificacion, usuarioModificacion, computadoraModificacion, aplicacionModificacion)
		SELECT idPago, idVenta, monto, fecha, idMetodoPago, observaciones, rutaAdjunto, fechaCreacion, usuarioCreacion, computadoraCreacion, aplicacionCreacion, fechaModificacion, usuarioModificacion, computadoraModificacion, aplicacionModificacion FROM dbo.TblPago WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_TblPago OFF
GO
DROP TABLE dbo.TblPago
GO
EXECUTE sp_rename N'dbo.Tmp_TblPago', N'TblPago', 'OBJECT' 
GO
ALTER TABLE dbo.TblPago ADD CONSTRAINT
	PK_TblPago PRIMARY KEY CLUSTERED 
	(
	idPago
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.TblPago ADD CONSTRAINT
	FK_TblPago_TblMetodoPago FOREIGN KEY
	(
	idMetodoPago
	) REFERENCES dbo.TblMetodoPago
	(
	idMetodoPago
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
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
CREATE trigger [dbo].[TrgUpdTblPago] on dbo.TblPago for update as
BEGIN
	UPDATE a
	SET
	computadoraModificacion = host_name(),
	aplicacionModificacion = app_name(),
	fechaModificacion = getdate()
	FROM TblPago a INNER JOIN  inserted I  ON    a.idPago = i.idPago
END
GO
COMMIT
select Has_Perms_By_Name(N'dbo.TblPago', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.TblPago', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.TblPago', 'Object', 'CONTROL') as Contr_Per 