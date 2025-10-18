using System.Linq;
using Foundations;

namespace Battle.Helpers
{
    public class TurnHelper
    {
        public static void to_enemy_turn()
        {
            var pds = BattleSceneRoot.instance.producers.Where(t => t is not Players.PlayerPD);
            foreach (var pd in pds)
            {
                pd.call();
            }
        }


        public static void to_player_turn()
        {
            var pds = BattleSceneRoot.instance.producers.Where(t => t is Players.PlayerPD);
            foreach (var pd in pds)
            {
                pd.call();
            }
        }
    }
}

