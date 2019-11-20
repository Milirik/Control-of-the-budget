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
    public partial class Delete : Form
    {
        public List<CheckBox> chs = new List<CheckBox>();
        public List<string> data = new List<string>();
        public Delete()
        {
            BD db = new BD();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `records`", db.getConnection());
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                data.Add(reader[0].ToString());
            }
            db.closeConnection();

            for (int i = 0; i < data.Count; i++)
            {
                chs.Add(new CheckBox());
                chs[chs.Count - 1].Name = data[i];
                chs[chs.Count - 1].Text = data[i] ;
                chs[chs.Count - 1].Location = new Point(33, 100 + (i * 20));
                chs[chs.Count - 1].Visible = true;
                Controls.Add(chs[chs.Count - 1]);
            }
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < data.Count; i++) {
                if (chs[i].Checked == true) {
                    BD db = new BD();
                    string k = chs[i].Text;

                    MySqlCommand command = new MySqlCommand("DELETE FROM `records` WHERE `id`=@id", db.getConnection());
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = k;
                    db.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Success!");
                        this.Close();
                    }
                    else MessageBox.Show("Ошибка подключения к базе данных", "Error");
                    db.closeConnection();
                }
            }
        }
    }
}
