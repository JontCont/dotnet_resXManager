using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Resources;
using dotnet_resXManager.Properties;

namespace dotnet_resXManager
{
    public class LanguageHelper
    {
        private static ResourceManager _res { get; set; }

        public static string GetText(string name)
        {
            string lanString = "en-US";//"zh-TW";

            //取得或設定 CultureInfo 物件，此物件代表 Resource Manager 用於執行階段查詢特定文化特性資源的目前使用者介面文化特性。
            //資源管理員用來在執行階段查詢特定文化特性資源的文化特性。
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo(lanString);
            _res =
                new ResourceManager("dotnet_resXManager.Properties.ResourceLanguage", typeof(ResourceLanguage).Assembly);

            return _res.GetString(name) ?? name;
        }

    }
}