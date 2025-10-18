using Foundations.MVVM;
using Foundations.Refs;
using UnityEngine;

namespace Battle.Indicators
{
    public class IntentionVCPN : MonoBehaviour
    {
        GameObject attacher_mono;
        IModelView m_attacher_view;

        public IntentionView view;

        //==================================================================================================

        private void OnEnable()
        {
            attacher_mono = transform.parent.parent.gameObject;
            attacher_mono.TryGetComponent(out m_attacher_view);
            m_attacher_view.tick1 += tick1;
        }


        private void OnDisable()
        {
            m_attacher_view.tick1 -= tick1;
        }


        public void tick1(object _attacher)
        {
            var attacher = _attacher as IItention;

            if (attacher.need_refresh)
            {
                Addrs.Addressable_Utility.try_load_asset(attacher.img_name, out AssetRef aref);
                view.img.sprite = (Sprite)aref.asset;
                view.gameObject.SetActive(attacher.is_active);

                attacher.need_refresh = false;
            }
        }

    }
}

