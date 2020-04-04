using System;

namespace LibraryLinq
{
    public class Aluno
    {
        public string FirstName { get; set; }

        public string Lastname { get; set; }
        
        public DateTime BirthDate { get; set; }

        public int DisciplinesMade { get; set; }

        public string Name => $"{FirstName} {Lastname}";




    }
}
