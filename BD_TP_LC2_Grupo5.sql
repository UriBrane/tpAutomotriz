CREATE DATABASE TP_Autos_19_11
GO
USE TP_Autos_19_11
GO

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
CUIT bigint,
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
CUIT bigint,
contrasenia varchar(64),
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
cant_min_por_mayor int not null,
cantidad int not null,
cantidad_min int not null

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


constraint pk_tarj_cred primary key (id_tarjeta),


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
id_tarjeta int,
id_cuota int

constraint pk_form_pag primary key (id_forma_pago),

constraint fk_fomr_tarj FOREIGN KEY(id_tarjeta)
			references Tarjetas_Credito(id_tarjeta),
constraint fk_tarj_cuo FOREIGN KEY (id_cuota)
		references Cuotas (id_cuota)
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
id_forma_pago int ,
anulada bit,

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
    (1, 'Gomez', 'Juan', 20123456789, '2022-01-15'),
    (2, 'Martinez', 'Maria', 27987654321, '2021-05-10'),
    (1, 'Lopez', 'Carlos', 23876543210, '2023-03-20'),
    (2, 'Rodriguez', 'Ana', 20345678901, '2020-12-05'),
    (3, 'Fernandez', 'Javier', 30567890123, '2019-08-18'),
    (1, 'Perez', 'Rodolfo', 27823456789, '2020/01/20'),
    (2, 'Laguna', 'Rafael', 24587654321, '2023/03/10'),
    (1, 'Diaz', 'Rosa', 21376543210, '2022/03/20'),
    (2, 'Llanes', 'Mariela', 21345678901, '2020/03/05'),
    (3, 'Arneudo', 'Fernando', 34567890123, '2019/05/18'),
    (1, 'Martinez', 'Hugo', 24123456789, '2020-01-15'),
    (2, 'Pozzi', 'Gustavo', 27987654321, '2022-05-10'),
    (1, 'Roldan', 'Mairan Ines', 25876543210, '2022-03-20'),
    (2, 'Arnaudo', 'Ana', 29834678901, '2023-12-05'),
    (3, 'Raful', 'Javier', 323567890123, '2019-08-18');


--INSERT PARA DESCUENTOS
	INSERT INTO Descuentos([descripcion], [porcentaje])
VALUES
    ('Sin descuento', 0),
    ('Descuento del 5', 5.0),
    ('Descuento del 10', 10.0),
    ('Descuento del 15', 15.0),
    ('Descuento del 20', 20.0),
    ('Descuento del 25', 25.0);


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
    ('Cordoba'),
    ('Santa Fe'),
    ('Mendoza'),
    ('Tucuman'),
    ('Chaco'),
    ('San Luis'),
    ('Jujuy'),
    ('Formosa'),
    ('Rio Negro'),
    ('Corrientes'),
    ('La Rioja'),
    ('Neuquen'),
    ('Misiones'),
    ('La Pampa');

--INSERT PARA BARRIOS
INSERT INTO Barrios ([descripcion], [id_provincia])
VALUES
    ('Palermo', 1),
    ('Nueva Cordoba', 2),
    ('Centro', 3),
    ('Godoy Cruz', 4),
    ('San Miguel de Tucuman', 5),
    ('Lamadrid', 6),
    ('Las Bervenas', 7),
    ('Abra Pampa', 8),
    ('El colorado', 9),
    ('El Porvenir', 10),
    ('Goya', 11),
    ('San Vicente', 12),
    ('Colona Nueva Esperanza', 13),
    ('Olimpia', 14),
    ('Santa Rosa', 15);

--INSERT PARA TIPO_CLIENTES
INSERT INTO Tipos_Clientes ([descripcion])
VALUES
    ('Individual'),
    ('Empresarial');

--INSERT PARA CLIENTES 
INSERT INTO Clientes ([id_tipo_cliente], [nombre], [apellido], [CUIT], [dire_calle], [dire_nro], [id_barrio])
VALUES
    (1, 'Juan', 'Gonzalez', 20123456789, 'Av. Rivadavia', 1234, 2),
    (1, 'Maria', 'Lopez', 27987654321, 'Av. San Martin', 567, 2),
    (2, 'Carlos', 'Martinez', 23876543210, 'Av. Belgrano', 890, 3),
    (1, 'Ana', 'Fernandez', 20345678901, 'Av. Pueyrredon', 456, 4),
    (2, 'Javier', 'Rodriguez', 30567890123, 'Av. Cordoba', 789, 5),
    (1, 'Benjamin', 'Lopez', 21123456789, 'Av. Colonial', 1254, 6),
    (1, 'Lautaro', 'Misso', 22987654321, 'Av. La Marinna', 557, 7),
    (2, 'Morena', 'Ledezma', 23476543210, 'Av. Belgrano', 810, 8),
    (1, 'Evangelina', 'Mundirran', 25345678901, 'Av. Sucre', 256, 9),
    (2, 'Diego', 'Boaglio', 35667890123, 'Av. Caracas', 709, 10),
    (1, 'Mirta', 'Gonzalez', 27823456789, 'Av. La Paz', 134, 11),
    (1, 'Simon', 'Folco', 27987698321, 'Av. Echeverry', 967, 12),
    (2, 'Joaquin', 'Brizio', 23854543210, 'Av. Amador', 890, 13),
    (1, 'Julian', 'Fernandez', 20235678901, 'Av. Junin', 246, 14),
    (2, 'Carlos', 'Rodreguez', 30567800123, 'Av. Tejelo', 1009, 15);

	--INSERT TIPOS CONTACTOS
INSERT INTO Tipos_Contactos ([descripcion])
VALUES
    ('Correo electronico'),
    ('Telefono'),
    ('WhatsApp'),
    ('Redes Sociales');

--INSERT PARA CONTACTOS no
INSERT INTO Contactos ([id_tipo_contacto], [id_cliente], [descripcion], [id_vendedor])
VALUES
    (1, 1, 'juan.gonzalez@email.com', 1),
    (2, 2, '555-1234567', 2),
    (3, 3, '011-9876543', 3),
    (4, 4, 'ana.fernandez@email.com', 4),
    (4, 5, 'javier.rodriguez@email.com', 5),
    (1, 6, 'benj_lopez@email.com', 8),
    (2, 7, '545-1234667', 9),
    (3, 8, '011-9898543', 10),
    (4, 9, 'evang@email.com', 11),
    (4, 10, 'diego@email.com', 12),
    (1, 11, 'mirta_098@email.com', 13),
    (2, 12, '555-1454567', 14),
    (3, 13, '011-9876093', 15),
    (4, 14, 'julian@email.com', 7),
    (4, 15, 'carlos._09@email.com', 6);

--INSERT TIPOS_PRODUCT
INSERT INTO Tipos_Productos ([descripcion])
VALUES
    ('Partes del Motor'),
    ('Filtros de Aceite'),
    ('Neumaticos'),
    ('Frenos'),
    ('Suspension'),
 ('Automovil');
	
--INSERT PARA PRODUCTOS
INSERT INTO Productos ([id_tipo_producto], [descripcion], [precio], [cant_min_por_mayor], [cantidad], [cantidad_min])
VALUES
    (1, 'Piston', 50.0, 10, 100, 5),
    (2, 'Filtro de Aceite', 15.0, 20, 200, 10),
    (3,'Neumatico 225/55R17', 120.01, 5, 50, 2),
    (4, 'Pastillas de Freno', 25.0, 15, 150, 10),
    (5, 'Amortiguador Trasero', 40.0, 8, 80, 4),
    (6, 'Uri Electrico', 9000000, 10, 200, 50),
    (1, 'Válvulas', 55.0, 10, 200, 5),
    (2, 'Caja del filtro', 60.0, 10, 100, 10),
    (3,' neumatico Michelin Pilot Sport 4', 180.01, 5, 150, 4),
    (4, 'Cilindro maestro', 30.0, 10, 150, 5),
    (5, 'Muelles de suspensión', 100.0, 8, 180, 4),
    (6, 'Peugeot 308', 10000000, 10, 20, 2),
    (1, 'Cigüeñal', 70.0, 15, 100, 5),
    (2, 'Tapa superior', 10.0, 20, 50, 10),  
    (3,'Neumatico Michelin CrossClimate+', 150.01, 5, 250, 4),
    (4, 'Mangueras de freno', 33.0, 15, 50, 10),
    (5, 'Amortiguador Trasero', 40.0, 8, 80, 4),
    (6, 'Ford 2019', 8000000, 10, 15, 50);

--INSERT TIPO_VENTAS
INSERT INTO Tipos_Ventas ([descripcion])
VALUES
    ('Venta al por mayor'),
    ('Venta al por menor');

	--INSERT PARA TARJETAS_CREDITO
INSERT INTO Tarjetas_credito(descripcion)
VALUES 
		('Bancor'),
		('Banco Nacion'),
		('Galicia'),
		('Sandander Rio'),
		('HSVC');

--INSERT PARA FORMAS_PAGO
INSERT INTO Formas_Pago([descripcion], [id_tarjeta], [id_cuota] )
VALUES
    ('Efectivo', NULL, null),
    ('Tarjeta de Credito', 1, 3),
    ('Tarjeta de Debito', 2, 1),
    ('Transferencia Bancaria', null, null),
    ('Cheque', NULL, null);

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
    (5, 18, 0.09),
    (6, 12, 0.1),
    (7, 6, 0.08),
    (8, 24, 0.15),
    (9, 12, 0.12),
    (10, 18, 0.09),
    (11, 12, 0.1),
    (12, 6, 0.08),
    (13, 24, 0.15),
    (14, 12, 0.12),
    (15, 18, 0.09);

set dateformat dmy;

	--INSERT INTO ORDENES_PEDIDOS
INSERT INTO Ordenes_Pedidos([id_cliente],[fecha_entrega],[fecha_pedido])
	VALUES 
	(1,'02/05/2022','15/08/2021'),
	(2, '20/11/2020','06/04/2018'),
	(3,'01/03/2023','17/12/2021'),
	(4,'12/10/2019','03/02/2019'),
	(5,'23/04/2022','13/09/2020'),
	(6,'12/06/2022','20/08/2021'),
	(7,'15/05/2020','06/04/2019'),
	(8,'01/02/2023','27/10/2022'),
	(9,'21/01/2020','30/12/2021'),
	(10,'24/05/2022','14/10/2020'),
	(11,'03/06/2019','15/08/2018'),
	(12, '21/12/2020','16/05/2019'),
	(13,'01/04/2023','17/12/2022'),
	(14,'25/10/2019','13/02/2019'),
	(15,'11/03/2022','13/09/2021');

--INSERT INTO FACTURAS
INSERT INTO Facturas ([id_cliente],[fecha],[id_vendedor] ,[id_orden_pedido] ,[id_autoplan] ,[id_forma_pago], [anulada])
	VALUES 
		(1,'02/05/2022',1,1,1,1,0),
		(2,'09/04/2020',2,2,2,2,0),
		(3,'10/04/2020',3,3,3,3,0),
		(4,'23/05/2021',4,4,4,4,0),
		(5,'20/06/2021',5,5,5,5,0),
	        (6,'02/06/2022',8,7,6,1,0),
		(7,'10/05/2020',9,8,7,2,0),
		(8,'11/06/2021',10,9,8,3,0),
		(9,'24/07/2021',11,10,9,4,0),
		(10,'21/06/2021',12,11,10,5,0),
		(11,'02/05/2022',13,11,11,1,0),
		(12,'29/04/2020',14,13,12,2,0),
		(13,'20/08/2020',15,14,13,3,0),
		(14,'12/03/2021',1,12,14,4,0),
		(15,'26/10/2021',1,1,15,5,0);
	
--INSERT INTO DETALLE_FACTURAS
INSERT INTO Detalles_Facturas([id_tipo_venta],[id_factura],[id_producto],[cantidad],[precio],[id_descuento])
VALUES
		(1,1,2,150,18015.01,1),
		(2,2,1,50,2500.01,2),
		(2,3,5,102,4120.20,3),
		(1,4,3,20,5540.01,4),
		(2,5,4,70,7990.50,5),
	        (1,6,7,100,50000.01,1),
		(2,7,6,10,250000.01,2),
		(2,8,9,102,5120.20,3),
		(1,9,8,20,2540.01,4),
		(2,10,11,50,8990.50,5),
		(1,11,10,150,19015.01,1),
		(2,12,12,50,25090.01,2),
		(2,13,13,102,7120.20,3),
		(1,14,15,20,551040.01,4),
		(2,15,14,70,2990.50,5);


--INSERT INTO DETALLES_PEDIDOS
INSERT INTO detalles_pedidos ([id_orden_pedido], [id_producto],[cantidad])
	VALUES (1,1,50), 
		(2,2,27),
		(3,3,45),
		(4,4,63),
		(5,5,80),
	    (7,6,51), 
		(8,7,22),
		(9,8,35),
		(10,9,23),
		(11,10,90),
		(12,11,40), 
		(13,12,37),
		(14,13,55),
		(15,14,53),
		(1,15,40);

GO

-- SPs

-- INSERTAR FACTURAS
CREATE PROCEDURE SP_INSERT_FACTURA
    @id_cliente int,
    @fecha datetime,
    @id_vendedor int,
    @id_orden_pedido int,
    @id_autoplan int,
    @id_forma_pago int,
    @nro int OUTPUT
AS
BEGIN
    INSERT INTO Facturas(id_cliente, fecha, id_vendedor, id_orden_pedido, id_autoplan, id_forma_pago)
    VALUES (@id_cliente, @fecha, @id_vendedor, @id_orden_pedido, @id_autoplan, @id_forma_pago);

    SET @nro = SCOPE_IDENTITY();
END;
GO

-- INSERTAR DETALLES_FACTURAS
CREATE PROCEDURE SP_INSERT_DETALLES_FAC
    @id_tipo_venta int,
    @nro int,
    @id_producto int,
    @cantidad int,
    @precio decimal(10,2),
    @id_descuento int
AS
BEGIN
    INSERT INTO Detalles_Facturas(id_tipo_venta, id_factura, id_producto, cantidad, precio, id_descuento)
    VALUES (@id_tipo_venta, @nro, @id_producto, @cantidad, @precio, @id_descuento);
END;
GO

--  INSERTAR ORDEN PEDIDO
CREATE PROCEDURE SP_INSERT_ORDEN_PEDIDO
    @id_cliente INT,
    @fecha_entrega DATETIME,
    @fecha_pedido DATETIME,
    @nro INT OUTPUT
AS
BEGIN
    INSERT INTO Ordenes_Pedidos(id_cliente, fecha_entrega, fecha_pedido)
    VALUES (@id_cliente, @fecha_entrega, @fecha_pedido);

    SET @nro = SCOPE_IDENTITY();
END;
GO

-- INSERTAR DETALLES PEDIDO
CREATE PROCEDURE SP_INSERT_DETALLES_PED
    @nro int,
    @id_producto int,
    @cantidad int
AS
BEGIN
    INSERT INTO Detalles_Pedidos(id_orden_pedido, id_producto, cantidad)
    VALUES (@nro, @id_producto, @cantidad)
END;
GO

-- INSERTAR  FORMA DE PAGO
CREATE PROCEDURE SP_INSERT_FORMA_PAGO
    @descripcion varchar(255),
    @id_tarjeta int,
    @id_cuota int
AS
BEGIN
    INSERT INTO Formas_Pago (descripcion, id_tarjeta, id_cuota)
    VALUES (@descripcion, @id_tarjeta, @id_cuota);
END;
GO

-- INSERTAR VENDEDOR
CREATE PROCEDURE SP_INSERT_VENDEDOR
    @id_categoria int,
    @apellido varchar(100),
    @nombre varchar(100),
    @CUIT bigint,
    @contrasenia varchar(64),
    @fecha_ingreso datetime
AS
BEGIN
    INSERT INTO Vendedores(id_categoria, apellido, nombre, CUIT, fecha_ingreso, contrasenia)
    VALUES (@id_categoria, @apellido, @nombre, @CUIT, @fecha_ingreso, @contrasenia)
END;
GO

-- INSERTAR CLIENTE
CREATE PROCEDURE SP_INSERT_CLIENTE
    @id_tipo_cliente int,
    @nombre varchar(200),
    @apellido varchar(200),
    @CUIT bigint,
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
-- SELECT 1 DESCUENTO
CREATE PROCEDURE SP_SELECT_DESCUENTO
@id int
AS
BEGIN
    SELECT * FROM Descuentos
	where id_descuento = @id
END;
GO

-- SELECT VENDEDORES
CREATE PROCEDURE SP_SELECT_VENDEDORES
AS
BEGIN
    SELECT * FROM Vendedores
END;
GO
-- SELECT AUTOPLAN ID
CREATE PROCEDURE SP_SELECT_AUTOPLAN
@id int
AS
BEGIN
    SELECT * FROM Autoplanes
	WHERE id_autoplan=@id
END;
GO
-- SELECT TIPO VENTA
CREATE PROCEDURE SP_SELECT_TIPO_VENTA
AS
BEGIN
    SELECT * FROM Tipos_Ventas
END;
GO
-- SELECT PRODUCTOS
CREATE PROCEDURE SP_SELECT_PRODUCTOS
AS
BEGIN
    SELECT * FROM Productos
END;
GO

-- SELECT TIPOS CLIENTES
CREATE PROCEDURE SP_SELECT_TIPO_CLIENTES
AS
BEGIN
    SELECT * FROM Tipos_Clientes
END;
GO

-- SELECT BARRIOS
CREATE PROCEDURE SP_SELECT_BARRIOS
AS
BEGIN
    SELECT * FROM Barrios
END;
GO

-- SELECT BARRIOS
CREATE PROCEDURE SP_SELECT_CATEGORIAS
AS
BEGIN
    SELECT * FROM Categorias
END;
GO

-- SELECT DESCUENTOS
CREATE PROCEDURE SP_SELECT_DESCUENTOS
AS
BEGIN
    SELECT * FROM Descuentos
END;
GO

-- SELECT BARRIOS
CREATE PROCEDURE SP_SELECT_TIPO_PRODUCTOS
AS
BEGIN
    SELECT * FROM Tipos_Productos
END;
GO

-- SELECT ORDENES PEDIDOS
CREATE PROCEDURE SP_SELECT_ORDENES_PEDIDOS
AS
BEGIN
    SELECT *
    FROM Ordenes_Pedidos;
END;
GO

-- SELECT FORMAS PAGO
CREATE PROCEDURE SP_SELECT_FORMAS_PAGO
AS
BEGIN
    SELECT * FROM Formas_Pago;
END;
GO

-- SELECT AUTOPLANES
CREATE PROCEDURE SP_SELECT_AUTOPLANES
AS
BEGIN
    SELECT * FROM Autoplanes;
END;
GO

-- SELECT TARJETAS
CREATE PROCEDURE SP_SELECT_TARJETAS
AS
BEGIN
    SELECT * FROM Tarjetas_Credito;
END;
GO

-- SELECT CUOTAS
CREATE PROCEDURE SP_SELECT_CUOTAS
AS
BEGIN
    SELECT * FROM Cuotas;
END;
GO

-- CONSULTAR CLIENTE
CREATE PROCEDURE SP_CONSULTAR_CLIENTE
    @id int
AS
BEGIN
    SELECT *
    FROM Clientes
    WHERE id_cliente = @id;
END;
GO

-- CONSULTAR VENDEDOR
CREATE PROCEDURE SP_CONSULTAR_VENDEDOR
    @id int
AS
BEGIN
    SELECT *
    FROM Vendedores
    WHERE id_vendedor = @id;
END;
GO

-- CONSULTAR PRODUCTO
CREATE PROCEDURE SP_CONSULTAR_PRODUCTO
    @id int
AS
BEGIN
    SELECT *
    FROM Productos
    WHERE id_producto = @id;
END;
GO

-- CONSULTAR PRODUCTOS
CREATE PROCEDURE SP_CONSULTAR_PRODUCTOS
    @idTipo int
AS
BEGIN
    SELECT *
    FROM Productos
    WHERE id_tipo_producto = @idTipo;
END;
go

-- CONSULTAR ORDEN PEDIDO
CREATE PROCEDURE SP_CONSULTAR_ORDEN_PEDIDO
    @id int
AS
BEGIN
    SELECT *
    FROM Ordenes_Pedidos
    WHERE id_orden_pedido = @id;
END;
GO

-- CONSULTAR DETALLES PEDIDOS
CREATE PROCEDURE SP_CONSULTAR_DETALLES_PEDIDO
    @id_orden_pedido int
AS
BEGIN
    SELECT * FROM Detalles_Pedidos WHERE id_orden_pedido = @id_orden_pedido
END;
GO

-- CONSULTAR FACTURA
CREATE PROCEDURE SP_CONSULTAR_FACTURA
    @id_factura int
AS
BEGIN
    SELECT * FROM Facturas WHERE id_factura = @id_factura
END;
GO
-- REPORTES
	-- para ver quien hace mas descuentos
CREATE PROCEDURE SP_CONSULTA_DESCUENTOS_PROMEDIO
AS
BEGIN
    SELECT
        c.id_cliente,
        c.nombre + ', ' + c.apellido AS 'cliente',
        v.nombre + ', ' + v.apellido AS 'vendedor',
        DATEDIFF(YEAR, v.fecha_ingreso, GETDATE()) AS 'antiguedad',
        SUM(((p.cantidad * p.precio) / 100) * d.porcentaje) AS 'descuento',
        AVG(d.porcentaje) AS 'promedio_descuento',
        cat.descripcion AS 'categoria'
    FROM
        Clientes c
    JOIN
        Facturas f ON f.id_cliente = c.id_cliente
    JOIN
        Detalles_Facturas df ON f.id_factura = df.id_factura
    JOIN
        Vendedores v ON f.id_vendedor = v.id_vendedor
    JOIN
        Descuentos d ON d.id_descuento = df.id_descuento
    JOIN
        Formas_Pago fp ON f.id_forma_pago = fp.id_forma_pago
    JOIN
        Categorias cat ON v.id_categoria = cat.id_categoria
    JOIN
        Productos p ON p.id_producto = df.id_producto
    WHERE
        f.id_forma_pago IN (
            SELECT
                id_forma_pago
            FROM
                Facturas ff
            JOIN
                Vendedores vv ON ff.id_vendedor = vv.id_vendedor
            WHERE
                DATEDIFF(YEAR, vv.fecha_ingreso, GETDATE()) >= 1
        )
    GROUP BY
        c.id_cliente,
        c.nombre,
        c.apellido,
        v.nombre,
        v.apellido,
        v.fecha_ingreso,
        cat.descripcion,
        f.id_factura
    HAVING
        AVG(d.porcentaje) IS NOT NULL
    ORDER BY
        'Promedio_Descuento' ASC;
END;

go

	--para ver quien vende mas
CREATE PROCEDURE SP_CONSULTA_VENTAS_TOTALES
AS
BEGIN
    SELECT
        v.id_vendedor,
        v.nombre + ', ' + v.apellido AS 'Vendedor',
        SUM(df.cantidad * df.precio) AS 'VentasTotales'
    FROM
        Vendedores v
    JOIN
        Facturas f ON v.id_vendedor = f.id_vendedor
    JOIN
        Detalles_Facturas df ON f.id_factura = df.id_factura
    GROUP BY
        v.id_vendedor,
        v.nombre,
        v.apellido
    HAVING
        SUM(df.cantidad * df.precio) > (
            SELECT AVG(VentasTotales)
            FROM (
                SELECT
                    SUM(df1.cantidad * df1.precio) AS 'VentasTotales'
                FROM
                    Facturas f1
                JOIN
                    Detalles_Facturas df1 ON f1.id_factura = df1.id_factura
                GROUP BY
                    f1.id_vendedor
            ) AS subconsulta
        );
END;
go

	-- listado de productos, y si fueron vendidos o no por año por mes en int
create PROCEDURE SP_CONSULTA_ESTADO_PRODUCTOS
@año int,
@mes int
AS
BEGIN
    -- Productos vendidos
    SELECT
        p.id_producto,
        p.descripcion,
        'Vendido' AS estado
    FROM
        Detalles_Facturas df
    JOIN
        Productos p ON df.id_producto = p.id_producto
	join
	Facturas f on f.id_factura=df.id_factura
	where
	year(f.fecha)=@año and month(f.fecha)=@mes

    UNION

    -- Productos no vendidos
    SELECT
        p.id_producto,
        p.descripcion,
        'No Vendido' AS estado
     FROM
        Detalles_Facturas df
    JOIN
        Productos p ON df.id_producto = p.id_producto
	join
	Facturas f on f.id_factura=df.id_factura
    WHERE
        p.id_producto NOT IN (
            SELECT DISTINCT id_producto
            FROM Detalles_Facturas
			where year(f.fecha)=@año and month(f.fecha)=@mes
        ) 
END;
GO


-- resumen cliente ultimos tres años
CREATE PROCEDURE SP_CONSULTA_ESTADISTICAS_VENDEDORES
    @total_facturado DECIMAL(25, 2)
AS
BEGIN
    SELECT
        f.id_cliente AS Id,
        c.apellido + ', ' + c.nombre AS Nombre,
        COUNT(f.id_factura) AS CantidaddeCompras,
        SUM(df.Cantidad) AS Productoscomprados,
        SUM(df.cantidad * df.precio) AS TotalFacturado
    FROM clientes c
    JOIN Facturas f ON f.id_cliente = c.id_cliente
    JOIN Detalles_Facturas df ON df.id_factura = f.id_factura
    WHERE DATEDIFF(YEAR, f.fecha, GETDATE()) <= 3
    GROUP BY f.id_cliente, c.apellido + ', ' + c.nombre
    HAVING SUM(df.cantidad * df.precio) > @total_facturado;
END;
GO

	
	
	--EXEC SP_CONSULTA_DESCUENTOS_PROMEDIO;
	--EXEC SP_CONSULTA_VENTAS_TOTALES;
	--exec SP_CONSULTA_ESTADO_PRODUCTOS 2022,05;
	--EXEC SP_CONSULTA_ESTADISTICAS_VENDEDORES @total_facturado = 50000.00;




-- UPDATES

-- UPDATE VENDEDOR
CREATE PROCEDURE SP_UPDATE_VENDEDOR
    @id_vendedor int,
    @id_categoria int,
    @apellido varchar(100),
    @nombre varchar(100),
    @CUIT bigint,
    @fecha_ingreso datetime
AS
BEGIN
    UPDATE Vendedores
    SET id_categoria = @id_categoria,
        apellido = @apellido,
        nombre = @nombre,
        CUIT = @CUIT,
        fecha_ingreso = @fecha_ingreso
    WHERE id_vendedor = @id_vendedor;
END;
GO

-- UPDATE CLIENTE
CREATE PROCEDURE SP_UPDATE_CLIENTE
    @id_cliente int,
    @id_tipo_cliente int,
    @nombre varchar(200),
    @apellido varchar(200),
    @CUIT bigint,
    @dire_calle varchar(200),
    @dire_nro int,
    @id_barrio int
AS
BEGIN
    UPDATE Clientes
    SET id_tipo_cliente = @id_tipo_cliente,
        nombre = @nombre,
        apellido = @apellido,
        CUIT = @CUIT,
        dire_calle = @dire_calle,
        dire_nro = @dire_nro,
        id_barrio = @id_barrio
    WHERE id_cliente = @id_cliente;
END;
GO

--UPDATE PRODUCTOS
	
CREATE PROCEDURE SP_UPDATE_PRODUCTOS
    @IdProducto int,
    @Descripcion varchar(100),
    @precio decimal(10,2),
    @cantidad int,
    @CantMinPorMayor int,
    @CantidadMin int,
    @IdTipoProducto int
AS
BEGIN
	UPDATE Productos
	SET 
	    id_tipo_producto = @IdTipoProducto,
	    descripcion = @Descripcion,
	    precio=@precio,
	    cant_min_por_mayor =@CantMinPorMayor,
	    cantidad = @cantidad,
	    cantidad_min = @CantidadMin
	WHERE id_producto = @IdProducto ;
END;
GO

-- DELETE

-- DELETE CLIENTE
CREATE PROCEDURE SP_DELETE_CLIENTE
    @id_cliente int
AS
BEGIN
    DELETE FROM Clientes
    WHERE id_cliente = @id_cliente;
END;
GO

	
--DELETE VENDEDOR
	
CREATE PROCEDURE SP_DELETE_VENDEDOR
@id_vendedor int
AS
BEGIN
	DELETE FROM Vendedores
	WHERE id_vendedor = @id_vendedor
END;
GO

--DELETE PRODUCTOS
	
CREATE PROCEDURE SP_DELETE_PRODUCTO
@id_producto int
AS
BEGIN
	DELETE FROM Productos
	WHERE id_producto = @id_producto
END;
GO

	-- PROXIMO AUTOPLAN
CREATE PROCEDURE SP_GET_NEXT_AUTOPLAN
@nro int OUTPUT
AS
BEGIN
    SELECT @nro = ISNULL(MAX(id_autoplan), 0) + 1 FROM Autoplanes;
END;
GO

-- SP PARA OBTENER EL SIGUIENTE NUMERO DE ORDEN PEDIDO
CREATE PROCEDURE SP_GET_NEXT_ORDEN_PEDIDO
    @nro int OUTPUT
AS
BEGIN
    SELECT @nro = ISNULL(MAX(id_orden_pedido), 0) + 1 FROM Ordenes_Pedidos;
END;
GO

-- SP PARA OBTENER EL SIGUIENTE NUMERO DE FACTURA
CREATE PROCEDURE SP_GET_NEXT_FACTURA
    @nro int OUTPUT
AS
BEGIN
    SELECT @nro = ISNULL(MAX(id_factura), 0) + 1 FROM Facturas;
END;
GO
