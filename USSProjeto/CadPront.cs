using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace USSProjeto
{
    public partial class CadPront : Form
    {
        public CadPront()
        {
            InitializeComponent();
        }

        private void Salvar(object sender, EventArgs e)
        {
            string connetionString = "server=localhost;database=uss_banco;uid=root;pwd=admin;";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = cnn,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "INSERT INTO tb_prontuario(paciente, descricao) VALUES('"+ Lista.Text+"','" + desc.Text + "'); "
                };
                cmd.ExecuteNonQuery();
                MessageBox.Show("Prontuário inserido com sucesso.");
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

        private void Cancelar(object sender, EventArgs e)
        {
            this.Hide();
            MenuBase menu = new MenuBase();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
            this.Dispose();
        }
   
        private void Lista_MouseEnter(object sender, EventArgs e)
        {
            PacienteDAO pacienteDAO = new PacienteDAO();
            List<string> nomesPacientes = pacienteDAO.GetPacientes();

            Lista.DataSource = nomesPacientes;
        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void desc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
