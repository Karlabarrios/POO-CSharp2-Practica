using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioExtra
{
    class Persona
    {
        //Persona: nombre, apellido, fecha de nacimiento, numeroTelefono, correo

        public string nombre { get; }
        public string apellido { get; }
        public int fechaNacimiento { get; }
        private string numeroTelefono;
        private string correo;
        private int edad;
        public string nacionalidad { get; }

        public Persona(string nombre, string apellido, int fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            nacionalidad = "mexicano(a)";
            edad = 2023 - fechaNacimiento;
        }
        public int GetEdad()
        {
            return edad;
        }

        public string NumeroTelefono
        {
            get { return numeroTelefono; }
            set
            {
                if (value.Length == 10)
                    numeroTelefono = value;
                else
                    numeroTelefono = "Su telefono no tiene la cantidad de valores correcta";
            }
        }
        public string Correo
        {
            get { return correo; }
            set
            {
                if (value.Contains("@gmail.com"))
                    correo = value;
                else
                    correo = "No se ingreso un correo gmail";
            }
        }

        public string darEdad()
        {
            return "Mi edad es: " + edad;
        }

        public string darEdad(string extraño)
        {
            return "Hola " + extraño + " mi edad es: " + edad;
        }
    }
}
