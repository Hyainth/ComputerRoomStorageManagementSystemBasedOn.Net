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
    public partial class Login : Form
    {
        UserManager useMan = new UserManager();

        List<string> storage = new List<string>();
        List<string[]> userMessage = new List<string[]>();
        List<string> userName = new List<string>();
        List<string> userPWD = new List<string>();
        List<string> userType = new List<string>();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            pictureUserName.BackColor = Color.Transparent;
            picturePassWord.BackColor = Color.Transparent;
            pictureSeePWD.BackColor = Color.Transparent;
            pictureTextPWD.BackColor = Color.Transparent;
            pictureCloth.BackColor = Color.Transparent;
            pictureTitle.BackColor = Color.Transparent;
            checkBoxPWD.BackColor = Color.Transparent;

            button1.BackgroundImage = Image.FromFile(Application.StartupPath + @"\pic\button.jpg");

            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\pic\background1.jpg");

            StreamReader sr = new StreamReader(Application.StartupPath + @"\account.txt");
            int i = 0;
            while (sr.Peek() > -1)
            {
                storage.Add(sr.ReadLine());
                i++;
            }
            sr.Close();

            for (int j = 0; j < storage.Count; j++)
            {
                userMessage.Add(storage[j].Split('|'));
                userName.Add(userMessage[j][0]);
                userPWD.Add(userMessage[j][1]);
                userType.Add(userMessage[j][2]);
            }
            comboBoxUser.DataSource = userName;
            if (comboBoxUser.Items.Count > 0) { comboBoxUser.SelectedIndex = 0; }
            radioBlack.Checked = true;
        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserManager.userType = userType[userName.IndexOf(comboBoxUser.Text)];
            textBoxPWD.Text = userPWD[comboBoxUser.SelectedIndex];
            if (textBoxPWD.Text.Equals(""))
            {
                checkBoxPWD.Checked = false;
                userPWD[comboBoxUser.SelectedIndex] = "";
            }
            else { checkBoxPWD.Checked = true; }
        }

        private void comboBoxUser_TextChanged(object sender, EventArgs e)
        {
            textBoxPWD.Text = "";
            checkBoxPWD.Checked = false;
            if (userName.IndexOf(comboBoxUser.Text) >= 0)
            {
                if (!userPWD[userName.IndexOf(comboBoxUser.Text)].Equals(""))
                {
                    textBoxPWD.Text = userPWD[userName.IndexOf(comboBoxUser.Text)];
                    checkBoxPWD.Checked = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string passWord = textBoxPWD.Text;
            string md5Pass = Adapter.Encrypt(passWord);
            useMan.user.UserID = comboBoxUser.Text;
            useMan.user.Password = md5Pass;

            if (useMan.Login().Equals("Success"))
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + @"\account.txt");
                if (!(comboBoxUser.SelectedIndex < 0))
                {
                    if (checkBoxPWD.Checked) { userPWD[comboBoxUser.SelectedIndex] = passWord; }
                    else { userPWD[comboBoxUser.SelectedIndex] = ""; }
                    storage[comboBoxUser.SelectedIndex] = userName[comboBoxUser.SelectedIndex] + "|" + userPWD[comboBoxUser.SelectedIndex] + "|" + userType[comboBoxUser.SelectedIndex];
                }
                else if (userName.IndexOf(comboBoxUser.Text) >= 0)
                {
                    if (checkBoxPWD.Checked) { userPWD[userName.IndexOf(comboBoxUser.Text)] = passWord; }
                    else { userPWD[comboBoxUser.SelectedIndex] = ""; }
                    storage[userName.IndexOf(comboBoxUser.Text)] = userName[userName.IndexOf(comboBoxUser.Text)] + "|" + userPWD[userName.IndexOf(comboBoxUser.Text)] + "|" + userType[userName.IndexOf(comboBoxUser.Text)];           
                }
                else if (userName.IndexOf(comboBoxUser.Text) < 0)
                {
                    userName.Add(comboBoxUser.Text);
                    if (checkBoxPWD.Checked) { userPWD.Add(passWord); }
                    else { userPWD.Add(""); }
                    userType.Add("admin");
                    storage.Add(userName[userName.Count - 1] + "|" + userPWD[userPWD.Count - 1] + "|" + userType[userType.Count - 1]);
                }
                for (int i = 0; i < storage.Count; i++)
                {
                    sw.WriteLine(storage[i]);
                }

                if (radioBlue.Checked) AbstractFactory.SkinStyle = "Blue";
                if (radioBlack.Checked) AbstractFactory.SkinStyle = "Black";
                if (radioYellow.Checked) AbstractFactory.SkinStyle = "Yellow";

                sw.Close();
                Close();
            }
            else if (useMan.Login().Equals("PWerro"))
            {
                MessageBox.Show("密码错误!", "提示");
                textBoxPWD.Focus();
            }
            else if (useMan.Login().Equals("NoCount"))
            {
                MessageBox.Show("找不到该帐号!", "提示");
                comboBoxUser.Focus();
            }
            else if (useMan.Login().Equals("NoID"))
            {
                MessageBox.Show("帐号不能为空!", "提示");
                comboBoxUser.Focus();
            }
            else if (useMan.Login().Equals("NoPW"))
            {
                MessageBox.Show("密码不能为空!", "提示");
                textBoxPWD.Focus();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        private void pictureSeePWD_Click(object sender, EventArgs e)
        {
            if (textBoxPWD.UseSystemPasswordChar)
            {
                pictureSeePWD.Image = Image.FromFile(Application.StartupPath + @"\pic\pwd_on.png");
                textBoxPWD.UseSystemPasswordChar = false;
            }
            else
            {
                pictureSeePWD.Image = Image.FromFile(Application.StartupPath + @"\pic\pwd_off.png");
                textBoxPWD.UseSystemPasswordChar = true;
            }

        }
    }
}
