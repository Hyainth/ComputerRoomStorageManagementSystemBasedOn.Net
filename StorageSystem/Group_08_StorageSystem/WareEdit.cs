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
    public partial class WareEdit : Form
    {
        private UserManager useMan = new UserManager();

        public Warehouse house=new Warehouse();

        public WareEdit()
        {
            InitializeComponent();
        }

        private void WareEdit_Load(object sender, EventArgs e)
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

            string flag = useMan.SelectDate(house.HouseID, out house);
            if (flag == "Success")
            {
                labelID.Text = house.HouseID;
                textName.Text = house.Name;
                textPosition.Text = house.Position;
                textSize.Text = house.Size;
            }
            else if (flag.Equals("Fail")) { MessageBox.Show("数据查询失败!", "提示"); Close(); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            house.HouseID = labelID.Text;
            house.Name = textName.Text;
            house.Position = textPosition.Text;
            house.Size = textSize.Text;
            if (useMan.Edit(house).Equals("Success"))
            { MessageBox.Show("修改成功!", "提示"); Close(); }
            else if (useMan.Edit(house) == "Fail")
            { MessageBox.Show("修改成功!", "提示"); }
            Close();
        }
    }
}
