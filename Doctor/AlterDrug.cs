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
    public partial class AlterDrug : Form
    {
        ConnectDB conn;
        private string DrugNo;
        private string SqlStr;

        public AlterDrug(string id)
        {
            InitializeComponent();
            #region 初始化加载供应商

            conn = new ConnectDB();
            SqlStr = "  SELECT [GYname] from YaoPinGongYing";

            conn.queryData(SqlStr);
            while (conn.reader.Read())
            {
                this.DrugProvideComboBox1.Items.Add(conn.reader[0]);
            }
            conn.reader.Close();
            conn.conn.Close();
            #endregion


            DrugNo = id;

            conn = new ConnectDB();

            SqlStr = "select [YPno],[GYno]=(select [GYname] from YaoPinGongYing as GY where YP.GYno=GY.GYno),[YPname],[YPJiaGe],[YPGuiGe],[YPLeiBie],[YPShenChandate],[YPBaoZhiQi]  from YaoPin as YP where YPno='" + DrugNo + "'";

            conn.queryData(SqlStr);

            while (conn.reader.Read())
            {
                DrugNoText.Text = conn.reader[0].ToString();
                DrugNameText.Text = conn.reader[2].ToString();
                DrugProvideComboBox1.Text=conn.reader[1].ToString() ;
                DrugTypeComboBox.Text=conn.reader[5].ToString();
                DrugPriceText.Text = conn.reader[3].ToString();
                DrugSpecificationText.Text = conn.reader[4].ToString();
                DrugProductionDateTime.Value = Convert.ToDateTime(conn.reader[6].ToString());
                DrugValidityDateTime.Value = Convert.ToDateTime(conn.reader[7].ToString());
            }
            conn.reader.Close();
            conn.conn.Close();
        }

        private void btnAddDrug_Click(object sender, EventArgs e)
        {
            #region 获取用户输入数据
            string DrugSpecification = DrugSpecificationText.Text.Trim();
            string DrugNo = DrugNoText.Text.Trim();         //药品编号
            string DrugName = DrugNameText.Text.Trim();     //药品名称
            string DrugProvide;                             //药品提供商
            string DrugType;                                //药品类别
            try                                             //使用try是为了防止出现：未将对象引用设置到对象的实例异常。
            {
                DrugProvide = DrugProvideComboBox1.SelectedItem.ToString();
                DrugType = DrugTypeComboBox.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "请选择信息！");
                return;
            }
            string DrugPrice = DrugPriceText.Text.Trim();   //药品价格

            //药品有效期
            string DrugValidity;
            string DrugValidityYear = DrugValidityDateTime.Value.Year.ToString();
            var DrugValidityMonth = ((DrugValidityDateTime.Value.Month < 10) ? "0" : "") + DrugValidityDateTime.Value.Month.ToString();
            var DrugValidityDay = ((DrugValidityDateTime.Value.Day < 10) ? "0" : "") + DrugValidityDateTime.Value.Day.ToString();
            DrugValidity = DrugValidityYear + DrugValidityMonth + DrugValidityDay;

            //药品生产日期
            string DrugProduction;
            string DrugProductionYear = DrugProductionDateTime.Value.Year.ToString();
            var DrugProductionMonth = ((DrugProductionDateTime.Value.Month < 10) ? "0" : "") + DrugProductionDateTime.Value.Month.ToString();
            var DrugProductionyDay = ((DrugProductionDateTime.Value.Day < 10) ? "0" : "") + DrugProductionDateTime.Value.Day.ToString();
            DrugProduction = DrugProductionYear + DrugProductionMonth + DrugProductionyDay;
            //MessageBox.Show("DrugProduction：" + DrugProduction + ";  DrugValidity：" + DrugValidity);

            //药品入库日期
            string DrugPublishTime = System.DateTime.Now.ToString();

            if (string.IsNullOrEmpty(DrugNo))
            {
                MessageBox.Show("请输入药品编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (string.IsNullOrEmpty(DrugName))
            {
                MessageBox.Show("请输入药品名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrEmpty(DrugPrice))
            {
                MessageBox.Show("请输入药品价格！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            #endregion
            conn = new ConnectDB();
            SqlStr = "UPDATE YaoPin SET GYno=(select [GYno] from YaoPinGongYing where GYname='" + DrugProvide + "'),YPname='" + DrugName + "',YPJiaGe='" + DrugPrice + "',YPGuiGe='" + DrugSpecification + "',YPLeiBie='" + DrugType + "',YPShenChandate='" + DrugProduction + "',YPBaoZhiQi='" + DrugValidity + "' WHERE YPno='" + DrugNo + "'";
            bool insertStatus = conn.updateData(SqlStr);
            if (insertStatus)
            {
                MessageBox.Show("修改成功！");
                this.Hide();
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
            conn.conn.Close();
        }

     

       
    }
}
