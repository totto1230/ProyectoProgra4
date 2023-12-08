------CREACION DE TABLAS
--Usuarios

CREATE TABLE dbo.Usuarios (
    Codigo INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(255) NOT NULL,
    Usuario VARCHAR(255) NOT NULL,
	Contrasenia VARCHAR(255) NOT NULL,
    Estado INT NOT NULL
);

--Choferes

CREATE TABLE dbo.Choferes (
    Codigo INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(255) NOT NULL,
    Cedula VARCHAR(255) NOT NULL,
	Telefono VARCHAR(255) NOT NULL,
    Estado INT NOT NULL
);

--Camiones

CREATE TABLE dbo.Camiones (
    Codigo INT IDENTITY(1,1) PRIMARY KEY,
    Unidad VARCHAR(255) NOT NULL,
	Placa VARCHAR(255) NOT NULL,
    Estado INT NOT NULL
);

--Clientes

CREATE TABLE dbo.Clientes (
    Codigo INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(255) NOT NULL,
	Telefono VARCHAR(255) NOT NULL,
	Contacto VARCHAR(255) NOT NULL,
	Direccion VARCHAR(255) NOT NULL,
    Estado INT NOT NULL
);

--Rutas
CREATE TABLE dbo.Rutas (
    Codigo INT IDENTITY(1,1) PRIMARY KEY,
    CodigoClientes INT NOT NULL,
    CodigoChoferes INT NOT NULL,
	CodigoCamiones INT NOT NULL,
    DireccionEntrega VARCHAR (255),
    FechaCreacion DATETIME,
    Estado INT NOT NULL

    FOREIGN KEY (CodigoClientes) REFERENCES Clientes(Codigo),
    FOREIGN KEY (CodigoChoferes) REFERENCES Choferes(Codigo),
    FOREIGN KEY (CodigoCamiones) REFERENCES Camiones(Codigo)
);
------LLENAR TABLAS
---USUARIOS:

INSERT INTO Usuarios (Nombre,Usuario,Contrasenia, Estado)
VALUES ('Joseph','joseph','test', 1);

INSERT INTO Usuarios (Nombre,Usuario,Contrasenia, Estado)
VALUES ('Alejandro','alejandro','test', 1);

INSERT INTO Usuarios (Nombre,Usuario,Contrasenia, Estado)
VALUES ('Joseph2','joseph2','test', 1);

INSERT INTO Usuarios (Nombre,Usuario,Contrasenia, Estado)
VALUES ('Alejandro2','alejandro2','test', 1);

INSERT INTO Usuarios (Nombre,Usuario,Contrasenia, Estado)
VALUES ('Progra4','progra4','test', 1);

---CHOFERES:
INSERT INTO Choferes (Nombre,Cedula,Telefono, Estado)
VALUES ('Chofer1','111111','88888888', 1);

INSERT INTO Choferes (Nombre,Cedula,Telefono, Estado)
VALUES ('Chofer2','222222','77777777', 1);

INSERT INTO Choferes (Nombre,Cedula,Telefono, Estado)
VALUES ('Chofer3','333333','66666666', 1);

INSERT INTO Choferes (Nombre,Cedula,Telefono, Estado)
VALUES ('Chofer4','444444','55555555', 1);

INSERT INTO Choferes (Nombre,Cedula,Telefono, Estado)
VALUES ('Chofer5','555555','44444444', 1);

---CAMIONES:
INSERT INTO Camiones (Unidad,Placa, Estado)
VALUES ('Camion1','111111', 1);

INSERT INTO Camiones (Unidad,Placa, Estado)
VALUES ('Camion2','222222', 1);

INSERT INTO Camiones (Unidad,Placa, Estado)
VALUES ('Camion3','333333', 1);

INSERT INTO Camiones (Unidad,Placa, Estado)
VALUES ('Camion4','444444', 1);

INSERT INTO Camiones (Unidad,Placa, Estado)
VALUES ('Camion5','555555', 1);

--Clientes

INSERT INTO Clientes (Nombre, Telefono, Contacto, Direccion, Estado)
VALUES ('Cliente1','8888888','test','CR', 1)

INSERT INTO Clientes (Nombre, Telefono, Contacto, Direccion, Estado)
VALUES ('Cliente2','12122112','test','CR', 1)

INSERT INTO Clientes (Nombre, Telefono, Contacto, Direccion, Estado)
VALUES ('Cliente3','7777777','test','CR', 1)

INSERT INTO Clientes (Nombre, Telefono, Contacto, Direccion, Estado)
VALUES ('Cliente4','87654321','test','CR', 1)

INSERT INTO Clientes (Nombre, Telefono, Contacto, Direccion, Estado)
VALUES ('Cliente5','12345678','test','CR', 1)

