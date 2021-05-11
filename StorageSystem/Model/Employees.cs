// File:    Employees.cs
// Author:  hp
// Created: 2018年12月10日 3:50:30
// Purpose: Definition of Class Employees

using System;

namespace Model
{
    public class Employees
    {
        private string empID;
        private string name;
        private string post;
        private string sex;
        private string salary;
        private string telephone;

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

        public string Post
        {
            get
            {
                return post;
            }
            set
            {
                this.post = value;
            }
        }

        public string Sex
        {
            get
            {
                return sex;
            }
            set
            {
                this.sex = value;
            }
        }

        public string Salary
        {
            get
            {
                return salary;
            }
            set
            {
                this.salary = value;
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
