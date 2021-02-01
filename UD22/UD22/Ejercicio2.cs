using System;
using System.Collections.Generic;
using System.Text;

namespace UD22
{
    class Ejercicio2
    {
        //Modelo
        public void CreateTableCliente(Database db)
        {
            db.Multifunction("CREATE TABLE Cliente(id int IDENTITY(1, 1),nombre varchar(250) default null,apellido varchar(250) default null,direccion varchar(250) default null,dni int default null,fecha date default null,primary key(id))");
        }
        public void CreateTableVideos(Database db)
        {
            db.Multifunction("CREATE TABLE Videos(id INT IDENTITY(1, 1)," +
                "title VARCHAR(250) DEFAULT NULL," +
                "director VARCHAR(250) DEFAULT NULL," +
                "cli_id INT DEFAULT NULL, " +
                "PRIMARY KEY (id), " +
                "CONSTRAINT videos_fk FOREIGN KEY (cli_id) REFERENCES Cliente (id))");
        }

        public void InsertTableCliente(Database db)
        {
            db.Multifunction("Insert into Cliente values ('Eric', 'Pastor', 'Calle Rita nº 6', '39927565', '10-12-1993')");
            db.Multifunction("INSERT INTO Cliente VALUES ('Sergio', 'Clavero', 'Tortellini Nº 22', '89485029', '24-4-1995')");
        }

        public void InsertTableVideos(Database db)
        {
            db.Multifunction("INSERT INTO Videos VALUES ('Punto Red','Jose Marinero',1)");
            db.Multifunction("INSERT INTO Videos VALUES ('Boot Can','Jalorin Fernando',2)");
        }

        public void SelectTableCliente(Database db)
        {
            db.Lectura("Select * from Cliente");        
        }
        public void SelectTableVideos(Database db)
        {
            db.Lectura("SELECT * FROM Videos");
        }
        public void UpdateTable(Database db)
        {
            db.Multifunction("Update Cliente set fecha='20-10-2010'");
            db.Multifunction("UPDATE Videos SET director = 'Malcom Ride'");
        }

        public void DeleteTable(Database db)
        {
            db.Multifunction("DELETE FROM Videos");
            db.Multifunction("Delete from Cliente");            
        }
    }
}
