using Foundations.MVVM;
using System.Linq;
using UnityEngine;

namespace Battle.Indicators
{
    public class ActionLineVCPN : MonoBehaviour
    {
        GameObject attacher_mono;
        IModelView m_attacher_view;

        public ActionLineView[] sub_views;

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
            var attacher = _attacher as IActionLine;

            if (attacher.need_refresh)
            {
                do_refresh(attacher.action_lines.ToArray());

                attacher.need_refresh = false;
            }

            transform.localScale = new(attacher.dir.x, 1, 1);
        }


        void do_refresh(string[] ac_array)
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

