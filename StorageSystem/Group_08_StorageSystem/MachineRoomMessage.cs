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
    public partial class MachineRoomMessage : Form
    {
        private UserManager useMan = new UserManager();

        private Machine machine;
        private List<Panel> panelList;

        private DataTable dt;
        private string roomID;

        public MachineRoomMessage()
        {
            InitializeComponent();
        }

        private void MachineRoomMessage_Load(object sender, EventArgs e)
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
            fac.CreateButton().Op(buttonRoom1);
            fac.CreateButton().Op(buttonRoom2);
            fac.CreateButton().Op(buttonRoom3);
            //修改皮肤


            panelList = new List<Panel>();
            roomID = "0001";
            panelLoad(roomID);
        }

        private void picBoxEvent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            MachineMessage mac = new MachineMessage();
            mac.machine.RoomID = roomID;
            mac.machine.SeatID = pic.Tag.ToString();
            mac.ShowDialog();
        }

        private void panelLoad(string roomID)
        {
            if (panelList.Count > 0)
            {
                for (int i = 0; i < panelList.Count; i++)
                {
                    this.Controls.Remove(panelList[i]);
                }
            }

            dt = new DataTable();
            panelList = new List<Panel>();
            useMan.Select("Machine", "roomID", roomID, out dt);
            for (int i = 1; i <= 24; i++)
            {
                machine = new Machine();
                Panel panel = new Panel();
                PictureBox picBox = new PictureBox();
                Label labelTag = new Label();
                Label labelState = new Label();
                Label labelSeat = new Label();
                Label labelID = new Label();

                if (i > dt.Rows.Count) { return; }

                string seatID;
                if (i < 10) { seatID = "000" + i; }
                else if (i >= 10) { seatID = "00" + i; }
                else if (i >= 100) { seatID = "0" + i; }
                else { seatID = "" + i; }

                if (useMan.SelectDate(roomID, seatID, out machine).Equals("Success"))
                {
                    if (machine.State.Equals("开机"))
                    { picBox.Image = Image.FromFile(Application.StartupPath + @"\pic\computer_on.png"); }
                    else if (machine.State.Equals("关机"))
                    { picBox.Image = Image.FromFile(Application.StartupPath + @"\pic\computer_off.png"); }
                    else if (machine.State.Equals("待机"))
                    { picBox.Image = Image.FromFile(Application.StartupPath + @"\pic\computer_daiji.png"); }
                    else if (machine.State.Equals("维修"))
                    { picBox.Image = Image.FromFile(Application.StartupPath + @"\pic\computer_weixiu.png"); }
                }
                else { continue; }

                //自动生成各组件属性设置

                picBox.Location = new System.Drawing.Point(5, 5);
                picBox.Size = new System.Drawing.Size(105, 77);
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                picBox.Tag = seatID;
                picBox.TabStop = false;

                labelSeat.AutoSize = true;
                labelSeat.Location = new System.Drawing.Point(5, 88);
                labelSeat.Size = new System.Drawing.Size(55, 15);
                labelSeat.Text = "编号:";

                labelID.AutoSize = true;
                labelID.Location = new System.Drawing.Point(55, 88);
                labelID.Size = new System.Drawing.Size(55, 15);
                labelID.Text = seatID;

                labelTag.AutoSize = true;
                labelTag.Location = new System.Drawing.Point(5, 103);
                labelTag.Size = new System.Drawing.Size(55, 15);
                labelTag.Text = "状态:";

                labelState.AutoSize = true;
                labelState.Location = new System.Drawing.Point(55, 103);
                labelState.Size = new System.Drawing.Size(55, 15);
                labelState.Text = machine.State;

                panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                panel.Location = new System.Drawing.Point(200 + 140 * ((i - 1) % 6), 20 + 140 * ((i - 1) / 6));
                panel.Size = new System.Drawing.Size(120, 120);

                panel.Controls.Add(picBox);
                panel.Controls.Add(labelTag);
                panel.Controls.Add(labelState);
                panel.Controls.Add(labelSeat);
                panel.Controls.Add(labelID);

                picBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picBoxEvent_MouseDoubleClick);

                panelList.Add(panel);

                this.Controls.Add(panel);

            }
        }

        private void buttonRoom1_Click(object sender, EventArgs e)
        {
            roomID = "0001";
            panelLoad(roomID);
        }

        private void buttonRoom2_Click(object sender, EventArgs e)
        {
            roomID = "0002";
            panelLoad(roomID);

        }

        private void buttonRoom3_Click(object sender, EventArgs e)
        {

            roomID = "0003";
            panelLoad(roomID);
        }
    }
}

