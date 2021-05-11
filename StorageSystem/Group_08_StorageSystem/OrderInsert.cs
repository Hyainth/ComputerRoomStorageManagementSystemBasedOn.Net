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
    public partial class OrderInsert : Form
    {
        private UserManager useMan = new UserManager();

        private List<string> supList;
        private List<string> partList;

        private Supplier supplier;
        private Parts part;
        private OrderList oList;
        private DataTable dt;

        private List<ComboBox> comboListPart = new List<ComboBox>();
        private List<NumericUpDown> numUpDownListPrice = new List<NumericUpDown>();
        private List<NumericUpDown> numUpDownListNum = new List<NumericUpDown>();


        private int panFlag = 1;

        public OrderInsert()
        {
            InitializeComponent();
        }

        private void OrderInsert_Load(object sender, EventArgs e)
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
            fac.CreateButton().Op(buttonAdd);
            fac.labelOP(label1);
            fac.labelOP(label3);
            fac.labelOP(label5);
            fac.labelOP(label8);
            fac.labelOP(labelID);
            fac.labelOP(labelNum);
            fac.labelOP(labelPart);
            fac.labelOP(labelPrice);
            fac.labelOP(labelTotal);
            fac.PicBoxOP(pictureAddList);
            fac.PicBoxOP(pictureAddPart);
            fac.PicBoxOP(pictureAddSup);

            //修改皮肤

            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
            
            string orderID;
            numUpDownListPrice.Add(numericUpDownPrice);
            numUpDownListNum.Add(numericUpDownNum);
            supSelect(comboBoxSup);
            partSelect(comboBoxParts);
            if (useMan.SelectObjID("OrderList", out orderID).Equals("Success"))
            {
                labelID.Text = orderID;
            }
        }

        private void pictureAddIcon_MouseEnter(object sender, EventArgs e)
        {
            PictureBox picb = (PictureBox)sender;
            picb.Image = Image.FromFile(Application.StartupPath + @"\pic\addButton2.png");
        }

        private void pictureAddIcon_MouseLeave(object sender, EventArgs e)
        {
            PictureBox picb = (PictureBox)sender;
            picb.Image = Image.FromFile(Application.StartupPath + @"\pic\addButton1.png");
        }

        private void pictureAddSup_Click(object sender, EventArgs e)
        {
            new SupplierInsert().ShowDialog();
            supSelect(comboBoxSup);
            comboBoxSup.SelectedIndex = comboBoxSup.Items.Count - 1;
        }

        private void pictureAddPart_Click(object sender, EventArgs e)
        {
            new PartInsert().ShowDialog();
            partSelect(comboBoxParts);
            comboBoxParts.SelectedIndex = comboBoxParts.Items.Count - 1;
        }

        private void pictureAddList_Click(object sender, EventArgs e)
        {
            Label lbPart = new Label();
            Label lbNum = new Label();
            Label lbPrice = new Label();
            ComboBox comboPart = new ComboBox();
            NumericUpDown numUpDownPrice = new NumericUpDown();
            NumericUpDown numUpDownNum = new NumericUpDown();

            lbPart.Location = new System.Drawing.Point(labelPart.Location.X, labelPart.Location.Y + 40 * panFlag);
            lbPart.Size = new System.Drawing.Size(labelPart.Size.Width, labelPrice.Size.Height);
            lbPart.Text = "货物：";
            lbNum.Location = new System.Drawing.Point(labelNum.Location.X, labelNum.Location.Y + 40 * panFlag);
            lbNum.Size = new System.Drawing.Size(labelNum.Size.Width, labelNum.Size.Height);
            lbNum.Text = "数量：";
            lbPrice.Location = new System.Drawing.Point(labelPrice.Location.X, labelPrice.Location.Y + 40 * panFlag);
            lbPrice.Size = new System.Drawing.Size(labelPrice.Size.Width, labelPrice.Size.Height);
            lbPrice.Text = "单价：";

            comboPart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboPart.FormattingEnabled = true;
            comboPart.Location = new System.Drawing.Point(comboBoxParts.Location.X, comboBoxParts.Location.Y + 40 * panFlag);
            comboPart.Size = new System.Drawing.Size(comboBoxParts.Size.Width, comboBoxParts.Size.Height);
            comboPart.SelectedIndexChanged += new System.EventHandler(this.comboBoxParts_SelectedIndexChanged);
            partSelect(comboPart);

            numUpDownPrice.Location = new System.Drawing.Point(numericUpDownPrice.Location.X, numericUpDownPrice.Location.Y + 40 * panFlag);
            numUpDownPrice.Size = new System.Drawing.Size(numericUpDownPrice.Size.Width, numericUpDownPrice.Size.Height);
            numUpDownPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            numUpDownPrice.ValueChanged += new System.EventHandler(this.numericUpDownNum_ValueChanged);
            numUpDownPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });


            numUpDownNum.Location = new System.Drawing.Point(numericUpDownNum.Location.X, numericUpDownNum.Location.Y + 40 * panFlag);
            numUpDownNum.Size = new System.Drawing.Size(numericUpDownNum.Size.Width, numericUpDownNum.Size.Height);
            numUpDownNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            numUpDownNum.ValueChanged += new System.EventHandler(this.numericUpDownNum_ValueChanged);
            numUpDownNum.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            
            numUpDownListPrice.Add(numUpDownPrice);
            numUpDownListNum.Add(numUpDownNum);

            panel1.Controls.Add(lbPart);
            panel1.Controls.Add(lbNum);
            panel1.Controls.Add(lbPrice);
            panel1.Controls.Add(comboPart);
            panel1.Controls.Add(numUpDownPrice);
            panel1.Controls.Add(numUpDownNum);

            panel1.Size = new System.Drawing.Size(panel1.Size.Width, panel1.Size.Height + 40);
            panel2.Location = new System.Drawing.Point(panel2.Location.X, panel2.Location.Y + 40);
            ClientSize = new System.Drawing.Size(ClientSize.Width, ClientSize.Height + 40);
            panFlag++;

        }   //自动生成


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            double total = 0;
            string partsInfo = "";
            string partID = "";
            dt = new DataTable();
            oList = new OrderList();
            oList.OrderID = labelID.Text;
            oList.SupID = supplier.SupID;
            oList.EmpID = UserManager.userID;
            for (int i = 0; i < comboListPart.Count; i++)
            {
                if (useMan.Select("Parts", "name", comboListPart[i].Text, out dt).Equals("Success"))
                {
                    if (dt.Rows.Count > 0) { partID = dt.Rows[0][0].ToString(); }
                }
                else { continue; }
                if (i == 0) { partsInfo = partID + "|" + numUpDownListNum[i].Value + "|" + numUpDownListPrice[i].Value; }
                else { partsInfo += "," + partID + "|" + numUpDownListNum[i].Value + "|" + numUpDownListPrice[i].Value; }
                total += Convert.ToDouble(numUpDownListNum[i].Value) * Convert.ToDouble(numUpDownListPrice[i].Value);
            }
            oList.State = "未入库";
            oList.PartsInfo = partsInfo;
            oList.Date = dateTimePicker1.Value;
            oList.Total = total.ToString();
            if (useMan.Insert(oList).Equals("Success")) { MessageBox.Show("添加订单成功!"); }
            Close();
        }

        private void supSelect(object sender)
        {
            ComboBox comboSup = (ComboBox)sender;
            supList = new List<string>();
            dt = new DataTable();
            if (useMan.Select("Supplier", out dt).Equals("Success"))
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    supList.Add(dt.Rows[i]["name"].ToString());
                }
            }
            comboSup.DataSource = supList;
        }

        private void partSelect(object sender)
        {
            ComboBox comboPart = (ComboBox)sender;
            partList = new List<string>();
            dt = new DataTable();
            if (useMan.Select("Parts", out dt).Equals("Success"))
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    partList.Add(dt.Rows[i]["name"].ToString());
                }
            }
            comboPart.DataSource = partList;
            comboListPart.Add(comboPart);
        }

        private void comboBoxSup_SelectedIndexChanged(object sender, EventArgs e)
        {
            supplier = new Supplier();
            dt = new DataTable();
            if (useMan.Select("Supplier", "name", comboBoxSup.SelectedValue.ToString(), out dt).Equals("Success"))
            {
                if (dt.Rows.Count > 0)
                {
                    supplier.SupID = dt.Rows[0][0].ToString();
                }
            }
            if (useMan.SelectDate(supplier.SupID, out supplier).Equals("Success"))
            {

            }
        }

        private void comboBoxParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            part = new Parts();
        }

        private void numericUpDownNum_ValueChanged(object sender, EventArgs e)
        {
            double total = 0;
            for (int i = 0; i < numUpDownListNum.Count; i++)
            {
                total += Convert.ToDouble(numUpDownListNum[i].Value) * Convert.ToDouble(numUpDownListPrice[i].Value);
            }
            labelTotal.Text = total.ToString();
        }

    }
}
