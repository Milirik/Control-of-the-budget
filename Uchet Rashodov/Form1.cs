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
    public partial class Enter : Form
    {
        public string loginUser;
        public Enter()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            this.loginUser = login1.Text;
            String passUser = password1.Text;
            BD db = new BD();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `employees` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MainMenu mf = new MainMenu(this.loginUser);
                mf.Show();
                this.Hide();
            }
            else MessageBox.Show("Error");
        }

        private void registration_label_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration r = new Registration(this);
            r.Show();
        }
    }
}
