// File:    Warehouse.cs
// Author:  hp
// Created: 2018年12月10日 3:01:10
// Purpose: Definition of Class Warehouse

using System;







namespace Model
{
    public class Warehouse
    {
        private string houseID;
        private string name;
        private string position;
        private string size;
        private string info;

        public string HouseID
        {
            get
            {
                return houseID;
            }
            set
            {
                this.houseID = value;
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

        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                this.position = value;
            }
        }

        public string Size
        {
            get
            {
                return size;
            }
            set
            {
                this.size = value;
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
