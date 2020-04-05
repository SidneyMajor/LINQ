using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBD
{
    class Program2
    {
        static void Main3(string[] args)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();

            //Lista de filmes só dramáticos
            //var lista = from Filme in dc.Filmes where Filme.Categoria == "DR" select Filme;

            //Fimes começados "A"
            //var lista = from Filme in dc.Filmes where Filme.Titulo.StartsWith("A") select Filme;

            //Filmes com determinado conjunto de caracteres no titulo
            var lista = from Filme in dc.Filmes where Filme.Titulo.Contains("a r") select Filme;
            foreach (Filme filme in lista)
            {
                Console.WriteLine("ID: " + filme.Id);
                Console.WriteLine("Titulo: " + filme.Titulo);
                Console.WriteLine("Categoria: " + filme.Categoria);
                Console.WriteLine();
            }

            Console.WriteLine("Existem {0} Filmes ", lista.Count());

            Console.WriteLine("-------------------------------------------------");

            //Agrupar informação contar filmes por categoria 

            var novaLista = from Filme in dc.Filmes
                            group Filme by Filme.Categoria
                           into c
                            select new
                            {
                                Categoria = c.Key,
                                Contagem = c.Count(),
                            };

            foreach (var c in novaLista)
            {
                Console.WriteLine(c.Categoria + " (" + c.Contagem+")");               
            }

            //junção entre tabelas            
            Console.WriteLine("-------------------Junção entre tabelas------------------------------");

            var outraLista = from Filme in dc.Filmes join Categoria in dc.Categorias
                             on Filme.Categoria equals Categoria.Sigla 
                            select new
                            {
                                Filme.Id,Filme.Titulo,Categoria.Categoria1
                            };

            foreach (var c in outraLista)
            {
                Console.WriteLine("ID: " + c.Id);
                Console.WriteLine("Titulo: " + c.Titulo);
                Console.WriteLine("Categoria: " + c.Categoria1);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
