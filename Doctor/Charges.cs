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
    public partial class Charges : Form
    {
        Timer time1 = new Timer();
        ConnectDB conn;
        private string SqlStr;
        public Charges(string id)
        {
            InitializeComponent();
        }

        private void btnSearchChuFang_Click(object sender, EventArgs e)
        {
            string UserNo = UserNoText.Text.ToString();
            if (string.IsNullOrEmpty(UserNo))
            {
                MessageBox.Show("请输入患者编号！");
            }
            else
            {
                SqlStr = "Select c.[BRno],b.[BRname],[CFno],[YPno],[CFdate] from ChuFangDan as c join BingRenBiao as b on c.BRno=b.BRno where c.BRno='" + UserNo + "' and [YPno] not in (select YPno from ShouFeiDan where BRno='" + UserNo + "')";
                try
                {
                    conn = new ConnectDB();
                    conn.queryData(SqlStr);
                    while (conn.reader.Read())
                    {
                        int index = this.dataGridView1.Rows.Add();
                        this.dataGridView1.Rows[index].Cells["UserNoColumn"].Value = conn.reader[0].ToString();
                        this.dataGridView1.Rows[index].Cells["UserNameColumn"].Value = conn.reader[1].ToString();
                        this.dataGridView1.Rows[index].Cells["ChuFangNoColumn"].Value = conn.reader[2].ToString();
                        this.dataGridView1.Rows[index].Cells["YaoPinNoColumn"].Value = conn.reader[3].ToString();
                        this.dataGridView1.Rows[index].Cells["ChuFangDateColumn"].Value = conn.reader[4].ToString();
                    }
                    conn.reader.Close();
                    conn.conn.Close();
                }
                catch
                {

                }
            }

        }

        private void btnShouFei_Click(object sender, EventArgs e)
        {
            string UserNo = UserNoText.Text.ToString();
            if (string.IsNullOrEmpty(UserNo))
            {
                MessageBox.Show("请输入需要收费的患者");
            }
            else
            {
                GetCharges GC = new GetCharges(UserNo);
                GC.Show();
            }
            
        }

        private void Charges_Load(object sender, EventArgs e)
        {
            this.time1.Interval = 1000;
            this.time1.Tick += new System.EventHandler(this.timer1_Tick);
            this.time1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();   
        }
    }
}
