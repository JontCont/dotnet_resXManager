using dotnet_resXManager.Properties.Resources;
using System.Resources;


namespace dotnet_resXManager
{
    public class Language
    {
        private static string _language = "zh-TW";//"en-US";

        public Language()
        {


        }
        public static string GetName(string str)
        {
            //取得或設定 CultureInfo 物件，表示目前線程和以工作為基礎的非同步作業所使用的文化特性。
            //目前線程和以工作為基礎的非同步作業所使用的文化特性。
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(lanString);
            //取得或設定 CultureInfo 物件，此物件代表 Resource Manager 用於執行階段查詢特定文化特性資源的目前使用者介面文化特性。
            //資源管理員用來在執行階段查詢特定文化特性資源的文化特性。
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(_language);

            ResourceManager RMang =
               new ResourceManager("dotnet_resXManager.Properties.Resources.ResourceLanguage", typeof(ResourceLanguage).Assembly);
            return RMang.GetString(str) ?? str;
        }
    }


}