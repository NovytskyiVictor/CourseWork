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
    public partial class UserForm : Form
    {

        db DB = new db();
        public string tmp;
        int selectedrow;
        public UserForm()
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
            DataGridViewCheckBoxColumn dgvcheckbox = new DataGridViewCheckBoxColumn();
            dgvcheckbox.ValueType = typeof(bool);
            dgvcheckbox.Name = "check";
            dgvcheckbox.HeaderText = "Порівняння";
            dgvcheckbox.ReadOnly = false;
            dgv.Columns.Add(dgvcheckbox);
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
            panelform.Width = 1;
            button_poriv.Visible = false;
            buttonok.Visible = false;
            label1.Visible = false;
            label7.Visible = false;
            textBoxot.Visible = false;
            textBoxdo.Visible = false;
            checkBox_4096.Visible = false;
            checkBox_6144.Visible = false;
            checkBox_8192.Visible = false;
            checkBox_10240.Visible = false;
            checkBox_12228.Visible = false;
            checkBox_16384.Visible = false;
            checkBox_24576.Visible = false;
            checkBox_amd.Visible = false;
            checkBox_nvidia.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            CreateColumns();
            Refreshdgv(dgv);
            styledatagridview();
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.RowHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            dgv.Columns["id"].ReadOnly = true;
            dgv.Columns["name"].ReadOnly = true;
            dgv.Columns["techproc"].ReadOnly = true;
            dgv.Columns["typememory"].ReadOnly = true;
            dgv.Columns["memory"].ReadOnly = true;
            dgv.Columns["memorybus"].ReadOnly = true;
            dgv.Columns["core"].ReadOnly = true;
            dgv.Columns["shaderblock"].ReadOnly = true;
            dgv.Columns["energy"].ReadOnly = true;
            dgv.Columns["date"].ReadOnly = true;
            dgv.Columns["price"].ReadOnly = true;
            dgv.Columns["status"].Visible = false;
            dgv.Columns["id"].Visible = false;
            dgv.Columns["check"].Visible = false;
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
        private void labelfilt_Click(object sender, EventArgs e)
        {
            if (label2.Visible == false)
            {
                labelporiv.Visible = false;
                textBoxsearch.ReadOnly = true;
                panelform.Width =  155;
                buttonok.Visible = true;
                checkBox_4096.Visible = true;
                checkBox_6144.Visible = true;
                checkBox_8192.Visible = true;
                checkBox_10240.Visible = true;
                checkBox_12228.Visible = true;
                checkBox_16384.Visible = true;
                checkBox_24576.Visible = true;
                checkBox_amd.Visible = true;
                checkBox_nvidia.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label1.Visible = true;
                label7.Visible = true;
                textBoxot.Visible = true;
                textBoxdo.Visible = true;
                Refreshdgv(dgv);
            }
            else
            {
                labelporiv.Visible = true;
                textBoxsearch.ReadOnly = false;
                panelform.Width = 1;
                buttonok.Visible = false;
                label1.Visible = false;
                label7.Visible = false;
                textBoxot.Visible = false;
                textBoxdo.Visible = false;
                checkBox_4096.Visible = false;
                checkBox_6144.Visible = false;
                checkBox_8192.Visible = false;
                checkBox_10240.Visible = false;
                checkBox_12228.Visible = false;
                checkBox_16384.Visible = false;
                checkBox_24576.Visible = false;
                checkBox_amd.Visible = false;
                checkBox_nvidia.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                Refreshdgv(dgv);
            }
        }
        private void checkBox_amd_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }
        private void checkBox_nvidia_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }
        int maxmem = 0, minmem = 25000;
        int minprice = 0, maxprice = 99999;
        private int findmax()
        {
            if (checkBox_24576.Checked == true && Convert.ToInt32(checkBox_24576.Text) > minmem)
            {
                maxmem = Convert.ToInt32(checkBox_24576.Text);
                return maxmem;
            }
            else if (checkBox_16384.Checked == true && Convert.ToInt32(checkBox_16384.Text) > minmem)
            {
                maxmem = Convert.ToInt32(checkBox_16384.Text);
                return maxmem;
            }
            if (checkBox_12228.Checked == true && Convert.ToInt32(checkBox_12228.Text) > minmem)
            {
                maxmem = Convert.ToInt32(checkBox_12228.Text);
                return maxmem;
            }
            else if (checkBox_10240.Checked == true && Convert.ToInt32(checkBox_10240.Text) > minmem)
            {
                maxmem = Convert.ToInt32(checkBox_10240.Text);
                return maxmem;
            }
            else if (checkBox_8192.Checked == true && Convert.ToInt32(checkBox_8192.Text) > minmem)
            {
                maxmem = Convert.ToInt32(checkBox_8192.Text);
                return maxmem;
            }
            else if (checkBox_6144.Checked == true && Convert.ToInt32(checkBox_6144.Text) > minmem)
            {
                maxmem = Convert.ToInt32(checkBox_6144.Text);
                return maxmem;
            }
            else if (checkBox_4096.Checked == true && Convert.ToInt32(checkBox_4096.Text) > minmem)
            {
                maxmem = Convert.ToInt32(checkBox_4096.Text);
                return maxmem;
            }
            else return maxmem = 25000;
        }
        private int findmin()
        {
            if (checkBox_4096.Checked == true && Convert.ToInt32(checkBox_4096.Text) < minmem)
            {
                minmem = Convert.ToInt32(checkBox_4096.Text);
                return minmem;
            }
            else if (checkBox_6144.Checked == true && Convert.ToInt32(checkBox_6144.Text) < minmem)
            {
                minmem = Convert.ToInt32(checkBox_6144.Text);
                return minmem;
            }
            else if (checkBox_8192.Checked == true && Convert.ToInt32(checkBox_8192.Text) < minmem)
            {
                minmem = Convert.ToInt32(checkBox_8192.Text);
                return minmem;
            }
            else if (checkBox_10240.Checked == true && Convert.ToInt32(checkBox_10240.Text) < minmem)
            {
                minmem = Convert.ToInt32(checkBox_10240.Text);
                return minmem;
            }
            else if (checkBox_12228.Checked == true && Convert.ToInt32(checkBox_12228.Text) < minmem)
            {
                minmem = Convert.ToInt32(checkBox_12228.Text);
                return minmem;
            }
            else if (checkBox_16384.Checked == true && Convert.ToInt32(checkBox_16384.Text) < minmem)
            {
                minmem = Convert.ToInt32(checkBox_16384.Text);
                return minmem;
            }
            else if (checkBox_24576.Checked == true && Convert.ToInt32(checkBox_24576.Text) < minmem)
            {
                minmem = Convert.ToInt32(checkBox_24576.Text);
                return minmem;
            }
            else return minmem = 0;
        }
        private void check()
        {
            maxmem = 0;
            int max = findmax();
            minmem = 25000;
            int min = findmin();
            if (checkBox_nvidia.Checked == false && checkBox_amd.Checked == true)
            {
                dgv.Rows.Clear();
                string filterquerry = $"select * from videocard where memory between {minmem} and {maxmem} and price between {minprice} and {maxprice} and name like '%" + checkBox_amd.Text + "%'";
                MySqlCommand com = new MySqlCommand(filterquerry, DB.getconnection());
                DB.open();
                MySqlDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    ReadRow(dgv, read);
                }
                read.Close();
            }
            else if (checkBox_nvidia.Checked == true && checkBox_amd.Checked == false)
            {
                dgv.Rows.Clear();
                string filterquerry = $"select * from videocard where memory between {minmem} and {maxmem} and price between {minprice} and {maxprice} and name like '%" + checkBox_nvidia.Text + "%'";
                MySqlCommand com = new MySqlCommand(filterquerry, DB.getconnection());
                DB.open();
                MySqlDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    ReadRow(dgv, read);
                }
                read.Close();
            }
            else
            {
                dgv.Rows.Clear();
                string filterquerry = $"select * from videocard where memory between {minmem} and {maxmem} and price between {minprice} and {maxprice}";
                MySqlCommand com = new MySqlCommand(filterquerry, DB.getconnection());
                DB.open();
                MySqlDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    ReadRow(dgv, read);
                }
                read.Close();
            }
        }
        private void checkBox_24576_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }
        private void checkBox_16384_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }
        private void checkBox_12228_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }
        private void checkBox_10240_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }
        private void checkBox_8192_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxdo.Text != String.Empty && textBoxot.Text != String.Empty)
            {
                if (Convert.ToInt32(textBoxot.Text) >= Convert.ToInt32(textBoxdo.Text))
                {
                    MessageBox.Show("Від більше До!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    minprice = int.Parse(textBoxot.Text);
                    maxprice = int.Parse(textBoxdo.Text);
                    check();
                }
            }
        }
        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
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
        private void checkBox_6144_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }
        private void labelporiv_Click(object sender, EventArgs e)
        {
            if (dgv.Columns["check"].Visible == false)
            {
                button_poriv.Visible = true;
                textBoxsearch.Visible = false;
                labelfilt.Visible = false;
                dgv.Columns["check"].Visible = true;
            }
            else
            {
                button_poriv.Visible = false;
                textBoxsearch.Visible = true;
                labelfilt.Visible = true;
                dgv.Columns["check"].Visible = false;
            }
        }

        private void button_poriv_Click(object sender, EventArgs e)
        {
            int[] array = new int[100];
            int j = 0;
            for (int i = 0; i < dgv.RowCount; i++)
            {
                if (Convert.ToBoolean(dgv.Rows[i].Cells[12].Value) == true)
                {
                    array[j] = Convert.ToInt32(dgv.Rows[i].Cells[0].Value);
                    j++;
                }
            }
            if (j > 0)
            {
                this.Hide();
                WinForms.PorivForm f = new WinForms.PorivForm();
                f.arrayadd(array, j);
                f.Show();
            }
        }

        private void checkBox_4096_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }
        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;
            int selectedcolumn = e.ColumnIndex;
            if (selectedcolumn == 1)
            {
                if (e.RowIndex >= 0)
                {
                    if (dgv.Rows[selectedrow].Cells[1].Value.ToString() != String.Empty)
                    {
                        Videocard.name = dgv.Rows[selectedrow].Cells[1].Value.ToString();
                        string querryimg = "select img from videocard where name like '%" + Videocard.name + "%'";
                        string querryinfo = "select info from videocard where name like '%" + Videocard.name + "%'";
                        DB.open();
                        MySqlCommand com = new MySqlCommand(querryimg, DB.getconnection());
                        Videocard.link = (string)com.ExecuteScalar();
                        com = new MySqlCommand(querryinfo, DB.getconnection());
                        Videocard.info = (string)com.ExecuteScalar();
                        DB.close();
                        this.Hide();
                        WinForms.Videocardinfo f = new WinForms.Videocardinfo();
                        f.Show();
                    }
                }
            }
        }
    }
}
