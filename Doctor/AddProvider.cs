using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Doctor
{
    public partial class AddProvider : Form
    {
        public AddProvider()
        {
            InitializeComponent();
        }

        private string SqlStr;
        ConnectDB conn;

        private void btnAddProvide_Click(object sender, EventArgs e)
        {
            string ProvideNo = ProvideNoText.Text.Trim();
            string ProvideName = ProvideNameText.Text.Trim();
            string ProvideLinkman = ProvideLinkmanText.Text.Trim();
            string ProvideLinkphone1 = ProvideLinkPhoneText1.Text.Trim();
            string ProvideLinkphone2 = ProvideLinkPhoneText2.Text.Trim();
            string ProvideAddress = ProvideAddressText.Text.Trim();

            if (string.IsNullOrEmpty(ProvideNo))
            {
                MessageBox.Show("请输入供应商号！");
                return;
            }

            if (string.IsNullOrEmpty(ProvideName))
            {
                MessageBox.Show("请输入供应商名称！");
                return;
            }

            if (string.IsNullOrEmpty(ProvideLinkman))
            {
                MessageBox.Show("请输入联系人！");
                return;
            }
            SqlStr = "INSERT INTO [YaoPinGongYing]([GYno],[GYname],[LXname],[GYtell],[GYaddress],[GYphone]) VALUES('" + ProvideNo + "','" + ProvideName + "','" + ProvideLinkman + "','" + ProvideLinkphone1 + "','" + ProvideAddress + "','" + ProvideLinkphone2 + "')";
            conn = new ConnectDB();
            if (conn.insertData(SqlStr))
            {
                MessageBox.Show("增加成功！");
                ProvideNoText.Text = "";
                ProvideNameText.Text = "";
                ProvideLinkmanText.Text = "";
                ProvideLinkPhoneText1.Text = "";
                ProvideLinkPhoneText2.Text = "";
                ProvideAddressText.Text = "";
            }
            else
            {
                MessageBox.Show("增加失败！");
            }
            
        }
    }
}
