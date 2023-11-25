--Creacion de Base de datos de banco
Create database Banco

use banco 
--CREACION DE TABLAS
Create Table Clientes(
id_cliente int identity(1,1),
dni varchar(10),
nombre varchar(50) not null,
apellido varchar (50) not null,
fecha_alta datetime,
fecha_baja datetime
Constraint pk_clientes Primary key (id_cliente)
)

Create Table Tipos_Cuentas(
id_tipo_cuenta int identity(1,1),
nombre varchar(50) not null
constraint pk_tipos_ctas primary key(id_tipo_cuenta)
)

INSERT INTO Tipos_Cuentas (nombre) values ('Caja de ahorro en pesos')
INSERT INTO Tipos_Cuentas (nombre) values ('Caja de ahorro en dolares')
INSERT INTO Tipos_Cuentas (nombre) values ('Cuenta sueldo')
INSERT INTO Tipos_Cuentas (nombre) values ('Caja Titulos Públicos')
INSERT INTO Tipos_Cuentas (nombre) values ('´Cuenta Corriente')
select * from Tipos_Cuentas



Create table Cuentas(
cbu int identity(1,1),
id_cliente int,
saldo decimal,
id_tipo int not null,
ult_mov decimal,
fecha_alta datetime not null,
fecha_ult_mov datetime,
fecha_baja datetime
constraint pk_cuenta_cliente Primary key (cbu,id_cliente),
constraint fk_cliente Foreign key (id_cliente)
			References  Clientes(id_cliente),
constraint fk_tipo Foreign key (id_tipo)
			References  Tipos_Cuentas(id_tipo_cuenta)
)

--CREACION DE PRCEDIMIENTOS ALMACENADOS

--Consultar Clientes
CREATE PROCEDURE [dbo].[SP_CONSULTAR_CLIENTES]
AS
BEGIN
	
	SELECT * from Clientes
END
GO

--Consultar Clientes
CREATE PROCEDURE [dbo].[SP_CONSUL_CLIENTES_FILTRO]
@nombre
AS
BEGIN
	
	SELECT * from Clientes
END
GO






--Consultar Tipos de cuentas
CREATE PROCEDURE [dbo].[SP_CONSULTAR_TIPO_DE_CUENTAS]
AS
BEGIN
	
	SELECT * from Tipos_Cuentas;
END
GO

--Eliminar CLiente

CREATE PROCEDURE [dbo].[SP_ELIMINAR_CLIENTE] 
	@clienteo_nro int
AS
BEGIN
	UPDATE CLIENTES SET fecha_baja = GETDATE()
	WHERE id_cliente = @clienteo_nro;
END

--Eliminar Cuenta

CREATE PROCEDURE [dbo].[SP_ELIMINAR_CUENTA] 
	@CBU int
AS
BEGIN
	UPDATE Cuentas SET fecha_baja = GETDATE()
	WHERE cbu = @CBU;
END



--Insertar detalle Maestro
CREATE PROCEDURE [dbo].[SP_INSERTAR_DETALLE] 
	@id_cliente int,
	@id_tipo int, 
	@saldo decimal, 
	@ultimo_mov decimal,
	@fecha_ult_mov datetime
AS
BEGIN
	INSERT INTO CUENTAS(id_cliente,id_tipo, saldo,ult_mov, fecha_ult_mov)
    VALUES (@id_cliente,@id_tipo,@saldo,@ultimo_mov,@fecha_ult_mov);
  
END



--Insertar Maestro


CREATE PROCEDURE [dbo].[SP_INSERTAR_MAESTRO] 
	@dni varchar(10), 
	@nombre varchar(50),
	@apellido  varchar(50),
	@cliente_nro int OUTPUT
AS
BEGIN
	INSERT INTO T_CLIENTES(fecha_alta, dni, nombre, apellido)
    VALUES (GETDATE(), @dni, @nombre, @apellido);
    --Asignamos el valor del último ID autogenerado (obtenido --  
    --mediante la función SCOPE_IDENTITY() de SQLServer)	
    SET @cliente_nro = SCOPE_IDENTITY();
END


CREATE PROCEDURE [dbo].[SP_INSERTAR_CLIENTE] 
	@dni varchar(10), 
	@nombre varchar(50),
	@apellido  varchar(50),
AS
BEGIN
	INSERT INTO T_CLIENTES(fecha_alta, dni, nombre, apellido)
    VALUES (GETDATE(), @dni, @nombre, @apellido);
END





--Modificar Maestro

CREATE PROCEDURE [dbo].[SP_MODIFICAR_MAESTRO] 
	@dni varchar(10), 
	@nombre varchar(50),
	@apellido  varchar(50),
	@cliente_nro int OUTPUT
AS
BEGIN
	UPDATE T_CLIENTE SET dni = @dni, nombre=@nombre,apellido = @apellido
	WHERE id_cliente =@cliente_nro;
	
END


--Modificar solo cliente 

CREATE PROCEDURE [dbo].[SP_MODIFICAR_CLIENTE]
	@Id_cliente int,
	@dni varchar(10), 
	@nombre varchar(50),
	@apellido  varchar(50),
AS
BEGIN
	UPDATE T_CLIENTE SET dni = @dni, nombre=@nombre,apellido = @apellido
	WHERE id_cliente =@Id_cliente;
	
END


--AFGAFGAFGAFGAFGAAAAAAAAAGAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA



--Proximo ID


CREATE PROCEDURE [dbo].[SP_PROXIMO_ID]
@next int OUTPUT
AS
BEGIN
	SET @next = (SELECT MAX(id_cliente)+1  FROM T_CLIENTES);
END




--AGREGAR REPORTE 


CREATE PROCEDURE [dbo].[SP_REPORTE_PRODUCTOS]
@fecha_desde datetime, 
@fecha_hasta datetime 

AS
BEGIN
	SELECT t2.n_producto as producto, SUM(t.cantidad) as cantidad
	FROM T_DETALLES_PRESUPUESTO t, T_PRODUCTOS t2, T_PRESUPUESTOS t3
	WHERE t.id_producto = t2.id_producto
	AND t.presupuesto_nro = t3.presupuesto_nro
	AND t3.fecha between @fecha_desde and @fecha_hasta
	GROUP BY t2.n_producto;
END
GO
USE [master]
GO
ALTER DATABASE [carpinteria_db] SET  READ_WRITE 
GO
