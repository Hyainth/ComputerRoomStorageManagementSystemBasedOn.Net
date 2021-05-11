// File:    OrderList.cs
// Author:  hp
// Created: 2018年12月10日 3:01:09
// Purpose: Definition of Class OrderList

using System;

namespace Model
{
    public class OrderList
    {
        private string orderID;
        private string supID;
        private string empID;
        private string partsInfo;
        private DateTime date;
        private string state;
        private string total;

        public string OrderID
        {
            get
            {
                return orderID;
            }
            set
            {
                this.orderID = value;
            }
        }

        public string SupID
        {
            get
            {
                return supID;
            }
            set
            {
                this.supID = value;
            }
        }

        public string EmpID
        {
            get
            {
                return empID;
            }
            set
            {
                this.empID = value;
            }
        }

        public string PartsInfo
        {
            get
            {
                return partsInfo;
            }
            set
            {
                this.partsInfo = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                this.date = value;
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

        public string Total
        {
            get
            {
                return total;
            }
            set
            {
                this.total = value;
            }
        }

    }
}
