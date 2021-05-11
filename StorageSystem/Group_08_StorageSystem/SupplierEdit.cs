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
    public partial class SupplierEdit : Form
    {
        private UserManager useMan = new UserManager();

        public Supplier supplier = new Supplier();

        public SupplierEdit()
        {
            InitializeComponent();
        }

        private void SupplierEdit_Load(object sender, EventArgs e)
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
            fac.CreateTextBox().Op(textArea);
            fac.CreateTextBox().Op(textName);
            fac.CreateTextBox().Op(textTel);
            fac.labelOP(label1);
            fac.labelOP(label2);
            fac.labelOP(label3);
            fac.labelOP(label4);
            fac.labelOP(labelID);

            //修改皮肤


            string flag = useMan.SelectDate(supplier.SupID, out supplier);
            if (flag == "Success")
            {
                labelID.Text = supplier.SupID;
                textName.Text = supplier.Name;
                textArea .Text = supplier.Area;
                textTel.Text = supplier.Telephone;
            }
            else if (flag.Equals("Fail")) { MessageBox.Show("数据查询失败!", "提示"); }
           }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            supplier.SupID = labelID.Text;
            supplier.Name = textName.Text;
            supplier.Area = textArea.Text;
            supplier.Telephone = textTel.Text;

            if (useMan.Edit(supplier) == "Success")
            { MessageBox.Show("修改成功!", "提示"); Close(); }
            else if (useMan.Edit(supplier) == "Fail")
            { MessageBox.Show("修改失败!", "提示"); }
        }
    }
}
