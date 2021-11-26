using Banco;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MySql.Data.MySqlClient;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1.Pages
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class CadastroPage : Page
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        public CadastroPage()
        {
            this.InitializeComponent();
        }

        void OpenHome(object sender, RoutedEventArgs e)
        {
            if (nameBox.Text == "" || cpfBox.Text == "" || aniverBox.Text == "" || tipoBox.Text == "")
            {
                // error
            }
            else
            {
                try
                {
                    conexao = new MySqlConnection("Server=localhost;Database=totalBank;Uid=root;Pwd=admin;");

                    strSQL = "INSERT INTO tb_usuario(nome, cpf, aniversario, tipo_conta, agencia, conta_numero) VALUES (@NOME, @CPF, @NIVER, @TIPO, @AGENCIA, @CONTNUM)";

                    comando = new MySqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@NOME", nameBox.Text);
                    comando.Parameters.AddWithValue("@CPF", cpfBox.Text);
                    comando.Parameters.AddWithValue("@NIVER", aniverBox.Text);
                    comando.Parameters.AddWithValue("@TIPO", tipoBox.Text);
                    Random random = new Random();
                    comando.Parameters.AddWithValue("@AGENCIA", random.Next(0, 999999999).ToString().Substring(0, 4));
                    comando.Parameters.AddWithValue("@CONTNUM", random.Next(0, 999999999).ToString().Substring(0, 6));

                    conexao.Open();

                    comando.ExecuteNonQuery();

                    Frame.Navigate(typeof(HomePage));
                }
                catch (Exception E)
                {
                    throw E;
                }
                finally
                {
                    conexao.Close();
                    conexao = null;
                    comando = null;
                }
            }
        }

        void OpenLogin(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
