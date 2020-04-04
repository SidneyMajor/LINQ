using LibraryLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> Alunos = ListaAluno.LoadAlunos();

            //Ordenar por apelidos
            Alunos = Alunos.OrderBy(x => x.Lastname).ToList();
            Console.WriteLine("**Ordenado por Aplidos**\n");
            foreach (var aluno in Alunos)
            {
                Console.WriteLine($"{aluno.Name} {aluno.BirthDate.ToShortDateString()} Disciplinas Feitas: {aluno.DisciplinesMade}");
            }

            //Ordenar por order descendente por apelidos e disciplinas feitas
            Alunos = Alunos.OrderByDescending(x => x.Lastname).ThenByDescending(x => x.DisciplinesMade).ToList();
            Console.WriteLine("\n**Ordenado descendentimente por Aplidos e Disciplinas feitas**\n");
            foreach (var aluno in Alunos)
            {
                Console.WriteLine($"{aluno.Name} {aluno.BirthDate.ToShortDateString()} Disciplinas Feitas: {aluno.DisciplinesMade}");
            }

            //Todos os alunos que têm mais de 10 disciplina e que nasceram no mês de março
            Alunos = Alunos.Where(x => x.DisciplinesMade > 10 && x.BirthDate.Month == 3).ToList();
            Console.WriteLine("\n**Todos os alunos que têm mais de 10 disciplina feitas e que nasceram no mês de março**\n");
            foreach (var aluno in Alunos)
            {
                Console.WriteLine($"{aluno.Name} {aluno.BirthDate.ToShortDateString()} Disciplinas Feitas: {aluno.DisciplinesMade}");
            }
           
            Alunos = ListaAluno.LoadAlunos().ToList();
            int totalDisciplinasFeitas = Alunos.Sum(x => x.DisciplinesMade);
            double mediaDisciplinasFeitas = Alunos.Average(x => x.DisciplinesMade);
            Console.WriteLine($"\nTotal de disciplinas feitas: {totalDisciplinasFeitas}");
            Console.WriteLine($"Média de disciplinas feitas: {mediaDisciplinasFeitas:N2}");

            totalDisciplinasFeitas = Alunos.Where(x => x.BirthDate.Month == 2).Sum(x => x.DisciplinesMade);
            mediaDisciplinasFeitas = Alunos.Where(x => x.BirthDate.Month == 2).Average(x => x.DisciplinesMade);
            Console.WriteLine($"\nTotal de disciplinas feitas em fevereiro: {totalDisciplinasFeitas}");
            Console.WriteLine($"Média de disciplinas feitas em fevereiro: {mediaDisciplinasFeitas:N2}");
            
            Console.ReadKey();
        }
    }
}
