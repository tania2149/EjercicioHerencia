using EjercicioClasess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
 
    namespace EjercicioClasess
{
    internal class Class : Class
    {
        public bool descripcion { get; set; }
        public bool nivel { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Area: {Area}");
            Console.WriteLine($"Longitud: {Longitud}");
            Console.WriteLine($"Volumen: {Volumen}");

        }
    }
}