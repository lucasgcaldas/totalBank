using App1.Pages;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using MySql.Data.MySqlClient;
using System.Data;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x416

namespace Banco
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        public MainPage()
        {
            this.InitializeComponent();
        }

        void OpenHome(object sender, RoutedEventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=totalBank;Uid=root;Pwd=admin;");

                strSQL = "SELECT * FROM tb_usuario WHERE agencia = @AGENCIA AND conta_numero = @NUMCONTA";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@AGENCIA", ageBox.Text);
                comando.Parameters.AddWithValue("@NUMCONTA", contBox.Text);

                conexao.Open();

                dr = comando.ExecuteReader();

                if(dr.Read())
                {
                    Frame.Navigate(typeof(HomePage));
                }

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

        void OpenCadastro(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CadastroPage));
        }
    }
}
