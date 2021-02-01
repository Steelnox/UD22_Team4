using System;
using System.Collections.Generic;
using System.Text;

namespace UD22
{
    public class Controlador
    {
        private Vista vista;
        string opcionModelo = "";
        string opcionTarea = "";
        string opcionSalir = "";
        bool acabado = false;
        Database db = new Database();
        public Controlador (Vista vista)
        {
            this.vista = vista;
            seleccion();
        }

        public void seleccion()
        {
            vista.menu();
            opcionModelo = Console.ReadLine();
            while (!acabado)
            {
                vista.menuOpcion();
                opcionTarea = Console.ReadLine();
                switch (opcionModelo)
                {
                    case "1":
                        Ejercicio1 ej1 = new Ejercicio1();
                        switch (opcionTarea)
                        {
                            case "1":
                                ej1.CreateTable(db);
                                break;
                            case "2":
                                ej1.InsertTableCliente(db);
                                break;
                            case "3":
                                ej1.SelectTableCliente(db);
                                break;
                            case "4":
                                ej1.UpdateTableCliente(db);
                                break;
                            case "5":
                                ej1.DeleteTableCliente(db);
                                break;
                            default:
                                break;
                        }
                        break;
                    case "2":
                        Ejercicio2 ej2 = new Ejercicio2();

                        switch (opcionTarea)
                        {
                            case "1":
                                ej2.CreateTableCliente(db);
                                ej2.CreateTableVideos(db);
                                break;
                            case "2":
                                ej2.InsertTableCliente(db);
                                ej2.InsertTableVideos(db);

                                break;
                            case "3":
                                ej2.SelectTableCliente(db);
                                ej2.SelectTableVideos(db);
                                break;
                            case "4":
                                ej2.UpdateTable(db);
                                break;
                            case "5":
                                ej2.DeleteTable(db);
                                break;


                            default: break;
                        }
                        break;
                    case "3":
                        Ejercicio3 ej3 = new Ejercicio3();

                        switch (opcionTarea)
                        {
                            case "1":
                                ej3.CrearTablaCientificos(db);
                                ej3.CrearTablaProyectos(db);
                                ej3.CrearTablaAsignado(db);
                                break;
                            case "2":
                                ej3.InsertarTablaCientificos(db);
                                ej3.InsertarTablaProyectos(db);
                                ej3.InsertarTablaAsignar(db);
                                break;
                            case "3":
                                ej3.SelectCientificos(db);
                                ej3.SelectProyectos(db);
                                ej3.SelectAsignar(db);
                                break;
                            case "4":
                                ej3.UpdatesTables(db);
                                break;
                            case "5":
                                ej3.DeleteTables(db);
                                break;


                            default: break;
                        }
                        break;
                    default: 
                        break;                 
                }
                vista.menuSalir();
                opcionSalir = Console.ReadLine();

                if(opcionSalir == "1")
                {
                    acabado = true;
                }
            }
        }
    }
}
