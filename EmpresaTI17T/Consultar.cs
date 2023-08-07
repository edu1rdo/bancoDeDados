using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaTI17T
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            
            InitializeComponent();
            configurardatagrid();
            adicionardados(); //preenchimento o data
        }
        public void NomeColuna()
        {
            dataGridView1.Columns[0].Name = "CPF";
            dataGridView1.Columns[1].Name = "nomde";
            dataGridView1.Columns[2].Name = "telefone";
            dataGridView1.Columns[3].Name = "cidade";
            dataGridView1.Columns[4].Name = "UF";
        }//fim do projeto


        public void configurardatagrid()
        {
           dataGridView1.AllowUserToAddRows = false;//adicionar linhas
            dataGridView1.AllowUserToDeleteRows = false;//deletar linhas
            dataGridView1.AllowUserToResizeColumns = false;//rediencionar colunas
            dataGridView1.AllowUserToResizeRows = false;//redimencionar linhas, falso para nao poder fazer isso

            dataGridView1.ColumnCount = 5;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Consultar_Load(object sender, EventArgs e)
        {

        }
    }
}
