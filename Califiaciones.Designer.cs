namespace Proyecto_de_estudiantes
{
    partial class Califiaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPromedio = new System.Windows.Forms.TextBox();
            this.tbIngles = new System.Windows.Forms.TextBox();
            this.tbMatematicas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbInformatica = new System.Windows.Forms.TextBox();
            this.Cailficacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.matematicas = new System.Windows.Forms.TextBox();
            this.informatica = new System.Windows.Forms.TextBox();
            this.ingles = new System.Windows.Forms.TextBox();
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPromedio
            // 
            this.tbPromedio.Location = new System.Drawing.Point(444, 189);
            this.tbPromedio.Name = "tbPromedio";
            this.tbPromedio.ReadOnly = true;
            this.tbPromedio.Size = new System.Drawing.Size(100, 20);
            this.tbPromedio.TabIndex = 6;
            // 
            // tbIngles
            // 
            this.tbIngles.Location = new System.Drawing.Point(95, 100);
            this.tbIngles.Name = "tbIngles";
            this.tbIngles.Size = new System.Drawing.Size(100, 20);
            this.tbIngles.TabIndex = 7;
            this.tbIngles.TextChanged += new System.EventHandler(this.tbIngles_TextChanged);
            this.tbIngles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIngles_KeyPress);
            // 
            // tbMatematicas
            // 
            this.tbMatematicas.Location = new System.Drawing.Point(95, 136);
            this.tbMatematicas.Name = "tbMatematicas";
            this.tbMatematicas.Size = new System.Drawing.Size(100, 20);
            this.tbMatematicas.TabIndex = 8;
            this.tbMatematicas.TextChanged += new System.EventHandler(this.tbMatematicas_TextChanged);
            this.tbMatematicas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMatematicas_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Informatica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ingles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Matematicas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Clasificaciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cursos Registrados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(419, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Caculo de promedio";
            // 
            // tbInformatica
            // 
            this.tbInformatica.Location = new System.Drawing.Point(95, 168);
            this.tbInformatica.Name = "tbInformatica";
            this.tbInformatica.Size = new System.Drawing.Size(100, 20);
            this.tbInformatica.TabIndex = 15;
            this.tbInformatica.TextChanged += new System.EventHandler(this.tbInformatica_TextChanged);
            this.tbInformatica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInformatica_KeyPress);
            // 
            // Cailficacion
            // 
            this.Cailficacion.Location = new System.Drawing.Point(444, 59);
            this.Cailficacion.Name = "Cailficacion";
            this.Cailficacion.Size = new System.Drawing.Size(100, 20);
            this.Cailficacion.TabIndex = 16;
            this.Cailficacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cailficacion_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(306, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Estudiante por Cedula";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(376, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Promedio";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(95, 234);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(444, 224);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 22;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(363, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Matematicas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(390, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Ingles";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(371, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Informatica";
            // 
            // matematicas
            // 
            this.matematicas.Location = new System.Drawing.Point(444, 161);
            this.matematicas.Name = "matematicas";
            this.matematicas.ReadOnly = true;
            this.matematicas.Size = new System.Drawing.Size(100, 20);
            this.matematicas.TabIndex = 28;
            // 
            // informatica
            // 
            this.informatica.Location = new System.Drawing.Point(444, 126);
            this.informatica.Name = "informatica";
            this.informatica.ReadOnly = true;
            this.informatica.Size = new System.Drawing.Size(100, 20);
            this.informatica.TabIndex = 29;
            // 
            // ingles
            // 
            this.ingles.Location = new System.Drawing.Point(444, 100);
            this.ingles.Name = "ingles";
            this.ingles.ReadOnly = true;
            this.ingles.Size = new System.Drawing.Size(100, 20);
            this.ingles.TabIndex = 30;
            // 
            // tbCedula
            // 
            this.tbCedula.Location = new System.Drawing.Point(95, 62);
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.Size = new System.Drawing.Size(100, 20);
            this.tbCedula.TabIndex = 31;
            this.tbCedula.TextChanged += new System.EventHandler(this.tbCedula_TextChanged);
            this.tbCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCedula_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Cedula";
            // 
            // Califiaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbCedula);
            this.Controls.Add(this.ingles);
            this.Controls.Add(this.informatica);
            this.Controls.Add(this.matematicas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Cailficacion);
            this.Controls.Add(this.tbInformatica);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMatematicas);
            this.Controls.Add(this.tbIngles);
            this.Controls.Add(this.tbPromedio);
            this.Name = "Califiaciones";
            this.Text = "Califiaciones";
            this.Load += new System.EventHandler(this.Califiaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPromedio;
        private System.Windows.Forms.TextBox tbIngles;
        private System.Windows.Forms.TextBox tbMatematicas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbInformatica;
        private System.Windows.Forms.TextBox Cailficacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox matematicas;
        private System.Windows.Forms.TextBox informatica;
        private System.Windows.Forms.TextBox ingles;
        private System.Windows.Forms.TextBox tbCedula;
        private System.Windows.Forms.Label label12;
    }
}