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
    public partial class Doctor : Form
    {
        private string month, day;
        private string ZGno;
        private static int i = 1;
        private string BLno;
        private string CFno;
        ConnectDB conn;
        private string SqlStr;
        Timer time1 = new Timer();

        public Doctor(string id)
        {
            InitializeComponent();
            ZGno = id;

            //#region 初始化加载所有患者编号
            //SqlStr = "";

            //#endregion
            CFno = GetCFno();
            CFnoLab.Text = "处方编号：" + CFno;

            #region 查询医生
            SqlStr = "select ZGname from ZhiGongBiao where ZGno='" + ZGno + "' ";
            conn = new ConnectDB();
            conn.queryData(SqlStr);
            while (conn.reader.Read())
            {
                doctor_label.Text = conn.reader[0].ToString() + "  医生，欢迎您!";
            }
            conn.reader.Close();
            conn.conn.Close();
            #endregion
        }

        #region 根据患者编号，查询病人信息
        private void Found_BingRen_But_Click(object sender, EventArgs e)
        {
            string BRno = BingRen_no_textBox.Text.ToString();
            if (string.IsNullOrEmpty(BRno))
            {
                MessageBox.Show("请输入患者编号进行查询！");
            }
            else
            {
                SqlStr = "select BRname,BRsex,BRage,BRphone,BRaddress  from BingRenBiao where  BingRenBiao.BRno='" + BRno + "'";
                try
                {
                    conn = new ConnectDB();
                    conn.queryData(SqlStr);
                    while (conn.reader.Read())
                    {
                        //插入患者姓名    
                        BingRen_Name_textBox1.Text = conn.reader[0].ToString();
                        BingRen_Name_textBox2.Text = conn.reader[0].ToString();


                        //插入患者性别
                        BingRen_Sex_textBox1.Text = conn.reader[1].ToString();
                        BingRen_Sex_textBox2.Text = conn.reader[1].ToString();


                        //插入患者年龄
                        BingRen_Age_textBox1.Text = conn.reader[2].ToString();
                        BingRen_Age_textBox2.Text = conn.reader[2].ToString();


                        //插入患者电话
                        // BingRen_Tel_textBox1.Text = sdr1[3].ToString();
                        BingRen_Tel_textBox2.Text = conn.reader[3].ToString();


                        //插入患者家庭住址
                        BingRen_Address_textBox1.Text = conn.reader[4].ToString();

                        //插入就诊类型
                        // JiuZhengLeiXing_comboBox.Text = sdr1[5].ToString();
                    }
                    conn.reader.Close();
                    conn.conn.Close();
                    BLno = GetBLno();
                    BingLi_label.Text = "病历编号：" + BLno;
                    ChuFangNoLab.Text =  BRno;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }
        #endregion


        #region 获取病历编号
        private string GetBLno()
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

            BLno = "BL" + DateTime.Now.Year + month + day + i.ToString().PadLeft(4, '0');

            try
            {
                SqlStr = "SELECT TOP 1 BLno  FROM BingLi ORDER BY BLno DESC";
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

            if (string.Compare(BLno, SelNum) <= 0)
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
                MessageBox.Show(BLno);
                BLno = a + (Convert.ToInt64(b) + 1);
            }

            return BLno;
            //System.Text.ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();
            //byte[] bs = asciiEncoding.GetBytes(SelNum);
            //bs[bs.Length - 1]++;
        }
        #endregion

        #region 获取处方编号
        private string GetCFno()
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

            CFno = "CF" + DateTime.Now.Year + month + day + i.ToString().PadLeft(4, '0');

            try
            {
                SqlStr = "  SELECT TOP 1 CFno  FROM ChuFangDan ORDER BY CFno DESC";
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

            if (string.Compare(CFno, SelNum) <= 0)
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
                CFno = a + (Convert.ToInt64(b) + 1);
            }

            return CFno;
            //System.Text.ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();
            //byte[] bs = asciiEncoding.GetBytes(SelNum);
            //bs[bs.Length - 1]++;
        }
        #endregion

        #region 保存病历信息
        private void BingRen_BingLi_Save_But_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BingRen_Name_textBox1.Text.ToString()))
            {
                MessageBox.Show("请输入患者编号！");
            }
            else
            {
                string Bidcard = BingRen_Tel_textBox1.Text.ToString();
                string JiuZheng = BingRen_BingQing_textBox.Text.ToString();
                string allergicYP = textBox1.Text.ToString();
                string JiuZhengLeiXing = "";
                try
                {
                    JiuZhengLeiXing = JiuZhengLeiXing_comboBox.SelectedItem.ToString();
                }
                catch
                {
                    MessageBox.Show("请选择就诊类型！");
                    return;
                }

                string FaBingDate;
                string FaBingDateYear = dateTimePicker3.Value.Year.ToString();
                var FaBingDateMonth = ((dateTimePicker3.Value.Month < 10) ? "0" : "") + dateTimePicker3.Value.Month.ToString();
                var FaBingDateDay = ((dateTimePicker3.Value.Day < 10) ? "0" : "") + dateTimePicker3.Value.Day.ToString();
                FaBingDate = FaBingDateYear + FaBingDateMonth + FaBingDateDay;
                SqlStr = " INSERT INTO [BingLi]([BLno],[BRno],[Bidcard],[JiuZheng],[allergicYP],[JiuZhengLeiXing],[FaBingDate]) VALUES('" + BLno + "','" + BingRen_no_textBox.Text.ToString() + "','" + Bidcard + "','" + JiuZheng + "','" + allergicYP + "','" + JiuZhengLeiXing + "','" + FaBingDate + "')";
                try
                {
                    conn = new ConnectDB();
                    if (conn.insertData(SqlStr))
                    {
                        MessageBox.Show("增加成功");
                        allergicYP_textBox.Text = allergicYP;
                        textBox1.Text = "";
                        BingRen_Tel_textBox1.Text = "";
                        JiuZhengLeiXing_comboBox.Text = "请选择";
                    }
                    else
                    {
                        MessageBox.Show("增加失败");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion





        #region 中、西、输液药品查询

        private void SearchDrug(string type)
        {
            this.YaoPin_dataGridView.Rows.Clear();
            if (type == "中药")
            {
                SqlStr = "select YPname, YPno, YPJiaGe, YPGuiGe, YPKuCun from YaoPin where YPLeiBie='中药'";
            }
            else if (type == "西药")
            {
                SqlStr = "select YPname, YPno, YPJiaGe, YPGuiGe, YPKuCun from YaoPin where YPLeiBie='西药'";
            }
            else
            {
                SqlStr = "select YPname, YPno, YPJiaGe, YPGuiGe, YPKuCun from YaoPin where YPLeiBie='输液'";
            }
            try
            {
                conn = new ConnectDB();
                conn.queryData(SqlStr);
                while (conn.reader.Read())
                {
                    int index = this.YaoPin_dataGridView.Rows.Add();
                    this.YaoPin_dataGridView.Rows[index].Cells["YaoPin_ZY_Name_Column"].Value = conn.reader[0].ToString();
                    this.YaoPin_dataGridView.Rows[index].Cells["YaoPin_ZY_YPno_Column"].Value = conn.reader[1].ToString();
                    this.YaoPin_dataGridView.Rows[index].Cells["YaoPin_ZY_Price_Column"].Value = conn.reader[2].ToString();
                    this.YaoPin_dataGridView.Rows[index].Cells["YaoPin_ZY_Eat_Column"].Value = conn.reader[3].ToString();
                    this.YaoPin_dataGridView.Rows[index].Cells["YaoPin_ZY_Stock_Column"].Value = conn.reader[4].ToString();
                }
                conn.reader.Close();
                conn.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //查询中药
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SearchDrug("中药");
        }

        //查询西药
        private void XiYao_select_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            SearchDrug("西药");
        }

        //查询输液
        private void ShuYe_select_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            SearchDrug("输液");
        }
        #endregion

        #region 添加药品到处方单
        private void btnAddDrug_Click(object sender, EventArgs e)
        {
            string num = this.YaoPin_dataGridView.SelectedRows[0].Cells["YaoPin_ZY_Stock_Column"].Value.ToString();
            if (num == "" || num == "0")
            {
                MessageBox.Show("库存不足！");
            }
            else
            {
                string B1 = this.YaoPin_dataGridView.SelectedRows[0].Cells["YaoPin_ZY_Name_Column"].Value.ToString();
                string B2 = this.YaoPin_dataGridView.SelectedRows[0].Cells["YaoPin_ZY_YPno_Column"].Value.ToString();
                string B3 = this.YaoPin_dataGridView.SelectedRows[0].Cells["YaoPin_ZY_Price_Column"].Value.ToString();
                string B4 = this.YaoPin_dataGridView.SelectedRows[0].Cells["YaoPin_ZY_Eat_Column"].Value.ToString();
                string B5 = "1";
                this.ChuFang_DataGridView.Rows.Add(new string[] { B1, B2, B3, B4, B5 });
            }
        }
        #endregion

        #region 删除处方单中的药品
        private void btnDelDrug_Click(object sender, EventArgs e)
        {
            for (int i = ChuFang_DataGridView.SelectedRows.Count; i > 0; i--)
            {
                ChuFang_DataGridView.Rows.RemoveAt(ChuFang_DataGridView.SelectedRows[i - 1].Index);
            }
        }
        #endregion

        /// <summary>
        /// 查询药品库存
        /// </summary>
        /// <param name="YPno"></param>
        /// <returns></returns>
        private string SearchDrugKuCun(string YPno)
        {
            SqlStr = "Select YPKuCun from YaoPin where YPno='" + YPno + "'";
            string YPKuCun = "" ;
            try
            {
                conn = new ConnectDB();
                conn.queryData(SqlStr);
                while (conn.reader.Read())
                {
                    YPKuCun = conn.reader[0].ToString();  
                }
                conn.reader.Close();
                conn.conn.Close();
                return YPKuCun;
            }
            catch
            {
                return null;
            }
        
        }


        /// <summary>
        /// 新增处方单
        /// </summary>
        /// <param name="CFno"></param>
        /// <param name="ZGno"></param>
        /// <param name="BRno"></param>
        /// <param name="CFdate"></param>
        /// <param name="YPnum"></param>
        /// <param name="YPno"></param>
        /// <returns></returns>
        private bool InsertChuFang(string CFno,string ZGno,string BRno,string CFdate,string YPnum,string YPno)
        {
            SqlStr = "INSERT INTO [ChuFangDan]([CFno],[ZGno],[BRno],[CFdate],[YPnum],[YPno]) VALUES('" + CFno + "','" + ZGno + "','" + BRno + "','" + CFdate + "','" + YPnum + "','" + YPno + "')";

            try
            {
                conn = new ConnectDB();
                if (conn.insertData(SqlStr))
                {
                    return true;
                }
                else
                {
                    return false;
                }
                conn.conn.Close();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        ///更新药品库存
        /// </summary>
        /// <param name="YPno"></param>
        /// <param name="YPnum"></param>
        /// <returns></returns>
        private bool UpdateDrugKuCun(string YPno, string YPnum) 
        {
            SqlStr = "update YaoPin set YPKuCun=(YPKuCun-" + YPnum + ") where YPno='" + YPno + "'";
          
            try
            {
                conn = new ConnectDB();
                if (conn.updateData(SqlStr))
                {
                    return true;
                }

                else
                {
                    return false;
                }
                conn.conn.Close();
             
            }
            catch
            {
                return false;
            }
        }
        private void ChuFang_Save_But_Click(object sender, EventArgs e)
        {
            string BRno = ChuFangNoLab.Text;
            string CFdate = System.DateTime.Now.ToString();
            string YPnum;
            string YPno;

            int index = this.ChuFang_DataGridView.Rows.Add();
            if (index == 0)
            {
                MessageBox.Show("请仔细核查是否需要添加！");
            }
            else
            {

                for (int i = 0; i < index; i++)  //判断输入的药品是否大于库存
                {
                    try
                    {
                        YPnum = ChuFang_DataGridView.Rows[i].Cells["ChuFang_Number_Column"].Value.ToString();
                        YPno = ChuFang_DataGridView.Rows[i].Cells["ChuFang_YPno_Column"].Value.ToString();
                        string DrugNum = SearchDrugKuCun(YPno);
                        if (Convert.ToInt32(YPnum) > Convert.ToInt32(DrugNum))
                        {
                            MessageBox.Show("药品编号为：" + YPno + "的处方数量不得大于库存量！");
                            return;
                        }
                    }
                    catch
                    {

                    }
                }


                for (int i = 0; i < index; i++)
                {

                    try
                    {
                        YPno = ChuFang_DataGridView.Rows[i].Cells["ChuFang_YPno_Column"].Value.ToString();
                        YPnum = ChuFang_DataGridView.Rows[i].Cells["ChuFang_Number_Column"].Value.ToString();
                        string DrugNum = SearchDrugKuCun(YPno);
                        if (InsertChuFang(CFno, ZGno, BRno, CFdate, YPnum, YPno))
                        {
                            if (UpdateDrugKuCun(YPno, YPnum))
                            {

                            }
                            else
                            {
                                MessageBox.Show(YPno + "新增失败");
                            }
                        }
                        else
                        {
                            MessageBox.Show("新增处方失败");
                        }
                    }
                    catch
                    {
                        this.ChuFang_DataGridView.Rows.Clear();
                        return;
                    }
                }
                MessageBox.Show("新增处方成功");
                this.ChuFang_DataGridView.Rows.Clear();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label57.Text ="现在的时间是："+ DateTime.Now.ToString();   
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            this.time1.Interval = 1000;
            this.time1.Tick += new System.EventHandler(this.timer1_Tick);
            this.time1.Start();
        }

        private void BingRen_ChuFang_Cancel_But_Click(object sender, EventArgs e)
        {
            this.ChuFang_DataGridView.Rows.Clear();
        }

        private void buttonBingRen_BingLi_Cancel_But2_Click(object sender, EventArgs e)
        {
            new Doctor(ZGno).Show();
        }



    }
}
