using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Fecha
    {
        public void menuFechas()
        {
            string opcion = "";
            int resultado = 0;
            do
            {
                Console.WriteLine("1.Dia Semana");
                Console.WriteLine("2.Libros");
                Console.WriteLine("3.Puerto");
                Console.WriteLine("Elige una opcion: ");
                opcion = Console.ReadLine();
                resultado = Int32.Parse(opcion);
            } while (resultado < 1 || resultado > 3);
            switch (resultado)
            {
                case 1:
                    String d;
                    String m;
                    String a;
                    Console.WriteLine("Escribe el año: ");
                    a = Console.ReadLine();
                    int anio = Int32.Parse(a);
                    Console.WriteLine("Escribe el mes: ");
                    m = Console.ReadLine();
                    int mes = Int32.Parse(m);
                    Console.WriteLine("Escribe el dia: ");
                    d = Console.ReadLine();
                    int dia = Int32.Parse(d);
                    DateTime date1 = new DateTime(anio, mes, dia);
                    Console.WriteLine(date1.ToString("dddd").ToUpper());
                    Console.ReadKey();
                    break;
                /*case 2: Libro;
                    break;
                case 3:Puerto;
                    break;*/
            }
        }
    }
}
