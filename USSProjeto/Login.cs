using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USSProjeto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Verificar(object sender, EventArgs e)
        {
            if (EntraLogin.Text == "root" && EntraSenha.Text == "admin")
            {
                string connetionString = null;
                MySqlConnection cnn;
                connetionString = "server=localhost;database=uss_banco;uid=root;pwd=admin;";
                cnn = new MySqlConnection(connetionString);
                try
                {
                    cnn.Open();
                    MessageBox.Show("Conexão realizada");
                    this.Hide();
                    MenuBase menu = new MenuBase();
                    menu.Closed += (s, args) => this.Dispose();
                    menu.Show();
                    cnn.Close();
                }
                catch
                {
                    MessageBox.Show("Não foi possível realizar conexão");
                }
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido");
            }
        }

        private void EntraLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void EntraSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
