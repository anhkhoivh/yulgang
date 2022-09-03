namespace YulgangServer.RxjhServer
{
    partial class FormWareHouse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtVoHuan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtHePhai = new System.Windows.Forms.TextBox();
            this.txtJobLv = new System.Windows.Forms.TextBox();
            this.txtTheLuc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Reload = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picKhoChung = new System.Windows.Forms.PictureBox();
            this.picVuKhi = new System.Windows.Forms.PictureBox();
            this.picKhoRieng = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKhoChung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVuKhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKhoRieng)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(156, 23);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 59;
            this.btnSubmit.Text = "Khóa";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(5, 25);
            this.txtUsername.MaxLength = 32;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(145, 20);
            this.txtUsername.TabIndex = 58;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Tên nhân vật:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 150);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 49;
            this.label16.Text = "Cash :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtCash);
            this.groupBox1.Controls.Add(this.txtLevel);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtVoHuan);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtMoney);
            this.groupBox1.Controls.Add(this.txtHePhai);
            this.groupBox1.Controls.Add(this.txtJobLv);
            this.groupBox1.Controls.Add(this.txtTheLuc);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(5, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 185);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info Item";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(145, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "LV : ";
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(73, 148);
            this.txtCash.MaxLength = 10;
            this.txtCash.Name = "txtCash";
            this.txtCash.ReadOnly = true;
            this.txtCash.Size = new System.Drawing.Size(147, 20);
            this.txtCash.TabIndex = 50;
            this.txtCash.TabStop = false;
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(180, 45);
            this.txtLevel.MaxLength = 10;
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.ReadOnly = true;
            this.txtLevel.Size = new System.Drawing.Size(40, 20);
            this.txtLevel.TabIndex = 15;
            this.txtLevel.TabStop = false;
            this.txtLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Võ huân : ";
            // 
            // txtVoHuan
            // 
            this.txtVoHuan.Location = new System.Drawing.Point(73, 122);
            this.txtVoHuan.MaxLength = 10;
            this.txtVoHuan.Name = "txtVoHuan";
            this.txtVoHuan.ReadOnly = true;
            this.txtVoHuan.Size = new System.Drawing.Size(147, 20);
            this.txtVoHuan.TabIndex = 12;
            this.txtVoHuan.TabStop = false;
            this.txtVoHuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Money : ";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(73, 96);
            this.txtMoney.MaxLength = 10;
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(147, 20);
            this.txtMoney.TabIndex = 10;
            this.txtMoney.TabStop = false;
            this.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHePhai
            // 
            this.txtHePhai.Location = new System.Drawing.Point(14, 70);
            this.txtHePhai.MaxLength = 10;
            this.txtHePhai.Name = "txtHePhai";
            this.txtHePhai.ReadOnly = true;
            this.txtHePhai.Size = new System.Drawing.Size(99, 20);
            this.txtHePhai.TabIndex = 8;
            this.txtHePhai.TabStop = false;
            this.txtHePhai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtJobLv
            // 
            this.txtJobLv.Location = new System.Drawing.Point(180, 70);
            this.txtJobLv.MaxLength = 10;
            this.txtJobLv.Name = "txtJobLv";
            this.txtJobLv.ReadOnly = true;
            this.txtJobLv.Size = new System.Drawing.Size(40, 20);
            this.txtJobLv.TabIndex = 7;
            this.txtJobLv.TabStop = false;
            this.txtJobLv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTheLuc
            // 
            this.txtTheLuc.Location = new System.Drawing.Point(119, 70);
            this.txtTheLuc.MaxLength = 10;
            this.txtTheLuc.Name = "txtTheLuc";
            this.txtTheLuc.ReadOnly = true;
            this.txtTheLuc.Size = new System.Drawing.Size(55, 20);
            this.txtTheLuc.TabIndex = 6;
            this.txtTheLuc.TabStop = false;
            this.txtTheLuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tên nhân vật :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(14, 45);
            this.txtName.MaxLength = 10;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(125, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TabStop = false;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Reload
            // 
            this.Reload.Interval = 1000;
            this.Reload.Tick += new System.EventHandler(this.Reload_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(590, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "3";
            this.pictureBox1.Visible = false;
            // 
            // picKhoChung
            // 
            this.picKhoChung.Image = global::YulgangServer.Properties.Resources.npc_window_store02;
            this.picKhoChung.Location = new System.Drawing.Point(550, 9);
            this.picKhoChung.Name = "picKhoChung";
            this.picKhoChung.Size = new System.Drawing.Size(280, 475);
            this.picKhoChung.TabIndex = 64;
            this.picKhoChung.TabStop = false;
            // 
            // picVuKhi
            // 
            this.picVuKhi.BackColor = System.Drawing.Color.Transparent;
            this.picVuKhi.Location = new System.Drawing.Point(307, 97);
            this.picVuKhi.Name = "picVuKhi";
            this.picVuKhi.Size = new System.Drawing.Size(32, 32);
            this.picVuKhi.TabIndex = 63;
            this.picVuKhi.TabStop = false;
            this.picVuKhi.Tag = "3";
            this.picVuKhi.Visible = false;
            // 
            // picKhoRieng
            // 
            this.picKhoRieng.Image = global::YulgangServer.Properties.Resources.npc_window_store01;
            this.picKhoRieng.Location = new System.Drawing.Point(266, 9);
            this.picKhoRieng.Name = "picKhoRieng";
            this.picKhoRieng.Size = new System.Drawing.Size(280, 475);
            this.picKhoRieng.TabIndex = 62;
            this.picKhoRieng.TabStop = false;
            // 
            // FormWareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 487);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picKhoChung);
            this.Controls.Add(this.picVuKhi);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picKhoRieng);
            this.Name = "FormWareHouse";
            this.Text = "FormWareHouse";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKhoChung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVuKhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKhoRieng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picKhoChung;
        private System.Windows.Forms.PictureBox picVuKhi;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtVoHuan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtHePhai;
        private System.Windows.Forms.TextBox txtJobLv;
        private System.Windows.Forms.TextBox txtTheLuc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Timer Reload;
        private System.Windows.Forms.PictureBox picKhoRieng;
    }
}