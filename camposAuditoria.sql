ALTER TABLE TblPago
	ADD
	fechaCreacion datetime NULL DEFAULT GETDATE(),
	usuarioCreacion varchar(40) NULL,
	computadoraCreacion varchar(40) NULL DEFAULT HOST_NAME(),
	aplicacionCreacion varchar(50) NULL DEFAULT APP_NAME(),
	fechaModificacion datetime NULL,
	usuarioModificacion varchar(40) NULL,
	computadoraModificacion varchar(40) NULL,
	aplicacionModificacion varchar(50) NULL