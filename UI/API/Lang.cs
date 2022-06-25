using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP4915M.API {
    public class Lang {
        private System.ComponentModel.ComponentResourceManager resources;
        public Lang(Type t) { resources = new System.ComponentModel.ComponentResourceManager(t); }

        public string GetString(string flog) {
            return resources.GetString(flog, CultureInfo.CurrentCulture) ?? resources.GetString(flog, CultureInfo.InvariantCulture) ?? flog;
        }
    }
}
