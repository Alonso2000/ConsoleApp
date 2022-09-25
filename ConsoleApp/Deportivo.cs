using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Deportivo : Barco
    {
        private int CV = 0;
        public Deportivo(string matricula, int eslora, int anio_fabricacion, int caballos) : base(matricula, eslora, anio_fabricacion)
        {
            this.matricula = matricula;
            this.eslora = eslora;
            this.anio_fabricacion = anio_fabricacion;
            this.CV = caballos;
        }
        public int Caballos
        {
            get { return CV; }
            set { CV = value; }
        }

        public override string ToString()
        {
            return $"{{{nameof(Caballos)}={Caballos.ToString()}}}";
        }
    }
}
