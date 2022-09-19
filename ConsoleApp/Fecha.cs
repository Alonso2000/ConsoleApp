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
                Console.WriteLine("4.Comparar fechas");
                Console.WriteLine("5.Mostrar fecha formato largo");
                Console.WriteLine("6.Volver al menu");
                Console.WriteLine("Elige una opcion: ");
                opcion = Console.ReadLine();
                resultado = Int32.Parse(opcion);
            } while (resultado < 1 || resultado > 6);
            string d1;
            string m1;
            string a1;
            string i;
            string d2;
            string m2;
            string a2;
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
                    }
                    catch (Exception e)
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
                    }
                    catch (Exception e)
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
                    menuFechas();
                    break;

                case 4:
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
                        int comparacion = date1.CompareTo(date2);

                        if (comparacion < 0)
                        {
                            Console.WriteLine(date1.ToString("dd/MM/yyyy") + " es menor que " + date2.ToString("dd/MM/yyyy"));
                        }
                        else if (comparacion == 0)
                        {
                            Console.WriteLine(date1.ToString("dd/MM/yyyy") + " son iguales " + date2.ToString("dd/MM/yyyy"));
                        }
                        else
                        {
                            Console.WriteLine(date1.ToString("dd/MM/yyyy") + " es mayor que " + date2.ToString("dd/MM/yyyy"));
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Ese mes no tiene ese dia");
                    }
                    break;

                case 5:
                    try
                    {
                        Console.WriteLine("Escribe el dia: ");
                        d1 = Console.ReadLine();
                        int dia = Int32.Parse(d1);
                        Console.WriteLine("Escribe el mes: ");
                        m1 = Console.ReadLine();
                        int mes = Int32.Parse(m1);
                        Console.WriteLine("Escribe el año: ");
                        a1 = Console.ReadLine();
                        int anio = Int32.Parse(a1);
                        DateTime date1 = new DateTime(anio, mes, dia);
                        Console.WriteLine(date1.ToString("dd/MM/yyyy"));
                        Console.WriteLine("La fecha en formato largo es "+date1.ToString("dddd dd MMMM yyyy"));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Introduce una fecha valida");
                    }
                    break ;

                    case 6:
                    break ;
            }
        }
    }
}
