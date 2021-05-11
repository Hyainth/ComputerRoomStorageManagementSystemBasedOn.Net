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
    public partial class OrderMessageDetail : Form
    {
        UserManager useMan = new UserManager();


        public string orderID = "";

        private OrderList order;
        private AbstractFactory fac = null;
        List<string> partName;

        public OrderMessageDetail()
        {
            InitializeComponent();
        }

        private void OrderMessageDetail_Load(object sender, EventArgs e)
        {
            if (AbstractFactory.SkinStyle.Equals("Black"))
            { fac = new BlackSkin(); }
            else if (AbstractFactory.SkinStyle.Equals("Blue"))
            { fac = new BlueSkin(); }
            else if (AbstractFactory.SkinStyle.Equals("Yellow"))
            { fac = new YellowSkin(); }
            else { fac = new DefaultSkin(); }

            fac.CreateForm().Op(this);
            fac.CreateButton().Op(buttonClose);
            fac.labelOP(label1);
            fac.labelOP(label3);
            fac.labelOP(label5);
            fac.labelOP(label8);
            fac.labelOP(labelDate);
            fac.labelOP(labelID);
            fac.labelOP(labelSupplier);
            fac.labelOP(labelTotal);

            //修改皮肤
            panel1.BackColor = Color.Transparent;

            int height = 30;

            partName = new List<string>();
            DataTable dt = new DataTable();
            if (useMan.Select("Parts", out dt).Equals("Success"))
            {
                for (int i = 0; i < dt.Rows.Count; i++) { partName.Add(dt.Rows[i][1].ToString()); }
            }


            if (useMan.SelectDate(orderID, out order).Equals("Success"))
            {
                string[] partMessage = order.PartsInfo.Split(',');
                string[] partInfo;
                for (int i = 0; i < partMessage.Length; i++)
                {
                    partInfo=partMessage[i].Split('|');

                     Label labelNum = new Label();
                     Label labelPrice = new Label();
                     Label labelPart = new Label();
                     Label labelPartNum = new Label();
                     Label labelPartPrice = new Label();
                     Label labelPartName = new Label();

                    labelNum.AutoSize = true;
                    labelNum.Location = new System.Drawing.Point(280, 110 + i * height);
                    labelNum.Text = "数量：";

                    labelPrice.AutoSize = true;
                    labelPrice.Location = new System.Drawing.Point(370, 110 + i * height);
                    labelPrice.Text = "单价：";

                    labelPart.AutoSize = true;
                    labelPart.Location = new System.Drawing.Point(70, 110 + i * height);
                    labelPart.Text = "货物：";

                    //标识label
                    
                    labelPartNum.AutoSize = true;
                    labelPartNum.Location = new System.Drawing.Point(330, 110 + i * height);
                    labelPartNum.Text = partInfo[1];

                    labelPartPrice.AutoSize = true;
                    labelPartPrice.Location = new System.Drawing.Point(420, 110 + i * height);
                    labelPartPrice.Text = partInfo[2];


                    labelPartName.AutoSize = true;
                    labelPartName.Location = new System.Drawing.Point(120, 110 + i * height);
                    labelPartName.Text = partName[Convert.ToInt32( partInfo[0])-1];
                    

                    fac.labelOP(labelNum);
                    fac.labelOP(labelPart);
                    fac.labelOP(labelPartName);
                    fac.labelOP(labelPartNum);
                    fac.labelOP(labelPartPrice);
                    fac.labelOP(labelPrice);


                    this.ClientSize = new System.Drawing.Size(this.Size.Width, this.Size.Height);
                    this.panel1.Location = new Point(panel1.Location.X, panel1.Location.Y + height);
                    //具体信息

                    this.Controls.Add(labelNum);
                    this.Controls.Add(labelPart);
                    this.Controls.Add(labelPrice);
                    this.Controls.Add(labelPartPrice);
                    this.Controls.Add(labelPartName);
                    this.Controls.Add(labelPartNum);

                }
            }




            labelID.Text = orderID;
            labelDate.Text = order.Date.ToString();
            labelTotal.Text = order.Total;

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
