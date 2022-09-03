using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using RxjhServer.RxjhServer;
using RxjhServer;
using YulgangServer.RxjhServer.DbClss;

namespace YulgangServer.RxjhServer
{
    public partial class FormADDitemALLcs : Form
    {
        public FormADDitemALLcs()
        {
            InitializeComponent();
        }
        bool isVaildItem = false;
        private void txtIDItem_TextChanged(object sender, EventArgs e)
        {
            if (txtIDItem.Text == "")
            {
                btnAdd.Enabled = false;
                return;
            }

            int IDItem = Convert.ToInt32(txtIDItem.Text.Trim());

            if (File.Exists(string.Format(@"Items\{0}.jpg", IDItem)))
            {
                picItem.Image = Image.FromFile(string.Format(@"Items\{0}.jpg", IDItem));
                isVaildItem = true;
            }
            else
            {
                picItem.Image = Image.FromFile(string.Format(@"Items\0.jpg"));
                isVaildItem = false;
            }

            btnAdd.Enabled = true;
            cbItemType.Enabled = true;
            cbItemType.SelectedIndex = 0;
            checkKhoa.Enabled = true;
        }

        private void cbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbItemType.SelectedIndex == 0)
            {
                cbPhamChat.Enabled = false;
                cbPhamChat.SelectedIndex = -1;

                cbCuongHoa.Enabled = false;
                cbCuongHoa.SelectedIndex = -1;

                cbThuocTinh.Enabled = false;
                cbThuocTinh.SelectedIndex = -1;
                cbThuocTinhLv.SelectedIndex = -1;

                cbOption1.Enabled = false;
                cbOption1.SelectedIndex = -1;

                cbOption2.Enabled = false;
                cbOption2.SelectedIndex = -1;

                cbOption3.Enabled = false;
                cbOption3.SelectedIndex = -1;

                cbOption4.Enabled = false;
                cbOption4.SelectedIndex = -1;

                cbTinhNgo.Enabled = false;
                cbTinhNgo.SelectedIndex = -1;

                cbTrungCap.Enabled = false;
                cbTrungCap.SelectedIndex = -1;

                numSoluong.Enabled = true;
                numSoluong.Value = 1;
            }
            else if (cbItemType.SelectedIndex == 1 || cbItemType.SelectedIndex == 2)
            {
                cbPhamChat.Enabled = true;
                cbPhamChat.SelectedIndex = 0;

                checkKhoa.Enabled = true;

                cbCuongHoa.Enabled = true;
                cbCuongHoa.SelectedIndex = 0;

                cbThuocTinh.Enabled = true;
                cbOption1.Enabled = true;
                cbOption2.Enabled = true;
                cbOption3.Enabled = true;
                cbOption4.Enabled = true;

                cbTinhNgo.Enabled = true;
                cbTrungCap.Enabled = true;

                numSoluong.Enabled = false;
                numSoluong.Value = 1;

                SaoNgaySuDung.Enabled = true;
            }
            else if (cbItemType.SelectedIndex == 3)
            {
                cbCuongHoa.Enabled = true;
                cbCuongHoa.SelectedIndex = 0;

                cbPhamChat.Enabled = false;
                cbPhamChat.SelectedIndex = -1;

                checkKhoa.Checked = false;
                checkKhoa.Enabled = true;

                cbThuocTinh.Enabled = false;
                cbOption1.Enabled = false;
                cbOption2.Enabled = false;
                cbOption3.Enabled = false;
                cbOption4.Enabled = false;

                cbTinhNgo.Enabled = false;
                cbTrungCap.Enabled = false;

                numSoluong.Enabled = false;
                numSoluong.Value = 1;

                SaoNgaySuDung.Enabled = true;
            }
        }

        private void cbThuocTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbThuocTinh.SelectedIndex >= 0)
            {
                cbThuocTinhLv.Enabled = true;
                cbThuocTinhLv.SelectedIndex = 0;
            }
            else
            {
                cbThuocTinhLv.Enabled = false;
                cbThuocTinhLv.SelectedIndex = 1;
            }
        }

        private void cbOption1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOption1.SelectedIndex >= 0)
            {
                txtOption1.Enabled = true;
            }
            else
            {
                txtOption1.Enabled = false;
                txtOption1.Clear();
            }
        }

        private void cbOption2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOption2.SelectedIndex >= 0)
            {
                txtOption2.Enabled = true;
            }
            else
            {
                txtOption2.Enabled = false;
                txtOption2.Clear();
            }
        }

        private void cbOption3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOption3.SelectedIndex >= 0)
            {
                txtOption3.Enabled = true;
            }
            else
            {
                txtOption3.Enabled = false;
                txtOption3.Clear();
            }
        }

        private void cbOption4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOption4.SelectedIndex >= 0)
            {
                txtOption4.Enabled = true;
            }
            else
            {
                txtOption4.Enabled = false;
                txtOption4.Clear();
            }
        }

        private void cbTrungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTinhNgo.SelectedIndex == -1)
                cbTinhNgo.SelectedIndex = 0;

            cbTrungCapLV.Enabled = true;
            cbTrungCapLV.Items.Clear();
            switch (cbTrungCap.SelectedIndex)
            {
                case 0: //phuc cuu
                    cbTrungCapLV.Items.Add("1");
                    cbTrungCapLV.Items.Add("2");
                    cbTrungCapLV.Items.Add("3");
                    cbTrungCapLV.Items.Add("4");
                    cbTrungCapLV.Items.Add("5");
                    break;
                case 1: //hap hon
                    cbTrungCapLV.Items.Add("1");
                    cbTrungCapLV.Items.Add("2");
                    cbTrungCapLV.Items.Add("3");
                    break;
                case 2: //ki duyen
                    cbTrungCapLV.Items.Add("1");
                    cbTrungCapLV.Items.Add("2");
                    cbTrungCapLV.Items.Add("3");
                    break;
                case 3: //phan no
                    cbTrungCapLV.Items.Add("1");
                    cbTrungCapLV.Items.Add("2");
                    cbTrungCapLV.Items.Add("3");
                    break;
                case 4: //di tinh
                    cbTrungCapLV.Items.Add("1");
                    cbTrungCapLV.Items.Add("2");
                    cbTrungCapLV.Items.Add("3");
                    cbTrungCapLV.Items.Add("4");
                    cbTrungCapLV.Items.Add("5");
                    break;
                case 5: //ho the
                    cbTrungCapLV.Items.Add("1");
                    cbTrungCapLV.Items.Add("2");
                    cbTrungCapLV.Items.Add("3");
                    cbTrungCapLV.Items.Add("4");
                    cbTrungCapLV.Items.Add("5");
                    break;
                case 6: //hon nguyen
                    cbTrungCapLV.Items.Add("1");
                    cbTrungCapLV.Items.Add("2");
                    cbTrungCapLV.Items.Add("3");
                    cbTrungCapLV.Items.Add("4");
                    cbTrungCapLV.Items.Add("5");
                    break;

                default:
                    cbTrungCapLV.SelectedIndex = -1;
                    cbTrungCapLV.Enabled = false;
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!isVaildItem)
            {
                MessageBox.Show("Item thêm vào không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (Players Player in World.AllConnectedChars.Values)
                {
                    int IDitem = Convert.ToInt32(txtIDItem.Text.Trim());
                    int ViTri = Player.DUOC_KIEN_HANG_RONG_VI_TRI();
                    int SoLuong = 1;
                    //int SoLuong = Convert.ToInt32(numSoluong.Value);
                    int NgaySuDung = Convert.ToInt32(SaoNgaySuDung.Text.Trim());
                    if (numSoluong.Value <= 0)
                    {
                        MessageBox.Show("Số lượng tối thiểu là 1!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        SoLuong = Convert.ToInt32(numSoluong.Value);
                    }
                    int Khoa = 0;
                    if (checkKhoa.Checked == true)
                        Khoa = 1;
                    if (cbItemType.SelectedIndex == 0) //item
                    {
                        //Player.TANG_CUONG_VAT_PHAM_MANG_THUOC_TINH(IDitem, ViTri, SoLuong, 0, 0, 0, 0, 0, 0, 0, 0, Khoa);
                        Player.制造物品(ViTri, BitConverter.GetBytes(IDitem));
                        Player.GameMessage_2("Bạn nhận được món quà bất ngờ từ GM", 10, "Hệ thống");
                        lblStatus.Text = "Item: " + IDitem + " SL: " + SoLuong + " NV: " + Player.UserName;
                        lblStatus.Visible = true;
                        //MessageBox.Show("Thêm thành công item " + IDitem + " số lượng " + SoLuong + " vào nhân vật " + Player.UserName, " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (cbItemType.SelectedIndex == 3) //trang sức
                    {
                        int CuongHoa = cbCuongHoa.SelectedIndex;
                        int DongCuongHoa = 0;

                        byte[] bytes = BitConverter.GetBytes(RxjhClass.GetDbItmeId());
                        byte[] dst = new byte[0x38];
                        ItmeClass ITEM = ItmeClass.GetItmeID(IDitem);

                        string temp = "";
                        if (CuongHoa <= 9)
                        {
                            temp = "000000" + CuongHoa;
                        }
                        else
                        {
                            temp = "00000" + CuongHoa;
                        }

                        switch (ITEM.FLD_RESIDE2)
                        {
                            case 10: //nhẫn
                                DongCuongHoa = Convert.ToInt32("1" + temp);
                                break;
                            case 8: //bông tai
                                DongCuongHoa = Convert.ToInt32("3" + temp);
                                break;

                            case 7: //dây chuyền
                                DongCuongHoa = Convert.ToInt32("2" + temp);
                                break;
                        }

                        Buffer.BlockCopy(BitConverter.GetBytes(DongCuongHoa), 0, dst, 0, 4);
                        Buffer.BlockCopy(BitConverter.GetBytes(ITEM.FLD_MAGIC1), 0, dst, 4, 4);
                        Buffer.BlockCopy(BitConverter.GetBytes(ITEM.FLD_MAGIC2), 0, dst, 8, 4);
                        Buffer.BlockCopy(BitConverter.GetBytes(ITEM.FLD_MAGIC3), 0, dst, 12, 4);
                        Buffer.BlockCopy(BitConverter.GetBytes(ITEM.FLD_MAGIC4), 0, dst, 0x10, 4);
                        Player.Make_Item_Upgrade(bytes, BitConverter.GetBytes(IDitem), ViTri, BitConverter.GetBytes(1), dst);
                        Player.GameMessage_2("Bạn nhận được [" + ITEM.ItmeNAME + "] từ GM", 10, "Hệ thống");
                        lblStatus.Text = "Item: " + IDitem + " SL: " + SoLuong + " NV: " + Player.UserName;
                        lblStatus.Visible = true;
                        //MessageBox.Show("Thêm thành công item " + IDitem + " số lượng " + SoLuong + " vào nhân vật " + Player.UserName, " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int PhamChat = cbPhamChat.SelectedIndex;
                        int CuongHoa = cbCuongHoa.SelectedIndex;
                        int ThuocTinh = cbThuocTinh.SelectedIndex + 1;
                        int ThuocTinhLV = cbThuocTinhLv.SelectedIndex;

                        int Dong1Loai = cbOption1.SelectedIndex + 1;
                        int Dong1LV = Convert.ToInt32(txtOption1.Text.Trim());
                        int Dong2Loai = cbOption2.SelectedIndex + 1;
                        int Dong2LV = Convert.ToInt32(txtOption2.Text.Trim());
                        int Dong3Loai = cbOption3.SelectedIndex + 1;
                        int Dong3LV = Convert.ToInt32(txtOption3.Text.Trim());
                        int Dong4Loai = cbOption4.SelectedIndex + 1;
                        int Dong4LV = Convert.ToInt32(txtOption4.Text.Trim());

                        int TinhNgo = cbTinhNgo.SelectedIndex + 1;
                        int TrungCap = 0;

                        switch (cbTrungCap.SelectedIndex)
                        {
                            case 0: //phuc cuu
                                TrungCap = 22;
                                break;
                            case 1: //hap hon
                                TrungCap = 27;
                                break;
                            case 2: //ki duyen
                                TrungCap = 30;
                                break;
                            case 3: //phan no
                                TrungCap = 33;
                                break;
                            case 4: //di tinh
                                TrungCap = 36;
                                break;
                            case 5: //ho the
                                TrungCap = 41;
                                break;
                            case 6: //hon nguyen
                                TrungCap = 46;
                                break;
                        }

                        TrungCap += cbTrungCapLV.SelectedIndex + 1;

                        if (cbTrungCapLV.SelectedIndex < 0)
                            TrungCap = 0;

                        int Dong1 = 0;
                        int Dong2 = 0;
                        int Dong3 = 0;
                        int Dong4 = 0;

                        if (Dong1Loai > 0 && Dong1LV > 0)
                        {
                            if (Dong1LV <= 9)
                            {
                                Dong1 = Convert.ToInt32(+Dong1Loai + "000000" + Dong1LV);
                            }
                            else
                            {
                                Dong1 = Convert.ToInt32(+Dong1Loai + "00000" + Dong1LV);
                            }
                        }
                        if (Dong2Loai > 0 && Dong2LV > 0)
                        {
                            if (Dong2LV <= 9)
                            {
                                Dong2 = Convert.ToInt32(+Dong2Loai + "000000" + Dong2LV);
                            }
                            else
                            {
                                Dong2 = Convert.ToInt32(+Dong2Loai + "00000" + Dong2LV);
                            }
                        }
                        if (Dong3Loai > 0 && Dong3LV > 0)
                        {
                            if (Dong3LV <= 9)
                            {
                                Dong3 = Convert.ToInt32(+Dong3Loai + "000000" + Dong3LV);
                            }
                            else
                            {
                                Dong3 = Convert.ToInt32(+Dong3Loai + "00000" + Dong3LV);
                            }
                        }
                        if (Dong4Loai > 0 && Dong4LV > 0)
                        {
                            if (Dong4LV <= 9)
                            {
                                Dong4 = Convert.ToInt32(+Dong4Loai + "000000" + Dong4LV);
                            }
                            else
                            {
                                Dong4 = Convert.ToInt32(+Dong4Loai + "00000" + Dong4LV);
                            }
                        }
                        int TTnCH = 0;

                        if (cbThuocTinh.SelectedIndex < 0)
                        {
                            ThuocTinh = 0;
                            ThuocTinhLV = 0;
                        }

                        if (cbItemType.SelectedIndex == 1) //vũ khí
                        {
                            if (CuongHoa <= 9)
                            {
                                TTnCH = Convert.ToInt32("101000" + ThuocTinh + +ThuocTinhLV + "0" + CuongHoa);
                            }
                            else
                            {
                                TTnCH = Convert.ToInt32("101000" + ThuocTinh + +ThuocTinhLV + +CuongHoa);
                            }
                        }
                        else if (cbItemType.SelectedIndex == 2) //trang bị̣
                        {
                            if (CuongHoa <= 9)
                            {
                                TTnCH = Convert.ToInt32("102000" + ThuocTinh + +ThuocTinhLV + "0" + CuongHoa);
                            }
                            else
                            {
                                TTnCH = Convert.ToInt32("102000" + ThuocTinh + +ThuocTinhLV + +CuongHoa);
                            }
                        }

                        //Player.TANG_CUONG_VAT_PHAM_MANG_THUOC_TINH(IDitem, ViTri, SoLuong, TTnCH, Dong1, Dong2, Dong3, Dong4, TinhNgo, TrungCap, PhamChat, Khoa); // cai củ
                        Player.BACH_BAO_TANG_CUONG_ITEM_MANG_THUOC_TINH(IDitem, ViTri, SoLuong, TTnCH, Dong1, Dong2, Dong3, Dong4, TinhNgo, TrungCap, PhamChat, Khoa, NgaySuDung);
                        Player.GameMessage_2("Bạn nhận được món quà bất ngờ từ GM", 10, "Hệ thống");
                        lblStatus.Text = "Item: " + IDitem + " SL: " + SoLuong + " NV: " + Player.UserName;
                        lblStatus.Visible = true;
                        //MessageBox.Show("Thêm thành công item " + IDitem + " số lượng " + SoLuong + " vào nhân vật " + Player.UserName, " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void cbTrungCapLV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            txtIDItem.Enabled = true;
        }

        private void picItem_Click(object sender, EventArgs e)
        {

        }

    }
}
