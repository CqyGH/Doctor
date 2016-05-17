using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Doctor
{
    class ConnectDB
    {
        public ConnectDB()
        {
            String sqlcon = "database=社区医疗系统;Password=123456;User ID=sa;server=.";
            try
            {
                conn = new SqlConnection(sqlcon);
                conn.Open();
                Console.WriteLine("lianjiechengg");
                Console.ReadLine();
            }
            catch (Exception err)
            {
                MessageBox.Show("连接数据库出现错误：" + err.ToString(), "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public SqlDataReader queryData(String op)
        {
            try
            {
                cmd = new SqlCommand(op, conn);
                reader = cmd.ExecuteReader();
            }
            catch (Exception err)
            {
                MessageBox.Show("查询数据出现错误：" + err.ToString(), "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return reader;
        }

        public bool updateData(String op)
        {
            try
            {
                cmd = new SqlCommand(op, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("更新数据时出现错误：" + err.ToString(), "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }

        public bool insertData(String op)
        {
            try
            {
                cmd = new SqlCommand(op, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("插入数据时出现错误：" + err.ToString(), "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public bool deleteData(String op)
        {
            try
            {
                cmd = new SqlCommand(op, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                //MessageBox.Show("删除数据时出现错误：" + err.ToString(), "提示",
                //    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public SqlConnection conn;
        public SqlCommand cmd;
        public SqlDataReader reader;

    }

}
