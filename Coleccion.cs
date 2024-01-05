using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_estudiantes
{
    internal class Coleccion
    {   //Clase coleccion que contiene las variables para su uso
        private String nombre;
        private String ubicacion;
        private String cedula;
        private String curso1;
        private String curso2;
        private String curso3;

        public String Nombre { get { return nombre; } set { nombre = value; } }
        public String Ubicacion {  get { return ubicacion; } set { ubicacion = value; } }
        public String Cdula { get {  return cedula; } set {  cedula = value; } }
        public String Curso1 { get {  return curso1; } set {  curso1 = value; } }
        public String Curso2 { get {  return curso2; } set {  curso2 = value; } }
        public String Curso3 { get {  return curso3; } set {  curso3 = value; } }

        public Coleccion()
        {
            Nombre = ""; Ubicacion = ""; Cdula = "";
            Curso1 = ""; Curso2 = ""; Curso3 = "";
        }

        public Coleccion(string a, string b, string c, string d, string e, string f)
        {
            Nombre = a; Cdula = c; ubicacion = b;
            curso1=d; curso2=e; curso3=f;
        }

    }
}
