CREATE DATABASE NEGOCIO;
USE NEGOCIO;
-- DROP DATABASE NEGOCIO;

CREATE TABLE AUTOR(
autorId int not null auto_increment primary key,
nome varchar(30) not null,
nacionalidade varchar(30));

CREATE TABLE LIVRO(
livroId int not null auto_increment primary key,
titulo varchar(50) not null,
datapublicacao date not null,
autorId int not null,
foreign key (autorId) references AUTOR(autorId));

insert into autor (nome,nacionalidade) values("Tudor, C.J.","Inglaterra");
-- select * from autor;
insert into Livro(titulo,datapublicacao,autorId) values("O Homem de Giz","2018-01-07",1);
-- select * from Livro;