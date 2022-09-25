﻿using ConsoleApp;
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
            case 2: Libro b = new Libro();
                b.menuLibros();
                break;
            case 3:
                Puerto puerto = new Puerto();
                puerto.menuBarco();
                ;
                break;
            case 4:
                break;
        } 
    }
}