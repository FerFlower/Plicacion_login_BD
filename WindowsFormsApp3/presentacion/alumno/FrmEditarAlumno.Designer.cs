namespace WindowsFormsApp3.presentacion.alumno
{
    partial class FrmEditarAlumno
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
            this.Nombre_txt = new System.Windows.Forms.Label();
            this.Apellido_txt = new System.Windows.Forms.Label();
            this.Info_02 = new System.Windows.Forms.Label();
            this.Info_01 = new System.Windows.Forms.Label();
            this.Dni_Ed = new System.Windows.Forms.TextBox();
            this.Nombre_Ed = new System.Windows.Forms.TextBox();
            this.Apellido_Ed = new System.Windows.Forms.TextBox();
            this.Boton_ed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dni_txt
            // 
            this.Dni_txt.AutoSize = true;
            this.Dni_txt.Location = new System.Drawing.Point(42, 105);
            this.Dni_txt.Name = "Dni_txt";
            this.Dni_txt.Size = new System.Drawing.Size(114, 13);
            this.Dni_txt.TabIndex = 0;
            this.Dni_txt.Text = "Dni para la busqueda :";
            // 
            // Nombre_txt
            // 
            this.Nombre_txt.AutoSize = true;
            this.Nombre_txt.Location = new System.Drawing.Point(42, 215);
            this.Nombre_txt.Name = "Nombre_txt";
            this.Nombre_txt.Size = new System.Drawing.Size(85, 13);
            this.Nombre_txt.TabIndex = 1;
            this.Nombre_txt.Text = "Nombre Nuevo :";
            // 
            // Apellido_txt
            // 
            this.Apellido_txt.AutoSize = true;
            this.Apellido_txt.Location = new System.Drawing.Point(42, 258);
            this.Apellido_txt.Name = "Apellido_txt";
            this.Apellido_txt.Size = new System.Drawing.Size(85, 13);
            this.Apellido_txt.TabIndex = 2;
            this.Apellido_txt.Text = "Apellido Nuevo :";
            // 
            // Info_02
            // 
            this.Info_02.AutoSize = true;
            this.Info_02.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Info_02.Location = new System.Drawing.Point(126, 178);
            this.Info_02.Name = "Info_02";
            this.Info_02.Size = new System.Drawing.Size(124, 13);
            this.Info_02.TabIndex = 3;
            this.Info_02.Text = "Datos Nuevos a ingresar";
            // 
            // Info_01
            // 
            this.Info_01.AutoSize = true;
            this.Info_01.ForeColor = System.Drawing.Color.Red;
            this.Info_01.Location = new System.Drawing.Point(159, 59);
            this.Info_01.Name = "Info_01";
            this.Info_01.Size = new System.Drawing.Size(69, 13);
            this.Info_01.TabIndex = 4;
            this.Info_01.Text = "Buscar datos";
            // 
            // Dni_Ed
            // 
            this.Dni_Ed.Location = new System.Drawing.Point(162, 102);
            this.Dni_Ed.Name = "Dni_Ed";
            this.Dni_Ed.Size = new System.Drawing.Size(154, 20);
            this.Dni_Ed.TabIndex = 5;
            this.Dni_Ed.TextChanged += new System.EventHandler(this.Dni_Ed_TextChanged);
            // 
            // Nombre_Ed
            // 
            this.Nombre_Ed.Location = new System.Drawing.Point(133, 212);
            this.Nombre_Ed.Name = "Nombre_Ed";
            this.Nombre_Ed.Size = new System.Drawing.Size(183, 20);
            this.Nombre_Ed.TabIndex = 6;
            // 
            // Apellido_Ed
            // 
            this.Apellido_Ed.Location = new System.Drawing.Point(133, 255);
            this.Apellido_Ed.Name = "Apellido_Ed";
            this.Apellido_Ed.Size = new System.Drawing.Size(183, 20);
            this.Apellido_Ed.TabIndex = 7;
            // 
            // Boton_ed
            // 
            this.Boton_ed.Location = new System.Drawing.Point(280, 326);
            this.Boton_ed.Name = "Boton_ed";
            this.Boton_ed.Size = new System.Drawing.Size(75, 23);
            this.Boton_ed.TabIndex = 8;
            this.Boton_ed.Text = "Modificar";
            this.Boton_ed.UseVisualStyleBackColor = true;
            this.Boton_ed.Click += new System.EventHandler(this.Boton_ed_Click);
            // 
            // FrmEditarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.Boton_ed);
            this.Controls.Add(this.Apellido_Ed);
            this.Controls.Add(this.Nombre_Ed);
            this.Controls.Add(this.Dni_Ed);
            this.Controls.Add(this.Info_01);
            this.Controls.Add(this.Info_02);
            this.Controls.Add(this.Apellido_txt);
            this.Controls.Add(this.Nombre_txt);
            this.Controls.Add(this.Dni_txt);
            this.Name = "FrmEditarAlumno";
            this.Text = "FrmEditarAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dni_txt;
        private System.Windows.Forms.Label Nombre_txt;
        private System.Windows.Forms.Label Apellido_txt;
        private System.Windows.Forms.Label Info_02;
        private System.Windows.Forms.Label Info_01;
        private System.Windows.Forms.TextBox Dni_Ed;
        private System.Windows.Forms.TextBox Nombre_Ed;
        private System.Windows.Forms.TextBox Apellido_Ed;
        private System.Windows.Forms.Button Boton_ed;
    }
}