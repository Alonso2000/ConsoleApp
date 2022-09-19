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
                Console.WriteLine("3.Diferencia fechas");
                Console.WriteLine("4.Salir");
                Console.WriteLine("Elige una opcion: ");
                opcion = Console.ReadLine();
                resultado = Int32.Parse(opcion);
            } while (resultado < 1 || resultado > 4);
            String d1;
            String m1;
            String a1;
            String i;
            String d2;
            String m2;
            String a2;
            switch (resultado)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Escribe el año: ");
                        a1 = Console.ReadLine();
                        int anio = Int32.Parse(a1);
                        Console.WriteLine("Escribe el mes: ");
                        m1 = Console.ReadLine();
                        int mes = Int32.Parse(m1);
                        Console.WriteLine("Escribe el dia: ");
                        d1 = Console.ReadLine();
                        int dia = Int32.Parse(d1);
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
                        a1 = Console.ReadLine();
                        int anio = Int32.Parse(a1);
                        Console.WriteLine("Escribe el mes: ");
                        m1 = Console.ReadLine();
                        int mes = Int32.Parse(m1);
                        Console.WriteLine("Escribe el dia: ");
                        d1 = Console.ReadLine();
                        int dia = Int32.Parse(d1);
                        DateTime date1 = new DateTime(anio, mes, dia);
                        Console.WriteLine(date1.ToString("dd/MM/yyyy"));
                        Console.WriteLine("Cuantos dias quieres incrementarle: ");
                        i = Console.ReadLine();
                        int inc = Int32.Parse(i);
                        Console.WriteLine(date1.AddDays(inc).ToString("dd/MM/yyyy"));
                    }catch(Exception e)
                    {
                        Console.WriteLine("Ese mes no tiene ese dia");
                    }
                    menuFechas();
                    break;
                case 3:
                    try
                    {
                        Console.WriteLine("PRIMERA FECHA");
                        Console.WriteLine("Escribe el año: ");
                        a1 = Console.ReadLine();
                        int anio = Int32.Parse(a1);
                        Console.WriteLine("Escribe el mes: ");
                        m1 = Console.ReadLine();
                        int mes = Int32.Parse(m1);
                        Console.WriteLine("Escribe el dia: ");
                        d1 = Console.ReadLine();
                        int dia = Int32.Parse(d1);

                        Console.WriteLine("SEGUNDA FECHA");
                        Console.WriteLine("Escribe el año: ");
                        a2 = Console.ReadLine();
                        int anioo = Int32.Parse(a2);
                        Console.WriteLine("Escribe el mes: ");
                        m2 = Console.ReadLine();
                        int mess = Int32.Parse(m2);
                        Console.WriteLine("Escribe el dia: ");
                        d2 = Console.ReadLine();
                        int diaa = Int32.Parse(d2);
                        DateTime date1 = new DateTime(anio, mes, dia);
                        Console.WriteLine(date1.ToString("dd/MM/yyyy"));
                        DateTime date2 = new DateTime(anioo, mess, diaa);
                        Console.WriteLine(date2.ToString("dd/MM/yyyy"));
                        Console.WriteLine("La diferencia en dias es de " + (date1 - date2).Days);

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Ese mes no tiene ese dia");
                    }
                    menuFechas(); ;
                    break;
                case 4: ;
                    break;
            }
        }
    }
}
