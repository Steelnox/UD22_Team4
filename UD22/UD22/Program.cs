using System;

namespace UD22
{
    class Program
    {
        static void Main(string[] args)
        {
            Vista vista = new Vista();
            Controlador controller = new Controlador(vista);
        }
    }
}
