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
    public partial class StorageMessage : Form
    {
        private UserManager useMan = new UserManager();

        Warehouse house = new Warehouse();

        List<string> stoID;

        List<string[]> parts;
        List<string> partName;
        List<string> partID;
        List<string> partNum;

        Parts part;

        DataTable dt;
        List<PictureBox> picBoxList = new List<PictureBox>();
        PictureBox picBox = new PictureBox();

        public StorageMessage()
        {
            InitializeComponent();
        }

        private void StorageMessage_Load(object sender, EventArgs e)
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
            fac.CreateButton().Op(buttonIncome);
            fac.CreateButton().Op(buttonTransfer);
            fac.labelOP(label1);
            fac.labelOP(label2);
            fac.labelOP(label3);
            fac.labelOP(label4);
            fac.labelOP(label5);
            fac.labelOP(labelName);
            fac.labelOP(labelPosition);
            fac.labelOP(labelSize);


            //修改皮肤

            listFlash();
        }

        private void listStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            partName = new List<string>();
            partID = new List<string>();
            partNum = new List<string>();
            parts = new List<string[]>();
            dt = new DataTable();
            part = new Parts();

            double[] pointPartNum = null;

            listParts.Items.Clear();

            if (useMan.SelectDate(listStorage.Text, out house).Equals("Success"))
            {

                labelName.Text = house.Name;
                labelPosition.Text = house.Position;
                labelSize.Text = house.Size;
                if (house.Info.Equals(""))
                {
                    listParts.Items.Clear();
                    chart1.Series.Clear();
                    return;
                }
                if (useMan.Select("Warehouse", "houseID", house.HouseID, out dt).Equals("Success"))
                {
                    parts.Add(dt.AsEnumerable().Select(d => d.Field<string>("storageInfo")).ToList()[0].Split(','));
                    pointPartNum = new double[parts[0].Length];
                    for (int i = 0; i < parts[0].Length; i++)
                    {
                        partID.Add(parts[0][i].Split('|')[0]);
                        partNum.Add(parts[0][i].Split('|')[1]);

                        if (useMan.SelectDate(partID[i], out part).Equals("Success"))
                        {
                            partName.Add(part.Name);
                            listParts.Items.Add(partID[i] + "  " + partName[partName.Count-1]);
                            pointPartNum[i] = Convert.ToDouble(partNum[i]);
                        }
                        else { }
                    }
                }
            }
            else { return; }
            chart1.Series.Clear();
            chart1.Series.Add(listStorage.Text);

            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;

            for (int i = 0; i < partName.Count; i++)
            {
                chart1.Series[0].Points.AddXY(partName[i], pointPartNum[i]);
            }

            label3.Text = "名称：";
            label4.Text = "地点：";
            label5.Text = "尺寸：";
            chart1.DataSource = partName;
        }

        private void listParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            part = new Parts();
            if (picBoxList.Count > 0)
            {
                this.Controls.Remove(picBoxList[0]);
                picBoxList[0].Dispose();
                picBoxList.Remove(picBox);
            }
            if (listParts.SelectedIndex < 0) { return; }
            if (useMan.SelectDate(partID[listParts.SelectedIndex], out part).Equals("Success"))
            {
                labelName.Text = part.Name;
                labelPosition.Text = part.Price;
                labelSize.Text = partNum[listParts.SelectedIndex];
            }

            label3.Text = "名称：";
            label4.Text = "价格：";
            label5.Text = "数量：";

            if (listParts.SelectedIndex >= 0)
            {
                int width = chart1.Width;
                int height = chart1.Height;
                int X = chart1.Location.X;
                int Y = chart1.Location.Y;

                if (!File.Exists(Application.StartupPath + @"\partPic\" + partID[listParts.SelectedIndex] + ".jpg"))
                {
                    MessageBox.Show("找不到图片!");
                    return;
                }
                 Image img = Image.FromFile(Application.StartupPath + @"\partPic\" + partID[listParts.SelectedIndex] + ".jpg");
                Image bmp = new System.Drawing.Bitmap(img);
                img.Dispose();
                picBox = new PictureBox();
                picBox.Size = new System.Drawing.Size(width, height);
                picBox.Location = new Point(X, Y);
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                picBox.Image = bmp;
                picBoxList.Add(picBox);
                this.Controls.Add(picBox);
                picBox.BringToFront();
            }
        }

        private void buttonNewOrder_Click(object sender, EventArgs e)
        {
            new OrderInsert().ShowDialog();
        }

        private void buttonIncome_Click(object sender, EventArgs e)
        {
            new OrderMessage().ShowDialog();
            listFlash();
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            new PartsTransfer().ShowDialog();
            dt = new DataTable();
            stoID = new List<string>();
            if (useMan.Select("Warehouse", out dt).Equals("Success"))
            {
                stoID = dt.AsEnumerable().Select(d => d.Field<string>("houseID")).ToList();
                listStorage.DataSource = stoID;
            }
        }

        private void listParts_Leave(object sender, EventArgs e)
        {
            listParts.SelectedIndex = -1;
        }

        private void StorageMessage_Click(object sender, EventArgs e)
        {

            listParts.SelectedIndex = -1;
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WareInsert().ShowDialog();
            listFlash();

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (useMan.SelectDate(listStorage.Text, out house).Equals("Success"))
            {
                if (house.Info.Equals(""))
                { useMan.Delete("Warehouse", "houseID", house.HouseID); }
                else { MessageBox.Show("仓库内存在物品，删除失败!"); }
            }
            else { MessageBox.Show("查询失败!"); }
            listFlash();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WareEdit houseEdit = new WareEdit();
            houseEdit.house.HouseID = listStorage.Text;
            houseEdit.ShowDialog();
            listFlash();
        }

        private void listFlash()
        {
            dt = new DataTable();
            stoID = new List<string>();
            if (useMan.Select("Warehouse", out dt).Equals("Success"))
            {
                stoID = dt.AsEnumerable().Select(d => d.Field<string>("houseID")).ToList();
                listStorage.DataSource = stoID;
            }
        }

        private void listStorage_MouseDown(object sender, MouseEventArgs e)
        {
            int y = Control.MousePosition.Y - this.Location.Y - listStorage.Location.Y - 20;
            int index = y / listStorage.ItemHeight - 1;
            if (index >= listStorage.Items.Count) { return; }
            listStorage.SelectedIndex = index;
        }

    }
}
