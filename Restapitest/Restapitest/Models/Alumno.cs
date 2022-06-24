using System;
using System.Collections.Generic;
using System.Text;

namespace Restapitest.Models
{
    public class Alumno
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public int edad { get; set; }
        public string genero { get; set; }
        public int idCarrera { get; set; }
    }
}
