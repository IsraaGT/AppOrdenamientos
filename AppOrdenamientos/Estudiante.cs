using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOrdenamientos
{
    public class Estudiante
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Carrera { get; set; }
        public int Semestre { get; set; }

        public Estudiante(int id, string nombre, int edad, string carrera, int semestre)
        {
            ID = id;
            Nombre = nombre;
            Edad = edad;
            Carrera = carrera;
            Semestre = semestre;
        }

        public override string ToString()
        {
            return $"{ID} | {Nombre} | {Edad} | {Carrera} | {Semestre}";
        }
    }

}
