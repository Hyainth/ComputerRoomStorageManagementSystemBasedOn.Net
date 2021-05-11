namespace Group_08_StorageSystem
{
    partial class MachineMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MachineMessage));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboRoomID = new System.Windows.Forms.ComboBox();
            this.comboSeatID = new System.Windows.Forms.ComboBox();
            this.listBoxDevice = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "设备信息：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "座位号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "机房号：";
            // 
            // comboRoomID
            // 
            this.comboRoomID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRoomID.FormattingEnabled = true;
            this.comboRoomID.Location = new System.Drawing.Point(134, 49);
            this.comboRoomID.Name = "comboRoomID";
            this.comboRoomID.Size = new System.Drawing.Size(136, 20);
            this.comboRoomID.TabIndex = 32;
            this.comboRoomID.SelectedIndexChanged += new System.EventHandler(this.comboRoomID_SelectedIndexChanged);
            // 
            // comboSeatID
            // 
            this.comboSeatID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSeatID.FormattingEnabled = true;
            this.comboSeatID.Location = new System.Drawing.Point(134, 89);
            this.comboSeatID.Name = "comboSeatID";
            this.comboSeatID.Size = new System.Drawing.Size(136, 20);
            this.comboSeatID.TabIndex = 32;
            this.comboSeatID.SelectedIndexChanged += new System.EventHandler(this.comboSeatID_SelectedIndexChanged);
            // 
            // listBoxDevice
            // 
            this.listBoxDevice.FormattingEnabled = true;
            this.listBoxDevice.ItemHeight = 12;
            this.listBoxDevice.Location = new System.Drawing.Point(134, 163);
            this.listBoxDevice.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxDevice.Name = "listBoxDevice";
            this.listBoxDevice.Size = new System.Drawing.Size(140, 160);
            this.listBoxDevice.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "状态：";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(132, 125);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(35, 12);
            this.labelState.TabIndex = 27;
            this.labelState.Text = "State";
            // 
            // MachineMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 363);
            this.Controls.Add(this.listBoxDevice);
            this.Controls.Add(this.comboSeatID);
            this.Controls.Add(this.comboRoomID);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MachineMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设备信息";
            this.Load += new System.EventHandler(this.MachineMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboRoomID;
        private System.Windows.Forms.ComboBox comboSeatID;
        private System.Windows.Forms.ListBox listBoxDevice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelState;
    }
}