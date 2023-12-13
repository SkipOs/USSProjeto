using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace USSProjeto
{
    public partial class CadPaci : Form
    {
        public CadPaci()
        {
            InitializeComponent();
        }

        private void CadPaci_Load(object sender, EventArgs e)
        {

        }

        private void Cancelar(object sender, EventArgs e)
        {
            this.Hide();
            MenuBase menu = new MenuBase();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
            this.Dispose();
        }

        private void Salvar(object sender, EventArgs e)
        {
            string connetionString = "server=localhost;database=uss_banco;uid=root;pwd=admin;";
            using (MySqlConnection cnn = new MySqlConnection(connetionString))
            {
                cnn.Open();
                //inserção

                MessageBox.Show("Paciente inserido com sucesso.");
                cnn.Close();
            }
        }

    }
}
