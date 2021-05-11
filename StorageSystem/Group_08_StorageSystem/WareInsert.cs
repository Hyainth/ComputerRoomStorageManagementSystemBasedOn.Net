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
    public partial class WareInsert : Form
    {
        private UserManager useMan = new UserManager();

        private Warehouse house;

        public WareInsert()
        {
            InitializeComponent();
        }

        private void WareInsert_Load(object sender, EventArgs e)
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
            fac.CreateTextBox().Op(textPosition);
            fac.CreateTextBox().Op(textName);
            fac.CreateTextBox().Op(textSize);
            fac.labelOP(label1);
            fac.labelOP(label2);
            fac.labelOP(label3);
            fac.labelOP(label4);
            fac.labelOP(labelID);

            //修改皮肤


            string houseID;
            if (useMan.SelectObjID("Warehouse", out houseID).Equals("Success")) { labelID.Text = houseID; }
            else { MessageBox.Show("查询失败!", "提示"); Close(); }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            house = new Warehouse();
            house.HouseID = labelID.Text;
            house.Name = textName.Text;
            house.Position = textPosition.Text;
            house.Size = textSize.Text;

            if (useMan.Insert(house).Equals("Success"))
            { MessageBox.Show("插入成功!", "提示"); Close(); }
            else if (useMan.Insert(house) == "Fail")
            { MessageBox.Show("插入失败!", "提示"); }
        }
    }
}
