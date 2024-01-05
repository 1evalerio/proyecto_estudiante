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
    public partial class Califiaciones : Form
    {

        CRUD b = new CRUD();
        public int pos = 0;
        public Califiaciones()
        {
            InitializeComponent();
            btnGuardar.Click += BtnGuardar_Click;
            btnCalcular.Click += BtnCalcular_Click;
            
        }
        private void Califiaciones_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {//Se encarga de obtener el promedio
            Boolean a = false;
            int pos = 0;
            List<string> cedulas = new List<string>();
            if(File.Exists("cEstudiantes.txt")==true)
            {
                cedulas = File.ReadAllLines("cEstudiantes.txt").ToList();//Almacena los datos obtenidos del archivo en una lista

                for (int i = 0; i < cedulas.Count; i++)//Verifica si esta el registro de la cedula del estudiante
                {
                    if (Cailficacion.Text == cedulas[i])
                    {
                        pos = i;
                        a = true;
                    }
                }
            }

            if (a == true)
            {
                float promedio = 0f;
                for (int i = 0; i < b.Colecciones2.Count; i++)
                {//Muestra cada nota en el registro
                    ingles.Text = b.Colecciones2[pos].Nota1.ToString();
                    informatica.Text = b.Colecciones2[pos].Nota2.ToString();
                    matematicas.Text = b.Colecciones2[pos].Nota3.ToString();

                    promedio = (b.Colecciones2[i].Nota1 + b.Colecciones2[i].Nota2 + b.Colecciones2[i].Nota3);
                }

                promedio = (promedio / 3);//Calcula el promedio

                tbPromedio.Text = promedio.ToString();//Muestra el promedio
            }
            else
            {
                MessageBox.Show("No hay registro de notas", "Calificaciones");
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Coleccion2 a = new Coleccion2();
            string cedula = tbCedula.Text;
            if (b.BuscarN(cedula) == true)
            {//Almacena cada dato en una lista de las notas
                a.Cedula = tbCedula.Text;
                a.Nota1 = float.Parse(tbIngles.Text);
                a.Nota2 = float.Parse(tbInformatica.Text);
                a.Nota3 = float.Parse(tbMatematicas.Text);
                b.registroNotas(a);
                MessageBox.Show("Registro Completado", "Calificaciones");
                tbCedula.Text = "";
                tbIngles.Text = "";
                tbInformatica.Text = "";
                tbMatematicas.Text = "";
            }
            else
            {
                MessageBox.Show("No hay registro de estudiante", "calificacion");
            }

        }

      
        public void validar_campo()
        {//Valida la que se escriba en los campos
            var vr = !string.IsNullOrEmpty(tbCedula.Text) &&
                     !string.IsNullOrEmpty(tbIngles.Text) &&
                     !string.IsNullOrEmpty(tbInformatica.Text) &&
            !string.IsNullOrEmpty(tbMatematicas.Text);
             
            btnGuardar.Enabled = vr;
        }
        private void tbCedula_KeyPress(object sender, KeyPressEventArgs e)
        {//Valida lo que se puede escribir en los campos de los textbox
            if ((e.KeyChar >= 32 && e.KeyChar <=47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void tbIngles_KeyPress(object sender, KeyPressEventArgs e)
        {//Valida lo que se puede escribir en los campos de los textbox
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros y coma", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void tbMatematicas_KeyPress(object sender, KeyPressEventArgs e)
        {//Valida lo que se puede escribir en los campos de los textbox
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros y coma", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void tbInformatica_KeyPress(object sender, KeyPressEventArgs e)
        {//Valida lo que se puede escribir en los campos de los textbox
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros y coma", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Cailficacion_KeyPress(object sender, KeyPressEventArgs e)
        {//Valida lo que se puede escribir en los campos de los textbox
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void tbCedula_TextChanged(object sender, EventArgs e)
        {
            validar_campo();
        }

        private void tbIngles_TextChanged(object sender, EventArgs e)
        {
            validar_campo();
        }

        private void tbInformatica_TextChanged(object sender, EventArgs e)
        {
            validar_campo();
        }

        private void tbMatematicas_TextChanged(object sender, EventArgs e)
        {
            validar_campo();
        }
    }
}
