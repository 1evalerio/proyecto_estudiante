using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Proyecto_de_estudiantes
{

   //10. Sistema de Registro de Estudiantes y Calificaciones:
    /*Descripción: Crea un sistema que gestione el registro de estudiantes, sus cursos y calificaciones.
      Utiliza estructuras de datos para representar la información de los estudiantes, cursos y realizar cálculos de calificaciones
      y promedios.
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnRegistro.Click += BtnRegistro_Click;
            btnCalificaciones.Click += BtnCalificaciones_Click;
            btnFuncion.Click += BtnFuncion_Click;
            FormClosed += Form1_FormClosed;
          
        }

        private void BtnFuncion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El siguiente programa se encarga de gestionar los registros de los estudiantes, sus cursos" +
                "y calificaciones; el primer modulo de registro se encarga del registro de los estudiantes " +
                "el cual contiene tres campos de 'Nombre' 'Cedula' 'Lugar de vivienda' y sus respectivos cursos " +
                "una vez registrado los estudiantes tambien esta el modulo de registro de notas y consulta de promedio." +
                "Con las notas que se proporcionen, (la variable a tomar en cuanta para el registro de las notas es la cedula del estudiante ya que es un valor unico por persona) Se sacara el promedio", "Funcion");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {//borra el archivo creado con los datos del estudiante guardados al cambiar al form de las calificaciones
            string filePath = "cEstudiantes.txt";

            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    Console.WriteLine("El archivo se ha borrado correctamente.");
                }
                else
                {
                    Console.WriteLine("El archivo no existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se produjo un error al borrar el archivo:");
                Console.WriteLine(ex.Message);
            }
        }

        private void BtnCalificaciones_Click(object sender, EventArgs e)
        { //Se encarga de mostrar el form de calificaciones
            Califiaciones a = new Califiaciones();
            a.Show();
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            //Se encarga de mostrar el form de registro
            Registro a = new Registro();
            a.Show();
        }


    }
}
