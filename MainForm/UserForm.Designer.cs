
namespace MainForm
{
    partial class UserForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonexit = new System.Windows.Forms.Button();
            this.paneltop = new System.Windows.Forms.Panel();
            this.button_poriv = new System.Windows.Forms.Button();
            this.labelporiv = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.labelfilt = new System.Windows.Forms.Label();
            this.panelform = new System.Windows.Forms.Panel();
            this.buttonok = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxdo = new System.Windows.Forms.TextBox();
            this.textBoxot = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_6144 = new System.Windows.Forms.CheckBox();
            this.checkBox_4096 = new System.Windows.Forms.CheckBox();
            this.checkBox_8192 = new System.Windows.Forms.CheckBox();
            this.checkBox_10240 = new System.Windows.Forms.CheckBox();
            this.checkBox_12228 = new System.Windows.Forms.CheckBox();
            this.checkBox_24576 = new System.Windows.Forms.CheckBox();
            this.checkBox_16384 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox_nvidia = new System.Windows.Forms.CheckBox();
            this.checkBox_amd = new System.Windows.Forms.CheckBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonexit
            // 
            this.buttonexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonexit.BackColor = System.Drawing.SystemColors.Control;
            this.buttonexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.buttonexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonexit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonexit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonexit.Image = ((System.Drawing.Image)(resources.GetObject("buttonexit.Image")));
            this.buttonexit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonexit.Location = new System.Drawing.Point(1242, 0);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(140, 102);
            this.buttonexit.TabIndex = 2;
            this.buttonexit.Text = "Вихід";
            this.buttonexit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonexit.UseVisualStyleBackColor = false;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.Transparent;
            this.paneltop.Controls.Add(this.button_poriv);
            this.paneltop.Controls.Add(this.labelporiv);
            this.paneltop.Controls.Add(this.pictureBox2);
            this.paneltop.Controls.Add(this.textBoxsearch);
            this.paneltop.Controls.Add(this.buttonexit);
            this.paneltop.Controls.Add(this.labelfilt);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1382, 102);
            this.paneltop.TabIndex = 4;
            // 
            // button_poriv
            // 
            this.button_poriv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_poriv.FlatAppearance.BorderSize = 0;
            this.button_poriv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.button_poriv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.button_poriv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_poriv.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_poriv.ForeColor = System.Drawing.Color.White;
            this.button_poriv.Location = new System.Drawing.Point(550, 12);
            this.button_poriv.Name = "button_poriv";
            this.button_poriv.Size = new System.Drawing.Size(300, 77);
            this.button_poriv.TabIndex = 7;
            this.button_poriv.Text = "Порівняти";
            this.button_poriv.UseVisualStyleBackColor = true;
            this.button_poriv.Click += new System.EventHandler(this.button_poriv_Click);
            // 
            // labelporiv
            // 
            this.labelporiv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelporiv.AutoSize = true;
            this.labelporiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelporiv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelporiv.ForeColor = System.Drawing.Color.White;
            this.labelporiv.Location = new System.Drawing.Point(1120, 80);
            this.labelporiv.Name = "labelporiv";
            this.labelporiv.Size = new System.Drawing.Size(116, 22);
            this.labelporiv.TabIndex = 8;
            this.labelporiv.Text = "Порівняння:";
            this.labelporiv.Click += new System.EventHandler(this.labelporiv_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(14, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxsearch.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxsearch.Location = new System.Drawing.Point(84, 18);
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.Size = new System.Drawing.Size(1152, 53);
            this.textBoxsearch.TabIndex = 0;
            this.textBoxsearch.TextChanged += new System.EventHandler(this.textBoxsearch_TextChanged);
            // 
            // labelfilt
            // 
            this.labelfilt.AutoSize = true;
            this.labelfilt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelfilt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelfilt.ForeColor = System.Drawing.Color.White;
            this.labelfilt.Location = new System.Drawing.Point(30, 74);
            this.labelfilt.Name = "labelfilt";
            this.labelfilt.Size = new System.Drawing.Size(86, 22);
            this.labelfilt.TabIndex = 0;
            this.labelfilt.Text = "Фільтри:";
            this.labelfilt.Click += new System.EventHandler(this.labelfilt_Click);
            // 
            // panelform
            // 
            this.panelform.BackColor = System.Drawing.Color.Transparent;
            this.panelform.Controls.Add(this.buttonok);
            this.panelform.Controls.Add(this.label7);
            this.panelform.Controls.Add(this.label1);
            this.panelform.Controls.Add(this.textBoxdo);
            this.panelform.Controls.Add(this.textBoxot);
            this.panelform.Controls.Add(this.label5);
            this.panelform.Controls.Add(this.label4);
            this.panelform.Controls.Add(this.label3);
            this.panelform.Controls.Add(this.checkBox_6144);
            this.panelform.Controls.Add(this.checkBox_4096);
            this.panelform.Controls.Add(this.checkBox_8192);
            this.panelform.Controls.Add(this.checkBox_10240);
            this.panelform.Controls.Add(this.checkBox_12228);
            this.panelform.Controls.Add(this.checkBox_24576);
            this.panelform.Controls.Add(this.checkBox_16384);
            this.panelform.Controls.Add(this.label2);
            this.panelform.Controls.Add(this.label6);
            this.panelform.Controls.Add(this.checkBox_nvidia);
            this.panelform.Controls.Add(this.checkBox_amd);
            this.panelform.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelform.Location = new System.Drawing.Point(0, 102);
            this.panelform.Name = "panelform";
            this.panelform.Size = new System.Drawing.Size(150, 651);
            this.panelform.TabIndex = 5;
            // 
            // buttonok
            // 
            this.buttonok.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonok.Location = new System.Drawing.Point(43, 480);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(44, 34);
            this.buttonok.TabIndex = 1;
            this.buttonok.Text = "Ок";
            this.buttonok.UseVisualStyleBackColor = true;
            this.buttonok.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Від:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "До:";
            // 
            // textBoxdo
            // 
            this.textBoxdo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxdo.ForeColor = System.Drawing.Color.Black;
            this.textBoxdo.Location = new System.Drawing.Point(62, 435);
            this.textBoxdo.Name = "textBoxdo";
            this.textBoxdo.Size = new System.Drawing.Size(54, 30);
            this.textBoxdo.TabIndex = 32;
            // 
            // textBoxot
            // 
            this.textBoxot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxot.ForeColor = System.Drawing.Color.Black;
            this.textBoxot.Location = new System.Drawing.Point(61, 399);
            this.textBoxot.Name = "textBoxot";
            this.textBoxot.Size = new System.Drawing.Size(55, 30);
            this.textBoxot.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "До:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Від:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ціна:";
            // 
            // checkBox_6144
            // 
            this.checkBox_6144.AutoSize = true;
            this.checkBox_6144.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_6144.ForeColor = System.Drawing.Color.White;
            this.checkBox_6144.Location = new System.Drawing.Point(30, 292);
            this.checkBox_6144.Name = "checkBox_6144";
            this.checkBox_6144.Size = new System.Drawing.Size(67, 24);
            this.checkBox_6144.TabIndex = 27;
            this.checkBox_6144.Text = "6144";
            this.checkBox_6144.UseVisualStyleBackColor = true;
            this.checkBox_6144.CheckedChanged += new System.EventHandler(this.checkBox_6144_CheckedChanged);
            // 
            // checkBox_4096
            // 
            this.checkBox_4096.AutoSize = true;
            this.checkBox_4096.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_4096.ForeColor = System.Drawing.Color.White;
            this.checkBox_4096.Location = new System.Drawing.Point(30, 322);
            this.checkBox_4096.Name = "checkBox_4096";
            this.checkBox_4096.Size = new System.Drawing.Size(67, 24);
            this.checkBox_4096.TabIndex = 26;
            this.checkBox_4096.Text = "4096";
            this.checkBox_4096.UseVisualStyleBackColor = true;
            this.checkBox_4096.CheckedChanged += new System.EventHandler(this.checkBox_4096_CheckedChanged);
            // 
            // checkBox_8192
            // 
            this.checkBox_8192.AutoSize = true;
            this.checkBox_8192.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_8192.ForeColor = System.Drawing.Color.White;
            this.checkBox_8192.Location = new System.Drawing.Point(30, 262);
            this.checkBox_8192.Name = "checkBox_8192";
            this.checkBox_8192.Size = new System.Drawing.Size(67, 24);
            this.checkBox_8192.TabIndex = 25;
            this.checkBox_8192.Text = "8192";
            this.checkBox_8192.UseVisualStyleBackColor = true;
            this.checkBox_8192.CheckedChanged += new System.EventHandler(this.checkBox_8192_CheckedChanged);
            // 
            // checkBox_10240
            // 
            this.checkBox_10240.AutoSize = true;
            this.checkBox_10240.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_10240.ForeColor = System.Drawing.Color.White;
            this.checkBox_10240.Location = new System.Drawing.Point(30, 232);
            this.checkBox_10240.Name = "checkBox_10240";
            this.checkBox_10240.Size = new System.Drawing.Size(76, 24);
            this.checkBox_10240.TabIndex = 24;
            this.checkBox_10240.Text = "10240";
            this.checkBox_10240.UseVisualStyleBackColor = true;
            this.checkBox_10240.CheckedChanged += new System.EventHandler(this.checkBox_10240_CheckedChanged);
            // 
            // checkBox_12228
            // 
            this.checkBox_12228.AutoSize = true;
            this.checkBox_12228.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_12228.ForeColor = System.Drawing.Color.White;
            this.checkBox_12228.Location = new System.Drawing.Point(30, 202);
            this.checkBox_12228.Name = "checkBox_12228";
            this.checkBox_12228.Size = new System.Drawing.Size(76, 24);
            this.checkBox_12228.TabIndex = 23;
            this.checkBox_12228.Text = "12228";
            this.checkBox_12228.UseVisualStyleBackColor = true;
            this.checkBox_12228.CheckedChanged += new System.EventHandler(this.checkBox_12228_CheckedChanged);
            // 
            // checkBox_24576
            // 
            this.checkBox_24576.AutoSize = true;
            this.checkBox_24576.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_24576.ForeColor = System.Drawing.Color.White;
            this.checkBox_24576.Location = new System.Drawing.Point(30, 142);
            this.checkBox_24576.Name = "checkBox_24576";
            this.checkBox_24576.Size = new System.Drawing.Size(76, 24);
            this.checkBox_24576.TabIndex = 22;
            this.checkBox_24576.Text = "24576";
            this.checkBox_24576.UseVisualStyleBackColor = true;
            this.checkBox_24576.CheckedChanged += new System.EventHandler(this.checkBox_24576_CheckedChanged);
            // 
            // checkBox_16384
            // 
            this.checkBox_16384.AutoSize = true;
            this.checkBox_16384.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_16384.ForeColor = System.Drawing.Color.White;
            this.checkBox_16384.Location = new System.Drawing.Point(30, 172);
            this.checkBox_16384.Name = "checkBox_16384";
            this.checkBox_16384.Size = new System.Drawing.Size(76, 24);
            this.checkBox_16384.TabIndex = 21;
            this.checkBox_16384.Text = "16384";
            this.checkBox_16384.UseVisualStyleBackColor = true;
            this.checkBox_16384.CheckedChanged += new System.EventHandler(this.checkBox_16384_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Об`єм пам`яті:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Модель:";
            // 
            // checkBox_nvidia
            // 
            this.checkBox_nvidia.AutoSize = true;
            this.checkBox_nvidia.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_nvidia.ForeColor = System.Drawing.Color.White;
            this.checkBox_nvidia.Location = new System.Drawing.Point(30, 66);
            this.checkBox_nvidia.Name = "checkBox_nvidia";
            this.checkBox_nvidia.Size = new System.Drawing.Size(93, 24);
            this.checkBox_nvidia.TabIndex = 18;
            this.checkBox_nvidia.Text = "GeForce";
            this.checkBox_nvidia.UseVisualStyleBackColor = true;
            this.checkBox_nvidia.CheckedChanged += new System.EventHandler(this.checkBox_nvidia_CheckedChanged);
            // 
            // checkBox_amd
            // 
            this.checkBox_amd.AutoSize = true;
            this.checkBox_amd.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_amd.ForeColor = System.Drawing.Color.White;
            this.checkBox_amd.Location = new System.Drawing.Point(30, 36);
            this.checkBox_amd.Name = "checkBox_amd";
            this.checkBox_amd.Size = new System.Drawing.Size(86, 24);
            this.checkBox_amd.TabIndex = 17;
            this.checkBox_amd.Text = "Radeon";
            this.checkBox_amd.UseVisualStyleBackColor = true;
            this.checkBox_amd.CheckedChanged += new System.EventHandler(this.checkBox_amd_CheckedChanged);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(150, 102);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.Size = new System.Drawing.Size(1232, 651);
            this.dgv.TabIndex = 6;
            this.dgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentDoubleClick);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panelform);
            this.Controls.Add(this.paneltop);
            this.MinimumSize = new System.Drawing.Size(1400, 800);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель користувача";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelform.ResumeLayout(false);
            this.panelform.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Panel panelform;
        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox textBoxsearch;
        private System.Windows.Forms.Label labelfilt;
        private System.Windows.Forms.TextBox textBoxdo;
        private System.Windows.Forms.TextBox textBoxot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_6144;
        private System.Windows.Forms.CheckBox checkBox_4096;
        private System.Windows.Forms.CheckBox checkBox_8192;
        private System.Windows.Forms.CheckBox checkBox_10240;
        private System.Windows.Forms.CheckBox checkBox_12228;
        private System.Windows.Forms.CheckBox checkBox_24576;
        private System.Windows.Forms.CheckBox checkBox_16384;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox_nvidia;
        private System.Windows.Forms.CheckBox checkBox_amd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonok;
        private System.Windows.Forms.Label labelporiv;
        private System.Windows.Forms.Button button_poriv;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

