﻿using System;
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
