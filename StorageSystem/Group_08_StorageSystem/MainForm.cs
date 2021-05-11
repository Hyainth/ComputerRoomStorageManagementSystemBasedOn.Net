using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using BLL;
using DAL;
using Model;

namespace Group_08_StorageSystem
{
    public partial class MainForm : Form
    {
        private UserManager useMan = new UserManager();

        User user = new User();

        private AbstractFactory fac = null;

        private string timeInfo, picInfo;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new Login().ShowDialog();
            if (UserManager.userID.Equals("")) { Application.ExitThread(); return; }

            if (AbstractFactory.SkinStyle.Equals("Black"))
            { fac = new BlackSkin(); }
            else if (AbstractFactory.SkinStyle.Equals("Blue"))
            { fac = new BlueSkin(); }
            else if (AbstractFactory.SkinStyle.Equals("Yellow"))
            { fac = new YellowSkin(); }
            else { fac = new DefaultSkin(); }

            fac.CreateForm().Op(this);
            fac.CreateButton().Op(button1);
            fac.labelOP(label1);
            fac.labelOP(label2);
            fac.labelOP(label3);
            fac.labelOP(label4);
            fac.labelOP(label5);
            fac.labelOP(label6);
            fac.labelOP(label7);
            fac.labelOP(label8);
            fac.labelOP(labelID);
            fac.labelOP(labelName);
            fac.PicBoxOP(pictureEmp);
            fac.PicBoxOP(pictureOrder);
            fac.PicBoxOP(picturePart);
            fac.PicBoxOP(pictureRoom);
            fac.PicBoxOP(pictureSup);
            fac.PicBoxOP(pictureWarehouse);

            //修改皮肤
            toolStripStatusLabel1.BackColor = Color.Transparent;
            toolStripStatusLabel2.BackColor = Color.Transparent;
            

            if (useMan.SelectDate(UserManager.userID, out user).Equals("Success"))
            {
                labelID.Text = user.UserID;
                if (UserManager.userType.Equals("admin"))
                { labelName.Text = "Admin"; }
                else
                {
                    Employees emp = new Employees();
                    Label labelPost = new Label();
                    Label labelPostName = new Label();
                    
                    if (useMan.SelectDate(user.UserID, out emp).Equals("Success")) { labelName.Text = emp.Name; }

                    pictureEmp.Visible = false;
                    label3.Visible = false;

                    int X1 = pictureEmp.Location.X, X2 = picturePart.Location.X, X3 = pictureSup.Location.X;
                    int Y = (int)((pictureEmp.Location.Y + pictureOrder.Location.Y) / 2);

            
                    picturePart.Location = new System.Drawing.Point(X1, Y);
                    label4.Location = new Point(X1+26, Y + 80);

                    if (UserManager.userType.Equals("storage"))
                    {
                        label5.Visible = false;
                        label6.Visible = false;
                        pictureSup.Visible = false;
                        pictureOrder.Visible = false;

                        pictureWarehouse.Location = new System.Drawing.Point(X2, Y);
                        pictureRoom.Location = new System.Drawing.Point(X3, Y);
                        label7.Location=new Point(X2 + 26, Y + 80);
                        label8.Location=new Point(X3 + 26, Y + 80);

                    }
                    else if (UserManager.userType.Equals("order"))
                    {
                        label7.Visible = false;
                        label8.Visible = false;
                        pictureRoom.Visible = false;
                        pictureWarehouse.Visible = false;

                        pictureSup.Location = new System.Drawing.Point(X2, Y);
                        pictureOrder.Location = new System.Drawing.Point(X3, Y);
                        label5.Location = new Point(X2 + 20, Y + 80);
                        label6.Location = new Point(X3 + 26, Y + 80);
                    }

                    labelPost.AutoSize = true;
                    labelPost.Location = new System.Drawing.Point(400, labelName.Location.Y);
                    labelPost.Text = "职务：";
                    labelPostName.AutoSize = true;
                    labelPostName.Location = new System.Drawing.Point(450, labelName.Location.Y);
                    labelPostName.Text = emp.Post;
                    fac.labelOP(labelPost);
                    fac.labelOP(labelPostName);
                    this.Controls.Add(labelPost);
                    this.Controls.Add(labelPostName);
                    //生成label
                }

                timeInfo = DateTime.Now.ToString("yyyy-MM-dd  HH:mm:ss");
                picInfo = user.LoginInfo.Split('|')[1];
                pictureBox1.Image = Image.FromFile(Application.StartupPath + picInfo);
                toolStripStatusLabel2.Text = timeInfo;
            }


        }


        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog fileReader = new OpenFileDialog();
            if (fileReader.ShowDialog() == DialogResult.OK)
            {
                if (MessageBox.Show("确认修改头像?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    picInfo = Application.StartupPath + @"\images\" + fileReader.SafeFileName;
                    File.Copy(fileReader.FileName, picInfo, true);
                    pictureBox1.Image = Image.FromFile(picInfo);
                    picInfo = @"\images\" + fileReader.SafeFileName;
                }
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            user.LoginInfo = timeInfo + "|" + picInfo;
            if (useMan.Edit(user).Equals("Success")) { }
            else { return; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PWDEdit().ShowDialog();
        }

        private void pictureEmp_Click(object sender, EventArgs e)
        {
            new EmployeesMessage().ShowDialog();
        }

        private void picturePart_Click(object sender, EventArgs e)
        {
            new PartMessage().ShowDialog();
        }

        private void pictureSup_Click(object sender, EventArgs e)
        {
            new SupplierMessage().ShowDialog();
        }

        private void pictureOrder_Click(object sender, EventArgs e)
        {
            new OrderMessage().ShowDialog();
        }

        private void pictureWarehouse_Click(object sender, EventArgs e)
        {
            new StorageMessage().ShowDialog();
        }

        private void pictureRoom_Click(object sender, EventArgs e)
        {
            new MachineRoomMessage().ShowDialog();
        }

        private void 灰色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbstractFactory.SkinStyle = "Black";
            AbstractFactory fac = new BlackSkin();
            fac.CreateForm().Op(this);
            fac.CreateButton().Op(button1);
        }

        private void 蓝色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbstractFactory.SkinStyle = "Blue";
            AbstractFactory fac = new BlueSkin();
            fac.CreateForm().Op(this);
            fac.CreateButton().Op(button1);
        }

        private void 黄色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbstractFactory.SkinStyle = "Yellow";
            AbstractFactory fac = new YellowSkin();
            fac.CreateForm().Op(this);
            fac.CreateButton().Op(button1);
        }

        private void morenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbstractFactory.SkinStyle = "default";
            AbstractFactory fac = new DefaultSkin();
            fac.CreateForm().Op(this);
            fac.CreateButton().Op(button1);
        }

        private void 员工管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new EmployeesMessage().ShowDialog();
        }

        private void 物品管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PartMessage().ShowDialog();
        }

        private void 供应商管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SupplierMessage().ShowDialog();
        }

        private void 订单管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OrderMessage().ShowDialog();
        }

        private void 仓储管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StorageMessage().ShowDialog();
        }

        private void 机房查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MachineRoomMessage().ShowDialog();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
