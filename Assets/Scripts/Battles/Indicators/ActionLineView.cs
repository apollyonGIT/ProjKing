using UnityEngine;

namespace Battles.Indicators
{
    public class ActionLineView : MonoBehaviour
    {

        //==================================================================================================

        public void clear()
        {
            foreach (Transform child in transform)
            {
                DestroyImmediate(child.gameObject);
            }

            gameObject.SetActive(false);
        }


        public void load_icon(string icon_id)
        {
            Addrs.Addressable_Utility.try_load_asset(icon_id, out GameObject _icon);
            Instantiate(_icon, transform);

            gameObject.SetActive(true);
        }
    }
}

