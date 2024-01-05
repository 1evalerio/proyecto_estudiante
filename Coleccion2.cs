using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_estudiantes
{
    internal class Coleccion2
    {
      //Clase coleccion que contiene las variables para su uso
        private float nota1;
        private float nota2;
        private float nota3;
        private String cedula;
        public int posicion;

        public String Cedula { get { return cedula; } set { cedula = value; } }
        public float Nota1 { get { return nota1; }set { nota1 = value; } }
        public float Nota2 { get { return nota2; }set { nota2 = value; } }
        public float Nota3 { get { return nota3; }set { nota3 = value; } }
        public int Posicion {get { return posicion; }set { posicion = value; } }
        public Coleccion2 () 
        {
            Nota1 = 0;
            Nota2 = 0;
            Nota3 = 0;
        }
    }
}
