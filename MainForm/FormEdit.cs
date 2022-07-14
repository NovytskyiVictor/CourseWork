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

namespace WinForms
{
    public partial class FormEdit : Form
    {
        public int tmp;
        public FormEdit()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void FormAdd_Load(object sender, EventArgs e)
        {
            textBoxname.Text = Videocard.name;
            textBoxtechproc.Text = Videocard.techproc.ToString();
            textBoxmemorytype.Text = Videocard.typememory;
            textBoxmemory.Text = Videocard.memory.ToString();
            textBoxmemorybus.Text = Videocard.memorybus;
            textBoxcore.Text = Videocard.core.ToString();
            textBoxshaderblock.Text = Videocard.shaderblock.ToString();
            textBoxenergy.Text = Videocard.energy.ToString();
            dateTimePicker1.Text = Videocard.date;
            textBoxprice.Text = Videocard.price.ToString();
            labelid.Text = Videocard.id.ToString();
            textBoxinfo.Text = Videocard.info;
            ofd.FileName = Videocard.link;
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            MainForm.AdminForm f = new MainForm.AdminForm();
            f.tmp = labelid.Text;
            Videocard.id = Convert.ToInt32(labelid.Text);
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
                this.Hide();
                f.Show();
                f.change();
            }
            else
            {
                MessageBox.Show("Помилка введення чисел!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            MainForm.AdminForm f = new MainForm.AdminForm();
            f.tmp = labelid.Text;
            this.Hide();
            f.Show();
            f.delete();
        }

        private void FormEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.AdminForm f = new MainForm.AdminForm();
            f.Show();
        }

        private void buttonimg_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Image Files(*.JPG;*.PNG)|*.JPG;*.PNG|All files(*.*)|*.*";
            if(ofd.ShowDialog() == DialogResult.OK)
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
