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
    public partial class PartEdit : Form
    {
        private UserManager useMan = new UserManager();

        public Parts part = new Parts();

        public PartEdit()
        {
            InitializeComponent();
        }

        private void PartEdit_Load(object sender, EventArgs e)
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
            fac.CreateComboBox().Op(comboBoxType);
            fac.labelOP(label1);
            fac.labelOP(label2);
            fac.labelOP(label3);
            fac.labelOP(label4);
            fac.labelOP(label6);
            fac.labelOP(labelID);

            //修改皮肤


            List<string> type;
            if (useMan.SelectType(out type).Equals("Success")) { comboBoxType.DataSource = type; }

            string flag = useMan.SelectDate(part.PartID, out part);
            if (flag == "Success")
            {
                labelID.Text = part.PartID;
                textName.Text = part.Name;
                comboBoxType.Text = part.Type;
                textPrice.Text = part.Price;
                textInfo.Text = part.Info;
            }
            else if (flag.Equals("Fail")) { MessageBox.Show("数据查询失败!", "提示"); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            part.PartID = labelID.Text;
            part.Name = textName.Text;
            part.Price = textPrice.Text;
            part.Type = comboBoxType.Text;
            part.Info = textInfo.Text;

            if (useMan.Edit(part) == "Success")
            { MessageBox.Show("修改成功!", "提示"); Close(); }
            else if (useMan.Edit(part) == "Fail")
            { MessageBox.Show("修改失败!", "提示"); }
        }
    }
}
