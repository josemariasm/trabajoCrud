CREATE DATABASE proyectoIntermodular;
use proyectoIntermodular;

CREATE TABLE cantante(
	id_cantante int auto_increment primary key,
    nombre varchar(100),
    descripcion varchar(500),
    estilo varchar(50)
);

insert into cantante(nombre, descripcion, estilo) values("Kaze", "El de cartagena", "Rap");
insert into cantante(nombre, descripcion, estilo) values("Estopa", "El mitico", "rumba, flamenco y pop-rock");
insert into cantante(nombre, descripcion, estilo) values("Andres Campos", "El Español", "Techno");
insert into cantante(nombre, descripcion, estilo) values("Bad Bunny", "el conejo malo", "Trap");

CREATE TABLE eventos(
	id_evento int auto_increment primary key,
	id_cantante int,
	nombre varchar(100),
	descripcion varchar(500),
	lugar varchar(100),
	fecha_evento date,
	FOREIGN KEY (id_cantante) REFERENCES cantante(id_cantante)
);

insert into eventos(id_cantante, nombre, descripcion, lugar, fecha_evento) values ("1", "PIRATA FESTIVAL", "Festival de rap", "Gandia", '2025-03-8');
insert into eventos(id_cantante, nombre, descripcion, lugar, fecha_evento) values ("2", "ESTOPA FESTIVAL", "Festival de estopa", "Buñol", '2025-07-17');
insert into eventos(id_cantante, nombre, descripcion, lugar, fecha_evento) values ("3", "SPOOK", "A volar a Spook", "Pinedo", '2025-06-3');
insert into eventos(id_cantante, nombre, descripcion, lugar, fecha_evento) values ("4", "TRAP FESTIVAL", "Hola", "Gandia", '2025-5-27');

CREATE TABLE ticket(
	id_ticket int auto_increment primary key,
    id_evento int,
    tipo varchar(50),
    precio double,
    FOREIGN KEY (id_evento) REFERENCES eventos(id_evento)
);

insert into ticket(id_evento, tipo, precio) values("1", "normal", 20.99);
insert into ticket(id_evento, tipo, precio) values("1", "VIP", 30.99);
insert into ticket(id_evento, tipo, precio) values("2", "normal", 15.99);
insert into ticket(id_evento, tipo, precio) values("2", "VIP", 25.99);
insert into ticket(id_evento, tipo, precio) values("3", "normal", 18.99);
insert into ticket(id_evento, tipo, precio) values("3", "BACKSTAGE", 28.99);
insert into ticket(id_evento, tipo, precio) values("4", "normal", 30.99);
insert into ticket(id_evento, tipo, precio) values("4", "VIP", 60.99);



CREATE TABLE cliente(
	id_cliente int auto_increment primary key,
    id_ticket int,
    dni varchar(20),
    nombre varchar(100),
    fecha_nacimiento date,	
    cantidad_entradas int
);