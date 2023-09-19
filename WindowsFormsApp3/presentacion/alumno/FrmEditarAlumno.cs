using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.datos.alumno;
using WindowsFormsApp3.datos;
using WindowsFormsApp3.negocio.alumno;
using WindowsFormsApp3.negocio;

namespace WindowsFormsApp3.presentacion.alumno
{
    public partial class FrmEditarAlumno : Form
    {
        public FrmEditarAlumno()
        {
            InitializeComponent();
        }

        private void Boton_ed_Click(object sender, EventArgs e)
        {
            NegocioAlumno negocioAlumno = new NegocioAlumno();
            EditarAlumno alumno_Ed = new EditarAlumno();

            alumno_Ed.Dni_Ed = Dni_Ed.Text;
            alumno_Ed.Nombres_Ed = Nombre_Ed.Text;
            alumno_Ed.Apellidos_Ed = Apellido_Ed.Text;

            try
            {
                int num = negocioAlumno.EditarAlumnoN(alumno_Ed);
                //int num = Num.Codigo;
                if (num != 0)
                {
                    MessageBox.Show("Operacion Satisfactoria");
                    Dni_Ed.Text = "";
                    Nombre_Ed.Text = "";
                    Apellido_Ed.Text = "";
                }
            }
            catch (ExceptionDatosAlumno ex)
            {

                MessageBox.Show(ex.Message, "Error Capa de Datos");
            }
            catch (ExceptionNegocioAlumno ex)
            {

                MessageBox.Show(ex.Message, "Error Capa de Negocio");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Dni_Ed_TextChanged(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
