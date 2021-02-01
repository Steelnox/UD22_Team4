using System;
using System.Collections.Generic;
using System.Text;

namespace UD22
{
    //Modelo
    public class Ejercicio1
    {
        public void CreateTable(Database db)
        {
            db.Multifunction("CREATE TABLE Cliente(id int IDENTITY(1, 1),nombre varchar(250) default null,apellido varchar(250) default null,direccion varchar(250) default null,dni int default null,fecha date default null,primary key(id))");
        }

        public void InsertTableCliente(Database db)
        {
            db.Multifunction("Insert into Cliente values ('Eric', 'Pastor', 'Calle Rita nº 6', '39927565', '10-12-1993')");
        }

        public void SelectTableCliente(Database db)
        {
            db.Lectura("Select * from Cliente");
        }

        public void UpdateTableCliente(Database db)
        {
            db.Multifunction("Update Cliente set fecha='20-10-2010'");
        }

        public void DeleteTableCliente(Database db)
        {
            db.Multifunction("Delete from Cliente");
        }
    }
}
