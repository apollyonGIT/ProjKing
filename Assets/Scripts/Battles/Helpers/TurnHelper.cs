using Foundations;

namespace Battles.Helpers
{
    public class TurnHelper
    {
        public static void enter_next_turn()
        {
            var pds = BattleSceneRoot.instance.producers;
            foreach (var pd in pds)
            {
                pd.call();
            }
        }
    }
}

