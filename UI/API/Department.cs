using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP4915M.API {
    public class Department {
        public const int Sales = 1;
        public const int Inventory = 2;
        public const int Accounting = 3;
        public const int Technical_Support = 4;
        public const int IT = 5;
        public const int CEO = 6;
        public const int Delivery = 7;
        public const int Installer = 8;

        public static String Get_DepartmentName(int departmentID) {
            switch (departmentID) {
                case Sales: return "Sales";
                case Inventory: return "Inventory";
                case Accounting: return "Accounting";
                case Technical_Support: return "Technical Support";
                case IT: return "IT";
                case CEO: return "CEO";
                case Delivery: return "Delivery Team";
                case Installer: return "Installer";
                default: return "(No department)";
            }
        }
    }
}
