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

namespace signupform
{
    public partial class signupform : Form
    {
        public signupform()
        {
            InitializeComponent();
            this.textBoxpass.AutoSize = false;
            this.textBoxpass.Size = new Size(this.textBoxpass.Size.Width, 46);
        }
        public static Regex regex;

        private void button1_Click(object sender, EventArgs e)
        {
            int tmp = 0;
            regex = new Regex(@"^[a-zA-Z][a-zA-Z0-9-_\.]{1,15}$");
            if (!(regex.IsMatch(textBoxlogin.Text)))
            {
                tmp++;
                MessageBox.Show("Помилка введення логіну", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            regex = new Regex(@"([a-z]+[A-Z]+[0-9]+|[a-z]+[0-9]+[A-Z]+|[A-Z]+[a-z]+[0-9]+|[A-Z]+[0-9]+[a-z]+|[0-9]+[a-z]+[A-Z]+|[0-9]+[A-Z]+[a-z]+)");
            if (!(regex.IsMatch(textBoxpass.Text)))
            {
                tmp++;
                MessageBox.Show("Помилка введення паролю\nМає бути щонайменше один символ верхнього регістру, один нижнього і цифра", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            db DB = new db();
            MySqlCommand com = new MySqlCommand("INSERT INTO user (id, login, password) VALUES (NULL, @login, @password);", DB.getconnection());
            com.Parameters.AddWithValue("login", textBoxlogin.Text);
            com.Parameters.AddWithValue("password", textBoxpass.Text);
            DB.open();
            if (tmp == 0)
                if (Convert.ToInt32(com.ExecuteNonQuery()) != 0)
                {
                    MessageBox.Show("Реєстрація пройшла успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    MainForm.StartForm f = new MainForm.StartForm();
                    f.Show();
                }
            DB.close();
        }

        private void signupform_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.StartForm form = new MainForm.StartForm();
            form.Show();
        }
    }
}
