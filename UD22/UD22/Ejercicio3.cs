using System;
using System.Collections.Generic;
using System.Text;

namespace UD22
{
    class Ejercicio3
    {
        public void CrearTablaCientificos(Database db)
        {
            db.Multifunction("CREATE TABLE Cientifico(Dni varchar(8),NomApels nvarchar(255),primary key(Dni))");

        }
        public void CrearTablaProyectos(Database db)
        {
            db.Multifunction("CREATE TABLE Proyecto(Id char(4),Nombre nvarchar(255),Horas int,primary key(Id))");

        }
        public void CrearTablaAsignado(Database db)
        {
            db.Multifunction("CREATE TABLE Asignado_A(Cientifico varchar(8) FOREIGN KEY REFERENCES Cientifico(Dni),Proyecto char(4) FOREIGN KEY REFERENCES Proyecto(Id),constraint asignar_fk PRIMARY KEY (Cientifico,Proyecto))");
        }

        public void InsertarTablaCientificos(Database db)
        {
            db.Multifunction("insert into Cientifico (Dni,NomApels) values ('11111111','Luis Martinez')");
            db.Multifunction("insert into Cientifico (Dni,NomApels) values ('22222222','Pilar Alegría')");
            db.Multifunction("insert into Cientifico (Dni,NomApels) values ('33333333','Pedro ´Marín')");
        }

        public void InsertarTablaProyectos(Database db)
        {
            db.Multifunction("insert into Proyecto (Id,Nombre,Horas) values ('0001','Proyecto 1',5)");
            db.Multifunction("insert into Proyecto (Id,Nombre,Horas) values ('0002','Proyecto 2',11)");
            db.Multifunction("insert into Proyecto (Id,Nombre,Horas) values ('0003','Proyecto 3',7)");
        }

        public void InsertarTablaAsignar(Database db)
        {
            db.Multifunction("insert into Asignado_A (Cientifico,Proyecto) values ('11111111','0003')");
            db.Multifunction("insert into Asignado_A (Cientifico,Proyecto) values ('22222222','0002')");
            db.Multifunction("insert into Asignado_A (Cientifico,Proyecto) values ('33333333','0001')");
        }
        public void SelectCientificos(Database db)
        {
            db.Lectura("Select * from Cientifico");
        }
        public void SelectProyectos(Database db)
        {
            db.Lectura("Select * from Proyecto");
        }
        public void SelectAsignar(Database db)
        {
            db.Lectura("Select * from Asignado_A");
        }
        public void UpdatesTables(Database db)
        {
            db.Multifunction("update Cientifico set NomApels='Cientifico ' + Dni");
            db.Multifunction("update Proyecto set Nombre='Proyecto ' + Id");
        }
        public void DeleteTables(Database db)
        {
            db.Multifunction("DELETE FROM Asignado_A");
            db.Multifunction("Delete from Cientifico");
            db.Multifunction("Delete from Proyecto");
        }
    }
}
