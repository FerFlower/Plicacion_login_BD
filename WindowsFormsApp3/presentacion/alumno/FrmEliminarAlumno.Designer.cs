namespace WindowsFormsApp3.presentacion.alumno
{
    partial class FrmEliminarAlumno
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
            this.Dni_txt = new System.Windows.Forms.Label();
            this.Dni_Eli = new System.Windows.Forms.TextBox();
            this.Boton_Eli = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Dni_txt
            // 
            this.Dni_txt.AutoSize = true;
            this.Dni_txt.Location = new System.Drawing.Point(55, 79);
            this.Dni_txt.Name = "Dni_txt";
            this.Dni_txt.Size = new System.Drawing.Size(29, 13);
            this.Dni_txt.TabIndex = 0;
            this.Dni_txt.Text = "Dni :";
            // 
            // Dni_Eli
            // 
            this.Dni_Eli.Location = new System.Drawing.Point(81, 76);
            this.Dni_Eli.Name = "Dni_Eli";
            this.Dni_Eli.Size = new System.Drawing.Size(200, 20);
            this.Dni_Eli.TabIndex = 1;
            this.Dni_Eli.TextChanged += new System.EventHandler(this.Dni_Eli_TextChanged);
            // 
            // Boton_Eli
            // 
            this.Boton_Eli.Location = new System.Drawing.Point(130, 169);
            this.Boton_Eli.Name = "Boton_Eli";
            this.Boton_Eli.Size = new System.Drawing.Size(75, 23);
            this.Boton_Eli.TabIndex = 2;
            this.Boton_Eli.Text = "Eliminar";
            this.Boton_Eli.UseVisualStyleBackColor = true;
            this.Boton_Eli.Click += new System.EventHandler(this.Boton_Eli_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.ForeColor = System.Drawing.Color.Red;
            this.Titulo.Location = new System.Drawing.Point(127, 27);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(97, 13);
            this.Titulo.TabIndex = 3;
            this.Titulo.Text = "Datos para eliminar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(22, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "El Dni es una referencia para eliminar toda sus datos del alumno";
            // 
            // FrmEliminarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Boton_Eli);
            this.Controls.Add(this.Dni_Eli);
            this.Controls.Add(this.Dni_txt);
            this.Name = "FrmEliminarAlumno";
            this.Text = "FrmEliminarAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dni_txt;
        private System.Windows.Forms.TextBox Dni_Eli;
        private System.Windows.Forms.Button Boton_Eli;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label label1;
    }
}