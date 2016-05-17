namespace Doctor
{
    partial class AddPatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatient));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_page = new System.Windows.Forms.TextBox();
            this.lab_page = new System.Windows.Forms.Label();
            this.tb_pmima = new System.Windows.Forms.TextBox();
            this.lab_mima = new System.Windows.Forms.Label();
            this.btn_ptijiao = new System.Windows.Forms.Button();
            this.tb_paddress = new System.Windows.Forms.TextBox();
            this.tb_ptell = new System.Windows.Forms.TextBox();
            this.tb_piphone = new System.Windows.Forms.TextBox();
            this.lab_paddress = new System.Windows.Forms.Label();
            this.lab_ptell = new System.Windows.Forms.Label();
            this.lab_piphone = new System.Windows.Forms.Label();
            this.cb_psex = new System.Windows.Forms.ComboBox();
            this.lab_psex = new System.Windows.Forms.Label();
            this.tb_pname = new System.Windows.Forms.TextBox();
            this.lab_pname = new System.Windows.Forms.Label();
            this.lab_pyhno = new System.Windows.Forms.Label();
            this.GhNoComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 74;
            this.label1.Text = "挂号编号：";
            // 
            // tb_page
            // 
            this.tb_page.Location = new System.Drawing.Point(329, 125);
            this.tb_page.Name = "tb_page";
            this.tb_page.Size = new System.Drawing.Size(126, 21);
            this.tb_page.TabIndex = 73;
            // 
            // lab_page
            // 
            this.lab_page.AutoSize = true;
            this.lab_page.BackColor = System.Drawing.Color.Transparent;
            this.lab_page.Location = new System.Drawing.Point(272, 128);
            this.lab_page.Name = "lab_page";
            this.lab_page.Size = new System.Drawing.Size(65, 12);
            this.lab_page.TabIndex = 72;
            this.lab_page.Text = "年    龄：";
            // 
            // tb_pmima
            // 
            this.tb_pmima.Location = new System.Drawing.Point(69, 125);
            this.tb_pmima.Name = "tb_pmima";
            this.tb_pmima.Size = new System.Drawing.Size(112, 21);
            this.tb_pmima.TabIndex = 71;
            // 
            // lab_mima
            // 
            this.lab_mima.AutoSize = true;
            this.lab_mima.BackColor = System.Drawing.Color.Transparent;
            this.lab_mima.Location = new System.Drawing.Point(12, 128);
            this.lab_mima.Name = "lab_mima";
            this.lab_mima.Size = new System.Drawing.Size(65, 12);
            this.lab_mima.TabIndex = 70;
            this.lab_mima.Text = "密    码：";
            // 
            // btn_ptijiao
            // 
            this.btn_ptijiao.Location = new System.Drawing.Point(183, 196);
            this.btn_ptijiao.Name = "btn_ptijiao";
            this.btn_ptijiao.Size = new System.Drawing.Size(75, 23);
            this.btn_ptijiao.TabIndex = 68;
            this.btn_ptijiao.Text = "提交";
            this.btn_ptijiao.UseVisualStyleBackColor = true;
            this.btn_ptijiao.Click += new System.EventHandler(this.btn_ptijiao_Click);
            // 
            // tb_paddress
            // 
            this.tb_paddress.Location = new System.Drawing.Point(71, 160);
            this.tb_paddress.Name = "tb_paddress";
            this.tb_paddress.Size = new System.Drawing.Size(386, 21);
            this.tb_paddress.TabIndex = 67;
            // 
            // tb_ptell
            // 
            this.tb_ptell.Location = new System.Drawing.Point(329, 87);
            this.tb_ptell.Name = "tb_ptell";
            this.tb_ptell.Size = new System.Drawing.Size(126, 21);
            this.tb_ptell.TabIndex = 66;
            // 
            // tb_piphone
            // 
            this.tb_piphone.Location = new System.Drawing.Point(69, 87);
            this.tb_piphone.Name = "tb_piphone";
            this.tb_piphone.Size = new System.Drawing.Size(112, 21);
            this.tb_piphone.TabIndex = 65;
            // 
            // lab_paddress
            // 
            this.lab_paddress.AutoSize = true;
            this.lab_paddress.BackColor = System.Drawing.Color.Transparent;
            this.lab_paddress.Location = new System.Drawing.Point(12, 163);
            this.lab_paddress.Name = "lab_paddress";
            this.lab_paddress.Size = new System.Drawing.Size(65, 12);
            this.lab_paddress.TabIndex = 64;
            this.lab_paddress.Text = "详细地址：";
            // 
            // lab_ptell
            // 
            this.lab_ptell.AutoSize = true;
            this.lab_ptell.BackColor = System.Drawing.Color.Transparent;
            this.lab_ptell.Location = new System.Drawing.Point(272, 90);
            this.lab_ptell.Name = "lab_ptell";
            this.lab_ptell.Size = new System.Drawing.Size(65, 12);
            this.lab_ptell.TabIndex = 63;
            this.lab_ptell.Text = "电    话：";
            // 
            // lab_piphone
            // 
            this.lab_piphone.AutoSize = true;
            this.lab_piphone.BackColor = System.Drawing.Color.Transparent;
            this.lab_piphone.Location = new System.Drawing.Point(12, 90);
            this.lab_piphone.Name = "lab_piphone";
            this.lab_piphone.Size = new System.Drawing.Size(65, 12);
            this.lab_piphone.TabIndex = 62;
            this.lab_piphone.Text = "手机号码：";
            // 
            // cb_psex
            // 
            this.cb_psex.FormattingEnabled = true;
            this.cb_psex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cb_psex.Location = new System.Drawing.Point(329, 46);
            this.cb_psex.Name = "cb_psex";
            this.cb_psex.Size = new System.Drawing.Size(126, 20);
            this.cb_psex.TabIndex = 61;
            // 
            // lab_psex
            // 
            this.lab_psex.AutoSize = true;
            this.lab_psex.BackColor = System.Drawing.Color.Transparent;
            this.lab_psex.Location = new System.Drawing.Point(272, 49);
            this.lab_psex.Name = "lab_psex";
            this.lab_psex.Size = new System.Drawing.Size(65, 12);
            this.lab_psex.TabIndex = 60;
            this.lab_psex.Text = "性    别：";
            // 
            // tb_pname
            // 
            this.tb_pname.Location = new System.Drawing.Point(69, 45);
            this.tb_pname.Name = "tb_pname";
            this.tb_pname.Size = new System.Drawing.Size(112, 21);
            this.tb_pname.TabIndex = 59;
            // 
            // lab_pname
            // 
            this.lab_pname.AutoSize = true;
            this.lab_pname.BackColor = System.Drawing.Color.Transparent;
            this.lab_pname.Location = new System.Drawing.Point(12, 49);
            this.lab_pname.Name = "lab_pname";
            this.lab_pname.Size = new System.Drawing.Size(65, 12);
            this.lab_pname.TabIndex = 58;
            this.lab_pname.Text = "患者姓名：";
            // 
            // lab_pyhno
            // 
            this.lab_pyhno.AutoSize = true;
            this.lab_pyhno.BackColor = System.Drawing.Color.Transparent;
            this.lab_pyhno.Location = new System.Drawing.Point(12, 9);
            this.lab_pyhno.Name = "lab_pyhno";
            this.lab_pyhno.Size = new System.Drawing.Size(137, 12);
            this.lab_pyhno.TabIndex = 57;
            this.lab_pyhno.Text = "用户编号：系统自动生成";
            // 
            // GhNoComboBox
            // 
            this.GhNoComboBox.FormattingEnabled = true;
            this.GhNoComboBox.Location = new System.Drawing.Point(329, 6);
            this.GhNoComboBox.Name = "GhNoComboBox";
            this.GhNoComboBox.Size = new System.Drawing.Size(126, 20);
            this.GhNoComboBox.TabIndex = 75;
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 227);
            this.Controls.Add(this.GhNoComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_page);
            this.Controls.Add(this.lab_page);
            this.Controls.Add(this.tb_pmima);
            this.Controls.Add(this.lab_mima);
            this.Controls.Add(this.btn_ptijiao);
            this.Controls.Add(this.tb_paddress);
            this.Controls.Add(this.tb_ptell);
            this.Controls.Add(this.tb_piphone);
            this.Controls.Add(this.lab_paddress);
            this.Controls.Add(this.lab_ptell);
            this.Controls.Add(this.lab_piphone);
            this.Controls.Add(this.cb_psex);
            this.Controls.Add(this.lab_psex);
            this.Controls.Add(this.tb_pname);
            this.Controls.Add(this.lab_pname);
            this.Controls.Add(this.lab_pyhno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPatient";
            this.Text = "添加患者信息";
            this.Load += new System.EventHandler(this.AddPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_page;
        private System.Windows.Forms.Label lab_page;
        private System.Windows.Forms.TextBox tb_pmima;
        private System.Windows.Forms.Label lab_mima;
        private System.Windows.Forms.Button btn_ptijiao;
        private System.Windows.Forms.TextBox tb_paddress;
        private System.Windows.Forms.TextBox tb_ptell;
        private System.Windows.Forms.TextBox tb_piphone;
        private System.Windows.Forms.Label lab_paddress;
        private System.Windows.Forms.Label lab_ptell;
        private System.Windows.Forms.Label lab_piphone;
        private System.Windows.Forms.ComboBox cb_psex;
        private System.Windows.Forms.Label lab_psex;
        private System.Windows.Forms.TextBox tb_pname;
        private System.Windows.Forms.Label lab_pname;
        private System.Windows.Forms.Label lab_pyhno;
        private System.Windows.Forms.ComboBox GhNoComboBox;
    }
}