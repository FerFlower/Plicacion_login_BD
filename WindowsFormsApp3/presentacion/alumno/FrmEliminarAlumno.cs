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
    public partial class FrmEliminarAlumno : Form
    {
        public FrmEliminarAlumno()
        {
            InitializeComponent();
        }

        private void Boton_Eli_Click(object sender, EventArgs e)
        {
            NegocioAlumno negocioAlumno = new NegocioAlumno();
            EliminarAlumno Alumno_Eli = new EliminarAlumno();

            Alumno_Eli.Dni_Eli = Dni_Eli.Text;
          

            try
            {
                int num = negocioAlumno.EliminarAlumnoN(Alumno_Eli);
                //int num = Num.Codigo;
                //if (num != 0)
                //{
                    MessageBox.Show("Operacion Satisfactoria");
                    Dni_Eli.Text = "";
                   
               // }
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

        private void Dni_Eli_TextChanged(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
