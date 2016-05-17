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
    public partial class ShouFei : Form
    {
       
        ConnectDB conn;
        private string SqlStr;
        private string UserNo;
        private string SFno;
        private string month, day;
        private static int i = 1;
        private string SFDate = System.DateTime.Now.ToString();
        public ShouFei(string id, string UserName, float rmb)
        {
            UserNo = id;
            InitializeComponent();
            #region  初始化用户信息
            textBox1.Text = UserName;
            textBox2.Text = UserNo;
            textBox3.Text = rmb.ToString();
            #endregion
            SFno = GetSFno();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetCharges GC = new GetCharges(UserNo);
            string GetNum = textBox4.Text.ToString();
            if (string.IsNullOrEmpty(GetNum))
            {
                MessageBox.Show("请收费！");
            }
            else if (!string.Equals(GetNum, textBox3.Text.ToString()))
            {
                MessageBox.Show("请输入准确金额！");
            }
            else
            {
                int index = GC.dataGridView1.Rows.Count;
                for (int i = 0; i < index; i++)
                {
                    string YPno = GC.dataGridView1.Rows[i].Cells["DrugNo"].Value.ToString();
                    float jiage = float.Parse(GC.dataGridView1.Rows[i].Cells["DrugPrice"].Value.ToString());
                    float num = float.Parse(GC.dataGridView1.Rows[i].Cells["DrugNum"].Value.ToString());
                    string XianJin = (jiage * num).ToString();
                    SqlStr = "INSERT INTO [ShouFeiDan] ([SFno],[BRno],[YPno],[SFdate],[XianJin]) VALUES('" + SFno + "','" + UserNo + "','" + YPno + "','" + SFDate + "','" + XianJin + "')";
                    try
                    {
                        conn = new ConnectDB();
                        if (conn.insertData(SqlStr))
                        {
                            MessageBox.Show("收费成功！");
                            this.Close();
                            GC.Show();
                        }
                        else
                        {
                            MessageBox.Show(YPno + "收费失败!");
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
               
            }
        }


        #region 获取收费编号
        private string GetSFno()
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

            SFno = "SF" + DateTime.Now.Year + month + day + i.ToString().PadLeft(4, '0');

            try
            {
                SqlStr = "  SELECT TOP 1 SFno  FROM ShouFeiDan ORDER BY SFno DESC";
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

            if (string.Compare(SFno, SelNum) <= 0)
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
                SFno = a + (Convert.ToInt64(b) + 1);
            }

            return SFno;
            //System.Text.ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();
            //byte[] bs = asciiEncoding.GetBytes(SelNum);
            //bs[bs.Length - 1]++;
        }
        #endregion
    }
}
