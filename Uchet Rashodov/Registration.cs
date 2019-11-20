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
    public partial class Registration : Form
    {
        Enter e;
        public Registration(Enter e)
        {
            this.e = e;
            InitializeComponent();
        }

        private void registrate_button_Click(object sender, EventArgs e)
        {
            BD bd = new BD();
            string k = r_login.Text;
            MySqlCommand command = new MySqlCommand("INSERT INTO `employees` (`login`, `pass`) VALUES (@uL, @uP)", bd.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = k;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = r_password.Text;

            bd.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Регистрация прошла успешна!", "Sucsess");
                if (radioButton1.Checked == true)
                {
                    this.Close();
                    this.e.Hide();
                    MainMenu mf = new MainMenu(k);
                    mf.Show();
                }
                else
                {
                    this.Close();
                }
            }
            else MessageBox.Show("Error");
            bd.closeConnection();

            
        }
    }
}
