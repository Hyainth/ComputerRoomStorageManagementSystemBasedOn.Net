using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public partial class Machine
    {
        private string roomID;
        private string seatID;
        private string device;
        private string state;
        private string useInfo;

        public string RoomID
        {
            get
            {
                return roomID;
            }
            set
            {
                this.roomID = value;
            }
        }

        public string SeatID
        {
            get
            {
                return seatID;
            }
            set
            {
                this.seatID = value;
            }
        }

        public string Device
        {
            get
            {
                return device;
            }
            set
            {
                this.device = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }
            set
            {
                this.state = value;
            }
        }

        public string UseInfo
        {
            get
            {
                return useInfo;
            }
            set
            {
                this.useInfo = value;
            }
        }

    }
}
