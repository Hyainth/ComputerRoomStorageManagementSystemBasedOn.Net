using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;





namespace Model
{
    public class Supplier
    {
        private string supID;
        private string name;
        private string area;
        private string telephone;

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

        public string Area
        {
            get
            {
                return area;
            }
            set
            {
                this.area = value;
            }
        }

        public string Telephone
        {
            get
            {
                return telephone;
            }
            set
            {
                this.telephone = value;
            }
        }

    }
}
