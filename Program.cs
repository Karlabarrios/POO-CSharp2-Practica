using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona per1 = new Persona("Nieve","Serena", 1993);
            Console.WriteLine("Ingrese su numero telefónico:");
            per1.NumeroTelefono = Console.ReadLine();
            Console.WriteLine("Ingrese su correo electrónico:");
            per1.Correo = Console.ReadLine();
            Console.WriteLine(per1.darEdad("pao"));
            Console.WriteLine("La nacionalidad de " + per1.nombre + " " + per1.apellido + " es " + per1.nacionalidad);
            Console.WriteLine("La edad de " + per1.nombre + " " + per1.apellido + " es " + per1.GetEdad() + " años");
            Console.WriteLine("Su número telefónico es: " + per1.NumeroTelefono);
            Console.WriteLine("Su correo electrónico es: " + per1.Correo);


            Console.ReadKey();
        }
    }
}
