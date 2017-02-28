SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE trigger [dbo].[TrgUpdTblPago] on [dbo].TblPago for update as
BEGIN
	UPDATE a
	SET
	computadoraModificacion = host_name(),
	aplicacionModificacion = app_name(),
	fechaModificacion = getdate()
	FROM TblPago a INNER JOIN  inserted I  ON    a.idPago = i.idPago
END