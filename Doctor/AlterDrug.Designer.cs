namespace Doctor
{
    partial class AlterDrug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterDrug));
            this.DrugValidityDateTime = new System.Windows.Forms.DateTimePicker();
            this.DrugProductionDateTime = new System.Windows.Forms.DateTimePicker();
            this.DrugProvideComboBox1 = new System.Windows.Forms.ComboBox();
            this.DrugTypeComboBox = new System.Windows.Forms.ComboBox();
            this.DrugSpecificationText = new System.Windows.Forms.TextBox();
            this.DrugPriceText = new System.Windows.Forms.TextBox();
            this.DrugNameText = new System.Windows.Forms.TextBox();
            this.DrugNoText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddDrug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DrugValidityDateTime
            // 
            this.DrugValidityDateTime.Location = new System.Drawing.Point(85, 227);
            this.DrugValidityDateTime.Name = "DrugValidityDateTime";
            this.DrugValidityDateTime.Size = new System.Drawing.Size(116, 21);
            this.DrugValidityDateTime.TabIndex = 60;
            // 
            // DrugProductionDateTime
            // 
            this.DrugProductionDateTime.Location = new System.Drawing.Point(84, 199);
            this.DrugProductionDateTime.Name = "DrugProductionDateTime";
            this.DrugProductionDateTime.Size = new System.Drawing.Size(117, 21);
            this.DrugProductionDateTime.TabIndex = 59;
            // 
            // DrugProvideComboBox1
            // 
            this.DrugProvideComboBox1.FormattingEnabled = true;
            this.DrugProvideComboBox1.Location = new System.Drawing.Point(84, 97);
            this.DrugProvideComboBox1.Name = "DrugProvideComboBox1";
            this.DrugProvideComboBox1.Size = new System.Drawing.Size(117, 20);
            this.DrugProvideComboBox1.TabIndex = 58;
            this.DrugProvideComboBox1.Text = "请选择";
            // 
            // DrugTypeComboBox
            // 
            this.DrugTypeComboBox.FormattingEnabled = true;
            this.DrugTypeComboBox.Items.AddRange(new object[] {
            "中药",
            "西药",
            "输液"});
            this.DrugTypeComboBox.Location = new System.Drawing.Point(84, 122);
            this.DrugTypeComboBox.Name = "DrugTypeComboBox";
            this.DrugTypeComboBox.Size = new System.Drawing.Size(117, 20);
            this.DrugTypeComboBox.TabIndex = 57;
            this.DrugTypeComboBox.Text = "请选择";
            // 
            // DrugSpecificationText
            // 
            this.DrugSpecificationText.Location = new System.Drawing.Point(84, 172);
            this.DrugSpecificationText.Name = "DrugSpecificationText";
            this.DrugSpecificationText.Size = new System.Drawing.Size(117, 21);
            this.DrugSpecificationText.TabIndex = 56;
            // 
            // DrugPriceText
            // 
            this.DrugPriceText.Location = new System.Drawing.Point(84, 147);
            this.DrugPriceText.Name = "DrugPriceText";
            this.DrugPriceText.Size = new System.Drawing.Size(117, 21);
            this.DrugPriceText.TabIndex = 55;
            // 
            // DrugNameText
            // 
            this.DrugNameText.Location = new System.Drawing.Point(84, 72);
            this.DrugNameText.Name = "DrugNameText";
            this.DrugNameText.Size = new System.Drawing.Size(117, 21);
            this.DrugNameText.TabIndex = 54;
            // 
            // DrugNoText
            // 
            this.DrugNoText.Location = new System.Drawing.Point(84, 47);
            this.DrugNoText.Name = "DrugNoText";
            this.DrugNoText.Size = new System.Drawing.Size(117, 21);
            this.DrugNoText.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(46, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "修改药品信息";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 51;
            this.label8.Text = "有效期至：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 50;
            this.label7.Text = "生产日期：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 49;
            this.label6.Text = "药品规格：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 48;
            this.label5.Text = "药品价格：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 47;
            this.label4.Text = "药品类别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 46;
            this.label3.Text = "供应商名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 45;
            this.label2.Text = "药品名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 44;
            this.label1.Text = "药品编号：";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(126, 261);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 43;
            this.btnRefresh.Text = "取消";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnAddDrug
            // 
            this.btnAddDrug.Location = new System.Drawing.Point(15, 261);
            this.btnAddDrug.Name = "btnAddDrug";
            this.btnAddDrug.Size = new System.Drawing.Size(75, 23);
            this.btnAddDrug.TabIndex = 42;
            this.btnAddDrug.Text = "保存";
            this.btnAddDrug.UseVisualStyleBackColor = true;
            this.btnAddDrug.Click += new System.EventHandler(this.btnAddDrug_Click);
            // 
            // AlterDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 309);
            this.Controls.Add(this.DrugValidityDateTime);
            this.Controls.Add(this.DrugProductionDateTime);
            this.Controls.Add(this.DrugProvideComboBox1);
            this.Controls.Add(this.DrugTypeComboBox);
            this.Controls.Add(this.DrugSpecificationText);
            this.Controls.Add(this.DrugPriceText);
            this.Controls.Add(this.DrugNameText);
            this.Controls.Add(this.DrugNoText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddDrug);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlterDrug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改药品信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DrugValidityDateTime;
        private System.Windows.Forms.DateTimePicker DrugProductionDateTime;
        private System.Windows.Forms.ComboBox DrugProvideComboBox1;
        private System.Windows.Forms.ComboBox DrugTypeComboBox;
        private System.Windows.Forms.TextBox DrugSpecificationText;
        private System.Windows.Forms.TextBox DrugPriceText;
        private System.Windows.Forms.TextBox DrugNameText;
        private System.Windows.Forms.TextBox DrugNoText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddDrug;
    }
}