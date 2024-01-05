using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_estudiantes
{
    internal class CRUD
    {
        private List<Coleccion> colecciones;//lista que guarda los datos del estudiante
        private List<Coleccion2> colecciones2;//Lista que guarda las calaficaciones de los estudiantes
        
        public List<Coleccion> Colecciones { get { return colecciones; }set { colecciones = value; } }
        public List<Coleccion2> Colecciones2 { get { return colecciones2; }set { colecciones2 = value; } }

        public CRUD() 
        {
            Colecciones = new List<Coleccion>();
            colecciones2 = new List<Coleccion2>();
         
        }

        public void registrarAlumno(Coleccion a)
        {//Almacena los datos en la lista
            Colecciones.Add(a);
          
        }
        public void RegistroArchivo(string a)
        {//Crea un archivo con las cedulas de los estudiantes para su uso
            using (StreamWriter b = File.AppendText("cEstudiantes.txt"))
            {
                b.WriteLine(a);
            }

        }
        public void registroNotas(Coleccion2 a)
        {//Almacena las notas
            colecciones2.Add(a);
        }
        public Boolean Buscar(string n)//Verifica si ya se registro
        {
            Boolean a= false;

          for(int i = 0;i<Colecciones.Count;i++)
            {
                if (n == colecciones[i].Cdula)
                {
                     a = true;
                }
            }

            return a;
        }
        public Boolean BuscarN(string n)//Verifica si ya se registro
        {
            Boolean a = false;
            List<string> cedulas = new List<string>();
            if (File.Exists("cEstudiantes.txt") == true)
            {
                cedulas = File.ReadAllLines("cEstudiantes.txt").ToList();
            }
            for (int i = 0; i <cedulas.Count ; i++)
            {
                if (n == cedulas[i])
                {

                    a = true;
                }
            }


            return a;
        }
    }
}
