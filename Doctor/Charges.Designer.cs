namespace Doctor
{
    partial class Charges
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Charges));
            this.button6 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnShouFei = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UserNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuFangNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YaoPinNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuFangDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchChuFang = new System.Windows.Forms.Button();
            this.UserNoText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(232, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 53;
            this.button6.Text = "查询";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(784, 561);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(424, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(325, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "当前时间：";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 527);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnShouFei);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnSearchChuFang);
            this.tabPage1.Controls.Add(this.UserNoText);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.splitter1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "收费发药";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnShouFei
            // 
            this.btnShouFei.Location = new System.Drawing.Point(247, 11);
            this.btnShouFei.Name = "btnShouFei";
            this.btnShouFei.Size = new System.Drawing.Size(75, 23);
            this.btnShouFei.TabIndex = 13;
            this.btnShouFei.Text = "收费";
            this.btnShouFei.UseVisualStyleBackColor = true;
            this.btnShouFei.Click += new System.EventHandler(this.btnShouFei_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserNoColumn,
            this.UserNameColumn,
            this.ChuFangNoColumn,
            this.YaoPinNoColumn,
            this.ChuFangDateColumn});
            this.dataGridView1.Location = new System.Drawing.Point(3, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(759, 453);
            this.dataGridView1.TabIndex = 12;
            // 
            // UserNoColumn
            // 
            this.UserNoColumn.HeaderText = "患者编号";
            this.UserNoColumn.Name = "UserNoColumn";
            this.UserNoColumn.ReadOnly = true;
            // 
            // UserNameColumn
            // 
            this.UserNameColumn.HeaderText = "患者姓名";
            this.UserNameColumn.Name = "UserNameColumn";
            this.UserNameColumn.ReadOnly = true;
            // 
            // ChuFangNoColumn
            // 
            this.ChuFangNoColumn.HeaderText = "处方编号";
            this.ChuFangNoColumn.Name = "ChuFangNoColumn";
            this.ChuFangNoColumn.ReadOnly = true;
            // 
            // YaoPinNoColumn
            // 
            this.YaoPinNoColumn.HeaderText = "药品编号";
            this.YaoPinNoColumn.Name = "YaoPinNoColumn";
            this.YaoPinNoColumn.ReadOnly = true;
            // 
            // ChuFangDateColumn
            // 
            this.ChuFangDateColumn.HeaderText = "处方日期";
            this.ChuFangDateColumn.Name = "ChuFangDateColumn";
            this.ChuFangDateColumn.ReadOnly = true;
            // 
            // btnSearchChuFang
            // 
            this.btnSearchChuFang.Location = new System.Drawing.Point(179, 9);
            this.btnSearchChuFang.Name = "btnSearchChuFang";
            this.btnSearchChuFang.Size = new System.Drawing.Size(61, 23);
            this.btnSearchChuFang.TabIndex = 11;
            this.btnSearchChuFang.Text = "查询";
            this.btnSearchChuFang.UseVisualStyleBackColor = true;
            this.btnSearchChuFang.Click += new System.EventHandler(this.btnSearchChuFang_Click);
            // 
            // UserNoText
            // 
            this.UserNoText.Location = new System.Drawing.Point(67, 11);
            this.UserNoText.Name = "UserNoText";
            this.UserNoText.Size = new System.Drawing.Size(100, 21);
            this.UserNoText.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 12);
            this.label6.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "患者编号：";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(3, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(762, 33);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView6);
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.textBox16);
            this.tabPage4.Controls.Add(this.label38);
            this.tabPage4.Controls.Add(this.splitter4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 501);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "收费查询";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView6.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(3, 36);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowTemplate.Height = 23;
            this.dataGridView6.Size = new System.Drawing.Size(951, 218);
            this.dataGridView6.TabIndex = 55;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(75, 9);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(98, 21);
            this.textBox16.TabIndex = 42;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label38.Location = new System.Drawing.Point(15, 12);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(65, 12);
            this.label38.TabIndex = 41;
            this.label38.Text = "患者姓名：";
            // 
            // splitter4
            // 
            this.splitter4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter4.Location = new System.Drawing.Point(3, 3);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(762, 69);
            this.splitter4.TabIndex = 0;
            this.splitter4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Charges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Charges";
            this.Text = "收费管理";
            this.Load += new System.EventHandler(this.Charges_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearchChuFang;
        private System.Windows.Forms.TextBox UserNoText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnShouFei;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuFangNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn YaoPinNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuFangDateColumn;
    }
}