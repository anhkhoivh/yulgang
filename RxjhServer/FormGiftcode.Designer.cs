namespace YulgangServer.RxjhServer
{
    partial class FormGiftcode
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiftcode = new System.Windows.Forms.TextBox();
            this.btnCreateGiftcode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbInfoItem = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.gbInfoItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giftcode : ";
            // 
            // txtGiftcode
            // 
            this.txtGiftcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtGiftcode.Location = new System.Drawing.Point(121, 50);
            this.txtGiftcode.MaxLength = 10;
            this.txtGiftcode.Name = "txtGiftcode";
            this.txtGiftcode.ReadOnly = true;
            this.txtGiftcode.Size = new System.Drawing.Size(139, 23);
            this.txtGiftcode.TabIndex = 2;
            this.txtGiftcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGiftcode.TextChanged += new System.EventHandler(this.txtGiftcode_TextChanged);
            // 
            // btnCreateGiftcode
            // 
            this.btnCreateGiftcode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreateGiftcode.Location = new System.Drawing.Point(124, 172);
            this.btnCreateGiftcode.Name = "btnCreateGiftcode";
            this.btnCreateGiftcode.Size = new System.Drawing.Size(100, 23);
            this.btnCreateGiftcode.TabIndex = 25;
            this.btnCreateGiftcode.Text = "Tạo giftcode";
            this.btnCreateGiftcode.UseVisualStyleBackColor = true;
            this.btnCreateGiftcode.Click += new System.EventHandler(this.btnCreateGiftcode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtGiftcode);
            this.groupBox1.Location = new System.Drawing.Point(3, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 115);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(23, 25);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(201, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Tạo thành công gift code cho tài khoản: ";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // gbInfoItem
            // 
            this.gbInfoItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInfoItem.Controls.Add(this.picItem);
            this.gbInfoItem.Controls.Add(this.label1);
            this.gbInfoItem.Controls.Add(this.txtDetail);
            this.gbInfoItem.Controls.Add(this.label5);
            this.gbInfoItem.Controls.Add(this.txtBonus);
            this.gbInfoItem.Controls.Add(this.label3);
            this.gbInfoItem.Controls.Add(this.txtCash);
            this.gbInfoItem.Controls.Add(this.label2);
            this.gbInfoItem.Controls.Add(this.txtUsername);
            this.gbInfoItem.Location = new System.Drawing.Point(3, 15);
            this.gbInfoItem.Name = "gbInfoItem";
            this.gbInfoItem.Size = new System.Drawing.Size(310, 151);
            this.gbInfoItem.TabIndex = 23;
            this.gbInfoItem.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Detail : ";
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(121, 116);
            this.txtDetail.MaxLength = 50;
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(139, 21);
            this.txtDetail.TabIndex = 6;
            this.txtDetail.Text = "TaoCode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bonus : ";
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(121, 76);
            this.txtBonus.MaxLength = 10;
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(100, 20);
            this.txtBonus.TabIndex = 4;
            this.txtBonus.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cash : ";
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(121, 50);
            this.txtCash.MaxLength = 10;
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(139, 20);
            this.txtCash.TabIndex = 2;
            this.txtCash.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tài khoản : ";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(121, 24);
            this.txtUsername.MaxLength = 15;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(139, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // picItem
            // 
            this.picItem.Location = new System.Drawing.Point(228, 78);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(32, 32);
            this.picItem.TabIndex = 26;
            this.picItem.TabStop = false;
            this.picItem.UseWaitCursor = true;
            this.picItem.WaitOnLoad = true;
            this.picItem.Click += new System.EventHandler(this.picItem_Click);
            // 
            // FormGiftcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 327);
            this.Controls.Add(this.btnCreateGiftcode);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbInfoItem);
            this.Name = "FormGiftcode";
            this.Text = "FormGiftcode";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbInfoItem.ResumeLayout(false);
            this.gbInfoItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiftcode;
        private System.Windows.Forms.Button btnCreateGiftcode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox gbInfoItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox picItem;
    }
}