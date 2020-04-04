using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBD
{
    class Program
    {
        static void Main2(string[] args)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            //Obter a listagem completa dos filmes 
            //var lista = from Filme in dc.Filmes orderby Filme.Titulo select Filme;

            //Obter a listagem completa dos filmes ordenados descendentimente 
            var lista = from Filme in dc.Filmes orderby Filme.Titulo descending,Filme.Id select Filme;
            foreach (Filme filme in lista)
            {
                Console.WriteLine("ID: " + filme.Id);
                Console.WriteLine("Titulo: " + filme.Titulo);
                Console.WriteLine("Categoria: " + filme.Categoria);
                Console.WriteLine();
            }

            Console.WriteLine("Existem {0} Filmes ", lista.Count());
            Console.ReadKey();
        }
    }
}
