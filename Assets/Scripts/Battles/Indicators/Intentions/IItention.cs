using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Battle.Indicators
{
    public interface IItention
    {
        bool need_refresh { get; set; }

        bool is_active { get; set; }

        string img_name { get; set; }

        //==================================================================================================

        public void add_itention(string itention_name)
        {
            img_name = itention_name;
            is_active = true;

            need_refresh = true;
        }


        public void remove_itention()
        {
            img_name = "";
            is_active = false;
        }
    }
}

