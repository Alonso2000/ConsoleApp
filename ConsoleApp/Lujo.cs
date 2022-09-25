using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Lujo : Barco
    {
        public int CV;
        public int camarotes;
        public Lujo(string matricula, int eslora, int anio_fabricacion, int caballos, int cam) : base(matricula, eslora, anio_fabricacion)
        {
            this.matricula = matricula;
            this.eslora = eslora;
            this.anio_fabricacion = anio_fabricacion;
            this.CV = caballos;
            this.camarotes = cam;
        }

        public int Caballos
        {
            get { return CV; }
            set { CV = value; }
        }

        public int Camarotes
        {
            get { return camarotes; }
            set { camarotes = value; }
        }

    }
}
