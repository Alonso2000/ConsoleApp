using ConsoleApp;

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
                Libro lib = new Libro("a","b","c","d");
                Console.WriteLine(lib);
                Console.ReadKey();
                break;
            /*case 3:Puerto;
                break;
            case 4: "";
                break;*/
        } 
    }
}