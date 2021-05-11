// File:    Parts.cs
// Author:  hp
// Created: 2018年12月10日 3:01:10
// Purpose: Definition of Class Parts

using System;

namespace Model
{
    public class Parts
    {
        private string partID;
        private string name;
        private string type;
        private string price;
        private string info;


        public string PartID
        {
            get
            {
                return partID;
            }
            set
            {
                this.partID = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                this.type = value;
            }
        }

        public string Price
        {
            get
            {
                return price;
            }
            set
            {
                this.price = value;
            }
        }

        public string Info
        {
            get
            {
                return info;
            }
            set
            {
                this.info = value;
            }
        }

    }
}
