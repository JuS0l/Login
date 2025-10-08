create database dbLogin;
/*drop database dbLogin*/
use dbLogin;

create table tbCliente(
Id int primary key auto_increment,
Nome varchar(70) not null,
DataNascimento date not null,
Sexo char(1) not null,
CPF bigint not null,
Telefone int not null,
Senha varchar(30) not null,
Email varchar(150) not null,
Situacao boolean not null
);

create table tbColaborador(
Id int primary key auto_increment,
Nome varchar(70) not null,
Senha varchar(30) not null,
Email varchar(150) not null,
Tipo varchar(70) not null
);