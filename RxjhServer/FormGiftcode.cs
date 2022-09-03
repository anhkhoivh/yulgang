using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YulgangServer.RxjhServer.DbClss;
using System.IO;

namespace YulgangServer.RxjhServer
{
    public partial class FormGiftcode : Form
    {
        public FormGiftcode()
        {
            InitializeComponent();
        }
        private void FormGiftcode_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            lblStatus.Visible = false;
        }
        private void btnCreateGiftcode_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text.Trim();
            int Cash = int.Parse(txtCash.Text.Trim());
            int Bonus = int.Parse(txtBonus.Text.Trim());
            string Detail = txtDetail.Text.Trim();

            if (Username.Length <= 4)
            {
                MessageBox.Show("Cần phải nhập vào username mới có thể tạo giftcode", "Lưu ý", MessageBoxButtons.OK);
                return;
            }
            if (Cash < 0 || Bonus < 0)
            {
                MessageBox.Show("Vui lòng nhập vào số hợp lệ", "Lưu ý", MessageBoxButtons.OK);
                return;
            }
            if (Detail.Length <= 4)
            {
                MessageBox.Show("Cần phải nhập vào thông tin mới có thể tạo giftcode", "Lưu ý", MessageBoxButtons.OK);
                return;
            }

            string Giftcode = RxjhClass.Tao_ra_giftcode(Username, Cash, Bonus, Detail);
            if (Giftcode != "")
            {
                lblStatus.Text = "Tạo thành công giftcode cho tài khoản " +Username;
                lblStatus.Visible = true;
                txtGiftcode.Text = Giftcode;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {

        }

        private void txtGiftcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void picItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
