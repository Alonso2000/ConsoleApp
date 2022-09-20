using ConsoleApp;
using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        string opcion = "";
        int resultado = 0;
        do
        {
            Console.WriteLine("1.Fechas");
            Console.WriteLine("2.Libros");
            Console.WriteLine("3.Puerto");
            Console.WriteLine("4.Salir");
            Console.WriteLine("Elige una opcion: ");
            opcion = Console.ReadLine();
            resultado = Int32.Parse(opcion);
        } while (resultado < 1 || resultado > 4);
        switch (resultado)
        {
            case 1: Fecha a = new Fecha();
                a.menuFechas();
                break;
            case 2:
                string n = "";
                int nu = 0;
                string titulo = "";
                string autor = "";
                string estilo = "";
                string editorial = "";
                ArrayList libros = new ArrayList();
                do
                {
                    Console.WriteLine("1.Insertar libro");
                    Console.WriteLine("2.Ver listado de libros");
                    Console.WriteLine("3.Modificar algun libro de los ya añadidos");
                    Console.WriteLine("4.Eliminar algun libro de los ya añadidos");
                    Console.WriteLine("5.Eliminar algun libro de los ya añadidos");
                    Console.WriteLine("6.Salir");
                    n = Console.ReadLine();
                    nu = Int32.Parse(n);
                } while (nu < 1 || nu > 6);
                switch (nu)
                {
                    case 1:
                        Console.WriteLine("Escribe el titulo:");
                        titulo = Console.ReadLine();
                        Console.WriteLine("Escribe el autor:");
                        autor = Console.ReadLine();
                        Console.WriteLine("Escribe el estilo");
                        estilo = Console.ReadLine();
                        Console.WriteLine("Escribe la editorial");
                        editorial = Console.ReadLine();
                        break;
                }
                break;
            /*case 3:Puerto;
                break;
            case 4: "";
                break;*/
        } 
    }
}