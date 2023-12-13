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
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnn;

                cmd.CommandText = "INSERT INTO tb_paciente(nome, nascimento, sexo, cpf, tel, email, endereco, complemento) VALUES('" + nome.Text + "', " + nasc.Text + ", " + sex.Text + ", " + cpf.Text + ", " + tel.Text + ", '" + email.Text + "', '" + end.Text + "', '" + comp.Text + "'); ";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Paciente inserido com sucesso.");
                cnn.Close();
            }
            catch
            {
                MessageBox.Show("Erro na inserção.");
            }
            finally
            {
                this.Hide();
                MenuBase menu = new MenuBase();
                menu.Closed += (s, args) => this.Close();
                menu.Show();
                this.Dispose();
            }

        }
    }
}
