using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uchet_Rashodov
{
    public partial class MainMenu : Form
    {
        public string loginUser;
        public MainMenu(string loginUser)
        {
            this.loginUser = loginUser;
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void add_new_m(object sender, EventArgs e)
        {
            CreateNew cr = new CreateNew(loginUser);
            cr.Show();
        }

        private void удалитьВыделенныеЗаписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete del = new Delete();
            del.Show();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            List<string[]> data = new List<string[]>();
            BD db = new BD();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `records` WHERE `creator`=@lu", db.getConnection());
            command.Parameters.Add("@lu", MySqlDbType.VarChar).Value = loginUser;

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                data.Add(new string[5]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[2].ToString();
                data[data.Count - 1][2] = reader[3].ToString();
                data[data.Count - 1][3] = reader[4].ToString();
                data[data.Count - 1][4] = reader[5].ToString();
            }
            db.closeConnection();

            foreach (string[] s in data) {
                dataGridView1.Rows.Add(s);
            }
        }
    }
}
