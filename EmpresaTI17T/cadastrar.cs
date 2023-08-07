using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using TelaDeLogin;

namespace EmpresaTI17T
{
    public partial class cadastrar : Form
    {
        DAO conectar;
        public cadastrar()
        {
            InitializeComponent();
            conectar = new DAO();  //ligando o formulario ao conectar do banco
        }//fim do construtor

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = conectar.inserir(Convert.ToUInt64( cpf.Text) , nome.Text, telefone.Text , cidade.Text, UF.Text
                 );
            MessageBox.Show(result);
        }//fim do botao inserir

        private void cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }// fim do cpf

        private void cadastrar_Load(object sender, EventArgs e)
        {

        }//fim do cadastrar

        private void telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do telefone

        private void cidade_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do cidade

        private void UF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do uf

        private void nome_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do nome
    }
}
