﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace USSProjeto
{
    public class PacienteDAO
    {
        private string connectionString = "server=localhost;database=uss_banco;uid=root;pwd=admin;";

        public List<string> GetPacientes()
        {
            List<string> nomesPacientes = new List<string>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT nome FROM tb_paciente";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nomesPacientes.Add(reader["nome"].ToString());
                    }
                }
            }

            return nomesPacientes;
        }
    }
}
