using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace USSProjeto
{
    public partial class ConPront : Form
    {
        public ConPront()
        {
            InitializeComponent();
        }

        private void Voltar(object sender, EventArgs e)
        {
            this.Hide();
            MenuBase menu = new MenuBase();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
            this.Dispose();
        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tb_prontuario WHERE paciente = '" + ListaPaciente.Text + "';";
            string connetionString = "server=localhost;database=uss_banco;uid=root;pwd=admin;";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable data = new DataTable();
            adapter.Fill(data);

            cnn.Open();
            dataGridView1.DataSource = data;
            cnn.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void Lista_Update(object sender, MouseEventArgs e)
        {
            PacienteDAO pacienteDAO = new PacienteDAO();
            List<string> nomesPacientes = pacienteDAO.GetPacientes();

            ListaPaciente.DataSource = nomesPacientes;
        }
    }
}
