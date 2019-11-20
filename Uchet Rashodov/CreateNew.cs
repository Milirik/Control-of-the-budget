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
    public partial class CreateNew : Form
    {

        public string loginUser;

        public CreateNew(string loginUser)
        {
            this.loginUser = loginUser;
            InitializeComponent();
        }

        private void add_e_Click(object sender, EventArgs e)
        {
            string status = comboBox1.SelectedItem.ToString();
            string comment = richTextBox1.Text;
            string sum = textBox1.Text;
            string date = dateTimePicker1.Text;

            BD bd = new BD();
            MySqlCommand command = new MySqlCommand("INSERT INTO `records` (`creator`, `status`, `comment`, `sum`, `date`) VALUES (@cr, @st, @co, @su, @da)", bd.getConnection());
            command.Parameters.Add("@cr", MySqlDbType.VarChar).Value = this.loginUser;
            command.Parameters.Add("@st", MySqlDbType.VarChar).Value = status;
            command.Parameters.Add("@co", MySqlDbType.VarChar).Value = comment;
            command.Parameters.Add("@su", MySqlDbType.VarChar).Value = sum;
            command.Parameters.Add("@da", MySqlDbType.VarChar).Value = date;

            bd.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Добавление новой записи - успешно!", "Sucsess");
                this.Close();
            }
            else MessageBox.Show("Error");
            bd.closeConnection();

        }
    }
}
