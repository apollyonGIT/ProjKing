using System;
using UnityEngine;

namespace Battles.Indicators
{
    public interface IActionLineAttacherView
    {
        Action<string[]> action_line_change { get; set; }
    }


    public class ActionLineController : MonoBehaviour
    {
        public GameObject attacher;
        IActionLineAttacherView m_attacher;

        public ActionLineView[] sub_views; 

        //==================================================================================================

        private void OnEnable()
        {
            attacher.transform.TryGetComponent(out m_attacher);

            m_attacher.action_line_change += notify_on_action_line_change;
        }


        private void OnDisable()
        {
            m_attacher.action_line_change -= notify_on_action_line_change;
        }


        public void notify_on_action_line_change(string[] ac_array)
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

