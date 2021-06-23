create database ConsultasSalon
go
use ConsultasSalon
go
create table Consultas(
Numero int,
Consigna varchar(5000),
Query varchar(5000),
constraint PKConsultas primary key (Numero))

set quoted_identifier off
insert into Consultas (Numero, consigna, query)
values (1,'Se quiere un listado de Clientes de la ciudad de Córdoba, que se hayan depilado y el tipo de depilación, el profesional que le atendió, y hace cuántos días se le realizó el servicio. Rotule, Cliente, Profesional, "desde última" y Servicio Ordenarlos por tipo de depilación.',"select c.apellido+', '+c.nombre 'CLIENTE',
               p.apellido+', '+p.nombre 'PROFESIONAL', 
               CAST(DATEDIFF(DAY, A.fecha, GETDATE()) AS VARCHAR)+' días' 'DESDE ULTIMA',
               UPPER(ts.nom_tipoServicio)+' '+ UPPER(s.nom_servicio) 'SERVICIO'
      from clientes c
      join atenciones a on c.id_cliente = a.id_cliente
      join profesionales p on a.id_profesional = p.id_profesional 
      join facturas f on a.id_atencion = f.id_atencion
      join detalle_facturas dt on f.id_factura = dt.id_factura
      join servicios s on dt.id_servicio = s.id_servicio
      join tipo_servicios ts on s.id_tipoServicio = ts.id_tipoServicio
      join barrios b on c.id_barrio = b.id_barrio
      join localidades l on l.id_localidad = l.id_localidad
 where ts.nom_tipoServicio = 'Depilacion' 
     and l.nom_localidad = upper('cordoba')
  order by s.nom_servicio;"),
(3,'Se quiere saber los clientes de los últimos 15 dias, listar que servicios se les brindaron y que abonaron por ellos, en otra columna aplicar descuento de 10% rotular "PRECIO CON 10% DESCUENTO", ordenado por tipo de servicio Y servicio.'," SELECT c.apellido+', '+c.nombre 'CLIENTE',
UPPER(ts.nom_tipoServicio)+', '+UPPER(s.nom_servicio) 'SERVICIO',
dt.precio 'PRECIO ENTERO',
CAST((dt.precio*0.90) as decimal (6,2)) 'PRECIO 10% CON DESCUENTO'
from clientes c
join atenciones a on c.id_cliente = a.id_cliente
join facturas f on a.id_atencion = f.id_atencion
join detalle_facturas dt on f.id_factura = dt.id_factura
join servicios s on dt.id_servicio = s.id_servicio
join tipo_servicios ts on s.id_tipoServicio = ts.id_tipoServicio
where DATEDIFF(DAY,f.fecha, GETDATE()) <= 15
order by ts.nom_tipoServicio, s.nom_servicio;"),
(2,' Se quiere saber los clientes que son de Córdoba, que la dirección sea desconocida, y si está en espera de ser atendida para solicitarle ese dato'," select c.apellido+', '+c.nombre ' CLIENTE',
l.nom_localidad 'LOCALIDAD',
c.direccion 'DIRECCION',E.nombre_estado 'ESTADO'
from clientes c
join barrios b on c.id_barrio = b.id_barrio
join localidades l on l.id_localidad = b.id_localidad
join atenciones a on a.id_cliente = c.id_cliente
join estados e on e.id_estado = a.id_estado
where l.nom_localidad = 'CORDOBA'
and c.direccion is null
and e.nombre_estado = 'EN ESPERA';
"),
(4,'Listar todos los clientes que dispongan como tipo de contacto Facebook o Teléfono.'," select cl.nombre + ' ' + cl.apellido CLIENTE,
             tc.descripcion 'TIPO CONTACTO', 
             dc.descripcion DETALLE
   from clientes cl
     join contactos co on cl.id_contacto = co.id_contacto
     join detalle_contactos dc on co.id_contacto = dc.id_contacto
     join tipo_contactos tc on dc.id_tipo_contacto = tc.id_tipo_contacto
where tc.descripcion = upper('facebook')
       or tc.descripcion = upper ('telefono');"),
(5,'Listar los profesionales disponibles para el turno TARDE, que viven en barrio Centro o barrio Alto Alberdi, o que pertenezcan a una ciudad que no sea Córdoba. Indicar barrio y localidad en una sola columna rotulada como barrio - localidad.
',"select p.nombre + space(1) + p.apellido PROFESIONAL, 
            b.nom_barrio + ' - ' + l.nom_localidad 'BARRIO - LOCALIDAD'
   from profesionales p
     join turnos t on p.id_turno = t.id_turno
     join barrios b on p.id_barrio = b.id_barrio
     join localidades l on b.id_localidad = l.id_localidad
 where t.descripcion = ('tarde')
     and (b.nom_barrio = 'alto alberdi'
        or b.nom_barrio = 'jardin')
        or (l.nom_localidad not like 'cordoba');"),
(6,'Mostrar todas las facturas cuyo precio total pagado por cada servicio consumido sea mayor o igual 600. Indicar a qué servicio y cliente corresponden.',"select df.id_factura 'N° DE FACTURA',
            c.nombre + ', ' + c.apellido 'CLIENTE',
            UPPER(s.nom_servicio) 'SERVICIO', 
            df.precio * df.cantidad 'IMPORTE'
  from detalle_facturas df
    join servicios s on df.id_servicio = s.id_servicio
    join facturas f on df.id_factura = f.id_factura
    join atenciones a on f.id_atencion = a.id_atencion
    join clientes c on a.id_cliente = c.id_cliente
where (df.precio * df.cantidad) >= 600;
"),
(7,'Se necesita mostrar todas aquellas facturas cuyo método de pago contengan la palabra cheque o débito de todas las facturas entre las fechas 16/05/2021 y 26/05/2021. Mostrar de forma ascendente el número de factura.
'," set dateformat dmy 
select f.id_factura 'N° DE FACTURA', 
              Convert(varchar,DAY(f.fecha)) +
'/'+ Convert(varchar,MONTH(f.fecha)) +
'/'+ Convert(varchar,YEAR(f.fecha))  'FECHA',
   	 mp.descripcion 'TIPO DE PAGO'
   from facturas f
     join detalle_metodo_pagos dmp on f.id_factura = dmp.id_factura
     join metodo_pagos mp on dmp.id_metodo_pago = mp.id_metodo_pago
where mp.descripcion like ('%cheque%')
       or mp.descripcion like ('%debito%')
    and f.fecha between '16/05/2021' and '26/05/2021'
 order by f.id_factura ASC;")

