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
    public partial class GetCharges : Form
    {
        ConnectDB conn;
        private string SqlStr;
        private string UserNo;
        public GetCharges(string id)
        {
            UserNo = id;
            InitializeComponent();

            UserNoLab.Text = UserNo;
            #region 加载用户信息
            SqlStr = "Select top 1 [CFno],[CFdate],[BRname],[BRsex],[BRage],[BRphone],[BRaddress] from ChuFangDan as c join BingRenBiao as b on c.BRno=b.BRno where c.BRno='" + UserNo + "' and [YPno] not in (select YPno from ShouFeiDan where BRno='" + UserNo + "')";
            try 
            {
                conn = new ConnectDB();
                conn.queryData(SqlStr);
                while (conn.reader.Read())
                {
                    ChuFangNoLab.Text = conn.reader[0].ToString();
                    ChuFangDate.Text = conn.reader[1].ToString();
                    UserNameText.Text = conn.reader[2].ToString();
                    UserSexText.Text = conn.reader[3].ToString();
                    UserAgeText.Text = conn.reader[4].ToString();
                    UserPhoneText.Text = conn.reader[5].ToString();
                    UserAddressText.Text = conn.reader[6].ToString();
                }
                conn.reader.Close();
                conn.conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion

            #region 加载药品信息
            SqlStr = "SELECT Y.[YPname],C.[YPno],Y.[YPJiaGe],C.[YPnum] FROM ChuFangDan AS  C join YaoPin AS Y on C.YPno=Y.YPno WHERE BRno='" + UserNo + "'  and C.[YPno] not in (select YPno from ShouFeiDan where BRno='" + UserNo + "')";
            try
            {
                conn = new ConnectDB();
                conn.queryData(SqlStr);
                while (conn.reader.Read())
                {
                    int index = this.dataGridView1.Rows.Add();
                    this.dataGridView1.Rows[index].Cells["DrugName"].Value = conn.reader[0].ToString();
                    this.dataGridView1.Rows[index].Cells["DrugNo"].Value = conn.reader[1].ToString();
                    this.dataGridView1.Rows[index].Cells["DrugPrice"].Value = conn.reader[2].ToString();
                    this.dataGridView1.Rows[index].Cells["DrugNum"].Value = conn.reader[3].ToString();
                }
                conn.reader.Close();
                conn.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = this.dataGridView1.Rows.Add();
            float SumRmb=0;
            for (int i = 0; i < index; i++)
            {
                float jiage = float.Parse(this.dataGridView1.Rows[i].Cells["DrugPrice"].Value.ToString());
                float num = float.Parse(this.dataGridView1.Rows[i].Cells["DrugNum"].Value.ToString());
                SumRmb += (jiage * num);
            }
            string UserName = UserNameText.Text.ToString();
            ShouFei sf = new ShouFei(UserNo, UserName, SumRmb);
            sf.Show();
            this.Close();
        }
    }
}
