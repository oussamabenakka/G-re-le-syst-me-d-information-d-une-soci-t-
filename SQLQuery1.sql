create database societe
use societe
create table Developpeurs
(
matricule nvarchar(10) UNIQUE,
nom_prenom nvarchar(50) UNIQUE,
email nvarchar(30),
salaire int
)
alter table Developpeurs
add constraint Q1 check (email like '%@%.%')