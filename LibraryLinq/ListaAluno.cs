using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLinq
{
    public class ListaAluno
    {
        public static List<Aluno> LoadAlunos()
        {
            List<Aluno> output = new List<Aluno>();
            output.Add(new Aluno { FirstName = "Torres", Lastname = "Carlos", BirthDate = Convert.ToDateTime("25/02/1970"), DisciplinesMade = 20 });
            output.Add(new Aluno { FirstName = "Jesuita", Lastname = "Susana", BirthDate = Convert.ToDateTime("31/03/1970"), DisciplinesMade = 12 });
            output.Add(new Aluno { FirstName = "Susana", Lastname = "Sousa", BirthDate = Convert.ToDateTime("03/01/1970"), DisciplinesMade = 1 });
            output.Add(new Aluno { FirstName = "Sara", Lastname = "Jesuita", BirthDate = Convert.ToDateTime("06/03/1970"), DisciplinesMade = 8 });
            output.Add(new Aluno { FirstName = "Janota", Lastname = "Duarte", BirthDate = Convert.ToDateTime("18/02/1970"), DisciplinesMade = 7 });
            output.Add(new Aluno { FirstName = "Maria", Lastname = "Susana", BirthDate = Convert.ToDateTime("23/01/1970"), DisciplinesMade = 16});

            return output;
        }
    }
}
