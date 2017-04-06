USE [DBPV]
GO

/****** Object:  Table [dbo].[TblSecUsuario]    Script Date: 03/31/2017 08:09:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[TblCorreo](
	[idCorreo] [int] IDENTITY(1,1) NOT NULL,
	[correoOrigen] [varchar](60) NULL,
	[contrasena] [varchar](60) NOT NULL,
	[correoDestino] [varchar](62) NOT NULL,
	[estado] [int] not null,
	[fechaCreacion] [datetime] NULL,
	[usuarioCreacion] [varchar](40) NULL,
	[computadoraCreacion] [varchar](40) NULL,
	[aplicacionCreacion] [varchar](50) NULL,
	[fechaModificacion] [datetime] NULL,
	[usuarioModificacion] [varchar](40) NULL,
	[computadoraModificacion] [varchar](40) NULL,
	[aplicacionModificacion] [varchar](50) NULL,
 CONSTRAINT [PK_TblCOrreo] PRIMARY KEY CLUSTERED 
(
	[idCorreo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[TblCorreo] ADD  CONSTRAINT [DF__TblCorreo__Fecha__00C31E99]  DEFAULT (getdate()) FOR [fechaCreacion]
GO

ALTER TABLE [dbo].[TblCorreo] ADD  CONSTRAINT [DF__TblCorreo__Usuar__01B742D2]  DEFAULT (suser_sname()) FOR [usuarioCreacion]
GO

ALTER TABLE [dbo].[TblCorreo] ADD  CONSTRAINT [DF__TblCorreo__Compu__02AB670B]  DEFAULT (host_name()) FOR [computadoraCreacion]
GO

ALTER TABLE [dbo].[TblCorreo] ADD  CONSTRAINT [DF__TblCorreo__Apliccr__039F8B44]  DEFAULT (app_name()) FOR [aplicacionCreacion]
GO


select * from TblCorreo

insert into TblCorreo(correoOrigen, contrasena,correoDestino,estado) values('mail.@gmail.com','1234','maind@mail.com',1);

update TblCorreo set correoOrigen = 'mail.m@mail.com' 



go
CREATE PROCEDURE SpUICorreo
@PidCorreo int,
@PcorreoOrigen varchar(60),
@Pcontrasena varchar(60),
@PcorreoDestino varchar(60),
@Pestado int,
@Pusuario varchar(40)
AS
BEGIN
	IF EXISTS(SELECT 1 FROM TblCorreo WHERE idCorreo = @PidCorreo)
	BEGIN
		UPDATE TblCorreo SET correoOrigen = @PcorreoOrigen, contrasena = @Pcontrasena, correoDestino = @PcorreoDestino,
		estado = @Pestado,
		usuarioModificacion = @Pusuario
		WHERE idCorreo = @PidCorreo
	END
	ELSE
	BEGIN
		INSERT TblCorreo(correoOrigen,contrasena, correoDestino, estado, usuarioCreacion )
		VALUES(@PcorreoOrigen,@Pcontrasena,@PcorreoDestino,@Pestado,@Pusuario )
	END
END;
go



CREATE PROCEDURE SpdCorreo
	@PidCorreo int
AS
BEGIN
--Verifica si hay vehículos relacionados con el actual registro antes de borrar
	DELETE TblCorreo WHERE idCorreo = @PidCorreo
END;


GO
alter PROCEDURE SpSCorreo
	@Pcriterio varchar(50)
AS
BEGIN
 SELECT idCorreo, correoDestino, correoOrigen, contrasena,
 CASE 
 WHEN estado = 0
 THEN 'Activo'
 ELSE 'Inactivo'
 END as estado
  FROM TblCorreo
 WHERE correoDestino LIKE '%'+ISNULL(@Pcriterio,correoDestino)+'%' order by idCorreo ASC
END;
GO
select * from TblCorreo

exec spscorreo @Pcriterio = ''

