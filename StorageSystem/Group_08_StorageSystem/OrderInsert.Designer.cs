namespace Group_08_StorageSystem
{
    partial class OrderInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderInsert));
            this.labelID = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.labelPart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.comboBoxSup = new System.Windows.Forms.ComboBox();
            this.numericUpDownNum = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.comboBoxParts = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureAddPart = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureAddList = new System.Windows.Forms.PictureBox();
            this.pictureAddSup = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAddPart)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAddList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAddSup)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(101, 27);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(47, 12);
            this.labelID.TabIndex = 19;
            this.labelID.Text = "orderID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 21);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(199, 90);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(97, 23);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "录入订单";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "总额：";
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(228, 12);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(41, 12);
            this.labelNum.TabIndex = 15;
            this.labelNum.Text = "数量：";
            // 
            // labelPart
            // 
            this.labelPart.AutoSize = true;
            this.labelPart.Location = new System.Drawing.Point(10, 11);
            this.labelPart.Name = "labelPart";
            this.labelPart.Size = new System.Drawing.Size(41, 12);
            this.labelPart.TabIndex = 13;
            this.labelPart.Text = "货物：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "订单ID：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "供应商：";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(88, 47);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(11, 12);
            this.labelTotal.TabIndex = 23;
            this.labelTotal.Text = "0";
            // 
            // comboBoxSup
            // 
            this.comboBoxSup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSup.FormattingEnabled = true;
            this.comboBoxSup.Location = new System.Drawing.Point(99, 65);
            this.comboBoxSup.Name = "comboBoxSup";
            this.comboBoxSup.Size = new System.Drawing.Size(136, 20);
            this.comboBoxSup.TabIndex = 24;
            this.comboBoxSup.SelectedIndexChanged += new System.EventHandler(this.comboBoxSup_SelectedIndexChanged);
            // 
            // numericUpDownNum
            // 
            this.numericUpDownNum.Location = new System.Drawing.Point(275, 9);
            this.numericUpDownNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownNum.Name = "numericUpDownNum";
            this.numericUpDownNum.Size = new System.Drawing.Size(65, 21);
            this.numericUpDownNum.TabIndex = 25;
            this.numericUpDownNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownNum.ValueChanged += new System.EventHandler(this.numericUpDownNum_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "订单日期：";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(346, 12);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(41, 12);
            this.labelPrice.TabIndex = 15;
            this.labelPrice.Text = "单价：";
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Location = new System.Drawing.Point(393, 8);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(63, 21);
            this.numericUpDownPrice.TabIndex = 25;
            this.numericUpDownPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownPrice.ValueChanged += new System.EventHandler(this.numericUpDownNum_ValueChanged);
            // 
            // comboBoxParts
            // 
            this.comboBoxParts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParts.FormattingEnabled = true;
            this.comboBoxParts.Location = new System.Drawing.Point(57, 9);
            this.comboBoxParts.Name = "comboBoxParts";
            this.comboBoxParts.Size = new System.Drawing.Size(136, 20);
            this.comboBoxParts.TabIndex = 27;
            this.comboBoxParts.SelectedIndexChanged += new System.EventHandler(this.comboBoxParts_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxParts);
            this.panel1.Controls.Add(this.labelPart);
            this.panel1.Controls.Add(this.pictureAddPart);
            this.panel1.Controls.Add(this.labelNum);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.numericUpDownNum);
            this.panel1.Controls.Add(this.numericUpDownPrice);
            this.panel1.Location = new System.Drawing.Point(42, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 36);
            this.panel1.TabIndex = 28;
            // 
            // pictureAddPart
            // 
            this.pictureAddPart.Image = global::Group_08_StorageSystem.Properties.Resources.addButton1;
            this.pictureAddPart.Location = new System.Drawing.Point(199, 7);
            this.pictureAddPart.Name = "pictureAddPart";
            this.pictureAddPart.Size = new System.Drawing.Size(23, 23);
            this.pictureAddPart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAddPart.TabIndex = 26;
            this.pictureAddPart.TabStop = false;
            this.pictureAddPart.Click += new System.EventHandler(this.pictureAddPart_Click);
            this.pictureAddPart.MouseEnter += new System.EventHandler(this.pictureAddIcon_MouseEnter);
            this.pictureAddPart.MouseLeave += new System.EventHandler(this.pictureAddIcon_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.labelTotal);
            this.panel2.Location = new System.Drawing.Point(13, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 154);
            this.panel2.TabIndex = 29;
            // 
            // pictureAddList
            // 
            this.pictureAddList.Image = global::Group_08_StorageSystem.Properties.Resources.addButton1;
            this.pictureAddList.Location = new System.Drawing.Point(13, 110);
            this.pictureAddList.Name = "pictureAddList";
            this.pictureAddList.Size = new System.Drawing.Size(23, 23);
            this.pictureAddList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAddList.TabIndex = 26;
            this.pictureAddList.TabStop = false;
            this.pictureAddList.Click += new System.EventHandler(this.pictureAddList_Click);
            this.pictureAddList.MouseEnter += new System.EventHandler(this.pictureAddIcon_MouseEnter);
            this.pictureAddList.MouseLeave += new System.EventHandler(this.pictureAddIcon_MouseLeave);
            // 
            // pictureAddSup
            // 
            this.pictureAddSup.Image = global::Group_08_StorageSystem.Properties.Resources.addButton1;
            this.pictureAddSup.Location = new System.Drawing.Point(241, 64);
            this.pictureAddSup.Name = "pictureAddSup";
            this.pictureAddSup.Size = new System.Drawing.Size(23, 23);
            this.pictureAddSup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAddSup.TabIndex = 26;
            this.pictureAddSup.TabStop = false;
            this.pictureAddSup.Click += new System.EventHandler(this.pictureAddSup_Click);
            this.pictureAddSup.MouseEnter += new System.EventHandler(this.pictureAddIcon_MouseEnter);
            this.pictureAddSup.MouseLeave += new System.EventHandler(this.pictureAddIcon_MouseLeave);
            // 
            // OrderInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 336);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureAddList);
            this.Controls.Add(this.pictureAddSup);
            this.Controls.Add(this.comboBoxSup);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "订单录入";
            this.Load += new System.EventHandler(this.OrderInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAddPart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAddList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAddSup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label labelPart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ComboBox comboBoxSup;
        private System.Windows.Forms.NumericUpDown numericUpDownNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureAddSup;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.ComboBox comboBoxParts;
        private System.Windows.Forms.PictureBox pictureAddList;
        private System.Windows.Forms.PictureBox pictureAddPart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}