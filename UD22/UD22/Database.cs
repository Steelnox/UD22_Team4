﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace UD22
{
    //Modelo
    public class Database
    {
        public void Multifunction(string cadena)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Data Source=192.168.1.49;Initial Catalog=UD22;Persist Security Info=True;User ID=root;Password=NvEPtJ&kxkWhmc21f#");
                conexion.Open();
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();

                Console.WriteLine("Operacion realizada");
                conexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Lectura(string cadena)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Data Source=192.168.1.49;Initial Catalog=UD22;Persist Security Info=True;User ID=root;Password=NvEPtJ&kxkWhmc21f#");
                conexion.Open();
                SqlCommand comando = new SqlCommand(cadena, conexion);
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.WriteLine(reader.GetValue(i));
                        }

                    }
                    Console.WriteLine("Operacion realizada");
                    conexion.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
