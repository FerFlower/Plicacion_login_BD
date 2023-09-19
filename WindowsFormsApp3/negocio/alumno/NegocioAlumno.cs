using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.datos;

namespace WindowsFormsApp3.negocio
{
    internal class NegocioAlumno
    {
        DatosAlumno datosAlumno = new DatosAlumno();

        public int InsertarAlumnoN(EntidadAlumno alumno)
        {
            //validaciones
            if (alumno.Dni.Length != 8)
            {
                MessageBox.Show("Longitud de dni incorrecta");
                return 0;
            }
            if (alumno.Nombres.Length == 0) {
                MessageBox.Show("Nombres esta vacio");
                return 0;
            }
            if (alumno.Apellidos.Length == 0)
            {
                MessageBox.Show("Apellidos esta vacio");
                return 0;
            }

            int numRes = datosAlumno.InsertarAlumno(alumno);
            return numRes;
        }
        public int EditarAlumnoN(EditarAlumno alumno_Ed)
        {
            //validaciones
            if (alumno_Ed.Dni_Ed.Length != 8)
            {
                throw new ExceptionNegocioAlumno("Longitud de dni incorrecta");
            }
            if (alumno_Ed.Nombres_Ed.Length == 0)
            {
                throw new ExceptionNegocioAlumno("Nombres esta vacio");
            }
            if (alumno_Ed.Apellidos_Ed.Length == 0)
            {
                throw new ExceptionNegocioAlumno("Apellidos esta vacio");
            }

            //Num.Codigo = 1;
         int numRes_Edi = datosAlumno.EditarAlumno(alumno_Ed);
         return numRes_Edi;

        }
        public int EliminarAlumnoN(EliminarAlumno Alumno_Eli)
        {
            //validaciones
            if (Alumno_Eli.Dni_Eli.Length != 8)
            {
                throw new ExceptionNegocioAlumno("Longitud de dni incorrecta");
            }
           
            //Num.Codigo = 1;
            int numRes_Eli = datosAlumno.EliminarAlumno(Alumno_Eli);
            return numRes_Eli;

        }
    }
}
