using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Libro
    {
        private string titulo;
        private string autor;
        private string estilo;
        private string editorial;

        public Libro(string titulo, string autor, string estilo, string editorial)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.estilo = estilo;
            this.editorial = editorial;
        }

        public Libro()
        {
            this.titulo = "";
            this.autor = "";
            this.estilo = "";
            this.editorial = "";
        }

        public string Titulo
        {
            get { return titulo; }
            set { this.titulo = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { this.autor = value; }
        }

        public string Estilo
        {
            get { return estilo; }
            set { this.estilo = value; }
        }

        public string Editorial
        {
            get { return editorial; }
            set { this.editorial = value; }
        }

        public override string ToString()
        {
            return $"{{{nameof(Titulo)}={Titulo}, {nameof(Autor)}={Autor}, {nameof(Estilo)}={Estilo}, {nameof(Editorial)}={Editorial}}}";
        }

        public void menuLibros()
        {
            string n = "";
            int nu = 0;
            string titulo = "";
            string autor = "";
            string estilo = "";
            string editorial = "";
            ArrayList libros = new ArrayList();
            bool acabado = false;
            do
            {
                Console.WriteLine("1.Insertar libro");
                Console.WriteLine("2.Ver listado de libros");
                Console.WriteLine("3.Modificar algun libro de los ya añadidos");
                Console.WriteLine("4.Eliminar algun libro de los ya añadidos");
                Console.WriteLine("5.Salir");
                n = Console.ReadLine();
                nu = Int32.Parse(n);

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
                        Libro lib = new Libro(titulo, autor, estilo, editorial);
                        libros.Add(lib);
                        break;

                    case 2:
                        for (int i = 0; i < libros.Count; i++)
                        {
                            Console.WriteLine(libros[i]);
                        }
                        break;
                    case 3:
                        Console.WriteLine("¿Que libro quieres modificar?");
                        titulo = Console.ReadLine();
                            foreach (Libro l in libros)
                            {
                                if (l.titulo == titulo)
                                {
                                    Console.WriteLine("Escribe el nuevo titulo");
                                    titulo = Console.ReadLine();
                                    l.titulo = titulo;
                                }
                            }
                        break;
                    case 4:
                        Console.WriteLine("¿Que libro quieres eliminar?");
                        titulo = Console.ReadLine();
                        foreach (Libro l in libros)
                        {
                            if (l.titulo == titulo)
                            {
                                libros.Remove(l);
                            }
                        }
                        break;
                    case 5:
                        break;
                }
            } while (nu < 1 || nu > 6 || acabado == false);
        }
    }
}
