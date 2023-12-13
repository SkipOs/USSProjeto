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
                    MySqlCommand cmd = new MySqlCommand
                    {
                        Connection = cnn,
                        CommandType = System.Data.CommandType.Text,
                        CommandText = "INSERT INTO tb_paciente(nome, nascimento, sexo, cpf, tel, email, endereco, complemento) VALUES(@Nome, @Nascimento, @Sexo, @Cpf, @Tel, @Email, @Endereco, @Complemento)"
                    };

                    cmd.Parameters.AddWithValue("@Nome", nome.Text);
                    cmd.Parameters.AddWithValue("@Nascimento", Convert.ToDateTime(nasc.Text).ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Sexo", sex.Text);
                    cmd.Parameters.AddWithValue("@Cpf", cpf.Text);
                    cmd.Parameters.AddWithValue("@Tel", tel.Text);
                    cmd.Parameters.AddWithValue("@Email", email.Text);
                    cmd.Parameters.AddWithValue("@Endereco", end.Text);
                    cmd.Parameters.AddWithValue("@Complemento", comp.Text);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Paciente inserido com sucesso.");
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na inserção: " + ex.Message);
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
