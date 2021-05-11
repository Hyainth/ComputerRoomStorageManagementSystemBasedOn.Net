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
    public partial class PartsTransfer : Form
    {
        UserManager useMan = new UserManager();

        Warehouse houseOut = new Warehouse();
        Warehouse houseIn = new Warehouse();

        List<string> stoID;

        List<string> partID, partName, partNum;

        string[] partInfo;

        DataTable dt;


        public PartsTransfer()
        {
            InitializeComponent();
        }

        private void PartsTransfer_Load(object sender, EventArgs e)
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
            fac.CreateComboBox().Op(comboBoxParts);
            fac.CreateComboBox().Op(comboBoxToSto);
            fac.CreateComboBox().Op(comboBoxFromSto);
            fac.labelOP(label1);
            fac.labelOP(label2);
            fac.labelOP(label3);
            fac.labelOP(label4);
            fac.labelOP(label5);
            fac.labelOP(labelPartNum);
            
            //修改皮肤

            dt = new DataTable();
            stoID = new List<string>();
            List<string> stoNameOut = new List<string>();
            List<string> stoNameIn = new List<string>();

            if (useMan.Select("Warehouse", out dt).Equals("Success"))
            {
                stoID = dt.AsEnumerable().Select(d => d.Field<string>("houseID")).ToList();
                stoNameOut = dt.AsEnumerable().Select(d => d.Field<string>("name")).ToList();
                stoNameIn = dt.AsEnumerable().Select(d => d.Field<string>("name")).ToList();
            }
            comboBoxFromSto.DataSource = stoNameOut;
            comboBoxToSto.DataSource = stoNameIn;
        }

        private void comboBoxFromSto_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            partID = new List<string>();
            partName = new List<string>();
            partNum = new List<string>();
            partInfo = null;
            if (useMan.SelectDate(stoID[comboBoxFromSto.SelectedIndex], out houseOut).Equals("Success"))
            {
                partInfo = houseOut.Info.Split(',');
                for (int i = 0; i < partInfo.Length; i++)
                {
                    partID.Add(partInfo[i].Split('|')[0]);
                    partNum.Add(partInfo[i].Split('|')[1]);
                    if (useMan.Select("Parts", "partID", partID[i], out dt).Equals("Success"))
                    { partName.Add(dt.Rows[0][1].ToString()); }
                }
                comboBoxParts.DataSource = partName;
                labelPartNum.Text = partNum[comboBoxParts.SelectedIndex];
            }
            else { MessageBox.Show("查询失败!"); }
        }

        private void comboBoxParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelPartNum.Text = partNum[comboBoxParts.SelectedIndex];
        }

        private void buttonTrans_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(numericUpDownPartNum.Text) > Convert.ToDouble(partNum[comboBoxParts.SelectedIndex]))
            { MessageBox.Show("仓库储量不足，请确认后输入!"); numericUpDownPartNum.Focus(); }
            else if (numericUpDownPartNum.Text.Equals("0")) { MessageBox.Show("请输入正确数量!"); numericUpDownPartNum.Focus(); }
            else if (comboBoxFromSto.SelectedIndex == comboBoxToSto.SelectedIndex) { MessageBox.Show("不可移入相同仓库!"); }
            else
            {
                bool flag = true;
                string stoInfoOut = "", stoInfoIn = "";
                string numUpDown = numericUpDownPartNum.Value.ToString();
                if (useMan.SelectDate(stoID[comboBoxToSto.SelectedIndex], out houseIn).Equals("Success"))
                {
                    for (int i = 0; i < partID.Count; i++)
                    {
                        if (stoInfoOut.Length > 0) { stoInfoOut += ","; }
                        if (i == comboBoxParts.SelectedIndex)
                        {
                            double partNumCount = (Convert.ToDouble(partNum[i]) - Convert.ToDouble(numUpDown));
                            if (partNumCount == 0)
                            { if (stoInfoOut.Length > 0) { stoInfoOut = stoInfoOut.Substring(0, stoInfoOut.Length - 1); } continue; }
                            stoInfoOut += partID[i] + "|" + partNumCount;
                        }
                        else { stoInfoOut += partID[i] + "|" + partNum[i]; }
                    }
                    houseOut.Info = stoInfoOut;
                    if (useMan.Edit(houseOut).Equals("Success")) { }
                    else { MessageBox.Show("转出失败!"); }
                }   //转出仓库修改
                else { flag = false; }


                List<string> partIDIn = new List<string>();
                List<string> partNumIn = new List<string>();
                partInfo = null;

                if (useMan.SelectDate(stoID[comboBoxToSto.SelectedIndex], out houseIn).Equals("Success"))
                {
                    if (houseIn.Info.Equals(""))
                    { houseIn.Info = partID[comboBoxParts.SelectedIndex] + "|" + numericUpDownPartNum.Value.ToString(); }
                    else
                    {
                        partInfo = houseIn.Info.Split(',');
                        for (int i = 0; i < partInfo.Length; i++)
                        {
                            partIDIn.Add(partInfo[i].Split('|')[0]);
                            partNumIn.Add(partInfo[i].Split('|')[1]);
                        }

                        bool partExist = false;
                        for (int i = 0; i < partIDIn.Count; i++)
                        {
                            if (partID[comboBoxParts.SelectedIndex] == partIDIn[i])
                            { partExist = true; break; }
                        }   //是否已存在该货物

                        if (partExist)
                        {
                            for (int i = 0; i < partIDIn.Count; i++)
                            {
                                if (stoInfoIn.Length > 0) { stoInfoIn += ","; }
                                if (partID[comboBoxParts.SelectedIndex] == partIDIn[i])
                                {
                                    double partNumCount = (Convert.ToDouble(partNumIn[i]) + Convert.ToDouble(numUpDown));
                                    stoInfoIn += partIDIn[i] + "|" + partNumCount;
                                }
                                else { stoInfoIn += partIDIn[i] + "|" + partNumIn[i]; }
                            }
                        }
                        else
                        {
                            for (int i = 0; i < partIDIn.Count; i++)
                            {
                                if (stoInfoIn.Length > 0) { stoInfoIn += ","; }
                                stoInfoIn += partIDIn[i] + "|" + partNumIn[i];
                            }
                            stoInfoIn += "," + partID[comboBoxParts.SelectedIndex] + "|" + numUpDown; ;
                        }
                        houseIn.Info = stoInfoIn;
                    }
                    if (useMan.Edit(houseIn).Equals("Success")) { }
                    else { MessageBox.Show("转入失败!"); }
                }   //转入仓库修改
                else { flag = false; }
                if (flag) { MessageBox.Show("转移成功!"); }
                Close();
            }
        }
    }
}
