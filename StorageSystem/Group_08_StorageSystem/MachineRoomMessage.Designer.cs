namespace Group_08_StorageSystem
{
    partial class MachineRoomMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MachineRoomMessage));
            this.buttonRoom1 = new System.Windows.Forms.Button();
            this.buttonRoom2 = new System.Windows.Forms.Button();
            this.buttonRoom3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRoom1
            // 
            this.buttonRoom1.Location = new System.Drawing.Point(31, 54);
            this.buttonRoom1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRoom1.Name = "buttonRoom1";
            this.buttonRoom1.Size = new System.Drawing.Size(75, 23);
            this.buttonRoom1.TabIndex = 0;
            this.buttonRoom1.Text = "机房1";
            this.buttonRoom1.UseVisualStyleBackColor = true;
            this.buttonRoom1.Click += new System.EventHandler(this.buttonRoom1_Click);
            // 
            // buttonRoom2
            // 
            this.buttonRoom2.Location = new System.Drawing.Point(31, 209);
            this.buttonRoom2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRoom2.Name = "buttonRoom2";
            this.buttonRoom2.Size = new System.Drawing.Size(75, 23);
            this.buttonRoom2.TabIndex = 0;
            this.buttonRoom2.Text = "机房2";
            this.buttonRoom2.UseVisualStyleBackColor = true;
            this.buttonRoom2.Click += new System.EventHandler(this.buttonRoom2_Click);
            // 
            // buttonRoom3
            // 
            this.buttonRoom3.Location = new System.Drawing.Point(31, 363);
            this.buttonRoom3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRoom3.Name = "buttonRoom3";
            this.buttonRoom3.Size = new System.Drawing.Size(75, 23);
            this.buttonRoom3.TabIndex = 0;
            this.buttonRoom3.Text = "机房3";
            this.buttonRoom3.UseVisualStyleBackColor = true;
            this.buttonRoom3.Click += new System.EventHandler(this.buttonRoom3_Click);
            // 
            // MachineRoomMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 602);
            this.Controls.Add(this.buttonRoom3);
            this.Controls.Add(this.buttonRoom2);
            this.Controls.Add(this.buttonRoom1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MachineRoomMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "机房状态查看";
            this.Load += new System.EventHandler(this.MachineRoomMessage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRoom1;
        private System.Windows.Forms.Button buttonRoom2;
        private System.Windows.Forms.Button buttonRoom3;



    }
}