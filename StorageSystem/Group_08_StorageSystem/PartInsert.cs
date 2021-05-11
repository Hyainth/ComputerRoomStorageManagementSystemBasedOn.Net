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
    public partial class PartInsert : Form
    {
        UserManager useMan = new UserManager();

        Parts part = new Parts();

        public PartInsert()
        {
            InitializeComponent();
        }

        private void PartInsert_Load(object sender, EventArgs e)
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
            fac.CreateTextBox().Op(textInfo);
            fac.CreateTextBox().Op(textName);
            fac.CreateTextBox().Op(textPrice);
            fac.labelOP(label1);
            fac.labelOP(label2);
            fac.labelOP(label3);
            fac.labelOP(label4);
            fac.labelOP(label6);
            fac.labelOP(labelID);

            //修改皮肤
            
            
            List<string> type;
            if (useMan.SelectType(out type).Equals("Success")) { comboBoxType.DataSource = type; }
            comboBoxType.Text = "";
            string partID;
            string flag = useMan.SelectObjID("Parts", out partID);
            if (flag.Equals("Success")) { labelID.Text = partID; }
            else { MessageBox.Show("查询失败!", "提示"); Close(); }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            part.PartID = labelID.Text;
            part.Name = textName.Text;
            part.Price = textPrice.Text;
            part.Type = comboBoxType.Text;
            part.Info = textInfo.Text;

            if (useMan.Insert(part) == "Success")
            { MessageBox.Show("插入成功!", "提示"); Close(); }
            else if (useMan.Insert(part) == "Fail")
            { MessageBox.Show("插入失败!", "提示"); }
        }
    }
}
