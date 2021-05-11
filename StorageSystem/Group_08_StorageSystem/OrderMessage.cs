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
    public partial class OrderMessage : Form
    {
        private UserManager useMan = new UserManager();


        Originator o = new Originator();
        Caretaker c = new Caretaker();


        List<string> stoID = new List<string>();
        List<string> stoName = new List<string>();

        public OrderMessage()
        {
            InitializeComponent();
        }

        private void OrderMessage_Load(object sender, EventArgs e)
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
            fac.CreateTextBox().Op(textSelect);
            fac.CreateButton().Op(buttonAdd);
            fac.CreateButton().Op(buttonStoIn);
            fac.CreateButton().Op(buttonDelete);
            fac.CreateButton().Op(buttonClear);
            fac.CreateButton().Op(buttonSelect);
            fac.CreateComboBox().Op(comboBoxSto);
            fac.CreateComboBox().Op(comboBoxSelect);
            fac.labelOP(label1);
            fac.labelOP(label2);
            fac.labelOP(label3);
            
            //修改皮肤

            if (UserManager.userType.Equals("storage"))
            {
                buttonAdd.Enabled = false;
                buttonDelete.Enabled = false;

            }
            
            DataTable dt = new DataTable();
            if (useMan.Select("OrderList", out dt).Equals("NotFind"))
            { MessageBox.Show("未找到该表，请确认表名是否错误!", "提示"); Close(); }
            else if (useMan.Select("OrderList", out dt).Equals("Success"))
            {
                dt.Columns.Remove("partsInfo");
                dataGridView1.DataSource = dt.DefaultView;
            }
            for (int i = 0; i < dt.Columns.Count; i++)
            { comboBoxSelect.Items.Add(dt.Columns[i].ToString()); }
            comboBoxSelect.SelectedIndex = 0;

            if (useMan.Select("Warehouse", out dt).Equals("Success"))
            {
                stoID = dt.AsEnumerable().Select(d => d.Field<string>("houseID")).ToList();
                stoName = dt.AsEnumerable().Select(d => d.Field<string>("name")).ToList();
            }
            comboBoxSto.DataSource = stoName;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            new OrderInsert().ShowDialog();
            tableFlash();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string flag = useMan.Delete("OrderList", dataGridView1.Columns[0].HeaderText, dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (flag.Equals("Success"))
            { MessageBox.Show("信息已删除!", "提示"); }
            else if (flag.Equals("Rerro"))
            { MessageBox.Show("输入信息错误，删除失败!", "提示"); }
            else if (flag.Equals("Fail"))
            { MessageBox.Show("输入信息错误，删除失败!", "提示"); }
            else if (flag.Equals("NotFind"))
            { MessageBox.Show("输入信息错误，删除失败!", "提示"); }
            tableFlash();
        }

        private void buttonStoIn_Click(object sender, EventArgs e)
        {
            OrderList olist = new OrderList();
            Warehouse house = new Warehouse();
            if (comboBoxSto.Text.Equals("")) { MessageBox.Show("未选择仓库!"); return; }
            if (useMan.SelectDate(stoID[comboBoxSto.SelectedIndex], out house).Equals("Success")) { }
            else { MessageBox.Show("找不到该仓库!"); return; }
            if (useMan.SelectDate(dataGridView1.CurrentRow.Cells[0].Value.ToString(), out olist).Equals("Success"))
            {
                if (olist.State.Equals("已入库")) { MessageBox.Show("入库失败，该订单已入库!"); }
                else
                {
                    string[] partMessageAdd, partMessageSto;
                    List<string> partIDAdd = new List<string>();
                    List<string> partNumAdd = new List<string>();
                    List<string> partIDSto = new List<string>();
                    List<string> partNumSto = new List<string>();

                    partMessageAdd = olist.PartsInfo.Split(',');
                    for (int i = 0; i < partMessageAdd.Length; i++)
                    {
                        partIDAdd.Add(partMessageAdd[i].Split('|')[0]);
                        partNumAdd.Add(partMessageAdd[i].Split('|')[1]);
                    }   //添加货物条目

                    if (house.Info.Equals("")) 
                    {
                        house.Info = olist.PartsInfo;
                    }   //空仓库
                    else
                    {
                        partMessageSto = house.Info.Split(',');
                        for (int i = 0; i < partMessageSto.Length; i++)
                        {
                            partIDSto.Add(partMessageSto[i].Split('|')[0]);
                            partNumSto.Add(partMessageSto[i].Split('|')[1]);
                        }   //仓储货物条目


                        bool flag;  //判断是否已经存在该货物
                        for (int i = 0; i < partMessageAdd.Length; i++)
                        {
                            flag = true;    //不存在为 true
                            for (int j = 0; j < partMessageSto.Length; j++)
                            {
                                if (partIDAdd[i].Equals(partIDSto[j]))
                                {
                                    string stoInfo = "";
                                    double partCount = Convert.ToDouble(partNumAdd[i]) + Convert.ToDouble(partNumSto[j]);
                                    partNumSto[j] = partCount.ToString();
                                    for (int k = 0; k < partMessageSto.Length; k++)
                                    {
                                        if (stoInfo.Length > 0) { stoInfo += ","; }
                                        stoInfo += partIDSto[k] + "|" + partNumSto[k];
                                    }   //仓储条目组合
                                    house.Info = stoInfo;
                                    flag = false;
                                    break;
                                }   //存在，修改数量                           
                            }
                            if (flag) { house.Info = house.Info + "," + partIDAdd[i] + "|" + partNumAdd[i]; } //不存在，新插入
                        }

                    }
                    olist.State = "已入库";
                    if (useMan.Edit(house).Equals("Success")) { MessageBox.Show("入库成功!"); }
                    if (useMan.Edit(olist).Equals("Success")) { }
                    tableFlash();
                }
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string flag = useMan.Select("OrderList", comboBoxSelect.Text, textSelect.Text, out dt);
            if (flag.Equals("Success")) { o.State = (DataView)dataGridView1.DataSource; c.Memento = o.CreateMemento(); dataGridView1.DataSource = dt.DefaultView; }
            else
            {
                if (flag.Equals("valueNull"))
                {
                    MessageBox.Show("查询条件不可为空!", "提示");
                    textSelect.Focus();
                }
                else if (flag.Equals("targetNull"))
                {
                    MessageBox.Show("查询目标不可为空!", "提示");
                    comboBoxSelect.Focus();
                }
                else { MessageBox.Show("查询失败，请确认条件是否有误!", "提示"); }
                tableFlash();
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            o.SetMemento(c.Memento);
            dataGridView1.DataSource = o.State;

        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[e.RowIndex].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                }
            }
        }


        private void tableFlash()
        {
            DataTable dt = new DataTable();
            if (useMan.Select("OrderList", out dt).Equals("NotFind"))
            { MessageBox.Show("未找到该表，请确认表名是否错误!", "提示"); Close(); }
            else if (useMan.Select("OrderList", out dt).Equals("Success"))
            {
                dt.Columns.Remove("partsInfo");
                dataGridView1.DataSource = dt.DefaultView;
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if( dataGridView1.CurrentRow.Cells[0].Value.ToString().Equals(""))
            { MessageBox.Show("请选择正确数据"); return; }
            OrderMessageDetail orderDetail = new OrderMessageDetail();
            orderDetail.orderID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            orderDetail.ShowDialog();

        }

    }
}
