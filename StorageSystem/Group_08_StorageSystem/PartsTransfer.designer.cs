namespace Group_08_StorageSystem
{
    partial class PartsTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartsTransfer));
            this.comboBoxParts = new System.Windows.Forms.ComboBox();
            this.comboBoxToSto = new System.Windows.Forms.ComboBox();
            this.comboBoxFromSto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTrans = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPartNum = new System.Windows.Forms.Label();
            this.numericUpDownPartNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPartNum)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxParts
            // 
            this.comboBoxParts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParts.FormattingEnabled = true;
            this.comboBoxParts.Location = new System.Drawing.Point(85, 82);
            this.comboBoxParts.Name = "comboBoxParts";
            this.comboBoxParts.Size = new System.Drawing.Size(121, 20);
            this.comboBoxParts.TabIndex = 9;
            this.comboBoxParts.SelectedIndexChanged += new System.EventHandler(this.comboBoxParts_SelectedIndexChanged);
            // 
            // comboBoxToSto
            // 
            this.comboBoxToSto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxToSto.FormattingEnabled = true;
            this.comboBoxToSto.Location = new System.Drawing.Point(85, 167);
            this.comboBoxToSto.Name = "comboBoxToSto";
            this.comboBoxToSto.Size = new System.Drawing.Size(121, 20);
            this.comboBoxToSto.TabIndex = 10;
            // 
            // comboBoxFromSto
            // 
            this.comboBoxFromSto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFromSto.FormattingEnabled = true;
            this.comboBoxFromSto.Location = new System.Drawing.Point(85, 35);
            this.comboBoxFromSto.Name = "comboBoxFromSto";
            this.comboBoxFromSto.Size = new System.Drawing.Size(121, 20);
            this.comboBoxFromSto.TabIndex = 11;
            this.comboBoxFromSto.SelectedIndexChanged += new System.EventHandler(this.comboBoxFromSto_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "数量：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "转移至：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "货物：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "原仓库：";
            // 
            // buttonTrans
            // 
            this.buttonTrans.Location = new System.Drawing.Point(85, 207);
            this.buttonTrans.Name = "buttonTrans";
            this.buttonTrans.Size = new System.Drawing.Size(75, 23);
            this.buttonTrans.TabIndex = 4;
            this.buttonTrans.Text = "转移";
            this.buttonTrans.UseVisualStyleBackColor = true;
            this.buttonTrans.Click += new System.EventHandler(this.buttonTrans_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "储量：";
            // 
            // labelPartNum
            // 
            this.labelPartNum.AutoSize = true;
            this.labelPartNum.Location = new System.Drawing.Point(190, 127);
            this.labelPartNum.Name = "labelPartNum";
            this.labelPartNum.Size = new System.Drawing.Size(11, 12);
            this.labelPartNum.TabIndex = 8;
            this.labelPartNum.Text = "0";
            // 
            // numericUpDownPartNum
            // 
            this.numericUpDownPartNum.Location = new System.Drawing.Point(85, 123);
            this.numericUpDownPartNum.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownPartNum.Name = "numericUpDownPartNum";
            this.numericUpDownPartNum.Size = new System.Drawing.Size(55, 21);
            this.numericUpDownPartNum.TabIndex = 13;
            this.numericUpDownPartNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PartsTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 242);
            this.Controls.Add(this.numericUpDownPartNum);
            this.Controls.Add(this.comboBoxParts);
            this.Controls.Add(this.comboBoxToSto);
            this.Controls.Add(this.comboBoxFromSto);
            this.Controls.Add(this.labelPartNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTrans);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PartsTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "货物转移";
            this.Load += new System.EventHandler(this.PartsTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPartNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxParts;
        private System.Windows.Forms.ComboBox comboBoxToSto;
        private System.Windows.Forms.ComboBox comboBoxFromSto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTrans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelPartNum;
        private System.Windows.Forms.NumericUpDown numericUpDownPartNum;
    }
}