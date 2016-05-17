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
    public partial class Login : Form
    {
        public string SqlStr;
        public string BJstr;
        public string str;
        public string checkCode = String.Empty;
        public bool cancleLogin;
        public int i, j;
        public string userName;     //用户名，对应数据库中ZGno
        public string userPWD;      //密码，对应数据库中ZGPassword
        public string Code;         //获取用户输入的验证码，需要注意的是：验证码区分大小写，现在生成的验证码只有大写，如果需要演示代码或者做测试，记得使用大写输入
        public string job;          //获取用户选择的需要进入的角色模块
        public static Doctor doctor;
        public static DrugManage drugM;
        ConnectDB conn;

        public Login()
        {
            InitializeComponent();
            conn = new ConnectDB();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            BJstr = CheckCode();
            CodeImage(BJstr);
        }

        #region 验证码

        /// <summary>
        /// 生成验证码
        /// </summary>
        /// <returns></returns>
        private string CheckCode()								//此方法生成字符串
        {
            int number;
            char code;
            // string checkCode = String.Empty;					//声明变量存储随机生成的4位英文或数字
            Random random = new Random();						//生成随机数
            for (int i = 0; i < 4; i++)
            {
                number = random.Next();							//返回非负随机数
                if (number % 2 == 0)							//判断数字是否为偶数
                    code = (char)('0' + (char)(number % 10));
                else											//如果不是偶数
                    code = (char)('A' + (char)(number % 26));
                checkCode += code.ToString();				//累加字符串
            }
            return " " + checkCode + " ";

            //返回生成的字符串
        }

        //生成验证码
        private void CodeImage(string checkCode)
        {
            if (checkCode == null || checkCode.Trim() == String.Empty)
                return;
            System.Drawing.Bitmap image = new System.Drawing.Bitmap((int)Math.Ceiling((checkCode.Length * 9.5)), 22);
            Graphics g = Graphics.FromImage(image);					//创建Graphics对象
            try
            {
                Random random = new Random();						//生成随机生成器
                g.Clear(Color.White); 								//清空图片背景色
                for (int i = 0; i < 3; i++)							//画图片的背景噪音线
                {
                    int x1 = random.Next(image.Width);
                    int x2 = random.Next(image.Width);
                    int y1 = random.Next(image.Height);
                    int y2 = random.Next(image.Height);
                    g.DrawLine(new Pen(Color.Black), x1, y1, x2, y2);
                }
                Font font = new System.Drawing.Font("Arial", 12, (System.Drawing.FontStyle.Bold));
                g.DrawString(checkCode, font, new SolidBrush(Color.Red), 2, 2);
                for (int i = 0; i < 150; i++)						//画图片的前景噪音点
                {
                    int x = random.Next(image.Width);
                    int y = random.Next(image.Height);
                    image.SetPixel(x, y, Color.FromArgb(random.Next()));
                }
                //画图片的边框线
                g.DrawRectangle(new Pen(Color.Silver), 0, 0, image.Width - 1, image.Height - 1);
                this.pictureBox1.Width = image.Width;				//设置PictureBox的宽度
                this.pictureBox1.Height = image.Height;				//设置PictureBox的高度
                this.pictureBox1.BackgroundImage = image;			//设置PictureBox的背景图像
            }
            catch
            { }
        }

        /// <summary>
        /// 刷新，重新获取验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnefresh_Click_1(object sender, EventArgs e)
        {
            checkCode = string.Empty;
            BJstr = CheckCode();
            CodeImage(BJstr);
        }
        //private void btnefresh_Click(object sender, EventArgs e)
        //{
           
        //}

        #endregion

        #region 用户登录
        /// <summary>
        /// 用户登录事件。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {


        }

        #endregion

        #region 关闭窗体事件
        /// <summary>
        /// 退出按钮，用户点击退出，询问是否退出：如果确认退出，关闭Form窗体；如果点击“否”，则不做任何事情。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogout_Click(object sender, EventArgs e)
        {
           
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("你确定要关闭此窗体么？", "关闭提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);//触发事件进行提示
            if (dr == DialogResult.No)
            {
                e.Cancel = true;//就不退了
            }
            else
            {
                e.Cancel = false;//退了
            }
        }
        #endregion

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
//#if DEBUG
//            new DrugManage("ZG001").Show();
//#endif

//#if DEBUG
//            new Reception("ZG001").Show();

//#endif

//#if DEBUG
//            new Doctor("ZG001").Show();

//#endif

//#if DEBUG
//            new Charges("ZG001").Show();

//#endif


            
            userName = UserNameText.Text.Trim();
            userPWD = UserPWDText.Text.Trim();
            Code = CodeText.Text.Trim();

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("请输入用户！","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(userPWD))
            {
                MessageBox.Show("请输入密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(Code))
            {
                MessageBox.Show("请输入验证码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                job = comboBox1.SelectedItem.ToString();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("请选择需要登录的模块");
                return;
                
            }
           
            if (Code != BJstr.Trim())
            {
                MessageBox.Show("验证码输入错误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                SqlStr = "SELECT ZGno,ZGPassword FROM ZhiGongBiao";
                conn.reader = conn.queryData(SqlStr);
                conn.reader.Read();

                if (conn.reader.HasRows)
                {
                    if (userName == conn.reader.GetString(0) && userPWD == conn.reader.GetString(1))
                    {
                        if (job == "医生")
                        {
                            doctor = new Doctor(userName);
                            doctor.Show();
                        }
                        else if (job == "采购员")
                        {
                            drugM = new DrugManage(userName);
                            drugM.Show();
                        }
                        else if (job == "挂号员")
                        {
                            new Reception(userName).Show();
                        }
                        else 
                        {
                            new Charges(userName).Show();
                        }
                        conn.reader.Close();
                        conn.conn.Close();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("你确定要关闭此窗体么？", "关闭提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);//触发事件进行提示
            if (dr == DialogResult.No)
            {
                //就不退了

            }
            else
            {
                this.Close();//退了
            }
        }

      
    }
}
