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
    
    
    public class scene_road
    {
        
        public uint group_id;
        
        public uint sub_id;
        
        public int generate_weight;
        
        public float generate_distance;
        
        public string road_data_path = "";
        
        public bool hidden;
        
        public object diy_obj;
    }
    
    public class scene_roads
    {
        
        private static System.Collections.Generic.Dictionary<string, scene_road> m_records;
        
        public static System.Collections.Generic.Dictionary<string, scene_road> records
        {
            get
            {
                return (System.Collections.Generic.Dictionary<string, scene_road>)Foundations.Excels.ExcelAnalyzer.init("scene_road");
            }
        }
        
        public static bool TryGetValue(string key, out scene_road record)
        {
            return Foundations.Excels.ExcelAnalyzer.try_get_value("scene_road", key, out record);
        }
    }
}
