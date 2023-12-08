----CLIENTE PROCESOS ALMACENADOS

--=============================================
--ACTUALIZAR CLIENTES
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[actualizar_cliente] 
	(
		@Codigo int,
		@Nombre varchar(255),
		@Telefono varchar(255),
		@Contacto varchar(255),
		@Direccion varchar(255),
		@Estado int
	)
AS
BEGIN

	SET NOCOUNT ON;
	Update Clientes
	SET 
	Nombre = @Nombre,
	Telefono = @Telefono,
	Contacto = @Contacto,
    Direccion = @Direccion,
	Estado = @Estado
	where Codigo = @Codigo

END
GO

-- =============================================
--ELIMINAR CLIENTES
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[eliminar_cliente]
	(
	@Codigo int,
	@Estado int
	)
AS
BEGIN

	SET NOCOUNT ON;
	Update Clientes
	Set Estado = @Estado
	where Codigo = @Codigo
END


-- =============================================
--INSERTAR CLIENTES
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_cliente]
	(
	    @Nombre varchar(255),
		@Telefono varchar(255),
		@Contacto varchar(255),
		@Direccion varchar(255),
		@Estado int	
	)
AS
BEGIN

	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert Into Clientes(Nombre,Telefono,Contacto,Direccion, Estado)	
	Values(@Nombre,@Telefono,@Contacto,@Direccion, @Estado)

	-- devuelve el id generado durante del Insert
	Select cast(Scope_Identity() as int)
END
GO


-- =============================================
--OBTENER CLIENTES POR ID
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtener_cliente_porID]
	(
	  @Codigo int
	)
AS
BEGIN

	SET NOCOUNT ON;
	Select * from Clientes
	where Codigo = @Codigo

END


-- =============================================
--OBTENER CLIENTES
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtener_clientes] 
AS
BEGIN
	SET NOCOUNT ON;
	SELECT  Codigo,
			Nombre,
			Telefono,
			Contacto,
			Direccion,
			Estado
    from    Clientes
END


--Al navegar a la opción de usuarios se presentará una lista con los usuarios. Cada fila tiene opciones de editar y eliminar los usuario
--USUARIO PROCESOS ALMACENADOS

-- =============================================
--ACTUALIZAR USUARIOS
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[actualizar_usuario] 
	(
		@Codigo int,
		@Nombre varchar(255),
		@Usuario varchar(255),
		@Contrasenia varchar(255),
		@Estado int
	)
AS
BEGIN

	SET NOCOUNT ON;
	Update Usuarios
	SET 
	Nombre = @Nombre,
	Usuario = @Usuario,
	Contrasenia = @Contrasenia,
	Estado = @Estado
	where Codigo = @Codigo

END
GO

-- =============================================
--ELIMINAR USUARIOS
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[eliminar_usuario]
	(
	@Codigo int,
	@Estado int
	)
AS
BEGIN

	SET NOCOUNT ON;
	Update Usuarios
	Set Estado = @Estado
	where Codigo = @Codigo
END

-- =============================================
--INSERTAR USUARIOS
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_usuario]
	(
		@Nombre varchar(255),
		@Usuario varchar(255),
		@Contrasenia varchar(255),
		@Estado int
	)
AS
BEGIN

	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert Into Usuarios(Nombre,Usuario,Contrasenia,Estado)	
	Values(@Nombre,@Usuario,@Contrasenia,@Estado)

	-- devuelve el id generado durante del Insert
	Select cast(Scope_Identity() as int)
END
GO

-- =============================================
--OBTENER USUARIOS POR ID
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtener_usuario_porID]
	(
	  @Codigo int
	)
AS
BEGIN

	SET NOCOUNT ON;
	Select * from Usuarios
	where Codigo = @Codigo

END

-- =============================================
--OBTENER CLIENTES
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtener_usuarios] 
AS
BEGIN
	SET NOCOUNT ON;
	SELECT  Codigo,
			Nombre,
			Usuario,
			Contrasenia,
			Estado
    from    Usuarios
END


-- =============================================
--VALIDAR USUARIOS
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[validar_usuario]
	(
	 @Usuario nvarchar(50),
	 @Contrasenia nvarchar(50)
	)
AS
BEGIN

	SET NOCOUNT ON;
	SELECT * from Usuarios where Usuario = @Usuario and Contrasenia = @contrasenia and Estado = 1
END
GO


----CHOFERES PROCESOS ALMACENADOS

--=============================================
--ACTUALIZAR CHOFERES
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[actualizar_chofer] 
	(
		@Codigo int,
		@Nombre varchar(255),
		@Cedula varchar(255),
		@Telefono varchar(255),
		@Estado int
	)
AS
BEGIN

	SET NOCOUNT ON;
	Update Choferes
	SET 
	Nombre = @Nombre,
	Cedula = @Cedula,
    Telefono = @Telefono,
	Estado = @Estado
	where Codigo = @Codigo

END
GO

-- =============================================
--ELIMINAR Chofer
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[eliminar_chofer]
	(
	@Codigo int,
	@Estado int
	)
AS
BEGIN

	SET NOCOUNT ON;
	Update Choferes
	Set Estado = @Estado
	where Codigo = @Codigo
END


-- =============================================
--INSERTAR Choferes
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_chofer]
	(
		@Nombre varchar(255),
		@Cedula varchar(255),
		@Telefono varchar(255),
		@Estado int
	)
AS
BEGIN

	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert Into Choferes(Nombre,Cedula,Telefono, Estado)	
	Values(@Nombre,@Cedula,@Telefono, @Estado)

	-- devuelve el id generado durante del Insert
	Select cast(Scope_Identity() as int)
END
GO

-- =============================================
--OBTENER Choferes POR ID
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtener_chofer_porID]
	(
	  @Codigo int
	)
AS
BEGIN

	SET NOCOUNT ON;
	Select * from Choferes
	where Codigo = @Codigo

END


-- =============================================
--OBTENER CHOFERES
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtener_choferes] 
AS
BEGIN
	SET NOCOUNT ON;
	SELECT  Codigo,
			Nombre,
			Cedula,
			Telefono,
			Estado
    from    Choferes
END


----CAMIONES PROCESOS ALMACENADOS

--=============================================
--ACTUALIZAR Camiones

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[actualizar_camiones] 
	(
		@Codigo int,
		@Unidad varchar(255),
		@Placa varchar(255),
		@Estado int
	)
AS
BEGIN

	SET NOCOUNT ON;
	Update Camiones
	SET 
	Unidad = @Unidad,
	Placa = @Placa,
	Estado = @Estado
	where Codigo = @Codigo

END
GO

-- =============================================
--ELIMINAR camiones
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[eliminar_camiones]
	(
	@Codigo int,
	@Estado int
	)
AS
BEGIN

	SET NOCOUNT ON;
	Update Camiones
	SET Estado = @Estado
	where Codigo = @Codigo
END

-- =============================================
--INSERTAR Camiones
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_camiones]
	(
		@Unidad varchar(255),
		@Placa varchar(255),
		@Estado int
	)
AS
BEGIN

	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert Into Camiones(Unidad,Placa, Estado)	
	Values(@Unidad,@Placa,@Estado)

	-- devuelve el id generado durante del Insert
	Select cast(Scope_Identity() as int)
END
GO

-- =============================================
--OBTENER CAMIONES POR ID
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtener_camiones_porID]
	(
	  @Codigo int
	)
AS
BEGIN

	SET NOCOUNT ON;
	Select * from Camiones
	where Codigo = @Codigo

END


-- =============================================
--OBTENER Camiones
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtener_camiones] 
AS
BEGIN
	SET NOCOUNT ON;
	SELECT  Codigo,
			Unidad,
			Placa,
			Estado
    from    Camiones
END
