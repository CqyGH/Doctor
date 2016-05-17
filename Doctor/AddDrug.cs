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
    public partial class AddDrug : Form
    {
        ConnectDB conn;
        private string SqlStr;
        public AddDrug()
        {
            InitializeComponent();

            #region 初始化加载供应商
            this.DrugProvideComboBox.Items.Clear();
            conn = new ConnectDB();
            SqlStr = "  SELECT [GYname] from YaoPinGongYing";

            conn.queryData(SqlStr);
            while (conn.reader.Read())
            {
                this.DrugProvideComboBox.Items.Add(conn.reader[0]);
            }
            conn.reader.Close();
            conn.conn.Close();
            #endregion

        }

        private void btnAddDrug_Click(object sender, EventArgs e)
        {
            #region 获取用户输入数据
            string DrugSpecification=DrugSpecificationText.Text.Trim();
            string DrugNo = DrugNoText.Text.Trim();         //药品编号
            string DrugName = DrugNameText.Text.Trim();     //药品名称
            string DrugProvide;                             //药品提供商
            string DrugType;                                //药品类别
            try                                             //使用try是为了防止出现：未将对象引用设置到对象的实例异常。
            {
                DrugProvide = DrugProvideComboBox.SelectedItem.ToString();
                DrugType = DrugTypeComboBox.SelectedItem.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+"请选择信息！");
                return;
            }           
            string DrugPrice = DrugPriceText.Text.Trim();   //药品价格

            //药品有效期
            string DrugValidity;                           
            string DrugValidityYear = DrugValidityDateTime.Value.Year.ToString();
            var DrugValidityMonth = ((DrugValidityDateTime.Value.Month<10)?"0":"")+DrugValidityDateTime.Value.Month.ToString();
            var DrugValidityDay = ((DrugValidityDateTime.Value.Day<10)?"0":"")+DrugValidityDateTime.Value.Day.ToString();
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
            SqlStr=" INSERT into YaoPin([YPno],[GYno],[YPname],[YPJiaGe],[YPGuiGe],[YPLeiBie],[YPShenChandate],[YPBaoZhiQi],[YPRuKudate]) select '"+DrugNo+"',GYno,'"+DrugName+"','"+DrugPrice+"','"+DrugSpecification+"','"+DrugType+"','"+DrugProduction+"','"+DrugValidity+"','"+DrugPublishTime+"' from YaoPinGongYing where GYname='"+DrugProvide+"'";
            bool insertStatus = conn.insertData(SqlStr);
            if (insertStatus)
            {
                MessageBox.Show("插入成功！");
                DrugPriceText.Text = "";
                DrugNoText.Text = "";
                DrugNameText.Text = "";
                DrugProvideComboBox.Text = "请选择";
                DrugTypeComboBox.Text = "请选择";
                DrugSpecificationText.Text = "";
            }
            else
            {
                MessageBox.Show("插入失败！");
            }
            conn.conn.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DrugPriceText.Text = "";
            DrugNoText.Text = "";
            DrugNameText.Text = "";
            DrugProvideComboBox.Text = "请选择";
            DrugTypeComboBox.Text = "请选择";
            DrugSpecificationText.Text = "";
        }




    }
}
