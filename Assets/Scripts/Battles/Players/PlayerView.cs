using Foundations.MVVM;
using UnityEngine;
using static Battles.Indicators.Action_Line_Controller;

namespace Battles.Players
{
    public class PlayerView : MonoBehaviour, IPlayerView, IAction_Line_View
    {
        Player owner;

        //==================================================================================================

        void IModelView<Player>.attach(Player owner)
        {
            this.owner = owner;

            calc_transform();
        }


        void IModelView<Player>.detach(Player owner)
        {
            this.owner = null;
        }


        void IPlayerView.notify_on_tick1()
        {
            calc_transform();
        }


        void calc_transform()
        {
            transform.localPosition = owner.view_pos;
            transform.localScale = new(owner.flipX, 1, 1);
        }
    }
}

