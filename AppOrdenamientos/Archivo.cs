using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOrdenamientos
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Archivo
    {
        private string _path = "archivo.txt"; 

        public List<Estudiante> LeerEstudiantes()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();

            if (File.Exists(_path))
            {
                string[] lines = File.ReadAllLines(_path);
                foreach (var line in lines)
                {
                    var datos = line.Split('|');
                    int id = int.Parse(datos[0]);
                    string nombre = datos[1].Trim();
                    int edad = int.Parse(datos[2]);
                    string carrera = datos[3].Trim();
                    int semestre = int.Parse(datos[4]);

                    estudiantes.Add(new Estudiante(id, nombre, edad, carrera, semestre));
                }
            }
            return estudiantes;
        }

        public void GuardarEstudiantes(List<Estudiante> estudiantes)
        {
            List<string> lines = new List<string>();

            foreach (var estudiante in estudiantes)
            {
                string line = $"{estudiante.ID} | {estudiante.Nombre} | {estudiante.Edad} | {estudiante.Carrera} | {estudiante.Semestre}";
                lines.Add(line);
            }

            File.WriteAllLines(_path, lines); 
        }
    }

}
