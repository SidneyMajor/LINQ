using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqBD;

namespace LinqUI2
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ListView
            listView1.Columns.Add("ID");
            listView1.Columns.Add("Titulo");
            listView1.Columns.Add("Categoria");
            //Carregar os filmes
            var lista = from Filme in dc.Filmes select Filme;

            foreach (Filme filme in lista)
            {
                ListViewItem item;
                item = listView1.Items.Add(filme.Id.ToString());
                item.SubItems.Add(filme.Titulo);
                item.SubItems.Add(filme.Categoria);
            }
            //AutoResize os Headers da colunas
            for (int i = 0; i <= 2; i++)
            {
                listView1.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            //TreeView

            var outralista = from Categoria in dc.Categorias select Categoria;

            foreach (Categoria categoria in outralista)
            {
                //Add nós principais da treeView
                treeView1.Nodes.Add(categoria.Sigla);
            }
            //Segundo nivel da treeView(filmes)

            var listaFilmes = from Filme in dc.Filmes orderby Filme.Titulo select Filme;

            string catFilme;
            foreach (Filme filme1 in listaFilmes)
            {
                catFilme = filme1.Categoria;

                foreach (TreeNode node in treeView1.Nodes)
                {
                    if (node.Text == catFilme)
                    {
                        node.Nodes.Add(filme1.Titulo);
                    }
                }
               
            }

            //GridView
            dataGridView1.Columns.Add("colId", "ID");
            dataGridView1.Columns.Add("colTitulo", "Titulo");
            dataGridView1.Columns.Add("colCategoria", "Categoria");

            var outralistaFilmes = from Filme in dc.Filmes select Filme;

            int linha = 0;

            DataGridViewCellStyle estilo = new DataGridViewCellStyle();
            estilo.ForeColor = Color.White;
            estilo.BackColor = Color.Red;
            estilo.Font = new Font(Font,FontStyle.Bold);
            foreach (Filme filme2 in outralistaFilmes)
            {
                DataGridViewRow row = new DataGridViewRow();
                dataGridView1.Rows.Add(row);
                dataGridView1.Rows[linha].Cells[0].Value = filme2.Id;
                dataGridView1.Rows[linha].Cells[1].Value = filme2.Titulo;
                dataGridView1.Rows[linha].Cells[2].Value = filme2.Categoria;

                if ((string)dataGridView1.Rows[linha].Cells[2].Value=="AC")
                {
                    dataGridView1.Rows[linha].DefaultCellStyle = estilo;
                }
                linha++;
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
    }
}
