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
    public partial class Reception : Form
    {
        private ConnectDB conn;
        private string SqlStr;

        private string month, day;
        public static string Aghno;
        public string ghno;
        public static string brno;
        //自增变量，每挂一次号变量加1。
        private static int i = 1;
        //标记的初始化，即重置以后的值。
        int biaoji = 0;
        //查询语句内的。
        string sstr;
        string j = "";
        //进行格式化以后的挂号时间。例如：2015-01-01
        string dt;


        public Reception(string ZGno)
        {
            InitializeComponent();
            SearchPtient("", "", "");

        }

        #region  挂号
        private void btn_gsure_Click(object sender, EventArgs e)
        {
            string KSName = cb_gks.SelectedItem.ToString();
            string ZhenJin = tb_gprice.Text.ToString();
            try
            {
                SqlStr = "INSERT INTO [GuaHaoDan]([GHno],[KSno],[ZhenJin],[GuaHaoFei],[GHtime]) SELECT '" + Aghno + "',KSno=(SELECT KSno FROM KeShi WHERE KSname='" + KSName + "'),'" + ZhenJin + "','1','" + DateTime.Now.ToString() + "'";
                conn = new ConnectDB();
                if (conn.insertData(SqlStr))
                {
                    MessageBox.Show("挂号成功");
                    i++;
                    Aghno = GetAghno();
                    lab_gghno.Text = "挂号编号：" + Aghno;
                    lab_hnowtime.Text = " 当前系统时间：" + DateTime.Now.ToString();
                    cb_gks.Text = "请选择";
                    tb_gprice.Text = "";
                }
                else
                {
                    MessageBox.Show("挂号失败");
                }
                conn.reader.Close();
                conn.conn.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        //挂号编号
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

            Aghno = "GH" + DateTime.Now.Year + month + day + i.ToString().PadLeft(4, '0');
            lab_gghno.Text = "挂号编号：" + Aghno;

            try
            {
                SqlStr = "SELECT TOP 1 GHno from GuaHaoDan order by GHno desc";
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

            if (string.Compare(Aghno,SelNum) <= 0)
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
                Aghno = a + (Convert.ToInt64(b) + 1);
            }
            return Aghno;
            //System.Text.ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();
            //byte[] bs = asciiEncoding.GetBytes(SelNum);
            //bs[bs.Length - 1]++;
        }

        private void Reception_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            //挂号tab中的时间，以及患者界面显示的时间。
            dt = DateTime.Now.Year + "-" + month + "-" + day;
            lab_hnowtime.Text = " 当前系统时间：" + DateTime.Now.ToString();
            Aghno = GetAghno();
            lab_gghno.Text = "挂号编号：" + Aghno;
            LabRegistrationTime.Text = System.DateTime.Now.ToString();

            conn = new ConnectDB();
            SqlStr = "Select KSno,KSname from KeShi";
            conn.queryData(SqlStr);
            while (conn.reader.Read())
            {
                this.cb_gks.Items.Add(conn.reader[1]);
                //this.cb_gksno.Items.Add(conn.reader[0]);
            }

            conn.reader.Close();
            conn.conn.Close();
        }

        #region 获取时间
        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Interval = 1000;
            ////挂号tab中的时间，以及患者界面显示的时间。
            //dt = DateTime.Now.Year + "-" + month + "-" + day;
            //lab_gdate.Text = "挂号日期：" + dt;
            //lab_hnowtime.Text = " 当前系统时间：" + DateTime.Now.ToString();
        }
        #endregion

        #region 查询病人信息
        private void SearchPtient(string Name, string Sex, string Phone)
        {
            dataGridView1.Rows.Clear();
            if (string.IsNullOrEmpty(Name) && string.IsNullOrEmpty(Sex) && string.IsNullOrEmpty(Phone))
            {
                SqlStr = "SELECT [BRno],[GHno],[BRname],[BRsex],[BRphone],[BRage],[BRaddress] FROM [BingRenBiao]";
            }
            else if (!string.IsNullOrEmpty(Name))
            {
                SqlStr = "SELECT [BRno],[GHno],[BRname],[BRsex],[BRphone],[BRage],[BRaddress] FROM [BingRenBiao] where [BRname] like '%" + Name + "%'";
            }
            else if (!string.IsNullOrEmpty(Sex))
            {
                SqlStr = "SELECT [BRno],[GHno],[BRname],[BRsex],[BRphone],[BRage],[BRaddress] FROM [BingRenBiao] where [BRsex] like '%" + Sex + "%'";
            }
            else
            {
                SqlStr = "SELECT [BRno],[GHno],[BRname],[BRsex],[BRphone],[BRage],[BRaddress] FROM [BingRenBiao] where [BRphone] like '%" + Phone + "%'";
            }
            try
            {
                conn = new ConnectDB();
                conn.queryData(SqlStr);
                while (conn.reader.Read())
                {
                    int index = this.dataGridView1.Rows.Add();
                    this.dataGridView1.Rows[index].Cells["BrNoColumn"].Value = conn.reader[0].ToString();
                    this.dataGridView1.Rows[index].Cells["GhNoColumn"].Value = conn.reader[1].ToString();
                    this.dataGridView1.Rows[index].Cells["NameColumn"].Value = conn.reader[2].ToString();
                    this.dataGridView1.Rows[index].Cells["SexColumn"].Value = conn.reader[3].ToString();
                    this.dataGridView1.Rows[index].Cells["PhoneColumn"].Value = conn.reader[4].ToString();
                    this.dataGridView1.Rows[index].Cells["AgeColumn"].Value = conn.reader[5].ToString();
                    this.dataGridView1.Rows[index].Cells["AddressColumn"].Value = conn.reader[6].ToString();               
                }
                conn.reader.Close();
                conn.conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        #endregion

        private void btn_hsearch_Click(object sender, EventArgs e)
        {
            string name = tb_hname.Text.ToString();
            string sex = "";
            string phone = tb_hiphone.Text.ToString();
            try
            {
                sex = cb_hsex.SelectedItem.ToString();
            }
            catch
            { 
            
            }
            SearchPtient(name,sex,phone);
        }

        private void btn_hadd_Click(object sender, EventArgs e)
        {
            AddPatient adp = new AddPatient();
            adp.Show();
        }

    }
}
