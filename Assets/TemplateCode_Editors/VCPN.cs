using UnityEditor;

namespace Editor.AutoCreators
{
    public class VCPN
    {
        static string path = "Assets/TemplateCode_Editors/Templates/VCPN_Template.cs.txt";

        //==================================================================================================

        [MenuItem("Assets/TemplateCode/VCPN", false, -1)]
        public static void EXE()
        {
            CreateScriptByTemplate.EXE(path, create_file_name, create_diy_fields);
        }


        static string create_file_name(string folder_name)
        {
            return $"{Cell.create_file_name(folder_name)}VCPN";
        }


        static void create_diy_fields(ref string txt, string folder_name)
        {
            Cell.create_diy_fields(ref txt, folder_name);
        }
    }
}

