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
    public partial class AddPatient : Form
    {
        private string month, day;
        private static int i = 1;
        private string UserNo;
        ConnectDB conn;
        private string SqlStr;
        public AddPatient()
        {
            InitializeComponent();
            #region 初始化，加载已经挂号但没有填写个人信息的患者挂号编号
            try
            {
                SqlStr = " Select GHno from GuaHaoDan where GHno not in (select GHno from BingRenBiao)";
                conn = new ConnectDB();
                conn.queryData(SqlStr);
                while (conn.reader.Read())
                {
                    this.GhNoComboBox.Items.Add(conn.reader[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion
            UserNo = GetAghno();
            lab_pyhno.Text = "用户编号：" + UserNo;
        }


        /// <summary>
        /// 获取用户编号
        /// </summary>
        /// <returns></returns>
        private string GetAghno()
        {
            string SelNum = "0";//查询数据库中现有挂号的最大号
            if (DateTime.Now.Month < 10)
            {
                month = "0" + DateTime.Now.Month;
            }
            else
            {
                month = "" + DateTime.Now.Month;
            }
            if (DateTime.Now.Day < 10)
            {
                day = "0" + DateTime.Now.Day;
            }
            else
            {
                day = "" + DateTime.Now.Day;
            }

            UserNo = "BR" + DateTime.Now.Year + month + day + i.ToString().PadLeft(4, '0');

            try
            {
                SqlStr = "SELECT TOP 1 BRno FROM BingRenBiao ORDER BY BRno DESC";
                conn = new ConnectDB();
                conn.queryData(SqlStr);

                while (conn.reader.Read())
                {
                    SelNum = conn.reader[0].ToString();
                }
                conn.reader.Close();
                conn.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (string.Compare(UserNo, SelNum) <= 0)
            {
                string a = "";
                string b = "";
                for (int j = 0; j < SelNum.Length; j++)
                {
                    try
                    {
                        b += Convert.ToInt32(SelNum.Substring(j, 1));
                    }

                    catch
                    {
                        a += SelNum.Substring(j, 1);
                    }
                }
                //MessageBox.Show(UserNo);
                UserNo = a + (Convert.ToInt64(b) + 1);
            }

            return UserNo;
            //System.Text.ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();
            //byte[] bs = asciiEncoding.GetBytes(SelNum);
            //bs[bs.Length - 1]++;
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {

        }

        private void btn_ptijiao_Click(object sender, EventArgs e)
        {
            string BRPassword, BRname, BRage, BRaddress, BRtell, BRphone;
            string GHno = "", BRsex = "";
            try
            {
                GHno = GhNoComboBox.SelectedItem.ToString();
            }
            catch 
            {
                MessageBox.Show("请选择患者挂号编号！");
                return;
            }
            try
            {
                BRsex = cb_psex.SelectedItem.ToString();
            }
            catch 
            {
                MessageBox.Show("请选择患者性别！");
                return;
            }

            BRname = tb_pname.Text.ToString();
            BRage = tb_page.Text.ToString();
            BRaddress = tb_paddress.Text.ToString();
            BRtell = tb_ptell.Text.ToString();
            BRphone = tb_piphone.Text.ToString();
            BRPassword = tb_pmima.Text.ToString();
            if (string.IsNullOrEmpty(BRage))
            {
                MessageBox.Show("请输入年龄！");
            }
            else
            {
                if (int.Parse(BRage) >= 150 || int.Parse(BRage) <= 0)
                {
                    MessageBox.Show("年龄在0-150之间！");
                }
                else
                {

                    SqlStr = "INSERT INTO [BingRenBiao]([BRno],[GHno],[BRPassword],[BRname],[BRsex],[BRage],[BRaddress],[BRtell],[BRphone]) VALUES('" + UserNo + "','" + GHno + "','" + BRPassword + "','" + BRname + "','" + BRsex + "','" + BRage + "','" + BRaddress + "','" + BRtell + "','" + BRphone + "')";
                    try
                    {
                        conn = new ConnectDB();
                        if (conn.insertData(SqlStr))
                        {
                            MessageBox.Show("新增成功");
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("新增失败");
                        }
                        conn.conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
