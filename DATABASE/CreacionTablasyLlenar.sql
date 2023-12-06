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

------LLENAR TABLAS
---USUARIOS:

INSERT INTO Usuarios (Nombre,Usuario,Contrasenia)
VALUES ('Joseph','joseph','test');

INSERT INTO Usuarios (Nombre,Usuario,Contrasenia)
VALUES ('Alejandro','alejandro','test');

INSERT INTO Usuarios (Nombre,Usuario,Contrasenia)
VALUES ('Joseph2','joseph2','test');

INSERT INTO Usuarios (Nombre,Usuario,Contrasenia)
VALUES ('Alejandro2','alejandro2','test');

INSERT INTO Usuarios (Nombre,Usuario,Contrasenia)
VALUES ('Progra4','progra4','test');

---CHOFERES:
INSERT INTO Choferes (Nombre,Cedula,Telefono)
VALUES ('Chofer1','111111','88888888');

INSERT INTO Choferes (Nombre,Cedula,Telefono)
VALUES ('Chofer2','222222','77777777');

INSERT INTO Choferes (Nombre,Cedula,Telefono)
VALUES ('Chofer3','333333','66666666');

INSERT INTO Choferes (Nombre,Cedula,Telefono)
VALUES ('Chofer4','444444','55555555');

INSERT INTO Choferes (Nombre,Cedula,Telefono)
VALUES ('Chofer5','555555','44444444');

---CAMIONES:
INSERT INTO Camiones (Unidad,Placa)
VALUES ('Camion1','111111');

INSERT INTO Camiones (Unidad,Placa)
VALUES ('Camion2','222222');

INSERT INTO Camiones (Unidad,Placa)
VALUES ('Camion3','333333');

INSERT INTO Camiones (Unidad,Placa)
VALUES ('Camion4','444444');

INSERT INTO Camiones (Unidad,Placa)
VALUES ('Camion5','555555');

--Clientes

INSERT INTO Clientes (Nombre, Telefono, Contacto, Direccion)
VALUES ('Cliente1','8888888','test','CR')

INSERT INTO Clientes (Nombre, Telefono, Contacto, Direccion)
VALUES ('Cliente2','12122112','test','CR')

INSERT INTO Clientes (Nombre, Telefono, Contacto, Direccion)
VALUES ('Cliente3','7777777','test','CR')

INSERT INTO Clientes (Nombre, Telefono, Contacto, Direccion)
VALUES ('Cliente4','87654321','test','CR')

INSERT INTO Clientes (Nombre, Telefono, Contacto, Direccion)
VALUES ('Cliente5','12345678','test','CR')