using Battles.Players;
using Foundations.MVVM;
using UnityEngine;

namespace Battles.Indicators
{
    public class Action_Line_Controller : MonoBehaviour
    {
        public interface IAction_Line_View
        {
            
        }

        public GameObject view;
        IAction_Line_View m_view;

        //==================================================================================================

        private void OnEnable()
        {
            view.transform.TryGetComponent(out m_view);
        }
    }
}

