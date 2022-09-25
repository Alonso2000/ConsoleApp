using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Velero : Barco
    {
        public int num_mastiles = 0;


        public Velero(string matricula, int eslora, int anio_fabricacion, int mastiles) : base(matricula, eslora, anio_fabricacion)
        {
            this.matricula = matricula;
            this.eslora = eslora;
            this.anio_fabricacion = anio_fabricacion; 
            this.num_mastiles = mastiles;
        }

        public int Mastiles
        {
            get { return num_mastiles; }
            set { num_mastiles = value; }
        }

        public override string ToString()
        {
            return $"{{{nameof(Mastiles)}={Mastiles.ToString()}}}";
        }
    }
}
