using Foundations;
using Foundations.MVVM;
using UnityEngine;

namespace Battles.Players
{
    public interface IPlayerView : IModelView<Player>
    {
        void notify_on_tick1();
    }


    public class Player : Model<Player, IPlayerView>
    {
        public Vector2 pos;
        public Vector2 view_pos => 1.25f * pos;

        public Vector2 dir = Vector2.right;
        public Quaternion view_dir => calc_view_dir();

        //==================================================================================================

        public void tick()
        {

        }


        public void tick1()
        {
            foreach (var view in views)
            {
                view.notify_on_tick1();
            }
        }


        Quaternion calc_view_dir()
        {
            return EX_Utility.look_rotation_from_left(dir);
        }
    }
}





