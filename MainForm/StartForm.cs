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

namespace MainForm
{
    public partial class StartForm : Form
    {
        db DB = new db();
        public StartForm()
        {
            InitializeComponent();
        }
        public void CreateColumns()
        {
            dgv.Columns.Add("id", "№");
            dgv.Columns.Add("name", "Назва");
            dgv.Columns.Add("techproc", "Техпроцес, нм");
            dgv.Columns.Add("typememory", "Тип пам'яті");
            dgv.Columns.Add("memory", "Об`єм пам`яті");
            dgv.Columns.Add("memorybus", "Шина пам'яті");
            dgv.Columns.Add("core", "Частота роботи ядра, МГц");
            dgv.Columns.Add("shaderblock", "Шейдерних блоків");
            dgv.Columns.Add("energy", "Споживання енергії, Вт");
            dgv.Columns.Add("date", "Дата випуску");
            dgv.Columns.Add("price", "Вартість, $");
            dgv.Columns.Add("status", String.Empty);
        }
        public void ReadRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetByte(0), record.GetString(1), record.GetByte(2), record.GetString(3), record.GetInt32(4), record.GetString(5), record.GetInt32(6), record.GetInt32(7), record.GetInt32(8), record.GetDateTime(9).Date.ToString("d"), record.GetInt32(10), Rowstate.ModifiedNew); ;
        }
        private void Refreshdgv(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string str = $"select * from videocard";
            MySqlCommand com = new MySqlCommand(str, DB.getconnection());
            DB.open();
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
                ReadRow(dgv, reader);
            DB.close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            Refreshdgv(dgv);
            styledatagridview();
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.RowHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            dgv.Columns["status"].Visible = false;
            dgv.Columns["id"].Visible = false;
        }
        private void styledatagridview()
        {
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Black;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(50, 50, 50);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.BackgroundColor = Color.Black;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("MS Times New Roman", 12);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(25, 25, 25);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void buttonsignin_Click(object sender, EventArgs e)
        {
            signinform.signinform signin = new signinform.signinform();
            this.Hide();
            signin.StartPosition = FormStartPosition.CenterScreen;
            signin.Show();
        }
        private void buttonsignup_Click(object sender, EventArgs e)
        {
            signupform.signupform signup = new signupform.signupform();
            this.Hide();
            signup.StartPosition = FormStartPosition.CenterScreen;
            signup.Show();
        }
        private void textBoxsearch_TextChanged(object sender, EventArgs e)
        {
            search(dgv);
        }
        private void search(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string searchquerry = $"select * from videocard where concat (id, name, techproc, typememory, memory, memorybus, core, shaderblock, energy, date, price) like '%" + textBoxsearch.Text + "%'";
            MySqlCommand com = new MySqlCommand(searchquerry, DB.getconnection());
            DB.open();
            MySqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadRow(dgv, read);
            }
            read.Close();
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ви впевнені що хочете вийти?", "Вихід", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
