using LibraryLinq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqUI
{   
    public partial class Form1 : Form
    {
        List<Aluno> Alunos = ListaAluno.LoadAlunos();
        public Form1()
        {
            InitializeComponent();
            InitCombo();

        }

        private void InitCombo()
        {
            ComboBoxTodosAlunos.DataSource = Alunos.ToList();
            ComboBoxTodosAlunos.DisplayMember = "Name";
            UpDateData();

            ListBoxAlunosFiltrados.DisplayMember = "Name";
        }

        private void ButtonUpDate_Click(object sender, EventArgs e)
        {
            Aluno alunoSelecionado = (Aluno)ComboBoxTodosAlunos.SelectedItem;
            alunoSelecionado.DisciplinesMade = Convert.ToInt32(NumericUpDownDisciplinasFeitas.Value);
            UpDateData();
        }

        private void UpDateData()
        {
            ListBoxAlunosFiltrados.DataSource = Alunos.Where(x => x.DisciplinesMade > 10).OrderBy(x => x.FirstName).ThenBy(x => x.Lastname).ToList();

        }

        private void ComboBoxTodosAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aluno alunoSelecionado = (Aluno)ComboBoxTodosAlunos.SelectedItem;

            NumericUpDownDisciplinasFeitas.Value = alunoSelecionado.DisciplinesMade;
        }
    }
}
