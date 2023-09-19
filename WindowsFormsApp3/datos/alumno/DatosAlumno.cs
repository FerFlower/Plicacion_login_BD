using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace WindowsFormsApp3.datos
{
    internal class DatosAlumno
    {
        public EntidadAlumno ObtenerAlumno(int idAlumno)
        {
            return null;
        }
        public int InsertarAlumno(EntidadAlumno alumno) {

            try
            {

                using (SqlCommand cmd = new SqlCommand("insertarAlumno", Connection.Singleton.SqlConnetionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Dni", alumno.Dni);
                    cmd.Parameters.AddWithValue("@Nombre", alumno.Nombres);
                    cmd.Parameters.AddWithValue("@Apellido", alumno.Apellidos);
                    int numRes = cmd.ExecuteNonQuery();
                    return numRes;
                    
                }   
            }
            catch (Exception ex)
            {
                throw new ExceptionDatosAlumno(ex.Message);
            }
        }
        public void EditarAlumno(EditarAlumno alumno_Edit)
        {
            try
            {

                using (SqlCommand Editar = new SqlCommand("editar_alumno", Connection.Singleton.SqlConnetionFactory))
                {
                    Editar.CommandType = CommandType.StoredProcedure;
                    Editar.Parameters.AddWithValue("@Dni", alumno_Edit.Dni_Ed);
                    Editar.Parameters.AddWithValue("@Nombre", alumno_Edit.Nombres_Ed);
                    Editar.Parameters.AddWithValue("@Apellido", alumno_Edit.Apellidos_Ed);
                    int numRes = Editar.ExecuteNonQuery();
                    return numRes;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public void EliminarAlumno(int idAlumno)
        {

        }
    }
}
