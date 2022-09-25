using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Barco
    {
        public string matricula;
        public int eslora;
        public int anio_fabricacion;

        public Barco(string matricula, int eslora, int anio_fabricacion)
        {
            this.matricula = matricula;
            this.eslora = eslora;
            this.anio_fabricacion = anio_fabricacion;
        }

        public override string ToString()
        {
            return $"{{}}";
        }
    }
}
