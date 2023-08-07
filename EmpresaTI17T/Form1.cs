using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaDeLogin;

namespace EmpresaTI17T
{
    public partial class empresa : Form
    {
       
        
        public partial class Empresa : Form {
            cadastrar cad;
            Consultar con;
            atualizar atu;
            Excluir exc;
            
            
        
       }
        public empresa()
        {
            InitializeComponent();
            cad = new cadastrar();
            con = new Consultar();
            atu = new atualizar();
            Exc = new Excluir();
            Consu = new Consultar();
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }//botao cadastrar

        private void button2_Click(object sender, EventArgs e)
        {
            con.showDialog();
        }//botao consultar

        private void button3_Click(object sender, EventArgs e)
        {

        }//botao atualizar

        private void button4_Click(object sender, EventArgs e)
        {

        }//botao excluir

        public void adicionardados()
        {
            Consul.prencherVetor();//prencher vetor
            dataGridwil.rows.add(Consul.nome[i], Consul.telefone[i], Consul.cidade[i], Consul.uf[i]);
        }//fim do metodo




    }//fim  da classe
}//fim do projeto
