//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoCodes
{
    
    
    public class table_l10n
    {
        
        public string id = "";
        
        public string CN = "";
        
        public string CHT = "";
        
        public string EN = "";
        
        public string ES = "";
        
        public string JA = "";
        
        public string RU = "";
        
        public string KO = "";
        
        public object diy_obj;
    }
    
    public class table_l10ns
    {
        
        private static System.Collections.Generic.Dictionary<string, table_l10n> m_records;
        
        public static System.Collections.Generic.Dictionary<string, table_l10n> records
        {
            get
            {
                return (System.Collections.Generic.Dictionary<string, table_l10n>)Foundations.Excels.ExcelAnalyzer.init("table_l10n");
            }
        }
        
        public static bool TryGetValue(string key, out table_l10n record)
        {
            return Foundations.Excels.ExcelAnalyzer.try_get_value("table_l10n", key, out record);
        }
    }
}
