
namespace WinForms
{
    partial class FormEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEdit));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelname = new System.Windows.Forms.Label();
            this.buttonedit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxtechproc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxmemorytype = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxmemory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxmemorybus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxcore = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxshaderblock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxenergy = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelprice = new System.Windows.Forms.Label();
            this.textBoxprice = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelid = new System.Windows.Forms.Label();
            this.buttondel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxinfo = new System.Windows.Forms.TextBox();
            this.buttonimg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(98, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1000, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Редагування запису";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxname
            // 
            this.textBoxname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxname.Location = new System.Drawing.Point(279, 178);
            this.textBoxname.Multiline = true;
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(273, 33);
            this.textBoxname.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(550, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelname.Location = new System.Drawing.Point(183, 181);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(90, 33);
            this.labelname.TabIndex = 4;
            this.labelname.Text = "Назва:";
            // 
            // buttonedit
            // 
            this.buttonedit.FlatAppearance.BorderSize = 0;
            this.buttonedit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.buttonedit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonedit.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonedit.Location = new System.Drawing.Point(288, 654);
            this.buttonedit.Name = "buttonedit";
            this.buttonedit.Size = new System.Drawing.Size(264, 88);
            this.buttonedit.TabIndex = 6;
            this.buttonedit.Text = "Редагувати";
            this.buttonedit.UseVisualStyleBackColor = true;
            this.buttonedit.Click += new System.EventHandler(this.buttonedit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(126, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "Техпроцес:";
            // 
            // textBoxtechproc
            // 
            this.textBoxtechproc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxtechproc.Location = new System.Drawing.Point(279, 227);
            this.textBoxtechproc.Multiline = true;
            this.textBoxtechproc.Name = "textBoxtechproc";
            this.textBoxtechproc.Size = new System.Drawing.Size(273, 33);
            this.textBoxtechproc.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(111, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "Тип пам`яті:";
            // 
            // textBoxmemorytype
            // 
            this.textBoxmemorytype.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxmemorytype.Location = new System.Drawing.Point(279, 274);
            this.textBoxmemorytype.Multiline = true;
            this.textBoxmemorytype.Name = "textBoxmemorytype";
            this.textBoxmemorytype.Size = new System.Drawing.Size(273, 33);
            this.textBoxmemorytype.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(64, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 33);
            this.label4.TabIndex = 12;
            this.label4.Text = "Частота пам`яті:";
            // 
            // textBoxmemory
            // 
            this.textBoxmemory.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxmemory.Location = new System.Drawing.Point(279, 323);
            this.textBoxmemory.Multiline = true;
            this.textBoxmemory.Name = "textBoxmemory";
            this.textBoxmemory.Size = new System.Drawing.Size(273, 33);
            this.textBoxmemory.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(83, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 33);
            this.label5.TabIndex = 14;
            this.label5.Text = "Шина пам`яті:";
            // 
            // textBoxmemorybus
            // 
            this.textBoxmemorybus.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxmemorybus.Location = new System.Drawing.Point(279, 370);
            this.textBoxmemorybus.Multiline = true;
            this.textBoxmemorybus.Name = "textBoxmemorybus";
            this.textBoxmemorybus.Size = new System.Drawing.Size(273, 33);
            this.textBoxmemorybus.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(98, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 33);
            this.label6.TabIndex = 16;
            this.label6.Text = "Частота ядра:";
            // 
            // textBoxcore
            // 
            this.textBoxcore.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxcore.Location = new System.Drawing.Point(279, 418);
            this.textBoxcore.Multiline = true;
            this.textBoxcore.Name = "textBoxcore";
            this.textBoxcore.Size = new System.Drawing.Size(273, 33);
            this.textBoxcore.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(29, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 33);
            this.label7.TabIndex = 18;
            this.label7.Text = "Шейдерних блоків:";
            // 
            // textBoxshaderblock
            // 
            this.textBoxshaderblock.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxshaderblock.Location = new System.Drawing.Point(279, 467);
            this.textBoxshaderblock.Multiline = true;
            this.textBoxshaderblock.Name = "textBoxshaderblock";
            this.textBoxshaderblock.Size = new System.Drawing.Size(273, 33);
            this.textBoxshaderblock.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(25, 517);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(248, 33);
            this.label8.TabIndex = 20;
            this.label8.Text = "Енергоспоживання:";
            // 
            // textBoxenergy
            // 
            this.textBoxenergy.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxenergy.Location = new System.Drawing.Point(279, 517);
            this.textBoxenergy.Multiline = true;
            this.textBoxenergy.Name = "textBoxenergy";
            this.textBoxenergy.Size = new System.Drawing.Size(273, 33);
            this.textBoxenergy.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(94, 565);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 33);
            this.label9.TabIndex = 22;
            this.label9.Text = "Дата випуску:";
            // 
            // labelprice
            // 
            this.labelprice.AutoSize = true;
            this.labelprice.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelprice.Location = new System.Drawing.Point(144, 615);
            this.labelprice.Name = "labelprice";
            this.labelprice.Size = new System.Drawing.Size(125, 33);
            this.labelprice.TabIndex = 24;
            this.labelprice.Text = "Вартість:";
            // 
            // textBoxprice
            // 
            this.textBoxprice.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxprice.Location = new System.Drawing.Point(279, 615);
            this.textBoxprice.Multiline = true;
            this.textBoxprice.Name = "textBoxprice";
            this.textBoxprice.Size = new System.Drawing.Size(273, 33);
            this.textBoxprice.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(279, 566);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(273, 34);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelid.Location = new System.Drawing.Point(782, 117);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(0, 45);
            this.labelid.TabIndex = 26;
            // 
            // buttondel
            // 
            this.buttondel.FlatAppearance.BorderSize = 0;
            this.buttondel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.buttondel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttondel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttondel.Location = new System.Drawing.Point(558, 654);
            this.buttondel.Name = "buttondel";
            this.buttondel.Size = new System.Drawing.Size(276, 88);
            this.buttondel.TabIndex = 27;
            this.buttondel.Text = "Видалити";
            this.buttondel.UseVisualStyleBackColor = true;
            this.buttondel.Click += new System.EventHandler(this.buttondel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(560, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 33);
            this.label10.TabIndex = 28;
            this.label10.Text = "Картинка:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(560, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(341, 33);
            this.label11.TabIndex = 29;
            this.label11.Text = "Інформація про відеокарту:";
            // 
            // textBoxinfo
            // 
            this.textBoxinfo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxinfo.Location = new System.Drawing.Point(561, 274);
            this.textBoxinfo.Multiline = true;
            this.textBoxinfo.Name = "textBoxinfo";
            this.textBoxinfo.Size = new System.Drawing.Size(609, 374);
            this.textBoxinfo.TabIndex = 30;
            // 
            // buttonimg
            // 
            this.buttonimg.ForeColor = System.Drawing.Color.Black;
            this.buttonimg.Location = new System.Drawing.Point(702, 181);
            this.buttonimg.Name = "buttonimg";
            this.buttonimg.Size = new System.Drawing.Size(144, 29);
            this.buttonimg.TabIndex = 31;
            this.buttonimg.Text = "Завантажити";
            this.buttonimg.UseVisualStyleBackColor = true;
            this.buttonimg.Click += new System.EventHandler(this.buttonimg_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.buttonimg);
            this.Controls.Add(this.textBoxinfo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttondel);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelprice);
            this.Controls.Add(this.textBoxprice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxenergy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxshaderblock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxcore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxmemorybus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxmemory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxmemorytype);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxtechproc);
            this.Controls.Add(this.buttonedit);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1201, 801);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "FormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редагування запису";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEdit_FormClosed);
            this.Load += new System.EventHandler(this.FormAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Button buttonedit;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxtechproc;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxmemorytype;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxmemory;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxmemorybus;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxcore;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textBoxshaderblock;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBoxenergy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelprice;
        public System.Windows.Forms.TextBox textBoxprice;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Button buttondel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox textBoxinfo;
        private System.Windows.Forms.Button buttonimg;
    }
}

