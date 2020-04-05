using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBD
{
    class ManipulaDados
    {
        static void Main(string[] args)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();

            //Inserir novo registo

            //Filme f = new Filme
            //{
            //    Id = dc.Filmes.Count() + 1,
            //    Titulo="O Exterminador III",
            //    Categoria="AC",
            //};

            //dc.Filmes.InsertOnSubmit(f);

            //try
            //{
            //    dc.SubmitChanges();
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(e.Message);
            //}

            var lista = from Filme in dc.Filmes  select Filme;
            foreach (Filme filme in lista)
            {
                Console.WriteLine("ID: " + filme.Id);
                Console.WriteLine("Titulo: " + filme.Titulo);
                Console.WriteLine("Categoria: " + filme.Categoria);
                Console.WriteLine();
            }

            Console.WriteLine("-------------------Alterar registo-------------------------------");

            //Alterar registo

            Filme f1 = new Filme();
            int idAlterar = 4;
            var pesquisa = from Filme in dc.Filmes where Filme.Id== idAlterar select Filme;
            //Single()-Retorna um elemento único e específico de uma sequência..
            f1 = pesquisa.Single();

            f1.Titulo = "Rambo";
            

            try
            {
                dc.SubmitChanges();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            var lista1 = from Filme in dc.Filmes select Filme;
            foreach (Filme filme in lista1)
            {
                Console.WriteLine("ID: " + filme.Id);
                Console.WriteLine("Titulo: " + filme.Titulo);
                Console.WriteLine("Categoria: " + filme.Categoria);
                Console.WriteLine();
            }
            Console.WriteLine("-------------------Apagar registo-------------------------------");

            //Apagar registo

           
            idAlterar = 10;
            pesquisa = from Filme in dc.Filmes where Filme.Id == idAlterar select Filme;

            if (pesquisa.Count()==0)
            {
                Console.WriteLine("O Filme já foi apagado");
                Console.ReadKey();
                return;
            }
            //Single()-Retorna um elemento único e específico de uma sequência..
            f1 = pesquisa.Single();

            dc.Filmes.DeleteOnSubmit(f1);

            try
            {
                dc.SubmitChanges();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            lista1 = from Filme in dc.Filmes select Filme;
            foreach (Filme filme in lista1)
            {
                Console.WriteLine("ID: " + filme.Id);
                Console.WriteLine("Titulo: " + filme.Titulo);
                Console.WriteLine("Categoria: " + filme.Categoria);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
