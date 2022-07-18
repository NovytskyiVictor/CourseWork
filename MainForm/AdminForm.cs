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
    enum Rowstatus{
        Modified,
        New,
        Deleted
    }

    public partial class AdminForm : Form
    {
        db DB = new db();
        int selectedRow;
        public string tmp;
        public AdminForm()
        {
            InitializeComponent();
        }
        private void CreateColumns()
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
            dgv.Columns.Add("info", "info");
            dgv.Columns.Add("img", "img");
            dgv.Columns.Add("status", String.Empty);
        }

        private void ReadRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetByte(0), record.GetString(1), record.GetByte(2), record.GetString(3), record.GetInt32(4), record.GetString(5), record.GetInt32(6), record.GetInt32(7), record.GetInt32(8), record.GetDateTime(9).Date.ToString("d"), record.GetInt32(10), record.GetString(11), record.GetString(12), Rowstatus.New); ;
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
            dgv.Columns["img"].Visible = false;
            dgv.Columns["info"].Visible = false;
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
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(25,25,25);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        public void change()
        {
            int index = 0;
            WinForms.FormEdit f = new WinForms.FormEdit();
            for (int i = 0; i < dgv.RowCount; i++)
            {
                if (dgv.Rows[i].Cells[0].Value.ToString() == tmp)
                {
                    index = i;
                }
            }
            dgv.Rows[index].SetValues(Videocard.id, Videocard.name, Videocard.techproc, Videocard.typememory, Videocard.memory, Videocard.memorybus, Videocard.core, Videocard.shaderblock, Videocard.energy, Videocard.date, Videocard.price);
            dgv.Rows[index].Cells[12].Value = Videocard.link;
            dgv.Rows[index].Cells[11].Value = Videocard.info;
            dgv.Rows[index].Cells[13].Value = Rowstatus.Modified;
            f.Close();
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            this.Hide();
            WinForms.FormAdd f = new WinForms.FormAdd();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void textBoxsearch_TextChanged(object sender, EventArgs e)
        {
            search(dgv);
        }
        private void search(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string searchquerry = $"select * from videocard where concat (id, name, techproc, typememory, memory, memorybus, core, shaderblock, energy, date, price) like '%"+ textBoxsearch.Text +"%'";
            MySqlCommand com = new MySqlCommand(searchquerry, DB.getconnection());
            DB.open();
            MySqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadRow(dgv, read);
            }
            read.Close();
        }
        public void delete()
        {
            int index = 0;
            for (int i = 0; i < dgv.RowCount; i++)
            {
                if (dgv.Rows[i].Cells[0].Value.ToString() == tmp)
                {
                    index = i;
                }
            }
            dgv.Rows[index].Visible = false;
            if (dgv.Rows[index].Cells[0].Value.ToString() == String.Empty)
            {
                dgv.Rows[index].Cells[13].Value = Rowstatus.Deleted;
                return;
            }
            dgv.Rows[index].Cells[13].Value = Rowstatus.Deleted;
        }

        private void update()
        {
            DB.open();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                var rowstatus = (Rowstatus)dgv.Rows[i].Cells[13].Value;
                if (rowstatus == Rowstatus.New)
                    continue;
                if (rowstatus == Rowstatus.Deleted)
                {
                    var id = Convert.ToInt32(dgv.Rows[i].Cells[0].Value);
                    var deletequerry = $"DELETE FROM videocard WHERE videocard.id = {id}";
                    MySqlCommand com = new MySqlCommand(deletequerry, DB.getconnection());
                    com.ExecuteNonQuery();
                }
                if (rowstatus == Rowstatus.Modified)
                {
                    string changequerry = $"update videocard set name = '{Videocard.name}', techproc = '{Videocard.techproc}', typememory= '{Videocard.typememory}', memory= '{Videocard.memory}', memorybus = '{Videocard.memorybus}', core = '{Videocard.core}', shaderblock = '{Videocard.shaderblock}', energy = '{Videocard.energy}', date = '{Videocard.date}', price= '{Videocard.price}', img= @img, info= '{Videocard.info}' where id = '{Videocard.id}'";
                    MySqlCommand com = new MySqlCommand(changequerry, DB.getconnection());
                    com.Parameters.AddWithValue("img", Videocard.link);
                    com.ExecuteNonQuery();
                }
            }
            DB.close();
            Refreshdgv(dgv);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            update();
        }
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv.Rows[selectedRow];
                Videocard.name = row.Cells[1].Value.ToString();
                Videocard.techproc = Convert.ToInt32(row.Cells[2].Value);
                Videocard.typememory = row.Cells[3].Value.ToString();
                Videocard.memory = Convert.ToInt32(row.Cells[4].Value);
                Videocard.memorybus = row.Cells[5].Value.ToString();
                Videocard.core = Convert.ToInt32(row.Cells[6].Value);
                Videocard.shaderblock = Convert.ToInt32(row.Cells[7].Value);
                Videocard.energy = Convert.ToInt32(row.Cells[8].Value);
                Videocard.date = row.Cells[9].Value.ToString();
                Videocard.price = Convert.ToInt32(row.Cells[10].Value);
                Videocard.id = Convert.ToInt32(row.Cells[0].Value);
                Videocard.link = row.Cells[12].Value.ToString();
                Videocard.info = row.Cells[11].Value.ToString();
                this.Hide();
                WinForms.FormEdit f = new WinForms.FormEdit();
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
        }

        private void pictureBoxrefresh_Click(object sender, EventArgs e)
        {
            Refreshdgv(dgv);
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult1 = MessageBox.Show("Ви впевнені що хочете вийти?", "Вихід", MessageBoxButtons.YesNo);
            if (dialogResult1 == DialogResult.Yes)
            {
                DialogResult dialogResult2 = MessageBox.Show("Ви точно бажаєте покинути ваш чудовий акаунт?", "Вихід", MessageBoxButtons.YesNo);
                if (dialogResult2 == DialogResult.Yes)
                {
                    MainForm.StartForm f = new MainForm.StartForm();
                    this.Hide();
                    f.Show();
                }
            }
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult1 = MessageBox.Show("Ви впевнені що хочете вийти?", "Вихід", MessageBoxButtons.YesNo);
            if (dialogResult1 == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
