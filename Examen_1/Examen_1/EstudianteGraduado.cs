using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1
{
    public class EstudianteGraduado : Estudiante
    {
        public string Titulo { get; set; }


        public EstudianteGraduado(string nombre, int edad, float calificacion, string titulo) : base(nombre, edad, calificacion)
        {
            Titulo = titulo;
        }

        

        
    }
}
