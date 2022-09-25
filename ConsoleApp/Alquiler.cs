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

        public Alquiler()
        {
            this.nombre = "";
            this.DNI = "";
            this.fecha_inicial = DateTime.Now;
            this.fecha_final = DateTime.Now;
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

        public String alquilerNormal(Barco a, DateTime fechF, DateTime fechI)
        {
            TimeSpan difFechas = fechF - fechI;
            int dias = difFechas.Days;
            int funcion = (a.eslora * 10) * 12;

            return funcion.ToString();
        }
        public String alquilerDeportivo(Deportivo a, DateTime fechI, DateTime fechF, int caballos)
        {
            TimeSpan difFechas = fechF - fechI;
            int dias = difFechas.Days;
            int funcion = (a.eslora * 10) * 12 + caballos;

            return funcion.ToString();
        }
        public String alquilerLujo(Lujo a, DateTime fechI, DateTime fechF, int caballos, int camarotes)
        {
            TimeSpan difFechas = fechF - fechI;
            int dias = difFechas.Days;
            int funcion = (a.eslora * 10) * 12 + caballos + camarotes;

            return funcion.ToString();
        }
        public String alquilerVelero(Velero a, DateTime fechI, DateTime fechF)
        {
            TimeSpan difFechas = fechF - fechI;
            int dias = difFechas.Days;
            int funcion = (a.eslora * 10) * 12 + a.num_mastiles;

            return funcion.ToString();
        }

        public override string ToString()
        {
            return $"{{{nameof(Nombre)}={Nombre}, {nameof(Dni)}={Dni}, {nameof(Fecha_inicial)}={Fecha_inicial.ToString()}, {nameof(Fecha_final)}={Fecha_final.ToString()}}}";
        }
    }
}
