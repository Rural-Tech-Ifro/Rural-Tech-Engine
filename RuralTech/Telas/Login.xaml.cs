using DataBase.Configuracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RuralTech.Telas
{
    /// <summary>
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        public bool ConsultarBancoDados(string usuario, string senha)
        {
           
                bool validador = false;
                var conexao = new Conexao();
                var comando = conexao.Comando("SELECT * FROM usuario");
                var leitor = comando.ExecuteReader();


                while (leitor.Read())
                {
                    string nomeBanco = DAOHelper.GetString(leitor, "nome_usu");
                    string senhaBanco = DAOHelper.GetString(leitor, "senha_usu");

                    if (usuario.Equals(nomeBanco) && senhaBanco.Equals(senhaBanco))
                    {
                   
                       
                        validador = true;
                    }
                    

            }
            return validador;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var usuario = txt_usuario.Text;
            var senha = txt_senha.Password;

            
            if (ConsultarBancoDados(usuario, senha))
            {
                MessageBox.Show("Logado com sucesso!");
                CadastroDeAnimal tela = new CadastroDeAnimal();
                this.Close();
                tela.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario não cadastrado!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Cadastro tela = new Cadastro();
            this.Close();
            tela.ShowDialog();
        }
    }
}
