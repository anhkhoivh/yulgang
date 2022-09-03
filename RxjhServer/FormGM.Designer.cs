namespace YulgangServer.RxjhServer
{
    partial class FormGM
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.checkKhoa = new System.Windows.Forms.CheckBox();
            this.cbPhamChat = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbTrungCapLV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVoHuan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.cbTrungCap = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.cbTinhNgo = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbThuocTinhLv = new System.Windows.Forms.ComboBox();
            this.cbCuongHoa = new System.Windows.Forms.ComboBox();
            this.cbItemType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtHePhai = new System.Windows.Forms.TextBox();
            this.txtIDItem = new System.Windows.Forms.TextBox();
            this.txtJobLv = new System.Windows.Forms.TextBox();
            this.txtOption4 = new System.Windows.Forms.TextBox();
            this.txtOption3 = new System.Windows.Forms.TextBox();
            this.txtOption2 = new System.Windows.Forms.TextBox();
            this.txtTheLuc = new System.Windows.Forms.TextBox();
            this.txtOption1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbThuocTinh = new System.Windows.Forms.ComboBox();
            this.cbOption3 = new System.Windows.Forms.ComboBox();
            this.cbOption1 = new System.Windows.Forms.ComboBox();
            this.cbOption4 = new System.Windows.Forms.ComboBox();
            this.gbInfoItem = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.SaoNgaySuDung = new System.Windows.Forms.TextBox();
            this.numSoluong = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.cbOption2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbInfoItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoluong)).BeginInit();
            this.SuspendLayout();
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
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(73, 148);
            this.txtCash.MaxLength = 10;
            this.txtCash.Name = "txtCash";
            this.txtCash.ReadOnly = true;
            this.txtCash.Size = new System.Drawing.Size(147, 20);
            this.txtCash.TabIndex = 14;
            this.txtCash.TabStop = false;
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // checkKhoa
            // 
            this.checkKhoa.AutoSize = true;
            this.checkKhoa.Enabled = false;
            this.checkKhoa.Location = new System.Drawing.Point(200, 54);
            this.checkKhoa.Name = "checkKhoa";
            this.checkKhoa.Size = new System.Drawing.Size(51, 17);
            this.checkKhoa.TabIndex = 2;
            this.checkKhoa.Text = "Khóa";
            this.checkKhoa.UseVisualStyleBackColor = true;
            this.checkKhoa.CheckedChanged += new System.EventHandler(this.checkKhoa_CheckedChanged);
            // 
            // cbPhamChat
            // 
            this.cbPhamChat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhamChat.Enabled = false;
            this.cbPhamChat.FormattingEnabled = true;
            this.cbPhamChat.Items.AddRange(new object[] {
            "Thường",
            "Khá tốt",
            "Cao cấp"});
            this.cbPhamChat.Location = new System.Drawing.Point(81, 103);
            this.cbPhamChat.Name = "cbPhamChat";
            this.cbPhamChat.Size = new System.Drawing.Size(102, 21);
            this.cbPhamChat.TabIndex = 3;
            this.cbPhamChat.SelectedIndexChanged += new System.EventHandler(this.cbPhamChat_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 150);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Cash :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Phẩm chất : ";
            // 
            // cbTrungCapLV
            // 
            this.cbTrungCapLV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrungCapLV.Enabled = false;
            this.cbTrungCapLV.FormattingEnabled = true;
            this.cbTrungCapLV.Location = new System.Drawing.Point(189, 324);
            this.cbTrungCapLV.Name = "cbTrungCapLV";
            this.cbTrungCapLV.Size = new System.Drawing.Size(45, 21);
            this.cbTrungCapLV.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Item :";
            // 
            // txtVoHuan
            // 
            this.txtVoHuan.Location = new System.Drawing.Point(73, 122);
            this.txtVoHuan.MaxLength = 20;
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
            // picItem
            // 
            this.picItem.Location = new System.Drawing.Point(226, 19);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(32, 32);
            this.picItem.TabIndex = 4;
            this.picItem.TabStop = false;
            // 
            // cbTrungCap
            // 
            this.cbTrungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrungCap.Enabled = false;
            this.cbTrungCap.FormattingEnabled = true;
            this.cbTrungCap.Items.AddRange(new object[] {
            "Phục Cừu",
            "Hấp Hồn",
            "Kì Duyên",
            "Phẫn Nộ",
            "Di Tinh",
            "Hộ Thể",
            "Hỗn Nguyên"});
            this.cbTrungCap.Location = new System.Drawing.Point(81, 324);
            this.cbTrungCap.Name = "cbTrungCap";
            this.cbTrungCap.Size = new System.Drawing.Size(102, 21);
            this.cbTrungCap.TabIndex = 16;
            this.cbTrungCap.SelectedIndexChanged += new System.EventHandler(this.cbTrungCap_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 327);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Trung cấp :";
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
            // cbTinhNgo
            // 
            this.cbTinhNgo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTinhNgo.Enabled = false;
            this.cbTinhNgo.FormattingEnabled = true;
            this.cbTinhNgo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbTinhNgo.Location = new System.Drawing.Point(81, 297);
            this.cbTinhNgo.Name = "cbTinhNgo";
            this.cbTinhNgo.Size = new System.Drawing.Size(52, 21);
            this.cbTinhNgo.TabIndex = 15;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Tỉnh ngộ :";
            // 
            // cbThuocTinhLv
            // 
            this.cbThuocTinhLv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThuocTinhLv.Enabled = false;
            this.cbThuocTinhLv.FormattingEnabled = true;
            this.cbThuocTinhLv.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbThuocTinhLv.Location = new System.Drawing.Point(189, 158);
            this.cbThuocTinhLv.Name = "cbThuocTinhLv";
            this.cbThuocTinhLv.Size = new System.Drawing.Size(45, 21);
            this.cbThuocTinhLv.TabIndex = 6;
            this.cbThuocTinhLv.SelectedIndexChanged += new System.EventHandler(this.cbThuocTinhLv_SelectedIndexChanged);
            // 
            // cbCuongHoa
            // 
            this.cbCuongHoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCuongHoa.Enabled = false;
            this.cbCuongHoa.FormattingEnabled = true;
            this.cbCuongHoa.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cbCuongHoa.Location = new System.Drawing.Point(81, 130);
            this.cbCuongHoa.Name = "cbCuongHoa";
            this.cbCuongHoa.Size = new System.Drawing.Size(45, 21);
            this.cbCuongHoa.TabIndex = 4;
            this.cbCuongHoa.SelectedIndexChanged += new System.EventHandler(this.cbCuongHoa_SelectedIndexChanged);
            // 
            // cbItemType
            // 
            this.cbItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItemType.Enabled = false;
            this.cbItemType.FormattingEnabled = true;
            this.cbItemType.Items.AddRange(new object[] {
            "(None)",
            "Vũ Khí",
            "Trang Bị",
            "Trang sức"});
            this.cbItemType.Location = new System.Drawing.Point(81, 50);
            this.cbItemType.Name = "cbItemType";
            this.cbItemType.Size = new System.Drawing.Size(102, 21);
            this.cbItemType.TabIndex = 1;
            this.cbItemType.SelectedIndexChanged += new System.EventHandler(this.cbItemType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Thể loại :";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(73, 96);
            this.txtMoney.MaxLength = 20;
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(147, 20);
            this.txtMoney.TabIndex = 10;
            this.txtMoney.TabStop = false;
            this.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMoney.Visible = false;
            this.txtMoney.TextChanged += new System.EventHandler(this.txtMoney_TextChanged);
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
            // txtIDItem
            // 
            this.txtIDItem.Enabled = false;
            this.txtIDItem.Location = new System.Drawing.Point(81, 24);
            this.txtIDItem.MaxLength = 10;
            this.txtIDItem.Name = "txtIDItem";
            this.txtIDItem.Size = new System.Drawing.Size(139, 20);
            this.txtIDItem.TabIndex = 0;
            this.txtIDItem.TextChanged += new System.EventHandler(this.txtIDItem_TextChanged);
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
            // txtOption4
            // 
            this.txtOption4.Enabled = false;
            this.txtOption4.Location = new System.Drawing.Point(189, 271);
            this.txtOption4.MaxLength = 2;
            this.txtOption4.Name = "txtOption4";
            this.txtOption4.Size = new System.Drawing.Size(45, 20);
            this.txtOption4.TabIndex = 14;
            this.txtOption4.Text = "0";
            this.txtOption4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOption3
            // 
            this.txtOption3.Enabled = false;
            this.txtOption3.Location = new System.Drawing.Point(189, 245);
            this.txtOption3.MaxLength = 2;
            this.txtOption3.Name = "txtOption3";
            this.txtOption3.Size = new System.Drawing.Size(45, 20);
            this.txtOption3.TabIndex = 12;
            this.txtOption3.Text = "0";
            this.txtOption3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOption2
            // 
            this.txtOption2.Enabled = false;
            this.txtOption2.Location = new System.Drawing.Point(189, 216);
            this.txtOption2.MaxLength = 2;
            this.txtOption2.Name = "txtOption2";
            this.txtOption2.Size = new System.Drawing.Size(45, 20);
            this.txtOption2.TabIndex = 10;
            this.txtOption2.Text = "0";
            this.txtOption2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // txtOption1
            // 
            this.txtOption1.Enabled = false;
            this.txtOption1.Location = new System.Drawing.Point(189, 188);
            this.txtOption1.MaxLength = 2;
            this.txtOption1.Name = "txtOption1";
            this.txtOption1.Size = new System.Drawing.Size(45, 20);
            this.txtOption1.TabIndex = 8;
            this.txtOption1.Text = "0";
            this.txtOption1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtLevel);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtCash);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtVoHuan);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtMoney);
            this.groupBox1.Controls.Add(this.txtHePhai);
            this.groupBox1.Controls.Add(this.txtJobLv);
            this.groupBox1.Controls.Add(this.txtTheLuc);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(16, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 185);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info Item";
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
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(167, 20);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 32;
            this.btnSubmit.Text = "Khóa";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Blue;
            this.lblStatus.Location = new System.Drawing.Point(245, 361);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 37;
            // 
            // cbThuocTinh
            // 
            this.cbThuocTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThuocTinh.Enabled = false;
            this.cbThuocTinh.FormattingEnabled = true;
            this.cbThuocTinh.Items.AddRange(new object[] {
            "Hỏa Công",
            "Thủy Công",
            "Phong Công",
            "Nội Công",
            "Ngoại Công",
            "Độc Công"});
            this.cbThuocTinh.Location = new System.Drawing.Point(81, 158);
            this.cbThuocTinh.Name = "cbThuocTinh";
            this.cbThuocTinh.Size = new System.Drawing.Size(102, 21);
            this.cbThuocTinh.TabIndex = 5;
            this.cbThuocTinh.SelectedIndexChanged += new System.EventHandler(this.cbThuocTinh_SelectedIndexChanged);
            // 
            // cbOption3
            // 
            this.cbOption3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOption3.Enabled = false;
            this.cbOption3.FormattingEnabled = true;
            this.cbOption3.ItemHeight = 13;
            this.cbOption3.Items.AddRange(new object[] {
            "Công lực",
            "Phòng ngự",
            "Sinh mệnh",
            "Nội công",
            "Chính xác",
            "Né tránh",
            "Công lực võ công",
            "Khí công",
            "May mắn",
            "Đả kích",
            "Phòng ngự võ công",
            "Xác xuất nhận tiền",
            "Giảm tổn thất EXP"});
            this.cbOption3.Location = new System.Drawing.Point(81, 242);
            this.cbOption3.Name = "cbOption3";
            this.cbOption3.Size = new System.Drawing.Size(102, 21);
            this.cbOption3.TabIndex = 11;
            this.cbOption3.SelectedIndexChanged += new System.EventHandler(this.cbOption3_SelectedIndexChanged);
            // 
            // cbOption1
            // 
            this.cbOption1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOption1.Enabled = false;
            this.cbOption1.FormattingEnabled = true;
            this.cbOption1.Items.AddRange(new object[] {
            "Công lực",
            "Phòng ngự",
            "Sinh mệnh",
            "Nội công",
            "Chính xác",
            "Né tránh",
            "Công lực võ công",
            "Khí công",
            "May mắn",
            "Đả kích",
            "Phòng ngự võ công",
            "Xác xuất nhận tiền",
            "Giảm tổn thất EXP"});
            this.cbOption1.Location = new System.Drawing.Point(81, 185);
            this.cbOption1.Name = "cbOption1";
            this.cbOption1.Size = new System.Drawing.Size(102, 21);
            this.cbOption1.TabIndex = 7;
            this.cbOption1.SelectedIndexChanged += new System.EventHandler(this.cbOption1_SelectedIndexChanged);
            // 
            // cbOption4
            // 
            this.cbOption4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOption4.Enabled = false;
            this.cbOption4.FormattingEnabled = true;
            this.cbOption4.Items.AddRange(new object[] {
            "Công lực",
            "Phòng ngự",
            "Sinh mệnh",
            "Nội công",
            "Chính xác",
            "Né tránh",
            "Công lực võ công",
            "Khí công",
            "May mắn",
            "Đả kích",
            "Phòng ngự võ công",
            "Xác xuất nhận tiền",
            "Giảm tổn thất EXP"});
            this.cbOption4.Location = new System.Drawing.Point(81, 270);
            this.cbOption4.Name = "cbOption4";
            this.cbOption4.Size = new System.Drawing.Size(102, 21);
            this.cbOption4.TabIndex = 13;
            this.cbOption4.SelectedIndexChanged += new System.EventHandler(this.cbOption4_SelectedIndexChanged);
            // 
            // gbInfoItem
            // 
            this.gbInfoItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gbInfoItem.Controls.Add(this.label19);
            this.gbInfoItem.Controls.Add(this.SaoNgaySuDung);
            this.gbInfoItem.Controls.Add(this.numSoluong);
            this.gbInfoItem.Controls.Add(this.label18);
            this.gbInfoItem.Controls.Add(this.checkKhoa);
            this.gbInfoItem.Controls.Add(this.cbPhamChat);
            this.gbInfoItem.Controls.Add(this.label12);
            this.gbInfoItem.Controls.Add(this.cbTrungCapLV);
            this.gbInfoItem.Controls.Add(this.label2);
            this.gbInfoItem.Controls.Add(this.picItem);
            this.gbInfoItem.Controls.Add(this.cbTrungCap);
            this.gbInfoItem.Controls.Add(this.label11);
            this.gbInfoItem.Controls.Add(this.cbTinhNgo);
            this.gbInfoItem.Controls.Add(this.label10);
            this.gbInfoItem.Controls.Add(this.cbThuocTinhLv);
            this.gbInfoItem.Controls.Add(this.cbCuongHoa);
            this.gbInfoItem.Controls.Add(this.cbItemType);
            this.gbInfoItem.Controls.Add(this.label3);
            this.gbInfoItem.Controls.Add(this.txtIDItem);
            this.gbInfoItem.Controls.Add(this.txtOption4);
            this.gbInfoItem.Controls.Add(this.txtOption3);
            this.gbInfoItem.Controls.Add(this.txtOption2);
            this.gbInfoItem.Controls.Add(this.txtOption1);
            this.gbInfoItem.Controls.Add(this.cbThuocTinh);
            this.gbInfoItem.Controls.Add(this.cbOption4);
            this.gbInfoItem.Controls.Add(this.cbOption3);
            this.gbInfoItem.Controls.Add(this.cbOption2);
            this.gbInfoItem.Controls.Add(this.cbOption1);
            this.gbInfoItem.Controls.Add(this.label9);
            this.gbInfoItem.Controls.Add(this.label8);
            this.gbInfoItem.Controls.Add(this.label7);
            this.gbInfoItem.Controls.Add(this.label6);
            this.gbInfoItem.Controls.Add(this.label5);
            this.gbInfoItem.Controls.Add(this.label4);
            this.gbInfoItem.Location = new System.Drawing.Point(248, 9);
            this.gbInfoItem.Name = "gbInfoItem";
            this.gbInfoItem.Size = new System.Drawing.Size(270, 358);
            this.gbInfoItem.TabIndex = 33;
            this.gbInfoItem.TabStop = false;
            this.gbInfoItem.Text = "Info Item";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(139, 300);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 13);
            this.label19.TabIndex = 35;
            this.label19.Text = "Ngày SD:";
            // 
            // SaoNgaySuDung
            // 
            this.SaoNgaySuDung.Enabled = false;
            this.SaoNgaySuDung.Location = new System.Drawing.Point(189, 297);
            this.SaoNgaySuDung.MaxLength = 2;
            this.SaoNgaySuDung.Name = "SaoNgaySuDung";
            this.SaoNgaySuDung.Size = new System.Drawing.Size(45, 20);
            this.SaoNgaySuDung.TabIndex = 34;
            this.SaoNgaySuDung.Text = "0";
            this.SaoNgaySuDung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numSoluong
            // 
            this.numSoluong.Enabled = false;
            this.numSoluong.Location = new System.Drawing.Point(81, 78);
            this.numSoluong.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numSoluong.Name = "numSoluong";
            this.numSoluong.Size = new System.Drawing.Size(45, 20);
            this.numSoluong.TabIndex = 32;
            this.numSoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 78);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "Số lượng : ";
            // 
            // cbOption2
            // 
            this.cbOption2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOption2.Enabled = false;
            this.cbOption2.FormattingEnabled = true;
            this.cbOption2.Items.AddRange(new object[] {
            "Công lực",
            "Phòng ngự",
            "Sinh mệnh",
            "Nội công",
            "Chính xác",
            "Né tránh",
            "Công lực võ công",
            "Khí công",
            "May mắn",
            "Đả kích",
            "Phòng ngự võ công",
            "Xác xuất nhận tiền",
            "Giảm tổn thất EXP"});
            this.cbOption2.Location = new System.Drawing.Point(81, 213);
            this.cbOption2.Name = "cbOption2";
            this.cbOption2.Size = new System.Drawing.Size(102, 21);
            this.cbOption2.TabIndex = 9;
            this.cbOption2.SelectedIndexChanged += new System.EventHandler(this.cbOption2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Dòng 4:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Dòng 3:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Dòng 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Dòng 1 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Thuộc tính :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cường hóa :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tên nhân vật:";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(351, 373);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 23);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(16, 22);
            this.txtUsername.MaxLength = 32;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(145, 20);
            this.txtUsername.TabIndex = 31;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // FormGM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 403);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.gbInfoItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtUsername);
            this.Name = "FormGM";
            this.Text = "FormGM";
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbInfoItem.ResumeLayout(false);
            this.gbInfoItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkKhoa;
        private System.Windows.Forms.ComboBox cbPhamChat;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbTrungCapLV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVoHuan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox picItem;
        private System.Windows.Forms.ComboBox cbTrungCap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.ComboBox cbTinhNgo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbThuocTinhLv;
        private System.Windows.Forms.ComboBox cbCuongHoa;
        private System.Windows.Forms.ComboBox cbItemType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtHePhai;
        private System.Windows.Forms.TextBox txtIDItem;
        private System.Windows.Forms.TextBox txtJobLv;
        private System.Windows.Forms.TextBox txtOption4;
        private System.Windows.Forms.TextBox txtOption3;
        private System.Windows.Forms.TextBox txtOption2;
        private System.Windows.Forms.TextBox txtTheLuc;
        private System.Windows.Forms.TextBox txtOption1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbThuocTinh;
        private System.Windows.Forms.ComboBox cbOption3;
        private System.Windows.Forms.ComboBox cbOption1;
        private System.Windows.Forms.ComboBox cbOption4;
        private System.Windows.Forms.GroupBox gbInfoItem;
        private System.Windows.Forms.ComboBox cbOption2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numSoluong;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox SaoNgaySuDung;

    }
}