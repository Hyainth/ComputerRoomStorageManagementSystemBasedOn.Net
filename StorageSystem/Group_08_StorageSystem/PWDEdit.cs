using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using DAL;
using BLL;

namespace Group_08_StorageSystem
{
    public partial class PWDEdit : Form
    {
        private UserManager useMan = new UserManager();

        private bool pwdFlag = false;
        private User user;

        public PWDEdit()
        {
            InitializeComponent();
        }

        private void PWDEdit_Load(object sender, EventArgs e)
        {
            AbstractFactory fac = null;
            if (AbstractFactory.SkinStyle.Equals("Black"))
            { fac = new BlackSkin(); }
            else if (AbstractFactory.SkinStyle.Equals("Blue"))
            { fac = new BlueSkin(); }
            else if (AbstractFactory.SkinStyle.Equals("Yellow"))
            { fac = new YellowSkin(); }
            else { fac = new DefaultSkin(); }

            fac.CreateForm().Op(this);
            fac.CreateTextBox().Op(textPWD);
            fac.CreateTextBox().Op(textPWDNew);
            fac.CreateTextBox().Op(textPWDCheck);
            fac.CreateButton().Op(buttonEdit);
            fac.labelOP(label1);
            fac.labelOP(label2);
            fac.labelOP(label3);
            fac.labelOP(label5);
            fac.labelOP(labelID);
            fac.PicBoxOP(pictureBoxCheck);
            fac.PicBoxOP(pictureBoxTag);

            //修改皮肤

            labelID.Text = UserManager.userID;
        }

        private void textPWDNew_TextChanged(object sender, EventArgs e)
        {
            if (textPWDNew.TextLength < 6)
            {
                pictureBoxTag.Image = Image.FromFile(Application.StartupPath + @"/pic/addButton2.png");
                toolTip.SetToolTip(pictureBoxTag, "密码过短!");
                pwdFlag = false;
            }
            else if (textPWDNew.TextLength > 15)
            {
                pictureBoxTag.Image = Image.FromFile(Application.StartupPath + @"/pic/addButton2.png");
                toolTip.SetToolTip(pictureBoxTag, "密码过长!");
                pwdFlag = false;
            }
            else
            {
                pictureBoxTag.Image = Image.FromFile(Application.StartupPath + @"/pic/addButton1.png");
                toolTip.SetToolTip(pictureBoxTag, "");
                pwdFlag = true;
            }
        }

        private void textPWDCheck_TextChanged(object sender, EventArgs e)
        {
            if (!textPWDCheck.Text.Equals(textPWDNew.Text))
            {
                pictureBoxCheck.Image = Image.FromFile(Application.StartupPath + @"/pic/addButton2.png");
                toolTip.SetToolTip(pictureBoxCheck, "两次密码不相同!");
                pwdFlag = false;
            }
            else
            {
                pictureBoxCheck.Image = Image.FromFile(Application.StartupPath + @"/pic/addButton1.png");
                toolTip.SetToolTip(pictureBoxCheck, "");
                pwdFlag = true;
            }

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string md5pass = Adapter.Encrypt(textPWD.Text);
            user = new User();
            if (textPWD.TextLength == 0)
            {
                MessageBox.Show("原密码不可为空!");
                textPWD.Focus();
            }
            if (pwdFlag)
            {
                if (useMan.SelectDate(labelID.Text,out user ).Equals("Success"))
                {
                    if (md5pass.Equals(user.Password))
                    {
                        user.Password = Adapter.Encrypt(textPWDNew.Text);
                        if (useMan.Edit(user).Equals("Success"))
                        {
                            MessageBox.Show("修改成功!");
                            Close();
                        }
                    }
                    else { MessageBox.Show("密码错误!"); }
                }
            }
            else
            {
                MessageBox.Show("请检查输入数据!", "提示");
                textPWDNew.Focus();
            }
        }

    }
}
