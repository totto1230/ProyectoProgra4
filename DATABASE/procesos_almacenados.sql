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
		@Estado bit
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
	@Estado bit
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
		@Estado bit	
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
		@Estado bit
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
	@Estado bit
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
		@Estado bit
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
		@Estado bit
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
	@Estado bit
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
		@Estado bit
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
		@Estado bit
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
	@Estado bit
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
		@Estado bit
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
			Estado
    from    Camiones
END


----RUTAS PROCESOS ALMACENADOS
-- =============================================
--OBTENER Rutas
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtener_rutas] 
AS
BEGIN
    SET NOCOUNT ON;

    SELECT  Codigo,
            CodigoClientes,
            Estado
    FROM    Rutas
	Where Estado = 1 or Estado = 0
END




-- =============================================
--INSERTAR Rutas
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_ruta]
    @CodigoClientes INT,
    @CodigoChoferes INT,
    @CodigoCamiones INT,
	@DireccionEntrega VARCHAR (225),
	@FechaCreacion DATETIME,
    @Estado bit
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM Clientes WHERE Codigo = @CodigoClientes)
       AND EXISTS (SELECT 1 FROM Choferes WHERE Codigo = @CodigoChoferes)
       AND EXISTS (SELECT 1 FROM Camiones WHERE Codigo = @CodigoCamiones)
    BEGIN
		INSERT INTO Rutas (CodigoClientes, CodigoChoferes, CodigoCamiones, DireccionEntrega, FechaCreacion, Estado)
		VALUES (@CodigoClientes, @CodigoChoferes, @CodigoCamiones, @DireccionEntrega, @FechaCreacion, @Estado);
	END

	Select cast(Scope_Identity() as int)
END


-- =============================================
--CAMBIAR ESTADO Rutas


GO
/****** Object:  StoredProcedure [dbo].[cambiarestado_ruta]    Script Date: 12/13/2023 9:14:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[cambiarestado_ruta]
    @CodigoRuta INT,
    @NuevoEstado INT,
	@NuevaFechaCreacion datetime
AS
BEGIN
    SET NOCOUNT ON;

    
    IF EXISTS (SELECT 1 FROM Rutas WHERE Codigo = @CodigoRuta)
    BEGIN
        
        UPDATE Rutas
        SET Estado = @NuevoEstado,
		    FechaCreacion = @NuevaFechaCreacion
        WHERE Codigo = @CodigoRuta;

    END
END


--REPORTES RUTAS
--OBTENER Rutas POR ID
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtener_ruta_porID]
	(
	  @Codigo int
	)
AS
BEGIN

	SET NOCOUNT ON;
	Select * from Rutas
	where Codigo = @Codigo

END


-- =============================================

-----Obtener_reporte_rutas

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE obtener_reporte_rutas
       @FechaInicio DATEtime,
	   @FechaFinal Datetime,
	   @Cliente int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT FechaCreacion, CodigoChoferes , CodigoCamiones , Estado
	From Rutas
	Where @Cliente = CodigoClientes and @FechaInicio >= FechaCreacion and FechaCreacion <= @FechaFinal

END
GO

--------- obtener_todos_reportes
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE obtener_todos_reportes
   
AS
BEGIN
	SET NOCOUNT ON;
	SELECT *
	From Rutas
	

END
GO

-------Carga_dropdown_clientes

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[carga_dropdown_clientes]
	
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT Codigo, Nombre from Clientes
	where Estado = 1
	Order by Nombre ASC

END
GO

-------Carga_dropdown_choferes


GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[carga_dropdown_choferes]
	
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT Codigo, Nombre from Choferes
	where Estado = 1
	Order by Nombre ASC

	END

GO


---------------Carga_dropdown_camiones 



GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[carga_dropdown_camiones]
	
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT Codigo, Unidad from Camiones
	where Estado = 1
	Order by Unidad ASC

	END

GO

GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_reportes]    Script Date: 12/10/2023 2:53:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtener_todos_reportes]
AS
BEGIN

	SET NOCOUNT ON;
	SELECT FechaCreacion,CodigoChoferes,CodigoCamiones,Estado from Rutas
END
