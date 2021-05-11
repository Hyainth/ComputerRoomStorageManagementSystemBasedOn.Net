namespace Group_08_StorageSystem
{
    partial class PWDEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PWDEdit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textPWD = new System.Windows.Forms.TextBox();
            this.textPWDNew = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textPWDCheck = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.pictureBoxTag = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxCheck = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "原密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "新密码：";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(95, 42);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(41, 12);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "userID";
            // 
            // textPWD
            // 
            this.textPWD.Location = new System.Drawing.Point(98, 84);
            this.textPWD.Margin = new System.Windows.Forms.Padding(2);
            this.textPWD.Name = "textPWD";
            this.textPWD.Size = new System.Drawing.Size(85, 21);
            this.textPWD.TabIndex = 0;
            this.toolTip.SetToolTip(this.textPWD, "请输入原密码");
            this.textPWD.UseSystemPasswordChar = true;
            // 
            // textPWDNew
            // 
            this.textPWDNew.Location = new System.Drawing.Point(98, 134);
            this.textPWDNew.Margin = new System.Windows.Forms.Padding(2);
            this.textPWDNew.Name = "textPWDNew";
            this.textPWDNew.Size = new System.Drawing.Size(85, 21);
            this.textPWDNew.TabIndex = 1;
            this.toolTip.SetToolTip(this.textPWDNew, "密码长度为6-18位");
            this.textPWDNew.UseSystemPasswordChar = true;
            this.textPWDNew.TextChanged += new System.EventHandler(this.textPWDNew_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "重复：";
            // 
            // textPWDCheck
            // 
            this.textPWDCheck.Location = new System.Drawing.Point(98, 183);
            this.textPWDCheck.Margin = new System.Windows.Forms.Padding(2);
            this.textPWDCheck.Name = "textPWDCheck";
            this.textPWDCheck.Size = new System.Drawing.Size(85, 21);
            this.textPWDCheck.TabIndex = 2;
            this.textPWDCheck.UseSystemPasswordChar = true;
            this.textPWDCheck.TextChanged += new System.EventHandler(this.textPWDCheck_TextChanged);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(80, 234);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "保存";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // pictureBoxTag
            // 
            this.pictureBoxTag.Location = new System.Drawing.Point(190, 130);
            this.pictureBoxTag.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxTag.Name = "pictureBoxTag";
            this.pictureBoxTag.Size = new System.Drawing.Size(30, 26);
            this.pictureBoxTag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTag.TabIndex = 2;
            this.pictureBoxTag.TabStop = false;
            // 
            // pictureBoxCheck
            // 
            this.pictureBoxCheck.Location = new System.Drawing.Point(190, 183);
            this.pictureBoxCheck.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCheck.Name = "pictureBoxCheck";
            this.pictureBoxCheck.Size = new System.Drawing.Size(30, 26);
            this.pictureBoxCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCheck.TabIndex = 2;
            this.pictureBoxCheck.TabStop = false;
            // 
            // PWDEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 293);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.pictureBoxCheck);
            this.Controls.Add(this.pictureBoxTag);
            this.Controls.Add(this.textPWDCheck);
            this.Controls.Add(this.textPWDNew);
            this.Controls.Add(this.textPWD);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PWDEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "密码修改";
            this.Load += new System.EventHandler(this.PWDEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textPWD;
        private System.Windows.Forms.TextBox textPWDNew;
        private System.Windows.Forms.PictureBox pictureBoxTag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPWDCheck;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox pictureBoxCheck;
    }
}