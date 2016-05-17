namespace Doctor
{
    partial class Reception
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reception));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_hadd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BrNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_hreset = new System.Windows.Forms.Button();
            this.btn_hsearch = new System.Windows.Forms.Button();
            this.tb_hiphone = new System.Windows.Forms.TextBox();
            this.tb_hname = new System.Windows.Forms.TextBox();
            this.lab_hiphone = new System.Windows.Forms.Label();
            this.cb_hsex = new System.Windows.Forms.ComboBox();
            this.lab_hsex = new System.Windows.Forms.Label();
            this.lab_hname = new System.Windows.Forms.Label();
            this.lab_hnowtime = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabRegistrationTime = new System.Windows.Forms.Label();
            this.lab_gghf = new System.Windows.Forms.Label();
            this.btn_gprint = new System.Windows.Forms.Button();
            this.btn_gsure = new System.Windows.Forms.Button();
            this.tb_gprice = new System.Windows.Forms.TextBox();
            this.cb_gks = new System.Windows.Forms.ComboBox();
            this.lab_gdate = new System.Windows.Forms.Label();
            this.lab_gprice = new System.Windows.Forms.Label();
            this.lab_gkeshi = new System.Windows.Forms.Label();
            this.lab_gghno = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 550);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.btn_hadd);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btn_hreset);
            this.tabPage1.Controls.Add(this.btn_hsearch);
            this.tabPage1.Controls.Add(this.tb_hiphone);
            this.tabPage1.Controls.Add(this.tb_hname);
            this.tabPage1.Controls.Add(this.lab_hiphone);
            this.tabPage1.Controls.Add(this.cb_hsex);
            this.tabPage1.Controls.Add(this.lab_hsex);
            this.tabPage1.Controls.Add(this.lab_hname);
            this.tabPage1.Controls.Add(this.lab_hnowtime);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "患者列表 ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_hadd
            // 
            this.btn_hadd.Location = new System.Drawing.Point(549, 61);
            this.btn_hadd.Name = "btn_hadd";
            this.btn_hadd.Size = new System.Drawing.Size(140, 23);
            this.btn_hadd.TabIndex = 11;
            this.btn_hadd.Text = " 新增患者信息";
            this.btn_hadd.UseVisualStyleBackColor = true;
            this.btn_hadd.Click += new System.EventHandler(this.btn_hadd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BrNoColumn,
            this.GhNoColumn,
            this.NameColumn,
            this.SexColumn,
            this.PhoneColumn,
            this.AgeColumn,
            this.AddressColumn});
            this.dataGridView1.Location = new System.Drawing.Point(6, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(740, 430);
            this.dataGridView1.TabIndex = 10;
            // 
            // BrNoColumn
            // 
            this.BrNoColumn.HeaderText = "病人编号";
            this.BrNoColumn.Name = "BrNoColumn";
            // 
            // GhNoColumn
            // 
            this.GhNoColumn.HeaderText = "挂号编号";
            this.GhNoColumn.Name = "GhNoColumn";
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "姓名";
            this.NameColumn.Name = "NameColumn";
            // 
            // SexColumn
            // 
            this.SexColumn.HeaderText = "性别";
            this.SexColumn.Name = "SexColumn";
            // 
            // PhoneColumn
            // 
            this.PhoneColumn.HeaderText = "联系电话";
            this.PhoneColumn.Name = "PhoneColumn";
            // 
            // AgeColumn
            // 
            this.AgeColumn.HeaderText = "年龄";
            this.AgeColumn.Name = "AgeColumn";
            // 
            // AddressColumn
            // 
            this.AddressColumn.HeaderText = "住址";
            this.AddressColumn.Name = "AddressColumn";
            // 
            // btn_hreset
            // 
            this.btn_hreset.Location = new System.Drawing.Point(781, 59);
            this.btn_hreset.Name = "btn_hreset";
            this.btn_hreset.Size = new System.Drawing.Size(57, 23);
            this.btn_hreset.TabIndex = 9;
            this.btn_hreset.Text = " 重置";
            this.btn_hreset.UseVisualStyleBackColor = true;
            // 
            // btn_hsearch
            // 
            this.btn_hsearch.Location = new System.Drawing.Point(483, 61);
            this.btn_hsearch.Name = "btn_hsearch";
            this.btn_hsearch.Size = new System.Drawing.Size(60, 23);
            this.btn_hsearch.TabIndex = 8;
            this.btn_hsearch.Text = "查询";
            this.btn_hsearch.UseVisualStyleBackColor = true;
            this.btn_hsearch.Click += new System.EventHandler(this.btn_hsearch_Click);
            // 
            // tb_hiphone
            // 
            this.tb_hiphone.Location = new System.Drawing.Point(353, 61);
            this.tb_hiphone.Name = "tb_hiphone";
            this.tb_hiphone.Size = new System.Drawing.Size(124, 21);
            this.tb_hiphone.TabIndex = 7;
            // 
            // tb_hname
            // 
            this.tb_hname.Location = new System.Drawing.Point(71, 61);
            this.tb_hname.Name = "tb_hname";
            this.tb_hname.Size = new System.Drawing.Size(105, 21);
            this.tb_hname.TabIndex = 3;
            // 
            // lab_hiphone
            // 
            this.lab_hiphone.AutoSize = true;
            this.lab_hiphone.Location = new System.Drawing.Point(296, 64);
            this.lab_hiphone.Name = "lab_hiphone";
            this.lab_hiphone.Size = new System.Drawing.Size(65, 12);
            this.lab_hiphone.TabIndex = 6;
            this.lab_hiphone.Text = "联系电话：";
            // 
            // cb_hsex
            // 
            this.cb_hsex.FormattingEnabled = true;
            this.cb_hsex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cb_hsex.Location = new System.Drawing.Point(217, 61);
            this.cb_hsex.Name = "cb_hsex";
            this.cb_hsex.Size = new System.Drawing.Size(73, 20);
            this.cb_hsex.TabIndex = 5;
            // 
            // lab_hsex
            // 
            this.lab_hsex.AutoSize = true;
            this.lab_hsex.Location = new System.Drawing.Point(182, 64);
            this.lab_hsex.Name = "lab_hsex";
            this.lab_hsex.Size = new System.Drawing.Size(41, 12);
            this.lab_hsex.TabIndex = 4;
            this.lab_hsex.Text = "性别：";
            // 
            // lab_hname
            // 
            this.lab_hname.AutoSize = true;
            this.lab_hname.Location = new System.Drawing.Point(12, 64);
            this.lab_hname.Name = "lab_hname";
            this.lab_hname.Size = new System.Drawing.Size(65, 12);
            this.lab_hname.TabIndex = 2;
            this.lab_hname.Text = "患者姓名：";
            // 
            // lab_hnowtime
            // 
            this.lab_hnowtime.AutoSize = true;
            this.lab_hnowtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_hnowtime.ForeColor = System.Drawing.Color.Red;
            this.lab_hnowtime.Location = new System.Drawing.Point(212, 19);
            this.lab_hnowtime.Name = "lab_hnowtime";
            this.lab_hnowtime.Size = new System.Drawing.Size(159, 25);
            this.lab_hnowtime.TabIndex = 1;
            this.lab_hnowtime.Text = "当前系统时间：";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(752, 524);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "挂号";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabRegistrationTime);
            this.panel1.Controls.Add(this.lab_gghf);
            this.panel1.Controls.Add(this.btn_gprint);
            this.panel1.Controls.Add(this.btn_gsure);
            this.panel1.Controls.Add(this.tb_gprice);
            this.panel1.Controls.Add(this.cb_gks);
            this.panel1.Controls.Add(this.lab_gdate);
            this.panel1.Controls.Add(this.lab_gprice);
            this.panel1.Controls.Add(this.lab_gkeshi);
            this.panel1.Controls.Add(this.lab_gghno);
            this.panel1.Location = new System.Drawing.Point(56, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 380);
            this.panel1.TabIndex = 19;
            // 
            // LabRegistrationTime
            // 
            this.LabRegistrationTime.AutoSize = true;
            this.LabRegistrationTime.Location = new System.Drawing.Point(445, 98);
            this.LabRegistrationTime.Name = "LabRegistrationTime";
            this.LabRegistrationTime.Size = new System.Drawing.Size(41, 12);
            this.LabRegistrationTime.TabIndex = 30;
            this.LabRegistrationTime.Text = "label1";
            // 
            // lab_gghf
            // 
            this.lab_gghf.AutoSize = true;
            this.lab_gghf.Location = new System.Drawing.Point(44, 245);
            this.lab_gghf.Name = "lab_gghf";
            this.lab_gghf.Size = new System.Drawing.Size(83, 12);
            this.lab_gghf.TabIndex = 29;
            this.lab_gghf.Text = "挂号费用：1元";
            // 
            // btn_gprint
            // 
            this.btn_gprint.Location = new System.Drawing.Point(369, 298);
            this.btn_gprint.Name = "btn_gprint";
            this.btn_gprint.Size = new System.Drawing.Size(75, 23);
            this.btn_gprint.TabIndex = 27;
            this.btn_gprint.Text = "打印";
            this.btn_gprint.UseVisualStyleBackColor = true;
            // 
            // btn_gsure
            // 
            this.btn_gsure.Location = new System.Drawing.Point(185, 298);
            this.btn_gsure.Name = "btn_gsure";
            this.btn_gsure.Size = new System.Drawing.Size(75, 23);
            this.btn_gsure.TabIndex = 26;
            this.btn_gsure.Text = "确认";
            this.btn_gsure.UseVisualStyleBackColor = true;
            this.btn_gsure.Click += new System.EventHandler(this.btn_gsure_Click);
            // 
            // tb_gprice
            // 
            this.tb_gprice.Location = new System.Drawing.Point(438, 169);
            this.tb_gprice.Name = "tb_gprice";
            this.tb_gprice.Size = new System.Drawing.Size(151, 21);
            this.tb_gprice.TabIndex = 25;
            // 
            // cb_gks
            // 
            this.cb_gks.FormattingEnabled = true;
            this.cb_gks.Location = new System.Drawing.Point(109, 169);
            this.cb_gks.Name = "cb_gks";
            this.cb_gks.Size = new System.Drawing.Size(151, 20);
            this.cb_gks.TabIndex = 24;
            this.cb_gks.Text = "请选择";
            // 
            // lab_gdate
            // 
            this.lab_gdate.AutoSize = true;
            this.lab_gdate.Location = new System.Drawing.Point(373, 98);
            this.lab_gdate.Name = "lab_gdate";
            this.lab_gdate.Size = new System.Drawing.Size(65, 12);
            this.lab_gdate.TabIndex = 23;
            this.lab_gdate.Text = "挂号日期：";
            // 
            // lab_gprice
            // 
            this.lab_gprice.AutoSize = true;
            this.lab_gprice.Location = new System.Drawing.Point(373, 172);
            this.lab_gprice.Name = "lab_gprice";
            this.lab_gprice.Size = new System.Drawing.Size(59, 12);
            this.lab_gprice.TabIndex = 22;
            this.lab_gprice.Text = "就诊费用:";
            // 
            // lab_gkeshi
            // 
            this.lab_gkeshi.AutoSize = true;
            this.lab_gkeshi.Location = new System.Drawing.Point(44, 172);
            this.lab_gkeshi.Name = "lab_gkeshi";
            this.lab_gkeshi.Size = new System.Drawing.Size(59, 12);
            this.lab_gkeshi.TabIndex = 21;
            this.lab_gkeshi.Text = "就诊科室:";
            // 
            // lab_gghno
            // 
            this.lab_gghno.AutoSize = true;
            this.lab_gghno.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_gghno.Location = new System.Drawing.Point(44, 98);
            this.lab_gghno.Name = "lab_gghno";
            this.lab_gghno.Size = new System.Drawing.Size(59, 12);
            this.lab_gghno.TabIndex = 19;
            this.lab_gghno.Text = "挂号编号:";
            // 
            // Reception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reception";
            this.Text = "挂号管理";
            this.Load += new System.EventHandler(this.Reception_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_hreset;
        private System.Windows.Forms.Button btn_hsearch;
        private System.Windows.Forms.TextBox tb_hiphone;
        private System.Windows.Forms.TextBox tb_hname;
        private System.Windows.Forms.Label lab_hsex;
        private System.Windows.Forms.Label lab_hname;
        private System.Windows.Forms.Label lab_hnowtime;
        private System.Windows.Forms.Label lab_hiphone;
        private System.Windows.Forms.ComboBox cb_hsex;
        private System.Windows.Forms.Button btn_hadd;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_gghf;
        private System.Windows.Forms.Button btn_gprint;
        private System.Windows.Forms.Button btn_gsure;
        private System.Windows.Forms.TextBox tb_gprice;
        private System.Windows.Forms.ComboBox cb_gks;
        private System.Windows.Forms.Label lab_gdate;
        private System.Windows.Forms.Label lab_gprice;
        private System.Windows.Forms.Label lab_gkeshi;
        private System.Windows.Forms.Label lab_gghno;
        private System.Windows.Forms.Label LabRegistrationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SexColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;
    }
}