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
    public partial class DrugManage : Form
    {
        private string userID;
        private string userName;
        ConnectDB conn;
        private string SqlStr;
        private string DrugUpdateNo;





        public DrugManage(string id)
        {
            conn = new ConnectDB();
            InitializeComponent();


            #region 加载用户信息。
            userID = id;
            SqlStr = "SELECT ZGname FROM ZhiGongBiao WHERE ZGno='" + userID + "'";
            conn.reader = conn.queryData(SqlStr);
            conn.reader.Read();
            while (conn.reader.HasRows)
            {
                for (int i = 0; i < conn.reader.FieldCount; i++)
                {
                    userName = conn.reader[i].ToString();
                }
                conn.reader.Close();
                conn.conn.Close();
                break;
            }
            if (string.IsNullOrEmpty(userName))
            {
                DoctorName.Text = "未登陆！";
            }
            else
            {
                DoctorName.Text = "" + userName + "    医生，欢迎您！";
            }
            #endregion

            #region 初始化加载
            SearchDrug("", "");

            #endregion


        }


        #region 药品信息维护
        /// <summary>
        /// 查询药品Btn事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchDrugPage1_Click(object sender, EventArgs e)
        {

            string DrugNo = DrugNoTextPage1.Text.Trim();
            string DrugName = DrugNameTextPage1.Text.Trim();
            SearchDrug(DrugNo, DrugName);

        }

        /// <summary>
        /// 跳转-添加药品，主页面不关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdddDrugInfPage1_Click(object sender, EventArgs e)
        {
            AddDrug addDrug = new AddDrug();
            addDrug.Show();
        }

        /// <summary>
        /// 跳转-修改药品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlertDrugInfPage1_Click(object sender, EventArgs e)
        {
            if (DrugGridViewPage1.Rows.Count != 0)
            {
                DrugUpdateNo = Convert.ToString(DrugGridViewPage1.SelectedRows[0].Cells[0].Value);
                AlterDrug alterDrug = new AlterDrug(DrugUpdateNo);
                alterDrug.Show();
            }
            else
            {
                MessageBox.Show("没有数据，无法编辑！");
            }
        }


        /// <summary>
        /// 查询药品-药品信息维护
        /// </summary>
        /// <param name="DrugNo"></param>
        /// <param name="DrugName"></param>
        private void SearchDrug(string DrugNo, string DrugName)
        {
            this.DrugGridViewPage1.Rows.Clear();
            if (string.IsNullOrEmpty(DrugNo) && string.IsNullOrEmpty(DrugName))
            {
                SqlStr = "SELECT [YPno],[YPname],[GYno],[YPLeiBie],[YPJiaGe],[YPGuiGe],[YPShenChandate],[YPBaoZhiQi] FROM YaoPin";
            }
            else if (!string.IsNullOrEmpty(DrugNo))
            {
                SqlStr = "SELECT [YPno],[YPname],[GYno],[YPLeiBie],[YPJiaGe],[YPGuiGe],[YPShenChandate],[YPBaoZhiQi] FROM YaoPin WHERE YPno LIKE '%" + DrugNo + "%'";
            }
            else
            {
                SqlStr = "SELECT [YPno],[YPname],[GYno],[YPLeiBie],[YPJiaGe],[YPGuiGe],[YPShenChandate],[YPBaoZhiQi] FROM YaoPin WHERE  YPname LIKE '%" + DrugName + "%'";
            }

            conn = new ConnectDB();
            conn.queryData(SqlStr);
            while (conn.reader.Read())
            {
                int index = this.DrugGridViewPage1.Rows.Add();
                this.DrugGridViewPage1.Rows[index].Cells["YPno"].Value = conn.reader[0].ToString();
                this.DrugGridViewPage1.Rows[index].Cells["YPname"].Value = conn.reader[1].ToString();
                this.DrugGridViewPage1.Rows[index].Cells["GYno"].Value = conn.reader[2].ToString();
                this.DrugGridViewPage1.Rows[index].Cells["YPLeiBie"].Value = conn.reader[3].ToString();
                this.DrugGridViewPage1.Rows[index].Cells["YPJiaGe"].Value = conn.reader[4].ToString();
                this.DrugGridViewPage1.Rows[index].Cells["YPGuiGe"].Value = conn.reader[5].ToString();
                this.DrugGridViewPage1.Rows[index].Cells["YPShenChandate"].Value = conn.reader[6].ToString();
                this.DrugGridViewPage1.Rows[index].Cells["YPBaoZhiQi"].Value = conn.reader[7].ToString();
            }
            conn.reader.Close();
            conn.conn.Close();
        }

        #endregion

        #region 药品入库
        /// <summary>
        /// 药品入库-SQL语句
        /// </summary>
        /// <param name="DrugNo"></param>
        /// <param name="DrugName"></param>
        private void SearchDrugPage2(string DrugNo, string DrugName)
        {
            this.DrugGridViewPage2.Rows.Clear();
            if (string.IsNullOrEmpty(DrugNo) && string.IsNullOrEmpty(DrugName))
            {
                SqlStr = "select [YPno],[GYno],[YPname],[YPJiaGe],[YPGuiGe],[YPLeiBie],[YPKuCun],[YPShenChandate],[YPBaoZhiQi],[YPRuKudate] from YaoPin";
            }
            else if (!string.IsNullOrEmpty(DrugNo))
            {
                SqlStr = "select [YPno],[GYno],[YPname],[YPJiaGe],[YPGuiGe],[YPLeiBie],[YPKuCun],[YPShenChandate],[YPBaoZhiQi],[YPRuKudate] from YaoPin WHERE YPno LIKE '%" + DrugNo + "%'";
            }
            else
            {
                SqlStr = "select [YPno],[GYno],[YPname],[YPJiaGe],[YPGuiGe],[YPLeiBie],[YPKuCun],[YPShenChandate],[YPBaoZhiQi],[YPRuKudate] from YaoPin WHERE  YPname LIKE '%" + DrugName + "%'";
            }

            conn = new ConnectDB();
            conn.queryData(SqlStr);
            while (conn.reader.Read())
            {
                int index = this.DrugGridViewPage2.Rows.Add();
                this.DrugGridViewPage2.Rows[index].Cells["YPnoPage2"].Value = conn.reader[0].ToString();
                this.DrugGridViewPage2.Rows[index].Cells["GYnoPage2"].Value = conn.reader[1].ToString();
                this.DrugGridViewPage2.Rows[index].Cells["YPnamePage2"].Value = conn.reader[2].ToString();
                this.DrugGridViewPage2.Rows[index].Cells["YPJiaGePage2"].Value = conn.reader[3].ToString();
                this.DrugGridViewPage2.Rows[index].Cells["YPGuiGePage2"].Value = conn.reader[4].ToString();
                this.DrugGridViewPage2.Rows[index].Cells["YPLeiBiePage2"].Value = conn.reader[5].ToString();
                this.DrugGridViewPage2.Rows[index].Cells["YPKuCunPage2"].Value = conn.reader[6].ToString();
                this.DrugGridViewPage2.Rows[index].Cells["YPShenChandatePage2"].Value = conn.reader[7].ToString();
                this.DrugGridViewPage2.Rows[index].Cells["YPBaoZhiQiPage2"].Value = conn.reader[8].ToString();
                this.DrugGridViewPage2.Rows[index].Cells["YPRuKudatePage2"].Value = conn.reader[9].ToString();
            }
            conn.reader.Close();
            conn.conn.Close();
        }

        /// <summary>
        /// 药品入库-查询药品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchDrugPage2_Click(object sender, EventArgs e)
        {
            string DrugNo = DrugNoTextPage2.Text.Trim();
            string DrugName = DrugNameTextPage2.Text.Trim();
            SearchDrugPage2(DrugNo, DrugName);
        }

        /// <summary>
        /// 新增药品库存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddDrugStockPage2_Click(object sender, EventArgs e)
        {
            string DrugNum = DrugNumTextPage2.Text.Trim();
            if (string.IsNullOrEmpty(DrugNum))
            {
                MessageBox.Show("请输入入库量！");
                return;
            }
            string YPno1 = Convert.ToString(DrugGridViewPage2.SelectedRows[0].Cells[0].Value);
            if (string.IsNullOrEmpty(YPno1))
            {
                MessageBox.Show("请选择需要入库的药品！");
                return;
            }

            SqlStr = "update YaoPin set YPKuCun='" + DrugNum + "' where YPno='" + YPno1 + "'";
            conn = new ConnectDB();
            if (conn.updateData(SqlStr))
            {
                MessageBox.Show("入库成功");
                SearchDrugPage2("", "");
            }
            else
            {
                MessageBox.Show("入库失败");
            }
        }

        #endregion

        #region 药品出库
        private void SearchDrugPage3(string DrugName)
        {
            this.DrugGridViewPage3.Rows.Clear();
            if (string.IsNullOrEmpty(DrugName))
            {
                SqlStr = "select [YPno],[YPname],[YPJiaGe],[YPGuiGe],[YPLeiBie],[YPKuCun],[YPShenChandate],[YPBaoZhiQi] from YaoPin ";
            }
            else
            {
                SqlStr = "select [YPno],[YPname],[YPJiaGe],[YPGuiGe],[YPLeiBie],[YPKuCun],[YPShenChandate],[YPBaoZhiQi] from YaoPin  WHERE  YPname LIKE '%" + DrugName + "%'";
            }

            conn = new ConnectDB();
            conn.queryData(SqlStr);
            while (conn.reader.Read())
            {
                int index = this.DrugGridViewPage3.Rows.Add();
                this.DrugGridViewPage3.Rows[index].Cells["YPnoPage3"].Value = conn.reader[0].ToString();
                this.DrugGridViewPage3.Rows[index].Cells["YPnamePage3"].Value = conn.reader[1].ToString();
                this.DrugGridViewPage3.Rows[index].Cells["YPJiaGePage3"].Value = conn.reader[2].ToString();
                this.DrugGridViewPage3.Rows[index].Cells["YPGuiGePage3"].Value = conn.reader[3].ToString();
                this.DrugGridViewPage3.Rows[index].Cells["YPLeiBiePage3"].Value = conn.reader[4].ToString();
                this.DrugGridViewPage3.Rows[index].Cells["YPKuCunPage3"].Value = conn.reader[5].ToString();
                this.DrugGridViewPage3.Rows[index].Cells["YPShenChandatePage3"].Value = conn.reader[6].ToString();
                this.DrugGridViewPage3.Rows[index].Cells["YPBaoZhiQiPage3"].Value = conn.reader[7].ToString();
            }
            conn.reader.Close();
            conn.conn.Close();
        }


        private void btnSearchDrugPage3_Click(object sender, EventArgs e)
        {
            string DrugName = DrugNameTextPage3.Text.Trim();
            SearchDrugPage3(DrugName);
        }

        private void btnDrugOutPage3_Click(object sender, EventArgs e)
        {
            int DrugOut = Convert.ToInt32(DrugOutTextPage3.Text.Trim());
            if (DrugOut <= 0)
            {
                MessageBox.Show("请输入出库量！");
                return;
            }

            int DrugNum = Convert.ToInt32(DrugGridViewPage3.SelectedRows[0].Cells[5].Value);
            string YPno1 = Convert.ToString(DrugGridViewPage3.SelectedRows[0].Cells[0].Value);
            //MessageBox.Show("DrugOut:" + DrugOut + "     DrugNum:" + DrugNum + "    YPno1:" + YPno1);
            if (DrugOut > DrugNum)
            {
                MessageBox.Show("出库量不得大于库存量！");
                return;
            }

            if (string.IsNullOrEmpty(YPno1))
            {
                MessageBox.Show("请选择需要入库的药品！");
                return;
            }

            SqlStr = "update YaoPin set YPKuCun=YPKuCun-" + DrugNum + " where YPno='" + YPno1 + "'";
            conn = new ConnectDB();
            if (conn.updateData(SqlStr))
            {
                MessageBox.Show("出库成功");
                SearchDrugPage3("");
            }
            else
            {
                MessageBox.Show("出库失败");
            }
        }
        #endregion

        #region 药品审核
        private void btnSearchDrugPage4_Click(object sender, EventArgs e)
        {
            string BeginTime = BeginDTPickerPage4.Value.ToString();
            string EndTime = EndDTPickerPage4.Value.ToString();

            //MessageBox.Show("BeginTime:" + BeginTime + "    EndTime:"+EndTime);
            this.DrugGridViewPage2.Rows.Clear();

            SqlStr = "SELECT YPno,GYno,YPname,YPJiaGe,YPGuiGe,YPLeiBie,YPKuCun,YPShenChandate,YPBaoZhiQi,YPRuKudate FROM YaoPin WHERE YPRuKudate BETWEEN '" + BeginTime + "' AND '" + EndTime + "'";

            conn = new ConnectDB();
            conn.queryData(SqlStr);
            while (conn.reader.Read())
            {
                int index = this.DrugDataGridViewPage4.Rows.Add();
                this.DrugDataGridViewPage4.Rows[index].Cells["YPnoPage4"].Value = conn.reader[0].ToString();
                this.DrugDataGridViewPage4.Rows[index].Cells["GYnoPage4"].Value = conn.reader[1].ToString();
                this.DrugDataGridViewPage4.Rows[index].Cells["YPnamePage4"].Value = conn.reader[3].ToString();
                this.DrugDataGridViewPage4.Rows[index].Cells["YPJiaGePage4"].Value = conn.reader[3].ToString();
                this.DrugDataGridViewPage4.Rows[index].Cells["YPGuiGePage4"].Value = conn.reader[4].ToString();
                this.DrugDataGridViewPage4.Rows[index].Cells["YPLeiBiePage4"].Value = conn.reader[5].ToString();
                this.DrugDataGridViewPage4.Rows[index].Cells["YPKuCunPage4"].Value = conn.reader[6].ToString();
                this.DrugDataGridViewPage4.Rows[index].Cells["YPShenChandatePage4"].Value = conn.reader[7].ToString();
                this.DrugDataGridViewPage4.Rows[index].Cells["YPBaoZhiQiPage4"].Value = conn.reader[8].ToString();
                this.DrugDataGridViewPage4.Rows[index].Cells["YPRuKudatePage4"].Value = conn.reader[9].ToString();
            }
            conn.reader.Close();
            conn.conn.Close();
        }

        #endregion


        #region 药品预警

        private void SearchDrugPage5(string DrugNo, string DrugName, string beginTime, string endTime)
        {
            this.DrugDataGridViewPage5.Rows.Clear();
            if (string.IsNullOrEmpty(DrugNo) && string.IsNullOrEmpty(DrugName))
            {
                SqlStr = "select [YPno],[GYno],[YPname],[YPJiaGe],[YPGuiGe],[YPLeiBie],[YPKuCun],[YPShenChandate],[YPBaoZhiQi],[YPRuKudate] from YaoPin WHERE YPBaoZhiQi BETWEEN '" + beginTime + "' AND '" + endTime + "'";
            }
            else if (!string.IsNullOrEmpty(DrugNo))
            {
                SqlStr = "select [YPno],[GYno],[YPname],[YPJiaGe],[YPGuiGe],[YPLeiBie],[YPKuCun],[YPShenChandate],[YPBaoZhiQi],[YPRuKudate] from YaoPin WHERE YPno LIKE '%" + DrugNo + "%' and  YPBaoZhiQi BETWEEN '" + beginTime + "' AND '" + endTime + "'";
            }
            else
            {
                SqlStr = "select [YPno],[GYno],[YPname],[YPJiaGe],[YPGuiGe],[YPLeiBie],[YPKuCun],[YPShenChandate],[YPBaoZhiQi],[YPRuKudate] from YaoPin WHERE  YPname LIKE '%" + DrugName + "%' and  YPBaoZhiQi BETWEEN '" + beginTime + "' AND '" + endTime + "'";
            }

            conn = new ConnectDB();
            conn.queryData(SqlStr);
            while (conn.reader.Read())
            {
                int index = this.DrugDataGridViewPage5.Rows.Add();
                this.DrugDataGridViewPage5.Rows[index].Cells["YPnoPage5"].Value = conn.reader[0].ToString();
                this.DrugDataGridViewPage5.Rows[index].Cells["GYnoPage5"].Value = conn.reader[1].ToString();
                this.DrugDataGridViewPage5.Rows[index].Cells["YPnamePage5"].Value = conn.reader[2].ToString();
                this.DrugDataGridViewPage5.Rows[index].Cells["YPJiaGePage5"].Value = conn.reader[3].ToString();
                this.DrugDataGridViewPage5.Rows[index].Cells["YPGuiGePage5"].Value = conn.reader[4].ToString();
                this.DrugDataGridViewPage5.Rows[index].Cells["YPLeiBiePage5"].Value = conn.reader[5].ToString();
                this.DrugDataGridViewPage5.Rows[index].Cells["YPKuCunPage5"].Value = conn.reader[6].ToString();
                this.DrugDataGridViewPage5.Rows[index].Cells["YPShenChandatePage5"].Value = conn.reader[7].ToString();
                this.DrugDataGridViewPage5.Rows[index].Cells["YPBaoZhiQiPage5"].Value = conn.reader[8].ToString();
                this.DrugDataGridViewPage5.Rows[index].Cells["YPRuKudatePage5"].Value = conn.reader[9].ToString();
            }
            conn.reader.Close();
            conn.conn.Close();
        }

        private void btnSearchDrugPage5_Click(object sender, EventArgs e)
        {
            string DrugNo = DrugNoTextPage5.Text.Trim();
            string DrugName = DrugNameTextPage5.Text.Trim();
            string beginTime = BeginDTPickerPage5.Value.ToString();
            string endTime = EndDTPickerPage5.Value.ToString();
            SearchDrugPage5(DrugNo, DrugName, beginTime, endTime);
        }

        private void btnSearchValitityPage5_Click(object sender, EventArgs e)
        {
            this.DrugDataGridViewPage5.Rows.Clear();
            string NowTime = System.DateTime.Now.ToString();

            conn = new ConnectDB();
            SqlStr = "select [YPno],[GYno],[YPname],[YPJiaGe],[YPGuiGe],[YPLeiBie],[YPKuCun],[YPShenChandate],[YPBaoZhiQi],[YPRuKudate] from YaoPin WHERE YPBaoZhiQi < '" + NowTime + "'";
            conn.queryData(SqlStr);
            while (conn.reader.Read())
            {
                int index = this.DrugDataGridViewPage5.Rows.Add();
                this.DrugDataGridViewPage5.Rows[index].Cells["YPnoPage5"].Value = conn.reader[0].ToString();
                this.DrugDataGridViewPage5.Rows[index].Cells["GYnoPage5"].Value = conn.reader[1].ToString();
                this.DrugDataGridViewPage5.Rows[index].Cells["YPnamePage5"].Value = conn.reader[2].ToString();
                this.DrugDataGridViewPage5.Rows[index].Cells["YPJiaGePage5"].Value = conn.reader[3].ToString();
                this.DrugDataGridViewPage5.Rows[index].Cells["YPGuiGePage5"].Value = conn.reader[4].ToString();
                this.DrugDataGridViewPage5.Rows[index].Cells["YPLeiBiePage5"].Value = conn.reader[5].ToString();
                this.DrugDataGridViewPage5.Rows[index].Cells["YPKuCunPage5"].Value = conn.reader[6].ToString();
                this.DrugDataGridViewPage5.Rows[index].Cells["YPShenChandatePage5"].Value = conn.reader[7].ToString();
                this.DrugDataGridViewPage5.Rows[index].Cells["YPBaoZhiQiPage5"].Value = conn.reader[8].ToString();
                this.DrugDataGridViewPage5.Rows[index].Cells["YPRuKudatePage5"].Value = conn.reader[9].ToString();
            }
            conn.reader.Close();
            conn.conn.Close();
        }

        #endregion

        #region 药品库存查询

        private void SearchDrugPage6(string DrugName, string DrugNo)
        {
            this.DrugDataGridViewPage6.Rows.Clear();
            if (string.IsNullOrEmpty(DrugName) && string.IsNullOrEmpty(DrugNo))
            {
                SqlStr = "select [YPno],[GYno],[YPname],[YPLeiBie],[YPKuCun],[YPBaoZhiQi] from YaoPin ";
            }
            else if (!string.IsNullOrEmpty(DrugNo))
            {
                SqlStr = "select [YPno],[GYno],[YPname],[YPLeiBie],[YPKuCun],[YPBaoZhiQi] from YaoPin  WHERE  YPno LIKE '%" + DrugNo + "%'";
            }
            else
            {
                SqlStr = "select [YPno],[GYno],[YPname],[YPLeiBie],[YPKuCun],[YPBaoZhiQi] from YaoPin  WHERE  YPname LIKE '%" + DrugName + "%'";
            }

            conn = new ConnectDB();
            conn.queryData(SqlStr);
            while (conn.reader.Read())
            {
                int index = this.DrugDataGridViewPage6.Rows.Add();
                this.DrugDataGridViewPage6.Rows[index].Cells["YPnoPage6"].Value = conn.reader[0].ToString();
                this.DrugDataGridViewPage6.Rows[index].Cells["GYnoPage6"].Value = conn.reader[1].ToString();
                this.DrugDataGridViewPage6.Rows[index].Cells["YPnamePage6"].Value = conn.reader[2].ToString();
                this.DrugDataGridViewPage6.Rows[index].Cells["YPLeiBiePage6"].Value = conn.reader[3].ToString();
                this.DrugDataGridViewPage6.Rows[index].Cells["YPKuCunPage6"].Value = conn.reader[4].ToString();
                this.DrugDataGridViewPage6.Rows[index].Cells["YPBaoZhiQiPage6"].Value = conn.reader[5].ToString();
            }
            conn.reader.Close();
            conn.conn.Close();
        }

        private void btnSearchDrugPage6_Click(object sender, EventArgs e)
        {
            string DrugName = DrugNameTextPage6.Text.Trim();
            string DrugNo = DrugNoTextPage6.Text.Trim();
            SearchDrugPage6(DrugName, DrugNo);
        }
        #endregion



        #region

        private void SearchProvide(string ProvideName, string ProvideNo)
        {
            ProvideGridView.Rows.Clear();
            if (string.IsNullOrEmpty(ProvideName) && string.IsNullOrEmpty(ProvideNo))
            {
                SqlStr = "SELECT [GYno],[GYname],[LXname],[GYtell],[GYaddress],[GYphone] FROM [YaoPinGongYing]";
            }
            else if (!string.IsNullOrEmpty(ProvideName))
            {
                SqlStr = "SELECT [GYno],[GYname],[LXname],[GYtell],[GYaddress],[GYphone] FROM [YaoPinGongYing] WHERE GYname LIKE '%" + ProvideName + "%'";
            }
            else
            {
                SqlStr = "SELECT [GYno],[GYname],[LXname],[GYtell],[GYaddress],[GYphone] FROM [YaoPinGongYing] WHERE  GYno LIKE '%" + ProvideNo + "%'";
            }

            conn = new ConnectDB();
            conn.queryData(SqlStr);
            while (conn.reader.Read())
            {
                int index = this.ProvideGridView.Rows.Add();
                this.ProvideGridView.Rows[index].Cells["GYnoColumn"].Value = conn.reader[0].ToString();
                this.ProvideGridView.Rows[index].Cells["GYnameColumn"].Value = conn.reader[1].ToString();
                this.ProvideGridView.Rows[index].Cells["LXnameColumn"].Value = conn.reader[2].ToString();
                this.ProvideGridView.Rows[index].Cells["GYtellColumn"].Value = conn.reader[3].ToString();
                this.ProvideGridView.Rows[index].Cells["GYaddressColumn"].Value = conn.reader[4].ToString();
                this.ProvideGridView.Rows[index].Cells["GYphoneColumn"].Value = conn.reader[5].ToString();
            }
            conn.reader.Close();
            conn.conn.Close();
        }

        private void btnAddProvide_Click(object sender, EventArgs e)
        {
            AddProvider addP = new AddProvider();
            addP.Show();
        }

        private void btnSearchProvide_Click(object sender, EventArgs e)
        {
            string ProvideName = ProvideNameText.Text.Trim();
            string ProvideNo = ProvideNoText.Text.Trim();
            SearchProvide(ProvideName, ProvideNo);
        }


        private void btnAlterProvide_Click(object sender, EventArgs e)
        {
            string provideNo;
            if (ProvideGridView.Rows.Count != 0)
            {
                provideNo = Convert.ToString(ProvideGridView.SelectedRows[0].Cells[0].Value);
            }
            else
            {
                MessageBox.Show("没有数据，无法编辑！");
                return;
            }

            AlterProvide ap = new AlterProvide(provideNo);
            ap.Show();
        }
        #endregion

        private void btnDelDrug_Click(object sender, EventArgs e)
        {
            string YPno = this.DrugGridViewPage1.SelectedRows[0].Cells["YPno"].Value.ToString().Trim();
            if (string.IsNullOrEmpty(YPno))
            {
                MessageBox.Show("请选择需要删除的药");
            }
            else
            {
                DialogResult dr = MessageBox.Show("你确定要删除该药品？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    SqlStr = " delete from YaoPin where YPno='" + YPno + "'";
                    try
                    {
                        conn = new ConnectDB();
                        if (conn.deleteData(SqlStr))
                        {
                            MessageBox.Show("删除成功");
                            this.btnSearchDrugPage1.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("删除失败，请核查该药是否已被使用！");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {

                }
            }


        }





    }
}
