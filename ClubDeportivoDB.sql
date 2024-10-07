drop database if exists Proyecto;
create database Proyecto;
use Proyecto;

create table roles(
RolUsu int,
NomRol varchar(30),
constraint primary key(RolUsu)
);

insert into roles values
(01,'Administrador'),
(02,'Empleado');

create table usuario(
CodUsu int auto_increment,
NombreUsu varchar (20),
PassUsu varchar (15),
RolUsu int,
Activo boolean default true,
constraint pk_usuario primary key (CodUsu),
constraint fk_usuario foreign key(RolUsu) references roles(RolUsu)
);

insert into usuario(NombreUsu,PassUsu,RolUsu) values
('Paez123','123456',01),
('Fernandez123','123456',02);

#procedure para el ingreso
delimiter //  
create procedure IngresoLogin(in Usu varchar(20),in Pass varchar(15))
begin
  select NomRol
	from usuario u inner join roles r on u.RolUsu = r.RolUsu
		where NombreUsu = Usu and PassUsu = Pass /* se compara con los parametros */
			and Activo = 1; /* el usuario debe estar activo */
end 
//

call IngresoLogin('Paez123', '123456')//
