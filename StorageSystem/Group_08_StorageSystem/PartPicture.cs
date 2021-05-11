using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Model;
using DAL;
using BLL;

namespace Group_08_StorageSystem
{
    public partial class PartPicture : Form
    {
        private UserManager useMan = new UserManager();
        public string partID = "";

        public PartPicture()
        {
            InitializeComponent();
        }

        private void PartPicture_Load(object sender, EventArgs e)
        {
            Parts part=new Parts();
            if (useMan.SelectDate(partID, out part).Equals("Success"))
            {  
                if (!File.Exists(Application.StartupPath + @"\partPic\" + partID + ".jpg"))
                {
                    MessageBox.Show("找不到图片!");
                    return;
                }
                 pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\partPic\" + partID + ".jpg");
            }

        }
    }
}
