using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public float Calificacion { get; set; }


        public Estudiante(string nombre, int edad, float calificacion)
        {
            Nombre = nombre;
            Edad = edad;
            Calificacion = calificacion;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Empleado:" + Nombre);
            Console.WriteLine("Edad:" + Edad);
            Console.WriteLine("Calificacion: " + Calificacion);
        }

    }
}
