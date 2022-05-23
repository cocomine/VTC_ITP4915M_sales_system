using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP4915M.API {
    /**
     * <summary>Account details</summary>
     */
    public class Account_Details {
        private string acoountID;
        private string username;
        private string fullRealName;
        private int departmentID;
        private bool isManager;

        /**
         * <summary>Account details construct</summary>
         * <param name="acoountID">User account id</param>
         * <param name="username">User login name</param>
         * <param name="fullRealName">User's real full name</param>
         * <param name="departmentID">user's department</param>
         * <param name="isManager">Whether the user is at the supervisor level</param>
         */
        public Account_Details(string acoountID, string username, string fullRealName, int departmentID, bool isManager) {
            this.acoountID = acoountID;
            this.username = username;
            this.departmentID = departmentID;
            this.isManager = isManager;
            this.fullRealName = fullRealName;
        }

        public string Get_acoountID() { return acoountID; }
        public string Get_username() { return username; }
        public string Get_fullRealName() { return fullRealName; }
        public int Get_departmentID() { return departmentID; }
        public bool Get_isManager() { return isManager; }
        override public String ToString() {
            return String.Format("Account_Details(acoountID: {0}, username: {1}, fullRealName: {2}, departmentID: {3}, isManager: {4})", acoountID, username, fullRealName, departmentID.ToString(), isManager.ToString());
        }
    }
}
