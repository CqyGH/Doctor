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
    public partial class AlterProvide : Form
    {
        ConnectDB conn;
        string ProvideNo;
        string SqlStr;

        public AlterProvide(string provideNo)
        {
            InitializeComponent();
            ProvideNo = provideNo;
          
            #region 初始化供应商信息
            conn = new ConnectDB();
            SqlStr = "SELECT [GYno],[GYname],[LXname],[GYtell],[GYaddress],[GYphone] FROM [YaoPinGongYing] where GYno='" + ProvideNo + "'";
            conn.queryData(SqlStr);
            while (conn.reader.Read())
            {
                ProvideNoText.Text = conn.reader[0].ToString();
                ProvideNameText.Text = conn.reader[1].ToString();
                ProvideLinkmanText.Text = conn.reader[2].ToString();
                ProvideLinkPhoneText1.Text = conn.reader[3].ToString();
                ProvideLinkPhoneText2.Text = conn.reader[5].ToString();
                ProvideAddressText.Text = conn.reader[4].ToString();
            }
            #endregion
        }

        private void btnAlterProvide_Click(object sender, EventArgs e)
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
            SqlStr = "UPDATE [YaoPinGongYing] SET [GYno] = '" + ProvideNo + "',[GYname] ='" + ProvideName + "',[LXname] = '" + ProvideLinkman + "',[GYtell] = '" + ProvideLinkphone1 + "',[GYaddress] ='" + ProvideAddress + "',[GYphone] ='" + ProvideLinkphone2 + "'  WHERE GYno='" + ProvideNo + "'";
            conn = new ConnectDB();
            if (conn.updateData(SqlStr))
            {
                MessageBox.Show("修改成功！");
                this.Hide();
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
            
        }
    }
}
