using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RxjhServer;
using System.IO;
using RxjhServer.RxjhServer;

namespace YulgangServer.RxjhServer
{
    public partial class FormWareHouse : Form
    {
        public FormWareHouse()
        {
            InitializeComponent();
        }
        Players Player;
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnSubmit.Text == "Khóa")
            {
                if (txtUsername.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập tên nhân vật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                foreach (Players players in World.AllConnectedChars.Values)
                {
                    if (players.UserName == txtUsername.Text.Trim())
                    {
                        txtUsername.Enabled = false;
                        this.Player = players;

                        btnSubmit.Text = "Mở khóa";

                        LoadUserInfo();
                        Reload.Start();

                        HamTaoKhoRieng();
                        HamTaoKhoChung();
                    }
                }
                if (this.Player == null)
                    MessageBox.Show("Tên nhân vật không đúng hoặc nhân vật không online!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (btnSubmit.Text == "Mở khóa")
            {
                btnSubmit.Text = "Khóa";
                Reload.Stop();
                KhoaHet();
            }
        }

        void LoadUserInfo()
        {
            txtName.Text = Player.UserName;
            txtLevel.Text = Player.Player_Level.ToString();
            string Job = "";
            switch (Player.Player_Job)
            {
                case 1:
                    Job = "Đao Khách";
                    break;
                case 2:
                    Job = "Kiếm Khách";
                    break;
                case 3:
                    Job = "Thương Khách";
                    break;
                case 4:
                    Job = "Cung Thủ";
                    break;
                case 5:
                    Job = "Đại Phu";
                    break;
                case 6:
                    Job = "Thích Khách";
                    break;
                case 7:
                    Job = "Cầm Sư";
                    break;
                case 8:
                    Job = "Hàn Bảo Quân";
                    break;
                case 9:
                    Job = "Đàm Hoa Liên";
                    break;
                case 10:
                    Job = "Quyền Sư";
                    break;
                case 11:
                    Job = "Diệu yến";
                    break;
                case 12:
                    Job = "Tử hào";
                    break;
            }
            txtHePhai.Text = Job;
            string Zx = "";
            switch (Player.Player_Zx)
            {
                case 1:
                    Zx = "Chính";
                    break;

                case 2:
                    Zx = "Tà";
                    break;

                default:
                    Zx = "Không";
                    break;
            }
            txtTheLuc.Text = Zx;
            txtJobLv.Text = Player.Player_Job_Level.ToString();
            txtMoney.Text = Player.Player_Money.ToString("D3");
            txtVoHuan.Text = Player.Player_WuXun.ToString("D3");
            txtCash.Text = Player.FLD_RXPIONT.ToString("D3");

            //LoadInventor();
        }

        private void KhoaHet()
        {

            txtUsername.Enabled = true;

            txtName.Clear();
            txtLevel.Clear();
            txtHePhai.Clear();
            txtTheLuc.Clear();
            txtJobLv.Clear();
            txtMoney.Clear();
            txtVoHuan.Clear();

            Player = null;

            HideInventor();
        }

        private void HideInventor()
        {
            foreach (PictureBox ViTri in KhoChung)
            {
                ViTri.Visible = false;
            }
            foreach (PictureBox ViTri in KhoRieng)
            {
                ViTri.Visible = false;
            }
        }

        PictureBox ViTriKhoDo;
        List<PictureBox> KhoRieng;
        List<PictureBox> KhoChung;

        private void HamTaoKhoRieng()
        {
            KhoRieng = new List<PictureBox>();
            for (int i = 0; i < 60; i++)
            {
                var name = string.Format("KhoRiengViTri{0}", i);
                ViTriKhoDo = new PictureBox();
                ViTriKhoDo.Tag = i;
                ViTriKhoDo.BackColor = Color.Black;
                ViTriKhoDo.Size = new Size(32, 32);
                ViTriKhoDo.Visible = false;
                int Vitri = i % 6;
                int SoDong = i / 6;
                int X = 306 + 33 * Vitri;
                int Y = 94 + 35 * SoDong;
                Point point = new Point(X, Y);
                ViTriKhoDo.Location = point;
                this.Controls.Add(ViTriKhoDo);
                KhoRieng.Add(ViTriKhoDo);
                ViTriKhoDo.BringToFront();
                ViTriKhoDo.Click += HienThiInfo;
                ViTriKhoDo.Name = name;
            }
            GetKhoRiengItem();
        }
        private void GetKhoRiengItem()
        {
            for (int i = 0; i < 60; i++)
            {
                int ItemID = BitConverter.ToInt32(Player.个人仓库[i].VAT_PHAM_ID, 0);//个人仓库 - > kho rieng
                var name = string.Format("KhoRiengViTri{0}", i);
                foreach (PictureBox ViTri in KhoRieng)
                {
                    if (ViTri.Name == name)
                    {
                        if (File.Exists(string.Format(@"Items\{0}.jpg", ItemID)) && ItemID != 0)
                        {
                            ViTri.Image = Image.FromFile(string.Format(@"Items\{0}.jpg", ItemID));
                            ViTri.Visible = true;
                        }
                        else
                        {
                            ViTri.Visible = false;
                        }
                    }
                }
            }
        }
        private void HamTaoKhoChung()
        {
            KhoChung = new List<PictureBox>();
            for (int i = 0; i < 60; i++)
            {
                var name = string.Format("KhoChungViTri{0}", i);
                ViTriKhoDo = new PictureBox();
                ViTriKhoDo.Tag = i + 100;
                ViTriKhoDo.BackColor = Color.Black;
                ViTriKhoDo.Size = new Size(32, 32);
                ViTriKhoDo.Visible = false;
                int Vitri = i % 6;
                int SoDong = i / 6;
                int X = 592 + 33 * Vitri;
                int Y = 94 + 35 * SoDong;
                Point point = new Point(X, Y);
                ViTriKhoDo.Location = point;
                this.Controls.Add(ViTriKhoDo);
                KhoChung.Add(ViTriKhoDo);
                ViTriKhoDo.BringToFront();
                ViTriKhoDo.Click += HienThiInfo;
                ViTriKhoDo.Name = name;
            }
            GetKhoChungItem();
        }

        private void GetKhoChungItem()
        {
            for (int i = 0; i < 60; i++)
            {
                int ItemID = BitConverter.ToInt32(Player.公共仓库[i].VAT_PHAM_ID, 0);// 公共仓库 - > kho chung

                var name = string.Format("KhoChungViTri{0}", i);
                foreach (PictureBox ViTri in KhoChung)
                {
                    if (ViTri.Name == name)
                    {
                        if (File.Exists(string.Format(@"Items\{0}.jpg", ItemID)) && ItemID != 0)
                        {
                            ViTri.Image = Image.FromFile(string.Format(@"Items\{0}.jpg", ItemID));
                            ViTri.Visible = true;
                        }
                        else
                        {
                            ViTri.Visible = false;
                        }
                    }
                }
            }
        }

        private void HienThiInfo(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((PictureBox)sender).Tag);

            if (index < 100)
            {
                if (GetItemID(index, 0) != 0)
                {
                    ItemInfo Info = new ItemInfo(GetItemID(index, 0), GetItemID(index, 0).ToString(), GetItemPhamChat(index, 0), GetItemCuongHoa(index, 0), GetItemLevel(index, 0), GetItemTheLuc(index, 0), GetItemOptionType(index, 1, 0), GetItemOptionLevel(index, 1, 0), GetItemOptionType(index, 2, 0), GetItemOptionLevel(index, 2, 0), GetItemOptionType(index, 3, 0), GetItemOptionLevel(index, 3, 0), GetItemOptionType(index, 4, 0), GetItemOptionLevel(index, 4, 0), GetThuocTinh(index, 0), GetThuocTinhLevel(index, 0), GetTinhNgo(index, 0), GetTrungCap(index, 0), GetKhoa(index, 0), 2, index, Player);
                    Info.ShowDialog();
                }
            }
            else
            {
                index -= 100;
                if (GetItemID(index, 1) != 0)
                {
                    ItemInfo Info = new ItemInfo(GetItemID(index, 1), GetItemID(index, 1).ToString(), GetItemPhamChat(index, 1), GetItemCuongHoa(index, 1), GetItemLevel(index, 1), GetItemTheLuc(index, 1), GetItemOptionType(index, 1, 1), GetItemOptionLevel(index, 1, 1), GetItemOptionType(index, 2, 1), GetItemOptionLevel(index, 2, 1), GetItemOptionType(index, 3, 1), GetItemOptionLevel(index, 3, 1), GetItemOptionType(index, 4, 1), GetItemOptionLevel(index, 4, 1), GetThuocTinh(index, 1), GetThuocTinhLevel(index, 1), GetTinhNgo(index, 1), GetTrungCap(index, 1), GetKhoa(index, 1), 3, index, Player);
                    Info.ShowDialog();
                }
            }
        }

        private void Reload_Tick(object sender, EventArgs e)
        {
            LoadUserInfo();
            GetKhoRiengItem();
            GetKhoChungItem();
        }

        private int GetItemID(int index, int type)
        {
            if (type == 0)
            {
                return BitConverter.ToInt32(Player.个人仓库[index].VAT_PHAM_ID, 0);
            }
            else
            {
                return BitConverter.ToInt32(Player.公共仓库[index].VAT_PHAM_ID, 0);
            }
        }

        private Image GetItemImage(int index)
        {
            int ItemID = GetItemID(index, 0);
            if (File.Exists(string.Format(@"Items\{0}.jpg", ItemID)))
            {
                return Image.FromFile(string.Format(@"Items\{0}.jpg", ItemID));
            }
            return null;
        }

        private int GetItemOptionType(int index, int SoDong, int type)
        {
            int OptionType = 0;
            if (type == 0)
            {
                switch (SoDong)
                {
                    case 1:
                        OptionType = Player.个人仓库[index].属性1.属性类型;
                        break;
                    case 2:
                        OptionType = Player.个人仓库[index].属性2.属性类型;
                        break;
                    case 3:
                        OptionType = Player.个人仓库[index].属性3.属性类型;
                        break;
                    case 4:
                        OptionType = Player.个人仓库[index].属性4.属性类型;
                        break;
                }
            }
            else
            {
                switch (SoDong)
                {
                    case 1:
                        OptionType = Player.公共仓库[index].属性1.属性类型;
                        break;
                    case 2:
                        OptionType = Player.公共仓库[index].属性2.属性类型;
                        break;
                    case 3:
                        OptionType = Player.公共仓库[index].属性3.属性类型;
                        break;
                    case 4:
                        OptionType = Player.公共仓库[index].属性4.属性类型;
                        break;
                }
            }

            return OptionType;
        }

        private int GetItemCuongHoa(int index, int type)
        {
            if (type == 0)
            {
                return Player.个人仓库[index].FLD_强化数量;
            }
            else
            {
                return Player.公共仓库[index].FLD_强化数量;
            }
        }

        private int GetItemLevel(int index, int type)
        {
            ItmeClass ITEM;
            if (type == 0)
            {
                ITEM = ItmeClass.GetItmeID(GetItemID(index, 0));
            }
            else
            {
                ITEM = ItmeClass.GetItmeID(GetItemID(index, 1));
            }
            return ITEM.FLD_LEVEL;
        }

        private int GetItemTheLuc(int index, int type)
        {
            ItmeClass ITEM;
            if (type == 0)
            {
                ITEM = ItmeClass.GetItmeID(GetItemID(index, 0));
            }
            else
            {
                ITEM = ItmeClass.GetItmeID(GetItemID(index, 1));
            }
            return ITEM.FLD_ZX;
        }

        private int GetThuocTinh(int index, int type)
        {
            if (type == 0)
            {
                return Player.个人仓库[index].Giai_doan_da_thuoc_tinh;
            }
            else
            {
                return Player.公共仓库[index].Giai_doan_da_thuoc_tinh;
            }
        }

        private int GetThuocTinhLevel(int index, int type)
        {
            if (type == 0)
            {
                return Player.个人仓库[index].Giai_doan_da_thuoc_tinh;
            }
            else
            {
                return Player.公共仓库[index].Giai_doan_da_thuoc_tinh;
            }
        }

        private int GetTinhNgo(int index, int type)
        {
            if (type == 0)
            {
                return Player.个人仓库[index].FLD_FJ_觉醒;
            }
            else
            {
                return Player.公共仓库[index].FLD_FJ_觉醒;
            }
        }

        private int GetTrungCap(int index, int type)
        {
            if (type == 0)
            {
                return Player.个人仓库[index].FLD_FJ_中级附魂;
            }
            else
            {
                return Player.公共仓库[index].FLD_FJ_中级附魂;
            }
        }

        private int GetItemPhamChat(int index, int type)
        {
            if (type == 0)
            {
                return Player.个人仓库[index].FLD_FJ_进化;
            }
            else
            {
                return Player.公共仓库[index].FLD_FJ_进化;
            }
        }

        private int GetKhoa(int index, int type)
        {
            bool isKhoa;
            if (type == 0)
            {
                isKhoa = Player.个人仓库[index].Item_rang_buoc;
            }
            else
            {
                isKhoa = false;
            }
            int Khoa = 0;
            if (isKhoa)
                Khoa = 1;
            return Khoa;
        }

        private int GetItemOptionLevel(int index, int SoDong, int type)
        {
            int OptionLevel = 0;
            if (type == 0)
            {
                switch (SoDong)
                {
                    case 1:
                        OptionLevel = Player.公共仓库[index].属性1.属性类型;
                        break;
                    case 2:
                        OptionLevel = Player.公共仓库[index].属性2.属性类型;
                        break;
                    case 3:
                        OptionLevel = Player.公共仓库[index].属性3.属性类型;
                        break;
                    case 4:
                        OptionLevel = Player.公共仓库[index].属性4.属性类型;
                        break;
                }
            }
            else
            {
                switch (SoDong)
                {
                    case 1:
                        OptionLevel = Player.公共仓库[index].属性1.属性类型;
                        break;
                    case 2:
                        OptionLevel = Player.公共仓库[index].属性2.属性类型;
                        break;
                    case 3:
                        OptionLevel = Player.公共仓库[index].属性3.属性类型;
                        break;
                    case 4:
                        OptionLevel = Player.公共仓库[index].属性4.属性类型;
                        break;
                }
            }

            return OptionLevel;
        }

    }
}
