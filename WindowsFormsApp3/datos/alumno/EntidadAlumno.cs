using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.datos
{
    internal class EntidadAlumno
    {
        public String Dni { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }

    }
    internal class EditarAlumno
    {
        public String Dni_Ed { get; set; }
        public String Nombres_Ed { get; set; }
        public String Apellidos_Ed { get; set; }

    }
    internal class EliminarAlumno
    {
        public String Dni_Eli { get; set; }
     

    }
    public class Num
    {
        static public int Codigo;
    }
}
