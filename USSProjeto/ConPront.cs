using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

        private void ListaPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
