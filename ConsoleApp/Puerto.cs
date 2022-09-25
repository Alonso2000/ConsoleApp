using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Puerto
    {
        public void crearNormal()
        {
            string alquilerNormal;
            Barco n = new Barco("111213",30,2006);
            DateTime fecha1 = Convert.ToDateTime("2021-09-24");
            DateTime fecha2 = Convert.ToDateTime("2021-10-30");
            Alquiler a = new Alquiler();
            alquilerNormal = a.alquilerNormal(n, fecha1, fecha2);
            Console.WriteLine("El alquiler del barco normal con matricula " + n.matricula + " es " + alquilerNormal + " de euros");
            Console.ReadKey();
        }

        public void crearDeportivo()
        {
            int caballos = 400;
            string alquilerDeportivo;
            Deportivo d = new Deportivo("8910",50,2015,caballos);
            DateTime fecha1 = Convert.ToDateTime("2021-09-24");
            DateTime fecha2 = Convert.ToDateTime("2021-10-20");
            Alquiler a = new Alquiler();
            alquilerDeportivo = a.alquilerDeportivo(d, fecha1, fecha2, caballos);
            Console.WriteLine("El alquiler del deportivo con matricula " + d.matricula + " es " + alquilerDeportivo + " de euros");
            Console.ReadKey();
        }
        public void crearLujo()
        {
            int camarotes = 50;
            int caballos = 200;
            string alquilerLujo;
            Lujo l = new Lujo("567",90,1990,caballos, camarotes);
            DateTime fecha1 = Convert.ToDateTime("2021-09-24");
            DateTime fecha2 = Convert.ToDateTime("2021-10-4");
            Alquiler a = new Alquiler();
            alquilerLujo = a.alquilerLujo(l, fecha1, fecha2, caballos, camarotes);
            Console.WriteLine("El alquiler del lujo con matricula " + l.matricula + " es " + alquilerLujo + " de euros");
            Console.ReadKey();
        }
        public void crearVelero()
        {
            int mastiles = 3;
            string alquilerVelero;
            Velero v = new Velero("123",10,2000,mastiles);
            DateTime fecha1 = Convert.ToDateTime("2021-09-24");
            DateTime fecha2 = Convert.ToDateTime("2021-09-29");
            Alquiler a = new Alquiler();
            alquilerVelero = a.alquilerVelero(v, fecha1, fecha2);
            Console.WriteLine("El alquiler del velero con matricula " + v.matricula + " es " + alquilerVelero + " de euros");
            Console.ReadKey();
        }
        public void menuBarco()
        {
            String tipo;
            do
            {
                Console.WriteLine("¿De que tipo quieres crear el barco?(velero, lujo, deportivo, normal)");
                tipo = Console.ReadLine().ToLower();
            } while (tipo != "velero" && tipo != "lujo" && tipo != "deportivo" && tipo != "normal");

            if (tipo == "velero")
            {
                crearVelero();
            }
            else if (tipo == "lujo")
            {
                crearLujo();
            }
            else if (tipo == "deportivo")
            {
                crearDeportivo();
            }
            else if (tipo == "normal") ;
            {
                crearNormal();
            }

        }
    }
}
