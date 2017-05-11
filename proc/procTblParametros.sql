

GO
CREATE PROCEDURE SpIUCorreo
@PdiaCorreo int
As
BEGIN
	IF EXISTS(SELECT 1 FROM TblParametro WHERE idParametro = 3)
	BEGIN
		UPDATE TblParametro SET valor = @PdiaCorreo
		WHERE idParametro = 3;
	END
	ELSE
	BEGIN
		INSERT TblParametro(idParametro,descripcion,valor)
		VALUES(3,'diaCorreoEnviado',@PdiaCorreo);
	END
END;
GO


GO
create procedure SpSParametroCorreo
AS
BEGIN
select valor dia from TblParametro where idParametro = 3
END;
GO