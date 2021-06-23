CREATE DATABASE SALON_DE_BELLEZA
GO
USE SALON_DE_BELLEZA

CREATE TABLE LOCALIDADES(
id_localidad INT,
nom_localidad VARCHAR (50),
CONSTRAINT pk_localidades PRIMARY KEY (id_localidad))

CREATE TABLE BARRIOS(
id_barrio INT,
nom_barrio VARCHAR (50),
id_localidad INT
CONSTRAINT pk_barrios PRIMARY KEY (id_barrio)
CONSTRAINT fk_barrios_localidadades FOREIGN KEY (id_localidad)
REFERENCES LOCALIDADES (id_localidad))

CREATE TABLE TIPO_DOCUMENTOS(
id_tipo_doc INT,
descripcion VARCHAR (50),
CONSTRAINT pk_tipos_doc PRIMARY KEY (id_tipo_doc))

CREATE TABLE TIPO_CONTACTOS(
id_tipo_contacto int,
descripcion varchar(50),
CONSTRAINT pk_tipo_contactos PRIMARY KEY (id_tipo_contacto))

CREATE TABLE CONTACTOS(
id_contacto int,
descripcion varchar(50)
CONSTRAINT pk_contactos PRIMARY KEY (id_contacto))

CREATE TABLE DETALLE_CONTACTOS(
id_contacto int,
id_tipo_contacto int,
descripcion varchar(100),
CONSTRAINT pk_detalle_contactos PRIMARY KEY (id_contacto,id_tipo_contacto),
CONSTRAINT fk_d_contacto_contactos FOREIGN KEY (id_contacto)
REFERENCES CONTACTOS (id_contacto),
CONSTRAINT fk_d_contacto_tipo_contactos FOREIGN KEY (id_tipo_contacto)
REFERENCES TIPO_CONTACTOS(id_tipo_contacto))


CREATE TABLE CLIENTES(
id_cliente int,
nombre varchar(50),
apellido varchar (50),
nro_documento int,
id_tipo_doc int,
id_barrio int,
direccion varchar (100),
id_contacto int,
CONSTRAINT pk_clientes PRIMARY KEY (id_cliente),
CONSTRAINT fk_clientes_tipo_dococumentos FOREIGN KEY (id_tipo_doc)
REFERENCES TIPO_DOCUMENTOS (id_tipo_doc),
CONSTRAINT fk_clientes_barrios FOREIGN KEY (id_barrio)
REFERENCES BARRIOS (id_barrio),
CONSTRAINT fk_clientes_contactos FOREIGN KEY (id_contacto)
REFERENCES CONTACTOS (id_contacto))


CREATE TABLE TURNOS(
id_turno int,
descripcion VARCHAR (50)
CONSTRAINT pk_turnos PRIMARY KEY (id_turno))

CREATE TABLE PROFESIONALES(
id_profesional INT,
nombre VARCHAR (50),
apellido VARCHAR (50),
nro_documento int,
id_tipo_doc int,
id_barrio int,
direccion VARCHAR(100),
email VARCHAR (100),
id_turno int,
id_contacto int,
CONSTRAINT pk_profesionales PRIMARY KEY (id_profesional),
CONSTRAINT fk_tipos_doc	FOREIGN KEY (id_tipo_doc)
REFERENCES TIPO_DOCUMENTOS (id_tipo_doc),
CONSTRAINT fk_profesionales_barrios FOREIGN KEY (id_barrio)
REFERENCES BARRIOS (id_barrio),
CONSTRAINT fk_profesionales_turnos FOREIGN KEY (id_turno)
REFERENCES TURNOS (id_turno),
CONSTRAINT fk_profesionales_contactos FOREIGN KEY (id_contacto)
REFERENCES CONTACTOS (id_contacto))

CREATE TABLE ESTADOS(
id_estado int,
nombre_estado VARCHAR (50)
CONSTRAINT pk_estados PRIMARY KEY (id_estado))


CREATE TABLE TIPO_SERVICIOS(
id_tipoServicio int,
nom_tipoServicio VARCHAR (50)
CONSTRAINT pk_tipo_servicios PRIMARY KEY (id_tipoServicio))

CREATE TABLE SERVICIOS(
id_servicio int,
nom_servicio VARCHAR (50),
id_tipoServicio int,
precio numeric (8,2),
CONSTRAINT pk_servicios PRIMARY KEY (id_servicio),
CONSTRAINT fk_servicios_tipo_servicios FOREIGN KEY (id_tipoServicio)
REFERENCES TIPO_SERVICIOS (id_tipoServicio))


CREATE TABLE ATENCIONES(
id_atencion int,
id_cliente int,
id_profesional int,
id_estado int,
fecha date,
hora time,
numero_orden int,
CONSTRAINT pk_atenciones PRIMARY KEY (id_atencion),
CONSTRAINT fk_atenciones_clientes FOREIGN KEY (id_cliente)
REFERENCES CLIENTES (id_cliente),
CONSTRAINT fk_atenciones_estados FOREIGN KEY (id_estado)
REFERENCES ESTADOS(id_estado),
CONSTRAINT fk_atenciones_profesionales FOREIGN KEY (id_profesional)
REFERENCES PROFESIONALES(id_profesional) )



CREATE TABLE FACTURAS(
id_factura int,
id_metodo_pago int,
id_atencion int,
fecha datetime,
CONSTRAINT pk_facturas PRIMARY KEY (id_factura),
CONSTRAINT fk_facturas_atenciones FOREIGN KEY (id_atencion)
REFERENCES ATENCIONES (id_atencion))


CREATE TABLE DETALLE_FACTURAS(
id_detalle_factura int,
id_factura int,
id_servicio int,
precio numeric(5,2),
cantidad int,
CONSTRAINT pk_detalle_facturas PRIMARY KEY (id_detalle_factura),
CONSTRAINT fk_d_factura_facturas FOREIGN KEY (id_factura)
REFERENCES FACTURAS (id_factura),
CONSTRAINT fk_d_factura_servicios FOREIGN KEY (id_servicio)
REFERENCES SERVICIOS (id_servicio))


CREATE TABLE METODO_PAGOS(
id_metodo_pago int,
descripcion VARCHAR (100),
CONSTRAINT pk_metodo_pagos PRIMARY KEY (id_metodo_pago))


CREATE TABLE DETALLE_METODO_PAGOS(
id_metodo_pago int,
id_factura int,
CONSTRAINT pk_detalle_metodo_pagos PRIMARY KEY (id_metodo_pago, id_factura),
CONSTRAINT fk_d_metodo_pago_metodo_pago FOREIGN KEY (id_metodo_pago)
REFERENCES METODO_PAGOS (id_metodo_pago),
CONSTRAINT fk_d_metodo_pago_facturas FOREIGN KEY (id_factura)
REFERENCES  FACTURAS (id_factura))


--CARGA DE DATOS

--LOCALIDADES
INSERT INTO LOCALIDADES (id_localidad, nom_localidad) 
VALUES(1,'CORDOBA') 
INSERT INTO LOCALIDADES (id_localidad, nom_localidad) 
VALUES(2,'CARLOS PAZ') 
INSERT INTO LOCALIDADES (id_localidad, nom_localidad) 
VALUES(3,'ADELIA MARIA') 
INSERT INTO LOCALIDADES (id_localidad, nom_localidad) 
VALUES(4,'ALTA GRACIA') 
INSERT INTO LOCALIDADES (id_localidad, nom_localidad) 
VALUES(5,'AGUA DE ORO') 
INSERT INTO LOCALIDADES (id_localidad, nom_localidad) 
VALUES(6,'AGUA DEL TALA') 
INSERT INTO LOCALIDADES (id_localidad, nom_localidad) 
VALUES(7,'AGUA PINTADA') 
INSERT INTO LOCALIDADES (id_localidad, nom_localidad) 
VALUES(8,'ALEJANDRO ROCA') 
INSERT INTO LOCALIDADES (id_localidad, nom_localidad) 
VALUES(9,'ARIAS') 
INSERT INTO LOCALIDADES (id_localidad, nom_localidad) 
VALUES(10,'ARROYO CABRAL') 
INSERT INTO LOCALIDADES (id_localidad, nom_localidad) 
VALUES(11,'ARROYO LA HIGUERA') 
INSERT INTO LOCALIDADES (id_localidad, nom_localidad) 
VALUES(12,'ASCOCHINGA') 
INSERT INTO LOCALIDADES (id_localidad, nom_localidad) 
VALUES(13,'BAJO DE FERNANDEZ') 
INSERT INTO LOCALIDADES (id_localidad, nom_localidad) 
VALUES(14,'BAJO DEL CARMEN')


 --BARRIOS
 INSERT INTO BARRIOS(id_barrio,	nom_barrio,		id_localidad)
 VALUES		(1,		'CENTRO',	  	1)
 INSERT INTO BARRIOS(id_barrio,	nom_barrio,		id_localidad)
 VALUES		(2,		'ALTO ALBERDI', 	1)
 INSERT INTO BARRIOS(id_barrio,	nom_barrio,		id_localidad)
 VALUES		(3,		'OBSERVATORIO', 	1)
 INSERT INTO BARRIOS(id_barrio,	nom_barrio,		id_localidad)
 VALUES		(4, 		'JARDIN',	  	1)
 INSERT INTO BARRIOS(id_barrio,	nom_barrio,		id_localidad)
 VALUES		(5,		'GENERAL PAZ',  	1)
 INSERT INTO BARRIOS(id_barrio,  	nom_barrio,		id_localidad)
 VALUES		(6,		'PUEYRREDON',	 	1)
 INSERT INTO BARRIOS(id_barrio,	nom_barrio,		id_localidad)
 VALUES		(7,		'PARQUE HORIZONTE',  1)
 INSERT INTO BARRIOS(id_barrio,  	nom_barrio,		id_localidad)
 VALUES		(8, 		'SAN MARTIN',	 	1)
 INSERT INTO BARRIOS(id_barrio, 	nom_barrio,		id_localidad)
 VALUES		(9,		'SAN VICENTE',	1)
 INSERT INTO BARRIOS(id_barrio, 	nom_barrio,		id_localidad)
 VALUES		(10,		'JUNIOR',		2)
 INSERT INTO BARRIOS(id_barrio, 	nom_barrio,		id_localidad)
 VALUES		(11,		'MAIPU',		2)
 INSERT INTO BARRIOS(id_barrio, nom_barrio,		id_localidad)
 VALUES		(12,		'PANAMERICANO',	2)

 --METODO_PAGOS
INSERT INTO METODO_PAGOS 	(id_metodo_pago, 	descripcion)
VALUES				(1,			'EFECTIVO')
INSERT INTO METODO_PAGOS 	(id_metodo_pago, 	descripcion)
VALUES				(2,			'CON CHEQUE')
INSERT INTO METODO_PAGOS 	(id_metodo_pago, 	descripcion)
VALUES				(3,			'TARJETA CREDITO')
INSERT INTO METODO_PAGOS 	(id_metodo_pago, 	descripcion)
VALUES				(4,			'TARJETA DEBITO')
INSERT INTO METODO_PAGOS 	(id_metodo_pago, 	descripcion)
VALUES				(5,			'CUENTA CORRIENTE')
INSERT INTO METODO_PAGOS	(id_metodo_pago,	descripcion)
VALUES				(7,			'PAYPAL');
INSERT INTO METODO_PAGOS	(id_metodo_pago,	descripcion)
VALUES				(6,			'BITCOINS')


--TIPOS DE DOCUMENTO
INSERT INTO TIPO_DOCUMENTOS	(id_tipo_doc,	descripcion)
VALUES				(1,		'D.N.I.');
INSERT INTO TIPO_DOCUMENTOS	(id_tipo_doc,	descripcion)
VALUES				(2,		'CEDULA');
INSERT INTO TIPO_DOCUMENTOS	(id_tipo_doc,	descripcion)
VALUES				(3,		'PASAPORTE');


--TIPOS_CONTACTOS
INSERT INTO TIPO_CONTACTOS	(id_tipo_contacto,	descripcion)
VALUES						(1,		'TELEFONO');
INSERT INTO TIPO_CONTACTOS	(id_tipo_contacto,	descripcion)
VALUES						(2,		'E-MAIL');
INSERT INTO TIPO_CONTACTOS	(id_tipo_contacto,	descripcion)
VALUES						(3,		'FACEBOOK');
INSERT INTO TIPO_CONTACTOS	(id_tipo_contacto,	descripcion)
VALUES						(4,		'INSTAGRAM');


--CONTACTOS PROFESIONALES
INSERT INTO CONTACTOS	(id_contacto,	descripcion)
VALUES					(1,				'PROFESIONAL ALEJANDRA ACHAVAL');
INSERT INTO CONTACTOS	(id_contacto,	descripcion)
VALUES					(2,				'PROFESIONAL JULIA SANCHEZ');
INSERT INTO CONTACTOS	(id_contacto,	descripcion)
VALUES					(3,				'PROFESIONAL MARTA MIGUEZ');
INSERT INTO CONTACTOS	(id_contacto,	descripcion)
VALUES					(4,				'PROFESIONAL MASSIMO BRUNO');
INSERT INTO CONTACTOS	(id_contacto,	descripcion)
VALUES					(5,				'PROFESIONAL LUNA PEREZ');
--CONTACTO CLIENTES
INSERT INTO CONTACTOS	(id_contacto,	descripcion)
VALUES					(6,				'CLIENTE ALONSO CLAUDIO');
INSERT INTO CONTACTOS	(id_contacto,	descripcion)
VALUES					(7,				'CLIENTE ALVAREZ MARCELO');
INSERT INTO CONTACTOS	(id_contacto,	descripcion)
VALUES					(8,				'CLIENTE ALVAREZ CRISTINA');
INSERT INTO CONTACTOS	(id_contacto,	descripcion)
VALUES					(9,				'CLIENTE ALVAREZ CLAUDIO');
INSERT INTO CONTACTOS	(id_contacto,	descripcion)
VALUES					(10,			'CLIENTE CAMPOS RAUL');
INSERT INTO CONTACTOS	(id_contacto,	descripcion)
VALUES					(11,			'CLIENTE DURAN CARLA');
INSERT INTO CONTACTOS	(id_contacto,	descripcion)
VALUES					(12,			'CLIENTE ROMANO JULIAN');
INSERT INTO CONTACTOS	(id_contacto,	descripcion)
VALUES					(13,			'CLIENTE MITRE RAUL');

--DETALLE_CONTACTOS
INSERT INTO DETALLE_CONTACTOS	(id_contacto,	id_tipo_contacto,	descripcion)
VALUES							(1,				2,					'aleacha@gmail.com');
INSERT INTO DETALLE_CONTACTOS	(id_contacto,	id_tipo_contacto,	descripcion)
VALUES							(2,				2,					'julsan78@gmail.com');
INSERT INTO DETALLE_CONTACTOS	(id_contacto,	id_tipo_contacto,	descripcion)
VALUES							(3,				2,					'mami999@gmail.com');
INSERT INTO DETALLE_CONTACTOS	(id_contacto,	id_tipo_contacto,	descripcion)
VALUES							(4,				1,					'4606060');
INSERT INTO DETALLE_CONTACTOS	(id_contacto,	id_tipo_contacto,	descripcion)
VALUES							(5,				3,					'pranabody@facebook.com');
INSERT INTO DETALLE_CONTACTOS	(id_contacto,	id_tipo_contacto,	descripcion)
VALUES							(6,				1,					'6795890');
INSERT INTO DETALLE_CONTACTOS	(id_contacto,	id_tipo_contacto,	descripcion)
VALUES							(7,				1,					'6045890');
INSERT INTO DETALLE_CONTACTOS	(id_contacto,	id_tipo_contacto,	descripcion)
VALUES							(8,				1,					'4445890');
INSERT INTO DETALLE_CONTACTOS	(id_contacto,	id_tipo_contacto,	descripcion)
VALUES							(9,				1,					'4568432');
INSERT INTO DETALLE_CONTACTOS	(id_contacto,	id_tipo_contacto,	descripcion)
VALUES							(10,			2,					'CamposRaul66@gmail.com');
INSERT INTO DETALLE_CONTACTOS	(id_contacto,	id_tipo_contacto,	descripcion)
VALUES							(11,			2,					'Carladepiedra@gmail.com');
INSERT INTO DETALLE_CONTACTOS	(id_contacto,	id_tipo_contacto,	descripcion)
VALUES							(12,			3,					'Romanopizzas@facebook.com');
INSERT INTO DETALLE_CONTACTOS	(id_contacto,	id_tipo_contacto,	descripcion)
VALUES							(13,				1,				'4568589');


--CLIENTES
INSERT INTO CLIENTES
(id_cliente, 	apellido,		nombre, 	direccion,		id_barrio,  	id_tipo_doc, 	nro_documento, id_contacto)
VALUES (1, 	'ALONSO',	'CLAUDIA', 	'Valparaiso 1012',	3,		2,		 25412554, 6);
INSERT INTO CLIENTES
(id_cliente, 	apellido, 	nombre, 	direccion, 		id_barrio, 		id_tipo_doc,	nro_documento, id_contacto)
VALUES (2, 	'ALVAREZ', 	'MARCELA', 	'Azcuenaga 2560',	2, 		1,		754566544, 7);
INSERT INTO CLIENTES
(id_cliente, 	apellido, 	nombre, 	direccion, 		id_barrio, 		id_tipo_doc,	nro_documento, id_contacto)
VALUES (3, 	'ALVAREZ',	'CRISTINA',	NULL,		1,			1,		842255434, 8);
INSERT INTO CLIENTES
(id_cliente, 	apellido, 	nombre, 	direccion, 		id_barrio, 		id_tipo_doc,	nro_documento, id_contacto)
VALUES (4, 	'ALVAREZ',	'MARTINA', 	'Calcayano 1010',		6,			1,		254871120, 9);
INSERT INTO CLIENTES
(id_cliente, 	apellido, 	nombre, 	direccion, 		id_barrio, 		id_tipo_doc,	nro_documento, id_contacto)
VALUES (5, 	'CAMPOS',	'ROSA', 		NULL,				3,		2,		514587452, 10);
INSERT INTO CLIENTES
(id_cliente, 	apellido, 	nombre, 	direccion, 		id_barrio, 		id_tipo_doc,	nro_documento, id_contacto)
VALUES (6, 	'DURAN',	'CARLA', 		'Molinos 3910',		7,		2,		467399254, 11);
INSERT INTO CLIENTES
(id_cliente, 	apellido, 	nombre, 	direccion, 		id_barrio, 		id_tipo_doc,	nro_documento, id_contacto)
VALUES (7,	'ROMANO',	'JULIAN',		'Ituzaingo 3450',	1,			1,		37848732, 12);
INSERT INTO CLIENTES
(id_cliente, 	apellido, 	nombre, 	direccion, 		id_barrio, 	id_tipo_doc,	nro_documento, id_contacto)
VALUES (8,	'AZAR',	'MARIA',			NULL,		3,	
	2,		32657546, 13);	

--TIPO_SERVICIOS
INSERT INTO TIPO_SERVICIOS
(id_tipoServicio,	nom_tipoServicio)	
VALUES (1,			'Depilacion')

INSERT INTO TIPO_SERVICIOS
(id_tipoServicio,	nom_tipoServicio)	
VALUES (2,			'Maquillaje')

INSERT INTO TIPO_SERVICIOS
(id_tipoServicio,	nom_tipoServicio)	
VALUES (3,			'Mascara')


INSERT INTO TIPO_SERVICIOS
(id_tipoServicio,	nom_tipoServicio)	
VALUES (4,			'Peluqueria')

INSERT INTO TIPO_SERVICIOS
(id_tipoServicio,	nom_tipoServicio)	
VALUES (5,			'Manicura')

--SERVICIOS
INSERT INTO SERVICIOS
(id_Servicio,	nom_Servicio,	id_tipoServicio,	precio)	
VALUES (1,		'bozo',			1,				5);
INSERT INTO SERVICIOS
(id_Servicio,	nom_Servicio,	id_tipoServicio,	precio)	
VALUES (2,		'cavado',		1,					10);
INSERT INTO SERVICIOS
(id_Servicio,	nom_Servicio,	id_tipoServicio,	precio)	
VALUES (3,		'cejas',		1,					9);
INSERT INTO SERVICIOS
(id_Servicio,	nom_Servicio,	id_tipoServicio,	precio)	
VALUES (4,		'facial',		1,					20);
INSERT INTO SERVICIOS
(id_Servicio,	nom_Servicio,	id_tipoServicio,	precio)	
VALUES (5,		'media pierna',	1,					30);
INSERT INTO SERVICIOS
(id_Servicio,	nom_Servicio,	id_tipoServicio,	precio)	
VALUES (6,		'pierna completa',	1,				60);
INSERT INTO SERVICIOS
(id_Servicio,	nom_Servicio,	id_tipoServicio,	precio)	
VALUES (7,		'social',		2,					70);
INSERT INTO SERVICIOS
(id_Servicio,	nom_Servicio,	id_tipoServicio,	precio)	
VALUES (8,		'artistico',	2,					100);
INSERT INTO SERVICIOS
(id_Servicio,	nom_Servicio,	id_tipoServicio,	precio)	
VALUES (9,		'de cobre y caviar',	3,			600);
INSERT INTO SERVICIOS
(id_Servicio,	nom_Servicio,	id_tipoServicio,	precio)	
VALUES (10,		'destello vital',		3,			200);
INSERT INTO SERVICIOS
(id_Servicio,	nom_Servicio,	id_tipoServicio,	precio)	
VALUES (11,		'velo de colágeno',		3,			150);
INSERT INTO SERVICIOS
(id_Servicio,	nom_Servicio,	id_tipoServicio,	precio)	
VALUES (12,		'corte dama+peinado',		4,		1600);
INSERT INTO SERVICIOS
(id_Servicio,	nom_Servicio,	id_tipoServicio,	precio)	
VALUES (13,		'corte flequillo',		4,			400);
INSERT INTO SERVICIOS
(id_Servicio,	nom_Servicio,	id_tipoServicio,	precio)	
VALUES (14,		'corte dama',		4,				1000);
INSERT INTO SERVICIOS
(id_Servicio,	nom_Servicio,	id_tipoServicio,	precio)	
VALUES (15,		'corte localizado',		4,			700);
INSERT INTO SERVICIOS
(id_Servicio,	nom_Servicio,	id_tipoServicio,	precio)	
VALUES (16,		'ambas manos',		5,			400);
INSERT INTO SERVICIOS
(id_Servicio,	nom_Servicio,	id_tipoServicio,	precio)	
VALUES (17,		'ambos pies',		5,				500);
INSERT INTO SERVICIOS
(id_Servicio,	nom_Servicio,	id_tipoServicio,	precio)	
VALUES (19,		'manos',			5,			280);

--ESTADOS
INSERT INTO ESTADOS
(id_estado,	nombre_estado)	
VALUES (1,	'ACTIVO');

INSERT INTO ESTADOS
(id_estado,	nombre_estado)	
VALUES (2,	'EN ESPERA');

INSERT INTO ESTADOS
(id_estado,	nombre_estado)	
VALUES (3,	'TERMINADO');

INSERT INTO ESTADOS
(id_estado,	nombre_estado)	
VALUES (4,	'NO PRESENTE');





--TURNOS
INSERT INTO TURNOS
(id_turno,	descripcion)	
VALUES (1,	'MAÑANA');

INSERT INTO TURNOS
(id_turno,	descripcion)	
VALUES (2,	'TARDE');


--PROFESIONALES
INSERT INTO PROFESIONALES
(id_profesional, nombre,		apellido,	nro_documento,	id_tipo_doc,	id_barrio,	direccion,			id_contacto,		id_turno)
VALUES (1, 		 'ALEJANDRA',	'ACHAVAL',	30425587,		1,				2,			'Felix Olmedo 1000',	1, 1);
INSERT INTO PROFESIONALES
(id_profesional, nombre,		apellido,	nro_documento,	id_tipo_doc,	id_barrio,	direccion,			id_contacto,		id_turno)
VALUES (2, 		 'JULIA',		'SANCHEZ',	28425543,		1,				3,			'Av. Richieri 3400',	2,	 1);
INSERT INTO PROFESIONALES
(id_profesional, nombre,		apellido,	nro_documento,	id_tipo_doc,	id_barrio,	direccion,			id_contacto,		id_turno)
VALUES (3, 		 'MARTA',		'MIGUEZ',	334555512,		1,				1,			'Arenales 1505',	3, 1);
INSERT INTO PROFESIONALES
(id_profesional, nombre,		apellido,	nro_documento,	id_tipo_doc,	id_barrio,	direccion,			id_contacto,		id_turno)
VALUES (4, 		 'MASSIMO',		'BRUNO',	450425587,		3,				2,			'Felix Olmedo 1000',	4, 2);
INSERT INTO PROFESIONALES
(id_profesional, nombre,		apellido,	nro_documento,	id_tipo_doc,	id_barrio,	direccion,			id_contacto,		id_turno)
VALUES (5, 	 'LUNA',		'PEREZ',	304255544,		1,			4,			'MANDISOVI 3400',	5, 2);



INSERT INTO ATENCIONES(id_atencion, id_cliente, id_profesional, id_estado, fecha, hora, numero_orden)
   		 	values(1,1,4,3,'2021/05/15', '10:30:00',1),
   				   (2,8,5,3,'2021/05/16', '08:30:00',2),
   				   (3,4,5,3,'2021/05/17', '12:00:00',3),
   				   (4,7,4,3,'2021/05/18', '15:30:00',4),
   				   (5,5,2,3,'2021/05/19', '17:30:00',5),   				   
   				   (6,2,1,4,'2021/05/20', '11:00:00 ',6),
   				   (7,8,5,3,'2021/05/26', '09:30:00',7),
   				   (8,4,5,3,'2021/05/27', '12:00:00',8),
   				   (9,7,4,3,'2021/05/29', '14:30:00',9),
   				   (10,5,2,3,'2021/05/29', '18:30:00',10),
   				   (11,1,5,3,'2021/05/30', '10:30:00',11),
   				   (12,2,1,3,'2021/05/31', '14:30:00',12),
   				   (13,8,4,4,'2021/05/31', '19:00:00',13),
   				   (14,5,1,2,'2021/06/01', '19:30:00',14),
   				   (15,3,2,2,'2021/06/01', '18:30:00',15),
   				   (16,8,5,2,'2021/06/01', '20:00:00',16),
   				   (17,1,4,2,'2021/06/01', '20:00:00',17),
   				   (18,6,2,1,'2021/06/03', '10:30:00',18),
   				   (19,8,3,1,'2021/06/03', '11:00:00',19),
   				   (20,2,3,1,'2021/06/04', '09:00:00',20),
   				   (21,1,2,1,'2021/06/04', '12:00:00',21),
   				   (22,5,5,1,'2021/06/05', '10:00:00',22),
   				   (23,7,1,1,'2021/06/05', '16:00:00',23),
   				   (24,4,4,1,'2021/06/07', '14:30:00',24),
   				   (25,8,3,1,'2021/06/07', '12:30:00',25),
   				   (26,3,2,1,'2021/06/08', '18:00:00',26);


insert into FACTURAS(id_metodo_pago,id_factura, id_atencion, fecha)
   		   values(1,1,1, '2021/06/15'),
   				 (3,2,2, '2021/05/16'),
   				 (4,3,3, '2021/05/17'),
   				 (3,4,4,'2021/05/18'),
   				 (4,5,5, '2021/05/19'),  
   				 (1,6,7, '2021/05/26'),
   				 (1,7,8,'2021/05/27'),
   				 (1,8,9,'2021/06/24'),
   				 (4,9,10,'2021/06/26'),
   				 (6,10,11,'2021/06/17'),
   				 (7,11,12,'2021/06/16');



INSERT INTO DETALLE_METODO_PAGOS(id_metodo_pago,id_factura)
   					   values(1,1), --efectivo
   						   (3,2), --credito
   						   (4,3), --debito
   						   (3,4), --credito
   						   (4,5),  --debito
   						   (1,6), --efectivo
   						   (1,7), -- efectivo
   					              (1,8), --efectivo
   						   (4,9), -- debito
   						   (6,10), --bitcoins
   						   (7,11); -- paypal
INSERT INTO DETALLE_FACTURAS(id_detalle_factura,id_factura,id_servicio,precio,cantidad)
					  VALUES( 1, 1,4,20.00,1),
							( 2, 1,3,09.00,1),
							( 3, 1,2,10.00,1),
							( 4, 1,6,60.00,1),
							( 5, 2,15,700.00,1),
							( 6, 3,9,600.00,1),
							( 7, 3,10,200.00,1),
							( 8, 3,11,150.00,1),
							( 9, 4,16,400.00,1),
							( 10, 4,17,500.00,1),
							( 11, 5,8,100.00,1),
							( 12, 5,10,200.00,1),
							( 13, 6,13,400.00,1),
							( 14, 6,2,10.00,1),
							( 15, 7,15,700.00,1),
							( 16, 8,16,400.00,1),
							( 17, 8,17,500.00,1),
							( 18, 9,11,150.00,1),
							( 19, 9,6,60.00,1),
							( 20, 9,7,70.00,1),
							( 21, 10,1,05.00,1),
							( 22, 10,2,10.00,1),
							( 23, 10,3,09.00,1),
							( 24, 10,4,20.00,1),
							( 25, 10,5,30.00,1),
							( 26, 11,15,700.00,1),
							( 27, 11,16,400.00,1),
							( 28, 11,17,500.00,1)

--//HAY QUE ELIMINAR EMAIL DE PROFESIONALES QUE SE QUEDO COLGADA
UPDATE PROFESIONALES
SET email = NULL
ALTER TABLE PROFESIONALES
DROP COLUMN email
ALTER TABLE CLIENTES
alter column nro_documento  varchar(30)
ALTER TABLE PROFESIONALES
alter column nro_documento  varchar(30)

