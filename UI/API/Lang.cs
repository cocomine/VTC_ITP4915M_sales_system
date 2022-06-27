using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP4915M.API {
    public class Lang {
        private System.ComponentModel.ComponentResourceManager resources;

        /// <summary>
        /// 多語言載入器
        /// </summary>
        /// <param name="t">typeof class名稱</param>
        public Lang(Type t) { resources = new System.ComponentModel.ComponentResourceManager(t); }

        /// <summary>
        /// 取得翻譯字串
        /// </summary>
        /// <param name="flog">翻譯keyword</param>
        /// <returns>翻譯後的文字</returns>
        public string GetString(string flog) {
            return resources.GetString(flog, CultureInfo.CurrentCulture) ?? resources.GetString(flog, CultureInfo.InvariantCulture) ?? flog;
        }
    }
}
