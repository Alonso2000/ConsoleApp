using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Alquiler
    {
        private string nombre;
        private string DNI;
        private DateTime fecha_inicial;
        private DateTime fecha_final;

        public Alquiler(string nombre, string DNI, DateTime fecha_inicial, DateTime fecha_final)
        {
            this.nombre = nombre;
            this.DNI = DNI;
            this.fecha_inicial = fecha_inicial;
            this.fecha_final = fecha_final;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Dni
        {
            get { return DNI; }
            set { DNI = value; }
        }

        public DateTime Fecha_inicial
        {
            get { return fecha_inicial; }
            set { fecha_inicial = value; }
        }

        public DateTime Fecha_final
        {
            get { return fecha_final; }
            set { fecha_final = value; }
        }


    }
}
