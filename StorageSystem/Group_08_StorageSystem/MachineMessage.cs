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
    public partial class MachineMessage : Form
    {
        private UserManager useMan = new UserManager();

        public Machine machine = new Machine();

        private List<string> roomIDList;
        private List<string> seatIDList;
        private List<string> deviceList;

        private DataTable dt = new DataTable();

        public MachineMessage()
        {
            InitializeComponent();
        }

        private void MachineMessage_Load(object sender, EventArgs e)
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
            fac.CreateComboBox().Op(comboRoomID);
            fac.CreateComboBox().Op(comboSeatID);
            fac.labelOP(label1);
            fac.labelOP(label2);
            fac.labelOP(label3);
            fac.labelOP(label4);
            fac.labelOP(labelState);
            //修改皮肤

            string roomID, seatID;
            roomID = machine.RoomID;
            seatID = machine.SeatID;
            if (useMan.SelectRoomID(out roomIDList).Equals("Success"))
            { comboRoomID.DataSource = roomIDList; }
            roomIDFlash();
            seatIDFlash();

            comboRoomID.SelectedIndex = comboSeatID.Items.IndexOf(roomID);
            comboSeatID.SelectedIndex = Convert.ToInt32(seatID)-1;
        }

        private void comboRoomID_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomIDFlash();
        }

        private void comboSeatID_SelectedIndexChanged(object sender, EventArgs e)
        {
            seatIDFlash();
        }

        private void roomIDFlash()
        {
            dt = new DataTable();
            seatIDList = new List<string>();
            if (useMan.Select("Machine", "roomID", comboRoomID.Text, out dt).Equals("Success"))
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                { seatIDList.Add(dt.Rows[i][1].ToString()); }
            }
            comboSeatID.DataSource = seatIDList;
        
        }

        private void seatIDFlash()
        {

            string[] deviceMessage;
            deviceList = new List<string>();
            if (useMan.SelectDate(comboRoomID.Text, comboSeatID.Text, out machine).Equals("Success"))
            {
                deviceMessage = machine.Device.Split('|');
                for (int i = 0; i < deviceMessage.Length; i++)
                {
                    Parts part = new Parts();
                    if (useMan.SelectDate(deviceMessage[i], out part).Equals("Success"))
                    { deviceList.Add(part.Name); }
                    else {  }
                }
                labelState.Text = machine.State;
                listBoxDevice.DataSource = deviceList;
            }
        }
    }
}
