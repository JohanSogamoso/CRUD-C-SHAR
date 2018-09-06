CREATE TABLE usuario (
  id_u int(11) NOT NULL primary key auto_increment,
  Nombre varchar(6) COLLATE utf8_unicode_ci NOT NULL,
  Apellido varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  Direccion varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  Identificacion varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  Celular varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  Correo varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  Rol varchar(10) COLLATE utf8_unicode_ci DEFAULT NULL
);

insert into usuario(Nombre, Apellido, Direccion, Identificacion, Celular, Correo, Rol)
values ("Pedro", "Alvarez", "Calle 12", "485478", "3001254875", "pedro_r52@gmail.com", "Estudiante");