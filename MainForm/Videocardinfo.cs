using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lib;
using MySql.Data.MySqlClient;

namespace WinForms
{
    public partial class Videocardinfo : Form
    {
        db DB = new db();
        public Videocardinfo()
        {
            InitializeComponent();
        }

        private void Videocard_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Videocard.link);
            labelname.Text = Videocard.name;
            labelinfo.Text = Videocard.info;
            pictureBox1.Focus();
        }

        private void Videocardinfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.UserForm form = new MainForm.UserForm();
            form.Show();
        }
    }
}
