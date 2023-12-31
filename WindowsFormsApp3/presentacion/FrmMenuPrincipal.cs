﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.presentacion.alumno;

namespace WindowsFormsApp3.presentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }
        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenuPrincipal_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al Sistema", "Acceso al Sistema",
            MessageBoxButtons.OK);
            //Ocultamos el formulario Login
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FrmIngresarAlumno frmIngresarAlumno = new FrmIngresarAlumno();
            frmIngresarAlumno.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmEditarAlumno frmEditarAlumno = new FrmEditarAlumno();
            frmEditarAlumno.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FrmEliminarAlumno frmEliminarAlumno = new FrmEliminarAlumno();
            frmEliminarAlumno.ShowDialog();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            FrmVerAlumno frmVerAlumno = new FrmVerAlumno();
            frmVerAlumno.ShowDialog();
        }
    }
}
