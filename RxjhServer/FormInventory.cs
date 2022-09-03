using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RxjhServer;
using RxjhServer.RxjhServer;
using System.IO;

namespace YulgangServer.RxjhServer
{
    public partial class FormInventory : Form
    {
        public FormInventory()
        {
            InitializeComponent();
        }

        Players Player;

        private void FormInventory_Load(object sender, EventArgs e)
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

                        HamTaoClick();

                        HamTaoTuiDoChinh();
                        HamTaoTuiDoPhu();
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

        private void Reload_Tick(object sender, EventArgs e)
        {
            LoadUserInfo();
            GetTuiDoChinhItem();
            GetTuiDoPhuItem();
        }

        PictureBox ViTriTuiDo;
        List<PictureBox> TuiDoChinh;
        List<PictureBox> TuiDoPhu;
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

            for (int i = 0; i < 15; i++)
            {
                HideInventor(i);
            }
        }
        private void HideInventor(int index)
        {
            switch (index)
            {
                case 0:
                    picAo.Visible = false;
                    break;
                case 1:
                    picTayTrai.Visible = false;
                    break;
                case 2:
                    picTayPhai.Visible = false;
                    break;
                case 3:
                    picVuKhi.Visible = false;
                    break;
                case 4:
                    picGiay.Visible = false;
                    break;
                case 5:
                    picGiap.Visible = false;
                    break;
                case 6:
                    picDayChuyen.Visible = false;
                    break;
                case 7:
                    picBongTaiTrai.Visible = false;
                    break;
                case 8:
                    picBongTaiPhai.Visible = false;
                    break;
                case 9:
                    picNhanTrai.Visible = false;
                    break;
                case 10:
                    picNhanPhai.Visible = false;
                    break;

                case 11:
                    picAoChoang.Visible = false;
                    break;
                case 12:
                    picPhuKien.Visible = false;
                    break;
                case 13:
                    picAoGuild.Visible = false;
                    break;
                case 14:
                    picPet.Visible = false;
                    break;
            }
        }
        private void HamTaoTuiDoPhu()
        {
            TuiDoPhu = new List<PictureBox>();
            for (int i = 36; i < 66; i++)
            {
                var name = string.Format("Vitri{0}", i);
                ViTriTuiDo = new PictureBox();
                ViTriTuiDo.Tag = i + 100;
                ViTriTuiDo.BackColor = Color.Black;
                ViTriTuiDo.Size = new Size(32, 32);
                ViTriTuiDo.Visible = false;
                int Vitri = (i - 36) % 6;
                int SoDong = (i - 36) / 6;
                int X = 36 + 33 * Vitri;
                int Y = 306 + 35 * SoDong;
                Point point = new Point(X, Y);
                ViTriTuiDo.Location = point;
                this.Controls.Add(ViTriTuiDo);
                TuiDoPhu.Add(ViTriTuiDo);
                ViTriTuiDo.BringToFront();
                ViTriTuiDo.Click += HienThiInfo;
                ViTriTuiDo.Name = name;
            }
            GetTuiDoPhuItem();
        }
        private void GetTuiDoPhuItem()
        {
            for (int i = 36; i < 66; i++)
            {
                int ItemID = BitConverter.ToInt32(Player.TRANG_BI_LAN_BAO_VAY[i].VAT_PHAM_ID, 0);
                var name = string.Format("Vitri{0}", i);
                foreach (PictureBox ViTri in TuiDoPhu)
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
                    ItemInfo Info = new ItemInfo(GetItemID(index, 0), GetItemID(index, 0).ToString(), GetItemPhamChat(index, 0), GetItemCuongHoa(index, 0), GetItemLevel(index, 0), GetItemTheLuc(index, 0), GetItemOptionType(index, 1, 0), GetItemOptionLevel(index, 1, 0), GetItemOptionType(index, 2, 0), GetItemOptionLevel(index, 2, 0), GetItemOptionType(index, 3, 0), GetItemOptionLevel(index, 3, 0), GetItemOptionType(index, 4, 0), GetItemOptionLevel(index, 4, 0), GetThuocTinh(index, 0), GetThuocTinhLevel(index, 0), GetTinhNgo(index, 0), GetTrungCap(index, 0), GetKhoa(index, 0), 0, index, Player);
                    Info.ShowDialog();
                }
            }
            else
            {
                index -= 100;
                if (GetItemID(index, 1) != 0)
                {
                    ItemInfo Info = new ItemInfo(GetItemID(index, 1), GetItemID(index, 1).ToString(), GetItemPhamChat(index, 1), GetItemCuongHoa(index, 1), GetItemLevel(index, 1), GetItemTheLuc(index, 1), GetItemOptionType(index, 1, 1), GetItemOptionLevel(index, 1, 1), GetItemOptionType(index, 2, 1), GetItemOptionLevel(index, 2, 1), GetItemOptionType(index, 3, 1), GetItemOptionLevel(index, 3, 1), GetItemOptionType(index, 4, 1), GetItemOptionLevel(index, 4, 1), GetThuocTinh(index, 1), GetThuocTinhLevel(index, 1), GetTinhNgo(index, 1), GetTrungCap(index, 1), GetKhoa(index, 1), 1, index, Player);
                    Info.ShowDialog();
                }
            }
        }
        private int GetItemPhamChat(int index, int type)
        {
            if (type == 0)
            {
                return Player.Item_Wear[index].FLD_FJ_进化;
            }
            else
            {
                return Player.TRANG_BI_LAN_BAO_VAY[index].FLD_FJ_进化;
            }
        }
        private int GetItemCuongHoa(int index, int type)
        {
            if (type == 0)
            {
                return Player.Item_Wear[index].FLD_强化数量;
            }
            else
            {
                return Player.TRANG_BI_LAN_BAO_VAY[index].FLD_强化数量;
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
        private int GetItemOptionType(int index, int SoDong, int type)
        {
            int OptionType = 0;
            if (type == 0)
            {
                switch (SoDong)
                {
                    case 1:
                        OptionType = Player.Item_Wear[index].属性1.属性类型;
                        break;
                    case 2:
                        OptionType = Player.Item_Wear[index].属性2.属性类型;
                        break;
                    case 3:
                        OptionType = Player.Item_Wear[index].属性3.属性类型;
                        break;
                    case 4:
                        OptionType = Player.Item_Wear[index].属性4.属性类型;
                        break;
                }
            }
            else
            {
                switch (SoDong)
                {
                    case 1:
                        OptionType = Player.TRANG_BI_LAN_BAO_VAY[index].属性1.属性类型;
                        break;
                    case 2:
                        OptionType = Player.TRANG_BI_LAN_BAO_VAY[index].属性2.属性类型;
                        break;
                    case 3:
                        OptionType = Player.TRANG_BI_LAN_BAO_VAY[index].属性3.属性类型;
                        break;
                    case 4:
                        OptionType = Player.TRANG_BI_LAN_BAO_VAY[index].属性4.属性类型;
                        break;
                }
            }

            return OptionType;
        }
        private int GetItemOptionLevel(int index, int SoDong, int type)
        {
            int OptionLevel = 0;
            if (type == 0)
            {
                switch (SoDong)
                {
                    case 1:
                        OptionLevel = Player.Item_Wear[index].属性1.属性数量;
                        break;
                    case 2:
                        OptionLevel = Player.Item_Wear[index].属性2.属性数量;
                        break;
                    case 3:
                        OptionLevel = Player.Item_Wear[index].属性3.属性数量;
                        break;
                    case 4:
                        OptionLevel = Player.Item_Wear[index].属性4.属性数量;
                        break;
                }
            }
            else
            {
                switch (SoDong)
                {
                    case 1:
                        OptionLevel = Player.TRANG_BI_LAN_BAO_VAY[index].属性1.属性数量;
                        break;
                    case 2:
                        OptionLevel = Player.TRANG_BI_LAN_BAO_VAY[index].属性2.属性数量;
                        break;
                    case 3:
                        OptionLevel = Player.TRANG_BI_LAN_BAO_VAY[index].属性3.属性数量;
                        break;
                    case 4:
                        OptionLevel = Player.TRANG_BI_LAN_BAO_VAY[index].属性4.属性数量;
                        break;
                }
            }

            return OptionLevel;
        }
        private int GetThuocTinh(int index, int type)
        {
            if (type == 0)
            {
                return Player.Item_Wear[index].Giai_doan_da_thuoc_tinh;
            }
            else
            {
                return Player.TRANG_BI_LAN_BAO_VAY[index].Giai_doan_da_thuoc_tinh;
            }
        }
        private int GetThuocTinhLevel(int index, int type)
        {
            if (type == 0)
            {
                return Player.Item_Wear[index].物品属性阶段数;
            }
            else
            {
                return Player.TRANG_BI_LAN_BAO_VAY[index].物品属性阶段数;
            }
        }
        private int GetTinhNgo(int index, int type)
        {
            if (type == 0)
            {
                return Player.Item_Wear[index].FLD_FJ_觉醒;
            }
            else
            {
                return Player.TRANG_BI_LAN_BAO_VAY[index].FLD_FJ_觉醒;
            }
        }
        private int GetTrungCap(int index, int type)
        {
            if (type == 0)
            {
                return Player.Item_Wear[index].FLD_FJ_中级附魂;
            }
            else
            {
                return Player.TRANG_BI_LAN_BAO_VAY[index].FLD_FJ_中级附魂;
            }
        }
        private int GetKhoa(int index, int type)
        {
            bool isKhoa;
            if (type == 0)
            {
                isKhoa = Player.Item_Wear[index].Item_rang_buoc;
            }
            else
            {
                isKhoa = Player.TRANG_BI_LAN_BAO_VAY[index].Item_rang_buoc;
            }
            int Khoa = 0;
            if (isKhoa)
                Khoa = 1;
            return Khoa;
        }
        /* return Convert.ToInt32(Player.Item_Wear[index].FLD_PID);
            }
            else
            {
                return BitConverter.ToInt32(Player.TRANG_BI_LAN_BAO_VAY[index].VAT_PHAM_ID, 0);*/
        private void HamTaoTuiDoChinh()
        {
            TuiDoChinh = new List<PictureBox>();
            for (int i = 0; i < 36; i++)
            {
                var name = string.Format("Vitri{0}", i);
                ViTriTuiDo = new PictureBox();
                ViTriTuiDo.Tag = i + 100;
                ViTriTuiDo.BackColor = Color.Black;
                ViTriTuiDo.Size = new Size(32, 32);
                ViTriTuiDo.Visible = false;
                int Vitri = i % 6;
                int SoDong = i / 6;
                int X = 291 + 33 * Vitri;
                int Y = 279 + 35 * SoDong;
                Point point = new Point(X, Y);
                ViTriTuiDo.Location = point;
                this.Controls.Add(ViTriTuiDo);
                TuiDoChinh.Add(ViTriTuiDo);
                ViTriTuiDo.BringToFront();
                ViTriTuiDo.Click += HienThiInfo;
                ViTriTuiDo.Name = name;
            }
            GetTuiDoChinhItem();
        }
        private void GetTuiDoChinhItem()
        {
            for (int i = 0; i < 36; i++)
            {
                int ItemID = BitConverter.ToInt32(Player.TRANG_BI_LAN_BAO_VAY[i].VAT_PHAM_ID, 0);

                var name = string.Format("Vitri{0}", i);
                foreach (PictureBox ViTri in TuiDoChinh)
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
        private void HamTaoClick()
        {
            this.picAo.Click += HienThiInfo;
            this.picTayTrai.Click += HienThiInfo;
            this.picTayPhai.Click += HienThiInfo;
            this.picVuKhi.Click += HienThiInfo;
            this.picGiay.Click += HienThiInfo;
            this.picGiap.Click += HienThiInfo;
            this.picDayChuyen.Click += HienThiInfo;
            this.picBongTaiTrai.Click += HienThiInfo;
            this.picBongTaiPhai.Click += HienThiInfo;
            this.picNhanTrai.Click += HienThiInfo;
            this.picNhanPhai.Click += HienThiInfo;
            this.picAoChoang.Click += HienThiInfo;
            this.picPhuKien.Click += HienThiInfo;
            this.picAoGuild.Click += HienThiInfo;
            this.picPet.Click += HienThiInfo;
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
                    Job = "Diệu yến ";
                    break;
                case 12:
                    Job = "Tử hào ";
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

            LoadInventor();
        }
        private void LoadInventor()
        {
            for (int i = 0; i < 15; i++)
            {
                LoadItem(i);
            }
        }
        private void LoadItem(int index)
        {
            if (GetItemID(index, 0) > 0)
            {
                switch (index)
                {
                    case 0:
                        picAo.Visible = true;
                        picAo.Image = GetItemImage(index);
                        break;
                    case 1:
                        picTayTrai.Visible = true;
                        picTayTrai.Image = GetItemImage(index);
                        break;
                    case 2:
                        picTayPhai.Visible = true;
                        picTayPhai.Image = GetItemImage(index);
                        break;
                    case 3:
                        picVuKhi.Visible = true;
                        picVuKhi.Image = GetItemImage(index);
                        break;
                    case 4:
                        picGiay.Visible = true;
                        picGiay.Image = GetItemImage(index);
                        break;
                    case 5:
                        picGiap.Visible = true;
                        picGiap.Image = GetItemImage(index);
                        break;
                    case 6:
                        picDayChuyen.Visible = true;
                        picDayChuyen.Image = GetItemImage(index);
                        break;
                    case 7:
                        picBongTaiTrai.Visible = true;
                        picBongTaiTrai.Image = GetItemImage(index);
                        break;
                    case 8:
                        picBongTaiPhai.Visible = true;
                        picBongTaiPhai.Image = GetItemImage(index);
                        break;
                    case 9:
                        picNhanTrai.Visible = true;
                        picNhanTrai.Image = GetItemImage(index);
                        break;
                    case 10:
                        picNhanPhai.Visible = true;
                        picNhanPhai.Image = GetItemImage(index);
                        break;
                    case 11:
                        picAoChoang.Visible = true;
                        picAoChoang.Image = GetItemImage(index);
                        break;
                    case 12:
                        picPhuKien.Visible = true;
                        picPhuKien.Image = GetItemImage(index);
                        break;
                    case 13:
                        picAoGuild.Visible = true;
                        picAoGuild.Image = GetItemImage(index);
                        break;
                    case 14:
                        picPet.Visible = true;
                        picPet.Image = GetItemImage(index);
                        break;
                }
            }
            else
            {
                switch (index)
                {
                    case 0:
                        picAo.Visible = false;
                        break;
                    case 1:
                        picTayTrai.Visible = false;
                        break;
                    case 2:
                        picTayPhai.Visible = false;
                        break;
                    case 3:
                        picVuKhi.Visible = false;
                        break;
                    case 4:
                        picGiay.Visible = false;
                        break;
                    case 5:
                        picGiap.Visible = false;
                        break;
                    case 6:
                        picDayChuyen.Visible = false;
                        break;
                    case 7:
                        picBongTaiTrai.Visible = false;
                        break;
                    case 8:
                        picBongTaiPhai.Visible = false;
                        break;
                    case 9:
                        picNhanTrai.Visible = false;
                        break;
                    case 10:
                        picNhanPhai.Visible = false;
                        break;
                    case 11:
                        picAoChoang.Visible = false;
                        break;
                    case 12:
                        picPhuKien.Visible = false;
                        break;
                    case 13:
                        picAoGuild.Visible = false;
                        break;
                    case 14:
                        picPet.Visible = false;
                        break;
                }
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
        private int GetItemID(int index, int type)
        {
            if (type == 0)
            {
                return Convert.ToInt32(Player.Item_Wear[index].FLD_PID);
            }
            else
            {
                return BitConverter.ToInt32(Player.TRANG_BI_LAN_BAO_VAY[index].VAT_PHAM_ID, 0);
            }
        }

        private void picInventor_Click(object sender, EventArgs e)
        {

        }

        private void picBongTaiTrai_Click(object sender, EventArgs e)
        {

        }

        private void picVuKhi_Click(object sender, EventArgs e)
        {

        }

        private void picPet_Click(object sender, EventArgs e)
        {

        }
    }
}
