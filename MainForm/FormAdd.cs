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
    public partial class FormAdd : Form
    {
        db DB = new db();
        public FormAdd()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void buttonedit_Click(object sender, EventArgs e)
        {
            DB.open();
            Videocard.name = textBoxname.Text;
            int techproc = Videocard.techproc;
            Videocard.typememory = textBoxmemorytype.Text;
            int memory = Videocard.memory;
            Videocard.memorybus = textBoxmemorybus.Text;
            int core = Videocard.core;
            int shaderblock = Videocard.shaderblock;
            int energy = Videocard.energy;
            Videocard.date = dateTimePicker1.Value.ToString("s");
            int price = Videocard.price;
            Videocard.info = textBoxinfo.Text;
            Videocard.link = ofd.FileName;
            if (int.TryParse(textBoxtechproc.Text, out techproc) && int.TryParse(textBoxmemory.Text, out memory) && int.TryParse(textBoxcore.Text, out core) && int.TryParse(textBoxshaderblock.Text, out shaderblock) && int.TryParse(textBoxenergy.Text, out energy) && int.TryParse(textBoxprice.Text, out price))
            {
                Videocard.techproc = techproc;
                Videocard.memory = memory;
                Videocard.core = core;
                Videocard.shaderblock = shaderblock;
                Videocard.energy = energy;
                Videocard.price = price;
                var addQuerry = $"insert into videocard (id, name, techproc, typememory, memory, memorybus, core, shaderblock, energy, date, price, info, img) values (NULL,'{Videocard.name}','{Videocard.techproc}','{Videocard.typememory}','{Videocard.memory}','{Videocard.memorybus}','{Videocard.core}','{Videocard.shaderblock}','{Videocard.energy}','{Videocard.date}','{Videocard.price}', '{Videocard.info}', @img)";
                MySqlCommand com = new MySqlCommand(addQuerry, DB.getconnection());
                com.Parameters.AddWithValue("img", Videocard.link);
                com.ExecuteNonQuery();
                MessageBox.Show("Запис успішно додано!", "Юху!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm.AdminForm form = new MainForm.AdminForm();
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Помилка введення чисел!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DB.close();
        }

        private void FormAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.AdminForm form = new MainForm.AdminForm();
            form.Show();
        }

        private void buttonimg_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Image Files(*.JPG;*.PNG)|*.JPG;*.PNG|All files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Videocard.link = ofd.FileName;
                }
                catch
                {
                    MessageBox.Show("Неправильний формат картинки!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
