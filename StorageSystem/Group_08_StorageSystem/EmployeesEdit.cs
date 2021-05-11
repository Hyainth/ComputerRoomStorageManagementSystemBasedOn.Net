using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using DAL;
using Model;

namespace Group_08_StorageSystem
{
    public partial class EmployeesEdit : Form
    {
        private UserManager useMan = new UserManager();

        public Employees emp = new Employees();

        public EmployeesEdit()
        {
            InitializeComponent();
        }

        private void EmployeesEdit_Load(object sender, EventArgs e)
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
            fac.CreateTextBox().Op(textName);
            fac.CreateTextBox().Op(textSalary);
            fac.CreateTextBox().Op(textTel);
            fac.labelOP(label1);
            fac.labelOP(label2);
            fac.labelOP(label3);
            fac.labelOP(label4);
            fac.labelOP(label5);
            fac.labelOP(label6);
            fac.labelOP(labelID);
            //修改皮肤
            panel1.BackColor = Color.Transparent;

            List<string> posts;
            if (useMan.SelectPost(out posts).Equals("Success")) { comboBoxPost.DataSource = posts; }

            string flag = useMan.SelectDate(emp.EmpID, out emp);
            if (flag == "Success")
            {
                labelID.Text = emp.EmpID;
                textName.Text = emp.Name;
                comboBoxPost.Text = emp.Post;
                textSalary.Text = emp.Salary;
                textTel.Text = emp.Telephone;
                if (emp.Sex.Equals("男")) { radioButton1.Checked = true; }
                else { radioButton2.Checked = true; }
            }
            else if (flag.Equals("Fail")) { MessageBox.Show("数据查询失败!", "提示"); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            emp.EmpID = labelID.Text;
            emp.Name = textName.Text;
            emp.Salary = textSalary.Text;
            emp.Post = comboBoxPost.Text;
            if (radioButton1.Checked == true) { emp.Sex = radioButton1.Text; }
            else { emp.Sex = radioButton2.Text; }
            emp.Telephone = textTel.Text;
            if (useMan.Edit(emp) == "Success")
            { MessageBox.Show("修改成功!", "提示"); Close(); }
            else if (useMan.Edit(emp) == "Fail")
            { MessageBox.Show("修改失败!", "提示"); }
        }

    }
}
