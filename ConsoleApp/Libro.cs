using System;
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
    }
}
