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
    public partial class EmployeesInsert : Form
    {
        UserManager useMan = new UserManager();

        Employees emp = new Employees();

        public EmployeesInsert()
        {
            InitializeComponent();
        }

        private void EmployeesInsert_Load(object sender, EventArgs e)
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
            fac.CreateComboBox().Op(comboBoxPost);
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
            comboBoxPost.Text = "";
            string empID;
            string flag = useMan.SelectObjID("Employees", out empID);
            if (flag.Equals("Success")) { labelID.Text = empID; }
            else{ MessageBox.Show("查询失败!", "提示"); Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            emp.EmpID = labelID.Text;
            emp.Name = textName.Text;
            emp.Salary = textSalary.Text;
            emp.Post = comboBoxPost.Text;
            if (radioButton1.Checked == true) { emp.Sex = radioButton1.Text; }
            else { emp.Sex = radioButton2.Text; }
            emp.Telephone = textTel.Text;
            if (useMan.Insert(emp) == "Success")
            { MessageBox.Show("插入成功!", "提示"); Close(); }
            else if (useMan.Insert(emp) == "Fail")
            { MessageBox.Show("插入失败!", "提示"); }
        }
    }
}
