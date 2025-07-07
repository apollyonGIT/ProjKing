using Commons;
using Foundations;
using Foundations.Tickers;

namespace Battles
{
    public class BattleSceneRoot : SceneRoot<BattleSceneRoot>
    {
        public Ticker_Mono ticker_mono;

        //==================================================================================================

        protected override void on_init()
        {
            ticker_mono.init(Config.PHYSICS_TICK_DELTA_TIME);

            base.on_init();
        }
    }
}

