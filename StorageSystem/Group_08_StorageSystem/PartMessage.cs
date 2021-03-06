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
    public partial class PartMessage : Form
    {
        UserManager useMan = new UserManager();

        public PartMessage()
        {
            InitializeComponent();
        }

        private void PartMessage_Load(object sender, EventArgs e)
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
            fac.CreateButton().Op(buttonEdit);
            fac.CreateButton().Op(buttonDelete);
            fac.CreateButton().Op(buttonClear);
            fac.CreateButton().Op(buttonSelect);
            fac.CreateComboBox().Op(comboBoxSelect);
            fac.labelOP(label1);
            fac.labelOP(label2);
            //修改皮肤


            DataTable dt = new DataTable();
            if (useMan.Select("Parts", out dt).Equals("NotFind"))
            { MessageBox.Show("未找到该表，请确认表名是否错误!", "提示"); Close(); }
            else if (useMan.Select("Parts", out dt).Equals("Success"))
            { dataGridView1.DataSource = dt.DefaultView; }
            for (int i = 0; i < dt.Columns.Count; i++)
            { comboBoxSelect.Items.Add(dt.Columns[i].ToString()); }
            comboBoxSelect.SelectedIndex = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            new PartInsert().ShowDialog();
            tableFlash();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string flag = useMan.Delete("Parts", dataGridView1.Columns[0].HeaderText, dataGridView1.CurrentRow.Cells[0].Value.ToString());
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            PartEdit partEdit = new PartEdit();
            partEdit.part.PartID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            partEdit.ShowDialog();
            tableFlash();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string flag = useMan.Select("Parts", comboBoxSelect.Text, textSelect.Text, out dt);
            if (flag.Equals("Success"))
            { dataGridView1.DataSource = dt.DefaultView; }
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
            tableFlash();
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
            if (useMan.Select("Parts", out dt).Equals("NotFind"))
            { MessageBox.Show("未找到该表，请确认表名是否错误!", "提示"); Close(); }
            else if (useMan.Select("Parts", out dt).Equals("Success"))
            { dataGridView1.DataSource = dt.DefaultView; }
        }

        private void 查看图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartPicture partPic = new PartPicture();
            partPic.partID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            partPic.ShowDialog();
        }
    }
}
