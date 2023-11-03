CREATE DATABASE TP_Autos

USE TP_Autos

CREATE TABLE Provincias
(id_provincia int IDENTITY(1,1) not null,
descripcion varchar(255) null

constraint pk_prov primary key (id_provincia)
);

CREATE TABLE Barrios
(id_barrio int identity(1,1) not null,
descripcion varchar(255) null,
id_provincia int null

constraint pk_barr primary key (id_barrio),

constraint fk_barr_prov FOREIGN KEY (id_provincia)
		references Provincias (id_provincia)
);

CREATE TABLE Tipos_Clientes
(id_tipo_cliente int identity(1,1) not null,
descripcion varchar(255) null

constraint pk_tipo_clientes primary key (id_tipo_cliente)
);

CREATE TABLE Clientes
(id_cliente int identity(1,1) not null,
id_tipo_cliente int null,
nombre varchar(200) null,
apellido varchar(200) null,
CUIT varchar(20) null,
dire_calle varchar(200) null,
dire_nro int,
id_barrio int 

constraint pk_clientes primary key (id_cliente),
constraint fk_clientes_tipo FOREIGN KEY (id_tipo_cliente)
		references Tipos_Clientes(id_tipo_cliente),
constraint fk_barrio_clien FOREIGN KEY (id_barrio)
		references Barrios (id_barrio)
);



CREATE TABLE Tipos_Contactos
(id_tipo_contacto int identity(1,1) not null,
descripcion varchar(255)

constraint pk_tipo_con primary key (id_tipo_contacto)
);

CREATE TABLE Categorias
(id_categoria int identity (1,1) not null,
descripcion varchar(255)

constraint pk_categorias primary key (id_categoria)
);

CREATE TABLE Vendedores
(id_vendedor int identity(1,1) not null,
id_categoria int,
apellido varchar(100),
nombre varchar(100),
CUIT varchar (20),
fecha_ingreso Datetime null

constraint pk_vend primary key (id_vendedor),
constraint fk_categ_vende FOREIGN KEY (id_categoria)
		references Categorias (id_categoria)
);

CREATE TABLE Contactos
(id_contacto int identity(1,1) not null,
id_tipo_contacto int,
id_cliente int,
descripcion varchar(255),
id_vendedor int

constraint pk_contac primary key (id_contacto),
constraint fk_tipo_con FOREIGN KEY (id_tipo_contacto)
		references Tipos_Contactos(id_tipo_contacto),
constraint fk_cliente_cont FOREIGN KEY(id_cliente)
			references Clientes (id_cliente),
constraint fk_vende_cont FOREIGN KEY (id_vendedor)
		references Vendedores (id_vendedor)
);

CREATE TABLE Descuentos
(id_descuento int identity (1,1) not null,
descripcion varchar (200),
porcentaje decimal(5,2)

constraint pk_descu primary key (id_descuento)
);

CREATE TABLE Tipos_Productos
(id_tipo_producto int identity(1,1) not null,
descripcion varchar(255)

constraint pk_tipo_prod primary key (id_tipo_producto)
);

CREATE TABLE Productos
(id_producto int identity(1,1) not null,
id_tipo_producto  int,
descripcion varchar(255),
precio decimal (10,2),
cant_min_por_mayor int,
cantidad int,
cantidad_min int 

constraint pk_prod primary key (id_producto),

constraint fk_prod_tipo FOREIGN KEY (id_tipo_producto)
		references Tipos_Productos (id_tipo_producto)
);

CREATE TABLE Cuotas
(id_cuota int identity(1,1) not null,
cantidad int 

constraint pk_cuotas primary key (id_cuota)
);

CREATE TABLE Tarjetas_Credito
(id_tarjeta int identity (1,1) not null,
descripcion varchar(255),
id_cuota int

constraint pk_tarj_cred primary key (id_tarjeta),

constraint fk_tarj_cuo FOREIGN KEY (id_cuota)
		references Cuotas (id_cuota)
);

CREATE TABLE Autoplanes
(id_autoplan int identity (1,1) not null,
id_cliente int,
cant_cuotas int,
interes decimal(10,2)

constraint pk_autoplan primary key (id_autoplan),

constraint fk_autopl_clien FOREIGN KEY (id_cliente)
		references Clientes (id_cliente)
);

CREATE TABLE Tipos_Ventas
(id_tipo_venta int identity(1,1) not null,
descripcion varchar (255)

constraint pk_tipo_vent primary key (id_tipo_venta)
);

CREATE TABLE Historiales_Precios
(id_historico int identity(1,1) not null,
id_producto int,
fecha datetime,
precio decimal(10,2)

constraint pk_historial primary key (id_historico),
constraint fk_prod_hist FOREIGN KEY(id_producto)
		references Productos (id_producto)
);

CREATE TABLE Formas_Pago
(id_forma_pago int identity(1,1) not null,
descripcion varchar(255),
id_tarjeta int 

constraint pk_form_pag primary key (id_forma_pago),

constraint fk_fomr_tarj FOREIGN KEY(id_tarjeta)
			references Tarjetas_Credito(id_tarjeta)
);

CREATE TABLE Ordenes_Pedidos
(id_orden_pedido int identity(1,1) not null,
id_cliente int,
fecha_entrega datetime,
fecha_pedido datetime

constraint pk_ord_ped primary key (id_orden_pedido),

constraint fk_clien_orde FOREIGN KEY(id_cliente)
references Clientes(id_cliente)
);

CREATE TABLE Detalles_Pedidos
(id_pedido int identity(1,1) not null,
id_orden_pedido int,
id_producto int,
cantidad int

constraint pk_detall_ped primary key (id_pedido),

constraint fk_ord_deta FOREIGN KEY(id_orden_pedido)
			references Ordenes_Pedidos (id_orden_pedido),

constraint fk_prod_detal FOREIGN KEY (id_producto)
		references Productos (id_producto)
);

CREATE TABLE Facturas
(id_factura int identity(1,1) not null,
id_cliente int,
fecha datetime,
id_vendedor int,
id_orden_pedido int,
id_autoplan int,
id_forma_pago int 

constraint pk_fac primary key (id_factura),

constraint fk_clien_fac FOREIGN KEY(id_cliente)
		references Clientes(id_cliente),

constraint fk_vend_fact FOREIGN KEY(id_vendedor)
			references Vendedores(id_vendedor),

constraint fk_orde_ped_fac FOREIGN KEY(id_orden_pedido)
			references Ordenes_Pedidos(id_orden_pedido),

constraint fk_autopl_fac FOREIGN KEY(id_autoplan)
		references Autoplanes(id_autoplan),

constraint fk_form_fac FOREIGN KEY(id_forma_pago)
			references Formas_Pago (id_forma_pago)
);

CREATE TABLE Detalles_Facturas
(id_detalle int identity(1,1) not null,
id_tipo_venta int,
id_factura int,
id_producto int,
cantidad int,
precio decimal(10,2),
id_descuento int 

constraint pk_deta_fac primary key (id_detalle),

constraint fk_venta_defac FOREIGN KEY(id_tipo_venta)
			references Tipos_Ventas (id_tipo_venta),

constraint fk_det_defac FOREIGN KEY(id_factura)
			references Facturas (id_factura),

constraint fk_prod_defac FOREIGN KEY(id_producto)
			references Productos (id_producto),

constraint fk_desc_defac FOREIGN KEY(id_descuento)
			references Descuentos(id_descuento)
);

--INSERT PARA CATEGORIAS
INSERT INTO Categorias([descripcion])
VALUES
    ('Vendedor Junior'),
    ('Vendedor Senior'),
    ('Gerente de Ventas'),
    ('Supervisor de Ventas'),
    ('Representante de Ventas');	

--INSERT PARA VENDEDORES
INSERT INTO Vendedores([id_categoria], [apellido], [nombre], [CUIT], [fecha_ingreso])
VALUES
    (1, 'G�mez', 'Juan', '20-12345678-9', '2022-01-15'),
    (2, 'Mart�nez', 'Mar�a', '27-98765432-1', '2021-05-10'),
    (1, 'L�pez', 'Carlos', '23-87654321-0', '2023-03-20'),
    (2, 'Rodr�guez', 'Ana', '20-34567890-1', '2020-12-05'),
    (3, 'Fern�ndez', 'Javier', '30-56789012-3', '2019-08-18');

	

--INSERT PARA DESCUENTOS
	INSERT INTO Descuentos([descripcion], [porcentaje])
VALUES
    ('Descuento A', 5.0),
    ('Descuento B', 10.0),
    ('Descuento C', 15.0),
    ('Descuento D', 20.0),
    ('Descuento E', 25.0);


--INSERT PARA CUOTAS
INSERT INTO Cuotas ([cantidad])
VALUES
    (3),
    (6),
    (12),
    (24),
    (36);

	--INSERT PARA PROVINCIAS
INSERT INTO Provincias ([descripcion])
VALUES
    ('Buenos Aires'),
    ('C�rdoba'),
    ('Santa Fe'),
    ('Mendoza'),
    ('Tucum�n');

--INSERT PARA BARRIOS
INSERT INTO Barrios ([descripcion], [id_provincia])
VALUES
    ('Palermo', 1),
    ('Nueva C�rdoba', 2),
    ('Centro', 3),
    ('Godoy Cruz', 4),
    ('San Miguel de Tucum�n', 5);

--INSERT PARA TIPO_CLIENTES
INSERT INTO Tipos_Clientes ([descripcion])
VALUES
    ('Individual'),
    ('Empresarial');

--INSERT PARA CLIENTES 
INSERT INTO Clientes ([id_tipo_cliente], [nombre], [apellido], [CUIT], [dire_calle], [dire_nro], [id_barrio])
VALUES
    (1, 'Juan', 'Gonz�lez', '20-12345678-9', 'Av. Rivadavia', 1234, 2),
    (1, 'Mar�a', 'L�pez', '27-98765432-1', 'Av. San Mart�n', 567, 2),
    (2, 'Carlos', 'Mart�nez', '23-87654321-0', 'Av. Belgrano', 890, 3),
    (1, 'Ana', 'Fern�ndez', '20-34567890-1', 'Av. Pueyrred�n', 456, 4),
    (2, 'Javier', 'Rodr�guez', '30-56789012-3', 'Av. C�rdoba', 789, 5);

	--INSERT TIPOS CONTACTOS
INSERT INTO Tipos_Contactos ([descripcion])
VALUES
    ('Correo electr�nico'),
    ('Tel�fono'),
    ('WhatsApp'),
    ('Redes Sociales');

--INSERT PARA CONTACTOS no
INSERT INTO Contactos ([id_tipo_contacto], [id_cliente], [descripcion], [id_vendedor])
VALUES
    (1, 1, 'juan.gonzalez@email.com', 1),
    (2, 2, '555-1234567', 2),
    (3, 3, '011-9876543', 3),
    (4, 4, 'ana.fernandez@email.com', 4),
    (4, 5, 'javier.rodriguez@email.com', 5);

--INSERT TIPOS_PRODUCT
INSERT INTO Tipos_Productos ([descripcion])
VALUES
    ('Partes del Motor'),
    ('Filtros de Aceite'),
    ('Neum�ticos'),
    ('Frenos'),
    ('Suspensi�n');

	
--INSERT PARA PRODUCTOS
INSERT INTO Productos ([id_tipo_producto], [descripcion], [precio], [cant_min_por_mayor], [cantidad], [cantidad_min])
VALUES
    (1, 'Pist�n', 50.0, 10, 100, 5),
    (2, 'Filtro de Aceite', 15.0, 20, 200, 10),
    (3,'Neum�tico 225/55R17', 120.01, 5, 50, 2),
    (4, 'Pastillas de Freno', 25.0, 15, 150, 10),
    (5, 'Amortiguador Trasero', 40.0, 8, 80, 4);

	select * from  Vendedores

--INSERT TIPO_VENTAS
INSERT INTO Tipos_Ventas ([descripcion])
VALUES
    ('Venta al por mayor'),
    ('Venta al por menor');

	--INSERT PARA TARJETAS_CREDITO
INSERT INTO Tarjetas_credito(descripcion,id_cuota)
VALUES 
		('Bancor',1),
		('Banco Nacion',2),
		('Galicia',3),
		('Sandander Rio',4),
		('HSVC',5);

--INSERT PARA FORMAS_PAGO
INSERT INTO Formas_Pago([descripcion], [id_tarjeta])
VALUES
    ('Efectivo', NULL),
    ('Tarjeta de Cr�dito', 1),
    ('Tarjeta de D�bito', 2),
    ('Transferencia Bancaria', null),
    ('Cheque', NULL);

--INSERT PARA HISTORIALES PRECIOS
INSERT INTO Historiales_precios ([id_producto], [fecha], [precio])
VALUES
    (1, '2023-01-01', 50.0);
	
--INSERT PARA AUTOPLANES ,NO
INSERT INTO Autoplanes ([id_cliente], [Cant_cuotas], [interes])
VALUES
    (1, 12, 0.1),
    (2, 6, 0.08),
    (3, 24, 0.15),
    (4, 12, 0.12),
    (5, 18, 0.09);

set dateformat dmy;

	--INSERT INTO ORDENES_PEDIDOS
INSERT INTO Ordenes_Pedidos([id_cliente],[fecha_entrega],[fecha_pedido])
	VALUES 
	(1,'02/05/2022','15/08/2021'),
	(2, '20/11/2020','06/04/2018'),
	(3,'01/03/2023','17/12/2021'),
	(4,'12/10/2019','03/02/2019'),
	(5,'23/04/2022','13/09/2020');

--INSERT INTO FACTURAS
INSERT INTO Facturas ([id_cliente],[fecha],[id_vendedor] ,[id_orden_pedido] ,[id_autoplan] ,[id_forma_pago])
	VALUES 
		(1,'02/05/2022',1,1,1,1),
		(2,'09/04/2020',2,2,2,2),
		(3,'10/04/2020',3,3,3,3),
		(4,'23/05/2021',4,4,4,4),
		(5,'20/06/2021',5,5,5,5);
	
--INSERT INTO DETALLE_FACTURAS
INSERT INTO Detalles_Facturas([id_tipo_venta],[id_factura],[id_producto],[cantidad],[precio],[id_descuento])
VALUES
		(1,1,2,150,18015.01,1),
		(2,2,1,50,2500.01,2),
		(2,3,5,102,4120.20,3),
		(1,4,3,20,5540.01,4),
		(2,5,4,70,7990.50,5);

--INSERT INTO DETALLES_PEDIDOS
INSERT INTO detalles_pedidos ([id_orden_pedido], [id_producto],[cantidad])
	VALUES (1,1,50), 
		(2,2,27),
		(3,3,45),
		(4,4,63),
		(5,5,80);
GO

-- SPs

-- INSERTAR VENDEDOR

CREATE PROCEDURE SP_INSERT_VENDEDOR
    @id_categoria int,
    @apellido varchar(100),
    @nombre varchar(100),
    @CUIT varchar(20),
    @fecha_ingreso datetime
AS
BEGIN
    INSERT INTO Vendedores(id_categoria, apellido, nombre, CUIT, fecha_ingreso)
    VALUES (@id_categoria, @apellido, @nombre, @CUIT, @fecha_ingreso)
END;
GO

-- INSERTAR VENDEDOR
CREATE PROCEDURE SP_INSERT_CLIENTE
    @id_tipo_cliente int,
    @nombre varchar(200),
    @apellido varchar(200),
    @CUIT varchar(20),
    @dire_calle varchar(200),
    @dire_nro int,
    @id_barrio int
AS
BEGIN
    INSERT INTO Clientes(id_tipo_cliente, nombre, apellido, CUIT, dire_calle, dire_nro, id_barrio)
    VALUES (@id_tipo_cliente, @nombre, @apellido, @CUIT, @dire_calle, @dire_nro, @id_barrio)
END;
GO

-- INSERTAR PRODUCTO
CREATE PROCEDURE SP_INSERT_PRODUCTO
    @id_tipo_producto int,
    @descripcion varchar(255),
    @precio decimal(10,2),
    @cant_min_por_mayor int,
    @cantidad int,
    @cantidad_min int
AS
BEGIN
    INSERT INTO Productos(id_tipo_producto, descripcion, precio, cant_min_por_mayor, cantidad, cantidad_min)
    VALUES (@id_tipo_producto, @descripcion, @precio, @cant_min_por_mayor, @cantidad, @cantidad_min)
END;
GO

-- SELECT CLIENTES
CREATE PROCEDURE SP_SELECT_CLIENTES
AS
BEGIN
    SELECT * FROM Clientes
END;
GO

-- SELECT VENDEDORES
CREATE PROCEDURE SP_SELECT_VENDEDORES
AS
BEGIN
    SELECT * FROM Vendedores
END;
GO

-- SELECT PRODUCTOS
CREATE PROCEDURE SP_SELECT_PRODUCTOS
AS
BEGIN
    SELECT * FROM Productos
END;
GO