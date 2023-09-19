using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.presentacion.alumno
{
    public partial class FrmVerAlumno : Form
    {
        public FrmVerAlumno()
        {
            InitializeComponent();
        }

        private void FrmVerAlumno_Load(object sender, EventArgs e)
        {
        
            
           
                using (SqlCommand Ver = new SqlCommand("ver_alumno", Connection.Singleton.SqlConnetionFactory))
          
                {
                    Ver.CommandType = CommandType.StoredProcedure; // Si "ver_alumno" es un procedimiento almacenado
                    DataTable dt = new DataTable();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(Ver))
                    {
                        adapter.Fill(dt);
                    }

                    // Asigna el DataTable al DataGridView
                    dataGridView1.DataSource = dt;
                }
            
        }
    }
}
