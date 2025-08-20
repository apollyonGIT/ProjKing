using UnityEngine;

namespace Battles.Indicators
{
    public interface IActionLineAttacher
    {
        Vector2 pos { get; set; }
        Vector2 dir { get; set; }

        //==================================================================================================

        void acti_move_forward()
        {
            var x = pos.x;

            x += 1 * dir.x;
            x = Mathf.Clamp(x, 0, BattleContext.instance.plots_count - 1);
            pos = new(x, pos.y);
        }


        void acti_move_back()
        {
            var x = pos.x;

            x -= 1 * dir.x;
            x = Mathf.Clamp(x, 0, BattleContext.instance.plots_count - 1);
            pos = new(x, pos.y);
        }


        void acti_turn_around()
        {
            dir = new(-dir.x, dir.y);
        }


        void acti_defense()
        {

        }
    }
}

