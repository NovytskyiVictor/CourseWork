using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using lib;
using MySql.Data.MySqlClient;

namespace signinform
{
    public partial class signinform : Form
    {
        public signinform()
        {
            InitializeComponent();
            this.textBoxpass.AutoSize = false;
            this.textBoxpass.Size = new Size(this.textBoxpass.Size.Width, 46);
        }
        public static Regex regex;

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBoxlogin.Text;
            string pass = textBoxpass.Text;
            db DB = new db();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand com = new MySqlCommand("SELECT * FROM user WHERE login=@uL AND password=@uP", DB.getconnection());
            com.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            com.Parameters.Add("@uP", MySqlDbType.VarChar).Value = pass;
            adapter.SelectCommand = com;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Авторизовано", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (login == "admin" && pass == "admin")
                {
                    this.Hide();
                    MainForm.AdminForm f = new MainForm.AdminForm();
                    f.Show();
                }
                else
                {
                    this.Hide();
                    MainForm.UserForm f = new MainForm.UserForm();
                    f.Show();
                }
            }

            else
                MessageBox.Show("Помилка авторизації! Перевірьте введенні дані", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void signinform_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.StartForm form = new MainForm.StartForm();
            form.Show();
        }

        private void pictureBoxvisible_Click(object sender, EventArgs e)
        {
            if (textBoxpass.UseSystemPasswordChar == true)
            {
                pictureBoxvisible.Image = Image.FromFile("C:\\Users\\Victor\\source\\repos\\kursova\\MainForm\\images\\view.png");
                textBoxpass.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBoxvisible.Image = Image.FromFile("C:\\Users\\Victor\\source\\repos\\kursova\\MainForm\\images\\hide.png");
                textBoxpass.UseSystemPasswordChar = true;

            }
        }
    }
}
