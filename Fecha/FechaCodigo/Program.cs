using System;
using FechaProg;

namespace FechaCodigo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fecha correcta, año bisiesto
            Fecha fecha1 = new Fecha(12, 2012, 4);
            Console.WriteLine("Fecha 1: " + fecha1.ToString());
            if (fecha1.EsBisiesto())
                Console.WriteLine("El año " + fecha1.A + " es bisiesto");
            else
                Console.WriteLine("El año " + fecha1.A + " no es bisiesto");
            //Fecha correcta, año no bisiesto
            Fecha fecha2 = new Fecha(10, 2013, 4);
            Console.WriteLine("Fecha 2: " + fecha2.ToString());
            if (fecha2.EsBisiesto())
                Console.WriteLine("El año " + fecha2.A + " es bisiesto");
            else
                Console.WriteLine("El año " + fecha2.A + " no es bisiesto");
            //Fecha con valores incorrectos
            Fecha fecha3 = new Fecha(13, -4, 4);
            Console.WriteLine("Fecha 3: " + fecha3.ToString());
            //Fecha con asignación incorrecta de valores erroneos
            Fecha fecha4 = new Fecha(67,80,3678);
            Console.WriteLine("Fecha 4: " + fecha4.ToString());
            //MAL!!
        }
    }
}
