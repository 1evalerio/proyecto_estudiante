using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_estudiantes
{
    public partial class Registro : Form
    {
        CRUD a = new CRUD();//Inicializa a clase CRUD para su uso
        public Registro()
        {
            InitializeComponent();
            btnRegistrar.Click += BtnRegistrar_Click;
        }


        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            string n = tbCedula.Text;
            if (a.Buscar(n) == true)//Verifica que no este ya registrado el estudiante
            {
                MessageBox.Show("Ya esta registrado el estudiante", "Registro");
                //Devuelve los campos vacios
                tbNombre.Text = "";
                tbCedula.Text = "";
                tbLugar.Text = "";
                cbInformatica.Checked = false;
                cbMatematicas.Checked = false;
                cbIngles.Checked = false;
            }//Si no lo esta permite el regustro//
            else
            {
                Coleccion b = new Coleccion();
                b.Nombre = tbNombre.Text;
                b.Ubicacion = tbLugar.Text;
                b.Cdula = tbCedula.Text;
                if (cbInformatica.Checked == true)
                {
                    b.Curso3 = "Informatica";
                }
                if (cbMatematicas.Checked == true)
                {
                    b.Curso2 = "Matematicas";
                }
                if (cbIngles.Checked == true)
                {
                    b.Curso1 = "Ingles";
                }
                a.registrarAlumno(b);
                a.RegistroArchivo(b.Cdula);
                MessageBox.Show("Estudiante registrado", "Registro");
                //Devueve los campos vacios
                tbNombre.Text = "";
                tbCedula.Text = "";
                tbLugar.Text = "";
                cbInformatica.Checked = false;
                cbMatematicas.Checked = false;
                cbIngles.Checked = false;
            }
        }

        private void tbCedula_KeyPress(object sender, KeyPressEventArgs e)
        {//Valida lo que se puede escribir en los campos de los textbox
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {//Valida lo que se puede escribir en los campos de los textbox
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Letras", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Registro_Load(object sender, EventArgs e)
        {//Desactiva los botones
            btnRegistrar.Enabled = false;
        }

        public void validar()
        {//Valida que todos los campos esten escritos para su llamada y activarlos
            var vr = !string.IsNullOrEmpty(tbNombre.Text) &&
                !string.IsNullOrEmpty(tbLugar.Text) &&
                !string.IsNullOrEmpty(tbCedula.Text) &&
                cbIngles.Checked && cbInformatica.Checked && cbMatematicas.Checked ;
            btnRegistrar.Enabled = vr;
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {//Verifica que se llenaron los campos
            validar();
        }

        private void tbLugar_TextChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void tbCedula_TextChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void cbIngles_CheckedChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void cbMatematicas_CheckedChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void cbInformatica_CheckedChanged(object sender, EventArgs e)
        {
            validar();
        }
    }
}
