create database dbBancoApp;
use dbBancoApp;
-- drop database dbBancoApp;
create table usuario
(
IdUsu int primary KEY auto_increment,
nomeUsu varchar(50) not null,
Cargo varchar(50) not null,
DataNasc datetime
);
insert into usuario(nomeUsu, Cargo, DataNasc)
			values('Nilson', 'Gerente', '1978-05-01'),
				('Bruno', 'Colaborador', '2000-10-12');
select*from usuario;                
                