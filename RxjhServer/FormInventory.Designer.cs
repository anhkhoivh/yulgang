namespace YulgangServer.RxjhServer
{
    partial class FormInventory
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
            this.Reload = new System.Windows.Forms.Timer(this.components);
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picSubBag = new System.Windows.Forms.PictureBox();
            this.picAoGuild = new System.Windows.Forms.PictureBox();
            this.picPet = new System.Windows.Forms.PictureBox();
            this.picPhuKien = new System.Windows.Forms.PictureBox();
            this.picTayPhai = new System.Windows.Forms.PictureBox();
            this.picGiay = new System.Windows.Forms.PictureBox();
            this.picTayTrai = new System.Windows.Forms.PictureBox();
            this.picNhanPhai = new System.Windows.Forms.PictureBox();
            this.picAo = new System.Windows.Forms.PictureBox();
            this.picNhanTrai = new System.Windows.Forms.PictureBox();
            this.picBongTaiPhai = new System.Windows.Forms.PictureBox();
            this.picDayChuyen = new System.Windows.Forms.PictureBox();
            this.picBongTaiTrai = new System.Windows.Forms.PictureBox();
            this.picAoChoang = new System.Windows.Forms.PictureBox();
            this.picGiap = new System.Windows.Forms.PictureBox();
            this.picVuKhi = new System.Windows.Forms.PictureBox();
            this.picInventor = new System.Windows.Forms.PictureBox();
            this.picPET2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSubBag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAoGuild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhuKien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTayPhai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGiay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTayTrai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanPhai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanTrai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBongTaiPhai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDayChuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBongTaiTrai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAoChoang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGiap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVuKhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPET2)).BeginInit();
            this.SuspendLayout();
            // 
            // Reload
            // 
            this.Reload.Interval = 1000;
            this.Reload.Tick += new System.EventHandler(this.Reload_Tick);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(166, 23);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 34;
            this.btnSubmit.Text = "Khóa";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(15, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 185);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info Item";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(15, 25);
            this.txtUsername.MaxLength = 32;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(145, 20);
            this.txtUsername.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tên nhân vật:";
            // 
            // picSubBag
            // 
            this.picSubBag.Image = global::YulgangServer.Properties.Resources.window_inventory_sub_bag;
            this.picSubBag.Location = new System.Drawing.Point(12, 243);
            this.picSubBag.Name = "picSubBag";
            this.picSubBag.Size = new System.Drawing.Size(247, 254);
            this.picSubBag.TabIndex = 64;
            this.picSubBag.TabStop = false;
            // 
            // picAoGuild
            // 
            this.picAoGuild.BackColor = System.Drawing.Color.Transparent;
            this.picAoGuild.Location = new System.Drawing.Point(456, 159);
            this.picAoGuild.Name = "picAoGuild";
            this.picAoGuild.Size = new System.Drawing.Size(32, 32);
            this.picAoGuild.TabIndex = 63;
            this.picAoGuild.TabStop = false;
            this.picAoGuild.Tag = "13";
            this.picAoGuild.Visible = false;
            // 
            // picPet
            // 
            this.picPet.BackColor = System.Drawing.Color.Transparent;
            this.picPet.Location = new System.Drawing.Point(451, 204);
            this.picPet.Name = "picPet";
            this.picPet.Size = new System.Drawing.Size(32, 32);
            this.picPet.TabIndex = 62;
            this.picPet.TabStop = false;
            this.picPet.Tag = "14";
            this.picPet.Visible = false;
            this.picPet.Click += new System.EventHandler(this.picPet_Click);
            // 
            // picPhuKien
            // 
            this.picPhuKien.BackColor = System.Drawing.Color.Transparent;
            this.picPhuKien.Location = new System.Drawing.Point(451, 111);
            this.picPhuKien.Name = "picPhuKien";
            this.picPhuKien.Size = new System.Drawing.Size(32, 32);
            this.picPhuKien.TabIndex = 61;
            this.picPhuKien.TabStop = false;
            this.picPhuKien.Tag = "12";
            this.picPhuKien.Visible = false;
            // 
            // picTayPhai
            // 
            this.picTayPhai.BackColor = System.Drawing.Color.Transparent;
            this.picTayPhai.Location = new System.Drawing.Point(412, 176);
            this.picTayPhai.Name = "picTayPhai";
            this.picTayPhai.Size = new System.Drawing.Size(32, 32);
            this.picTayPhai.TabIndex = 60;
            this.picTayPhai.TabStop = false;
            this.picTayPhai.Tag = "2";
            this.picTayPhai.Visible = false;
            // 
            // picGiay
            // 
            this.picGiay.BackColor = System.Drawing.Color.Transparent;
            this.picGiay.Location = new System.Drawing.Point(376, 176);
            this.picGiay.Name = "picGiay";
            this.picGiay.Size = new System.Drawing.Size(32, 32);
            this.picGiay.TabIndex = 59;
            this.picGiay.TabStop = false;
            this.picGiay.Tag = "4";
            this.picGiay.Visible = false;
            // 
            // picTayTrai
            // 
            this.picTayTrai.BackColor = System.Drawing.Color.Transparent;
            this.picTayTrai.Location = new System.Drawing.Point(338, 176);
            this.picTayTrai.Name = "picTayTrai";
            this.picTayTrai.Size = new System.Drawing.Size(32, 32);
            this.picTayTrai.TabIndex = 58;
            this.picTayTrai.TabStop = false;
            this.picTayTrai.Tag = "1";
            this.picTayTrai.Visible = false;
            // 
            // picNhanPhai
            // 
            this.picNhanPhai.BackColor = System.Drawing.Color.Transparent;
            this.picNhanPhai.Location = new System.Drawing.Point(412, 138);
            this.picNhanPhai.Name = "picNhanPhai";
            this.picNhanPhai.Size = new System.Drawing.Size(32, 32);
            this.picNhanPhai.TabIndex = 57;
            this.picNhanPhai.TabStop = false;
            this.picNhanPhai.Tag = "10";
            this.picNhanPhai.Visible = false;
            // 
            // picAo
            // 
            this.picAo.BackColor = System.Drawing.Color.Transparent;
            this.picAo.Location = new System.Drawing.Point(375, 138);
            this.picAo.Name = "picAo";
            this.picAo.Size = new System.Drawing.Size(32, 32);
            this.picAo.TabIndex = 56;
            this.picAo.TabStop = false;
            this.picAo.Tag = "0";
            this.picAo.Visible = false;
            // 
            // picNhanTrai
            // 
            this.picNhanTrai.BackColor = System.Drawing.Color.Transparent;
            this.picNhanTrai.Location = new System.Drawing.Point(338, 138);
            this.picNhanTrai.Name = "picNhanTrai";
            this.picNhanTrai.Size = new System.Drawing.Size(32, 32);
            this.picNhanTrai.TabIndex = 55;
            this.picNhanTrai.TabStop = false;
            this.picNhanTrai.Tag = "9";
            this.picNhanTrai.Visible = false;
            // 
            // picBongTaiPhai
            // 
            this.picBongTaiPhai.BackColor = System.Drawing.Color.Transparent;
            this.picBongTaiPhai.Location = new System.Drawing.Point(412, 100);
            this.picBongTaiPhai.Name = "picBongTaiPhai";
            this.picBongTaiPhai.Size = new System.Drawing.Size(32, 32);
            this.picBongTaiPhai.TabIndex = 54;
            this.picBongTaiPhai.TabStop = false;
            this.picBongTaiPhai.Tag = "8";
            this.picBongTaiPhai.Visible = false;
            // 
            // picDayChuyen
            // 
            this.picDayChuyen.BackColor = System.Drawing.Color.Transparent;
            this.picDayChuyen.Location = new System.Drawing.Point(376, 100);
            this.picDayChuyen.Name = "picDayChuyen";
            this.picDayChuyen.Size = new System.Drawing.Size(32, 32);
            this.picDayChuyen.TabIndex = 53;
            this.picDayChuyen.TabStop = false;
            this.picDayChuyen.Tag = "6";
            this.picDayChuyen.Visible = false;
            // 
            // picBongTaiTrai
            // 
            this.picBongTaiTrai.BackColor = System.Drawing.Color.Transparent;
            this.picBongTaiTrai.Location = new System.Drawing.Point(338, 100);
            this.picBongTaiTrai.Name = "picBongTaiTrai";
            this.picBongTaiTrai.Size = new System.Drawing.Size(32, 32);
            this.picBongTaiTrai.TabIndex = 52;
            this.picBongTaiTrai.TabStop = false;
            this.picBongTaiTrai.Tag = "7";
            this.picBongTaiTrai.Visible = false;
            this.picBongTaiTrai.Click += new System.EventHandler(this.picBongTaiTrai_Click);
            // 
            // picAoChoang
            // 
            this.picAoChoang.BackColor = System.Drawing.Color.Transparent;
            this.picAoChoang.Location = new System.Drawing.Point(298, 204);
            this.picAoChoang.Name = "picAoChoang";
            this.picAoChoang.Size = new System.Drawing.Size(32, 32);
            this.picAoChoang.TabIndex = 51;
            this.picAoChoang.TabStop = false;
            this.picAoChoang.Tag = "11";
            this.picAoChoang.Visible = false;
            // 
            // picGiap
            // 
            this.picGiap.BackColor = System.Drawing.Color.Transparent;
            this.picGiap.Location = new System.Drawing.Point(293, 159);
            this.picGiap.Name = "picGiap";
            this.picGiap.Size = new System.Drawing.Size(32, 32);
            this.picGiap.TabIndex = 50;
            this.picGiap.TabStop = false;
            this.picGiap.Tag = "5";
            this.picGiap.Visible = false;
            // 
            // picVuKhi
            // 
            this.picVuKhi.BackColor = System.Drawing.Color.Transparent;
            this.picVuKhi.Location = new System.Drawing.Point(298, 111);
            this.picVuKhi.Name = "picVuKhi";
            this.picVuKhi.Size = new System.Drawing.Size(32, 32);
            this.picVuKhi.TabIndex = 49;
            this.picVuKhi.TabStop = false;
            this.picVuKhi.Tag = "3";
            this.picVuKhi.Visible = false;
            this.picVuKhi.Click += new System.EventHandler(this.picVuKhi_Click);
            // 
            // picInventor
            // 
            this.picInventor.Image = global::YulgangServer.Properties.Resources.window_inventory_bag;
            this.picInventor.Location = new System.Drawing.Point(267, 12);
            this.picInventor.Name = "picInventor";
            this.picInventor.Size = new System.Drawing.Size(247, 610);
            this.picInventor.TabIndex = 37;
            this.picInventor.TabStop = false;
            this.picInventor.Click += new System.EventHandler(this.picInventor_Click);
            // 
            // picPET2
            // 
            this.picPET2.BackColor = System.Drawing.Color.Transparent;
            this.picPET2.Location = new System.Drawing.Point(375, 214);
            this.picPET2.Name = "picPET2";
            this.picPET2.Size = new System.Drawing.Size(32, 32);
            this.picPET2.TabIndex = 65;
            this.picPET2.TabStop = false;
            this.picPET2.Tag = "14";
            this.picPET2.Visible = false;
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 631);
            this.Controls.Add(this.picPET2);
            this.Controls.Add(this.picSubBag);
            this.Controls.Add(this.picAoGuild);
            this.Controls.Add(this.picPet);
            this.Controls.Add(this.picPhuKien);
            this.Controls.Add(this.picTayPhai);
            this.Controls.Add(this.picGiay);
            this.Controls.Add(this.picTayTrai);
            this.Controls.Add(this.picNhanPhai);
            this.Controls.Add(this.picAo);
            this.Controls.Add(this.picNhanTrai);
            this.Controls.Add(this.picBongTaiPhai);
            this.Controls.Add(this.picDayChuyen);
            this.Controls.Add(this.picBongTaiTrai);
            this.Controls.Add(this.picAoChoang);
            this.Controls.Add(this.picGiap);
            this.Controls.Add(this.picVuKhi);
            this.Controls.Add(this.picInventor);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Name = "FormInventory";
            this.Text = "FormInventory";
            this.Load += new System.EventHandler(this.FormInventory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSubBag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAoGuild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhuKien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTayPhai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGiay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTayTrai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanPhai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanTrai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBongTaiPhai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDayChuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBongTaiTrai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAoChoang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGiap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVuKhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPET2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Reload;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label16;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picInventor;
        private System.Windows.Forms.PictureBox picAoGuild;
        private System.Windows.Forms.PictureBox picPet;
        private System.Windows.Forms.PictureBox picPhuKien;
        private System.Windows.Forms.PictureBox picTayPhai;
        private System.Windows.Forms.PictureBox picGiay;
        private System.Windows.Forms.PictureBox picTayTrai;
        private System.Windows.Forms.PictureBox picNhanPhai;
        private System.Windows.Forms.PictureBox picAo;
        private System.Windows.Forms.PictureBox picNhanTrai;
        private System.Windows.Forms.PictureBox picBongTaiPhai;
        private System.Windows.Forms.PictureBox picDayChuyen;
        private System.Windows.Forms.PictureBox picBongTaiTrai;
        private System.Windows.Forms.PictureBox picAoChoang;
        private System.Windows.Forms.PictureBox picGiap;
        private System.Windows.Forms.PictureBox picVuKhi;
        private System.Windows.Forms.PictureBox picSubBag;
        private System.Windows.Forms.PictureBox picPET2;
    }
}