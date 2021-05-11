using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model;
using DAL;

namespace BLL
{
    public class UserManager
    {
        private UserDAO userDao = new UserDAO();

        public User user = new User();

        public static string userID = "";
        public static string userType = "";

        public string[] TableName = { "Employees", "Machine", "OrderList", "Parts", "Supplier", "users", "Warehouse" };
           
        public string Login()
        {
            if (user.UserID == "") { return "NoID"; }
            else if (user.Password == "") { return "NoPW"; }
            else if (userDao.Login(user.UserID, user.Password) == 0) { return "NoCount"; }
            else if (userDao.Login(user.UserID, user.Password) == -1) { return "PWerro"; }
            else { userID = user.UserID; return "Success"; }
        }   //Login

        public string Select(string tableName, out DataTable dt)
        {
            dt = null;
            if (tableExist(tableName))
            {
                dt = userDao.Select(tableName);
                return "Success";
            }
            else { return "NotFind"; }
        }   //Table Select

        public string Select(string tableName, string target, string value, out DataTable dt)
        {
            dt = null;
            if (tableExist(tableName))
            {
                if (value.Equals("")) { return "valueNull"; }
                if (target.Equals("")) { return "targetNull"; }
                dt = userDao.Select(tableName, target, value);
                if (dt.Rows.Count == 0) { return "NotFind"; }
                return "Success";
            }
            else { return "NotFind"; }
        }   //TableDate Select

        public string SelectDate(string empID, out Employees emp)
        {
            emp = new Employees();
            string sqlstr = "Select * From Employees Where empID = '" + empID + "'";
            DataTable dt = userDao.SelectDate(sqlstr);
            if (dt.Rows.Count != 0)
            {
                emp.EmpID = dt.Rows[0][0].ToString();
                emp.Name = dt.Rows[0][1].ToString();
                emp.Salary = dt.Rows[0][2].ToString();
                emp.Post = dt.Rows[0][3].ToString();
                emp.Sex = dt.Rows[0][4].ToString();
                emp.Telephone = dt.Rows[0][5].ToString();
                return "Success";
            }
            else { return "Fail"; }
        }   //employees ObjectDate Select

        public string SelectDate(string userID, out User user)
        {
            user = new User();
            string sqlstr = "Select * From users Where userID = '" + userID + "'";
            DataTable dt = userDao.SelectDate(sqlstr);
            if (dt.Rows.Count != 0)
            {
                user.UserID = dt.Rows[0][0].ToString();
                user.Password = dt.Rows[0][1].ToString();
                user.LoginInfo = dt.Rows[0][2].ToString();
                return "Success";
            }
            else { return "Fail"; }
        }   //users ObjectDate Select

        public string SelectDate(string roomID, string seatID, out Machine machine)
        {
            machine = new Machine();
            string sqlstr = "Select * From machine Where roomID = '" + roomID + "' and seatID = '" + seatID + "'";
            DataTable dt = userDao.SelectDate(sqlstr);
            if (dt.Rows.Count != 0)
            {
                machine.RoomID = dt.Rows[0][0].ToString();
                machine.SeatID = dt.Rows[0][1].ToString();
                machine.Device = dt.Rows[0][2].ToString();
                machine.State = dt.Rows[0][3].ToString();
                machine.UseInfo = dt.Rows[0][4].ToString();
                return "Success";
            }
            else { return "Fail"; }
        }   //machine ObjectDate Select

        public string SelectDate(string orderID, out OrderList oList)
        {
            oList = new OrderList();
            string sqlstr = "Select * From OrderList Where orderID = '" + orderID + "'";
            DataTable dt = userDao.SelectDate(sqlstr);
            if (dt.Rows.Count != 0)
            {
                oList.OrderID = dt.Rows[0][0].ToString();
                oList.SupID = dt.Rows[0][1].ToString();
                oList.EmpID = dt.Rows[0][2].ToString();
                oList.PartsInfo = dt.Rows[0][3].ToString();
                oList.Date = Convert.ToDateTime(dt.Rows[0][4]);
                oList.State = dt.Rows[0][5].ToString();
                oList.Total = dt.Rows[0][6].ToString();
                return "Success";
            }
            else { return "Fail"; }
        }   //orderList ObjectDate Select

        public string SelectDate(string supID, out Supplier sup)
        {
            sup = new Supplier();
            string sqlstr = "Select * From Supplier Where supID = '" + supID + "'";
            DataTable dt = userDao.SelectDate(sqlstr);
            if (dt.Rows.Count != 0)
            {
                sup.SupID = dt.Rows[0][0].ToString();
                sup.Name = dt.Rows[0][1].ToString();
                sup.Area = dt.Rows[0][2].ToString();
                sup.Telephone = dt.Rows[0][3].ToString();
                return "Success";
            }
            else { return "Fail"; }
        }   //supplier ObjectDate Select

        public string SelectDate(string partID, out Parts part)
        {
            part = new Parts();
            string sqlstr = "Select * From Parts Where partID = '" + partID + "'";
            DataTable dt = userDao.SelectDate(sqlstr);
            if (dt.Rows.Count != 0)
            {
                part.PartID = dt.Rows[0][0].ToString();
                part.Name = dt.Rows[0][1].ToString();
                part.Type = dt.Rows[0][2].ToString();
                part.Price = dt.Rows[0][3].ToString();
                part.Info = dt.Rows[0][4].ToString();
                return "Success";
            }
            else { return "Fail"; }
        }   //parts ObjectDate Select

        public string SelectDate(string houseID, out Warehouse house)
        {
            house = new Warehouse();
            string sqlstr = "Select * From Warehouse Where houseID = '" + houseID + "'";
            DataTable dt = userDao.SelectDate(sqlstr);
            if (dt.Rows.Count != 0)
            {
                house.HouseID = dt.Rows[0][0].ToString();
                house.Name = dt.Rows[0][1].ToString();
                house.Position = dt.Rows[0][2].ToString();
                house.Size = dt.Rows[0][3].ToString();
                house.Info = dt.Rows[0][4].ToString();
                return "Success";
            }
            else { return "Fail"; }
        }   //warehouse ObjectDate Select
        
        public string SelectObjID(string tableName,out string objID)
        {
            objID = "";
            if (tableExist(tableName))
            {
                string sqlstr = "Select * From " + tableName;
                DataTable dt = userDao.SelectDate(sqlstr);
                int id;
                if (dt.Rows.Count == 0) { id = 1; }
                else { id = Convert.ToInt32(dt.Rows[dt.Rows.Count-1][0].ToString()) + 1; }
                if (id < 10 && id >= 0) { objID = "000" + id; }
                else if (id < 100) { objID = "00" + id; }
                else if (id < 1000) { objID = "0" + id; }
                else { objID = "" + id; }
                return "Success";
            }
            return "Fail";
        }   //objID Select

        public string SelectPost(out List<string> posts)
        {
            posts = new List<string>();
            string sqlstr = "Select distinct post From Employees";
            DataTable dt = userDao.SelectDate(sqlstr);
            for (int i = 0; i < dt.Rows.Count; i++) { posts.Add(dt.Rows[i][0].ToString()); }
            return "Success";
        }   //employeesPost Select

        public string SelectType(out List<string> type)
        {
            type = new List<string>();
            string sqlstr = "Select distinct type From Parts";
            DataTable dt = userDao.SelectDate(sqlstr);
            for (int i = 0; i < dt.Rows.Count; i++) { type.Add(dt.Rows[i][0].ToString()); }
            return "Success";
        }   //deviceType Select

        public string SelectRoomID(out List<string> roomID)
        {
            roomID = new List<string>();
            string sqlstr = "Select distinct roomID From Machine";
            DataTable dt = userDao.SelectDate(sqlstr);
            for (int i = 0; i < dt.Rows.Count; i++) { roomID.Add(dt.Rows[i][0].ToString()); }
            return "Success";
        }   //machineRoomID Select

        public string Delete(string tableName, string target, string value)
        {
            if (tableExist(tableName))
            {
                if (value.Equals("")) { return "Rerro"; }
                else if (!userDao.Delete(tableName, target, value)) { return "Fail"; }
                else { return "Success"; }
            }
            else { return "NotFind"; }
        }   //Delete

        public string Insert(Model.Machine machine)
        {
            string sqlStr = "insert into Machine(roomID,seatID,device,state,useInfo) values(@roomID,@seatID,@device,@state,@useInfo)";
            SqlParameter[] paras = new SqlParameter[] { 
            new SqlParameter("@roomID",machine.RoomID),
            new SqlParameter("@seatID",machine.SeatID),
            new SqlParameter("@device",machine.State),
            new SqlParameter("@state",machine.State),
            new SqlParameter("@useInfo",machine.UseInfo)
            };
            if (userDao.Insert(sqlStr, paras)) { return "Success"; }
            else { return "Fail"; }

        }   //machine Insert

        public string Insert(Model.Supplier supplier)
        {
            string sqlStr = "insert into Supplier(supID,name,area,telephone) values(@supID,@name,@area,@telephone)";
            SqlParameter[] paras = new SqlParameter[] { 
            new SqlParameter("@supID",supplier.SupID),
            new SqlParameter("@name",supplier.Name),
            new SqlParameter("@area",supplier.Area),
            new SqlParameter("@telephone",supplier.Telephone)
            };
            if (userDao.Insert(sqlStr, paras)) { return "Success"; }
            else { return "Fail"; }
        }   //supplier Insert

        public string Insert(Model.User users)
        {
            string sqlStr = "insert into users(userID,password,loginInfo) values(@userID,@password,@loginInfo)";
            SqlParameter[] paras = new SqlParameter[] { 
            new SqlParameter("@userID",users.UserID),
            new SqlParameter("@password",users.Password),
            new SqlParameter("@loginInfo",users.LoginInfo)
            };
            if (userDao.Insert(sqlStr, paras)) { return "Success"; }
            else { return "Fail"; }
        }   //users Insert

        public string Insert(Model.Employees employees)
        {
            string sqlStr = "insert into Employees(empID,name,salary,post,sex,telephone) values(@empID,@name,@salary,@post,@sex,@telephone)";
            SqlParameter[] paras = new SqlParameter[] { 
            new SqlParameter("@empID",employees.EmpID),
            new SqlParameter("@name",employees.Name),
            new SqlParameter("@salary",employees.Salary),
            new SqlParameter("@post",employees.Post),
            new SqlParameter("@sex",employees.Sex),
            new SqlParameter("@telephone",employees.Telephone)
            };
            if (userDao.Insert(sqlStr, paras)) { return "Success"; }
            else { return "Fail"; }
        }   //emoloyees Insert

        public string Insert(Model.OrderList orderList)
        {
            string sqlStr = "insert into OrderList(orderID,supID,empID,partsInfo,date,state,total) values(@orderID,@supID,@empID,@partsInfo,@date,@state,@total)";
            SqlParameter[] paras = new SqlParameter[] { 
            new SqlParameter("@orderID",orderList.OrderID),
            new SqlParameter("@supID",orderList.SupID),
            new SqlParameter("@empID",orderList.EmpID),
            new SqlParameter("@partsInfo",orderList.PartsInfo),
            new SqlParameter("@date",orderList.Date),
            new SqlParameter("@state",orderList.State),
            new SqlParameter("@total",orderList.Total)
            };
            if (userDao.Insert(sqlStr, paras)) { return "Success"; }
            else { return "Fail"; }
        }   //orderList Insert

        public string Insert(Model.Parts parts)
        {
            string sqlStr = "insert into Parts(partID,name,type,price,info) values(@partID,@name,@type,@price,@info)";
            SqlParameter[] paras = new SqlParameter[] { 
            new SqlParameter("@partID",parts.PartID),
            new SqlParameter("@name",parts.Name),
            new SqlParameter("@type",parts.Type),
            new SqlParameter("@price",parts.Price),
            new SqlParameter("@info",parts.Info)
            };
            if (userDao.Insert(sqlStr, paras)) { return "Success"; }
            else { return "Fail"; }
        }   //parts Insert

        public string Insert(Model.Warehouse warehouse)
        {
            string sqlStr = "insert into Warehouse(houseID,name,position,size) values(@houseID,@name,@position,@size)";
            SqlParameter[] paras = new SqlParameter[] { 
            new SqlParameter("@houseID",warehouse.HouseID),
            new SqlParameter("@name",warehouse.Name),
            new SqlParameter("@position",warehouse.Position),
            new SqlParameter("@size",warehouse.Size)
            };
            if (userDao.Insert(sqlStr, paras)) { return "Success"; }
            else { return "Fail"; }
        }   //warehouse Insert

        public string Edit(Model.User users)
        {
            string sqlStr = "update users set password=@password,loginInfo=@loginInfo where userID=@userID";
            SqlParameter[] paras = new SqlParameter[] { 
            new SqlParameter("@userID",users.UserID),
            new SqlParameter("@password",users.Password),
            new SqlParameter("@loginInfo",users.LoginInfo)
            };
            if (userDao.Edit(sqlStr, paras)) { return "Success"; }
            else { return "Fail"; }
        }   //users Edit

        public string Edit(Model.Machine machine)
        {
            string sqlStr = "update Machine set seatID=@seatID,device=@device,state=@state,useInfo=@useInfo where roomID=@roomID";
            SqlParameter[] paras = new SqlParameter[] { 
            new SqlParameter("@roomID",machine.RoomID),
            new SqlParameter("@seatID",machine.SeatID),
            new SqlParameter("@device",machine.State),
            new SqlParameter("@state",machine.State),
            new SqlParameter("@useInfo",machine.UseInfo)
            };
            if (userDao.Edit(sqlStr, paras)) { return "Success"; }
            else { return "Fail"; }
        }   //machine Edit

        public string Edit(Model.OrderList orderList)
        {
            string sqlStr = "update OrderList set supID=@supID,empID=@empID,partsInfo=@partsInfo,date=@date,state=@state,total=@total where orderID=@orderID";
            SqlParameter[] paras = new SqlParameter[] { 
            new SqlParameter("@orderID",orderList.OrderID),
            new SqlParameter("@supID",orderList.SupID),
            new SqlParameter("@empID",orderList.EmpID),
            new SqlParameter("@partsInfo",orderList.PartsInfo),
            new SqlParameter("@date",orderList.Date),
            new SqlParameter("@state",orderList.State),
            new SqlParameter("@total",orderList.Total)
            };
            if (userDao.Edit(sqlStr, paras)) { return "Success"; }
            else { return "Fail"; }
        }   //orderList Edit

        public string Edit(Model.Supplier supplier)
        {
            string sqlStr = "update Supplier set name=@name,area=@area,telephone=@telephone where supID=@supID";
            SqlParameter[] paras = new SqlParameter[] { 
            new SqlParameter("@supID",supplier.SupID),
            new SqlParameter("@name",supplier.Name),
            new SqlParameter("@area",supplier.Area),
            new SqlParameter("@telephone",supplier.Telephone)
            };
            if (userDao.Edit(sqlStr, paras)) { return "Success"; }
            else { return "Fail"; }
        }   //supplier Edit

        public string Edit(Model.Employees employees)
        {
            string sqlStr = "update Employees set name=@name,post=@post,sex=@sex,telephone=@telephone where empID=@empID";
            SqlParameter[] paras = new SqlParameter[] { 
            new SqlParameter("@empID",employees.EmpID),
            new SqlParameter("@name",employees.Name),
            new SqlParameter("@post",employees.Post),
            new SqlParameter("@sex",employees.Sex),
            new SqlParameter("@telephone",employees.Telephone)
            };
            if (userDao.Edit(sqlStr, paras)) { return "Success"; }
            else { return "Fail"; }
        }   //employees Edit

        public string Edit(Model.Parts parts)
        {
            string sqlStr = "update Parts set name=@name,type=@type,price=@price,info=@info Where partID=@partID";
            SqlParameter[] paras = new SqlParameter[] { 
            new SqlParameter("@partID",parts.PartID),
            new SqlParameter("@name",parts.Name),
            new SqlParameter("@type",parts.Type),
            new SqlParameter("@price",parts.Price),
            new SqlParameter("@info",parts.Info)
            };
            if (userDao.Edit(sqlStr, paras)) { return "Success"; }
            else { return "Fail"; }
        }   //parts Edit
        
        public string Edit(Model.Warehouse warehouse)
        {
            string sqlStr = "update Warehouse set name=@name,position=@position,size=@size,storageInfo=@info Where houseID=@houseID";
            SqlParameter[] paras = new SqlParameter[] { 
            new SqlParameter("@houseID",warehouse.HouseID),
            new SqlParameter("@name",warehouse.Name),
            new SqlParameter("@position",warehouse.Position),
            new SqlParameter("@size",warehouse.Size),
            new SqlParameter("@info",warehouse.Info)
            };
            if (userDao.Edit(sqlStr, paras)) { return "Success"; }
            else { return "Fail"; }
        }   //warehouse Edit

        private bool tableExist(string tableName)
        {
            for (int i = 0; i < TableName.Length; i++)
            {
                if (tableName.Equals(TableName[i]))
                { return true; }
            }
            return false;
        }   //tableName Exist
        

    }
}



