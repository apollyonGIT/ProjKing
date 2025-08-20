using UnityEngine;

namespace Battles.Indicators
{
    public class ActionLineController : MonoBehaviour
    {
        public ActionLineView[] sub_views; 

        //==================================================================================================

        public void do_refresh(string[] ac_array)
        {
            foreach (var sub_view in sub_views)
            {
                sub_view.clear();
            }

            for (int i = 0; i < ac_array.Length; i++)
            {
                sub_views[i].load_icon(ac_array[i]);
            }
        }
    }
}

