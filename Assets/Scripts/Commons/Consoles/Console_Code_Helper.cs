using System;
using System.Reflection;
using UnityEngine;
using static Commons.Attributes;

namespace Commons
{
    public class Console_Code_Helper
    {

        //==================================================================================================

        public static bool try_do_code(string code, Type code_type)
        {
            MethodInfo mi;

            //带参数指令
            if (code.Contains('(') || code.Contains(')'))
            {
                var strs = code.Split('(');
                var mi_name = strs[0];

                mi = code_type.GetMethod(mi_name);
                if (mi == null)
                {
                    return false;
                }
                else
                {
                    var args = strs[1].TrimEnd(')').Split(',');

                    //规则：参数数量对不上，过滤
                    if (mi.GetParameters().Length != args.Length) return false;

                    mi.Invoke(null, args);
                    return true;
                }
            }

            //直接指令
            mi = code_type.GetMethod(code);
            if (mi == null)
            {
                return false;
            }
            else
            {
                mi.Invoke(null, null);
                return true;
            }
        }


        public static void help(Type code_type)
        {
            var ms = code_type.GetMethods();

            foreach (var mi in ms)
            {
                var attrs = mi.GetCustomAttributes(typeof(DetailAttribute), false);
                foreach (var attr in attrs)
                {
                    DetailAttribute e = (DetailAttribute)attr;
                    Debug.Log($"{e.detail}");
                }
            }
        }
    }
}

