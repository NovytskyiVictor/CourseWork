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
    public partial class PorivForm : Form
    {
        db DB = new db();
        int[] array = new int[100];
        int j;
        int i = 0;
        public PorivForm()
        {
            InitializeComponent();
        }
        public void arrayadd(int[] a, int i)
        {
            array = a;
            j = i;
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
        }
        public void ReadRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetByte(0), record.GetString(1), record.GetByte(2), record.GetString(3), record.GetInt32(4), record.GetString(5), record.GetInt32(6), record.GetInt32(7), record.GetInt32(8), record.GetDateTime(9).Date.ToString("d"), record.GetInt32(10)); ;
        }
        private void Refreshdgv(DataGridView dgv)
        {
            string str = $"select * from videocard where id = '{array[i]}'";
            MySqlCommand com = new MySqlCommand(str, DB.getconnection());
            DB.open();
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
                ReadRow(dgv, reader);
            DB.close();
        }
        private void PorivForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            while (i <= j)
            {
                Refreshdgv(dgv);
                i++;
            }
            styledatagridview();
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.RowHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
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

        private void PorivForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.UserForm form = new MainForm.UserForm();
            form.Show();
        }
    }
}
