using UnityEngine;

namespace Battles.Movers
{
    public interface IMover
    {
        Vector2 pos { get; set; }
        Vector2 dir { get; set; }

        //==================================================================================================

        void acti_move_forward();

        void acti_move_back();

        void acti_turn_around();

        void acti_defense();
    }
}

