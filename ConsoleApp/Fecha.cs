using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
                Console.WriteLine("2.Incrementar fecha");
                Console.WriteLine("3.Puerto");
                Console.WriteLine("4.Salir");
                Console.WriteLine("Elige una opcion: ");
                opcion = Console.ReadLine();
                resultado = Int32.Parse(opcion);
            } while (resultado < 1 || resultado > 4);
            String d;
            String m;
            String a;
            String i;
            switch (resultado)
            {
                case 1:
                    try
                    {
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
                    }catch(Exception e)
                    {
                        Console.WriteLine("Ese mes no tiene ese dia");
                    }
                    menuFechas();
                    break;
                case 2:
                    try
                    {
                        Console.WriteLine("Escribe el año: ");
                        a = Console.ReadLine();
                        int anioo = Int32.Parse(a);
                        Console.WriteLine("Escribe el mes: ");
                        m = Console.ReadLine();
                        int mess = Int32.Parse(m);
                        Console.WriteLine("Escribe el dia: ");
                        d = Console.ReadLine();
                        int diaa = Int32.Parse(d);
                        DateTime date2 = new DateTime(anioo, mess, diaa);
                        Console.WriteLine(date2.ToString("dd/MM/yyyy"));
                        Console.WriteLine("Cuantos dias quieres incrementarle: ");
                        i = Console.ReadLine();
                        int inc = Int32.Parse(i);
                        Console.WriteLine(date2.AddDays(inc).ToString("dd/MM/yyyy"));
                    }catch(Exception e)
                    {
                        Console.WriteLine("Ese mes no tiene ese dia");
                    }
                    menuFechas();
                    break;
                /*case 3:Puerto;
                    break;*/
                //case 4: Program.Main(args);
                    break;
            }
        }
    }
}
