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
    public partial class SupplierInsert : Form
    {
        UserManager useMan = new UserManager();

        Supplier supplier = new Supplier();

        public SupplierInsert()
        {
            InitializeComponent();
        }

        private void SupplierInsert_Load(object sender, EventArgs e)
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


            string supID;
            string flag = useMan.SelectObjID("Supplier", out supID);
            if (flag.Equals("Success")) { labelID.Text = supID; }
            else { MessageBox.Show("查询失败!", "提示"); Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            supplier.SupID = labelID.Text;
            supplier.Name = textName.Text;
            supplier.Area = textArea.Text;
            supplier.Telephone = textTel.Text;        

            if (useMan.Insert(supplier) == "Success")
            { MessageBox.Show("插入成功!", "提示"); Close(); }
            else if (useMan.Insert(supplier) == "Fail")
            { MessageBox.Show("插入失败!", "提示"); }
        }
    }
}
