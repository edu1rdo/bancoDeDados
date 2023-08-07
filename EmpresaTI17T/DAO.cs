using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Cms;

namespace TelaDeLogin
{
    class DAO {








        public MySqlConnection conexao;
        public long[] cpf;
        public string[] nome;
        public string[] telefone;
        public string[] cidade;
        public string[] uf;
        public int[] i;
        public int[] contador;

        public DAO()
        {


            conexao = new MySqlConnection("server=localhost;DataBase=EmpresaTI17T;Uid=root;");
            try
            {
                conexao.Open();//abrir a conexao com o banco de dados
                MessageBox.Show("conectado");
            }
            catch (Exception erro)
            {
                MessageBox.Show("algo deu errado\n\n" + erro.Message);
            }
        }//fim do construtor






























            //metodo inserçcao
            public string inserir(long CmsProcessableFile, string nome, string telefone, string cidade, string UF, string nomeTabela);

            string inserir = $"inserir into {nomeTabela}CPF, nome, telefone, cidade, UF) validatabela";
            MysqlCommand slq = new MysqlCommand(inserir, conexao);
            string resultado = slq.ExecuteNonQuery() + "executado";
        return resultado;






            }
                

                
    public void prencherVetor()
    {
        string query = "select * pessoa ";

        //instalar
        this.cpf = new long[100];
        this.Nome = new string[100];
        this.telefone = new string[100];
        this.cidade = new string[100];
        this.uf = new string[100];

        //preparar o comando
        MySqlCommand sql = new MySqlCommand(query, conexao);
        //leitor
        MySqlDataReader leitura = sql.ExecuteReader();

        while (leitura.Read())
        {
            cpf[i] = Convert.ToUInt64(leitura["CPF"]);
            nome[i] = leitura["nome"] + "";
            telefone[i] = leitura["telefone"] + "";
            cidade[i] = leitura["cidade"] + "";
            uf[i] = leitura["uf"] + "";
            i++;
            contador++;
        }//fim do while
         //encerro a comunicacao com o banco
        leitura.Close();

        
    
    
    }//fim do metodo
    public int quantidadedados()
    {
        return contador;
    }
    public string Atualizar(long CPF ,string nomeTabdela ,string nomecampo, string dado)
    {
        string query = $"update {nomeTabdela} set nome =' {dado}' where CPF = '{CPF}'";
        MySqlCommand slk = new MySqlCommand(query, conexao);
        string resultado = slq.Executennquery() + "Atualiazdo";
        return resultado;
    }//fim do metodo
    public string excluir(long CPF,string nomeTabela)
    {
        string query = $"delete from {nomeTabela} where CPF = '{CPF}'";
        MySqlCommand sql = new MySqlCommand(query, conexao);
        string resultado = sql.ExecuteNonQuery() + " wxcluido ";
        return resultado;   
    }//fim do metodo

  }//fim do projeto
     





    
