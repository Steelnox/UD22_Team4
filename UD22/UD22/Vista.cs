using System;
using System.Collections.Generic;
using System.Text;

namespace UD22
{
    public class Vista
    {
        public void menu()
        {
            //Menú apertura
            Console.WriteLine("Bienvenido cliente");
            Console.WriteLine("Selecciona una acción");
            Console.WriteLine("1-Ejercicio 1");
            Console.WriteLine("2-Ejercicio 2");
            Console.WriteLine("3-Ejercicio 3");
        }

        public void menuOpcion()
        {
            //Menu opcion CRUD
            Console.WriteLine("Escoja una opcion de entre estas 4 según la tarea que quiera realizar");
            Console.WriteLine("1-Crear la tabla");
            Console.WriteLine("2-Insertar datos en la tabla tabla");
            Console.WriteLine("3-Leer datos de la tabla");
            Console.WriteLine("4-Actualizar datos de la tabla");
            Console.WriteLine("5-Borrar datos de la tabla");
        }

        public void menuSalir()
        {
            //Menu para salir del programa
            Console.WriteLine("¿Quiere salir del programa?");
            Console.WriteLine("1- Si 2- No");
        }
    }
}
