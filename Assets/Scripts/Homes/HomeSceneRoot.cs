using Commons;
using Foundations;
using Foundations.Tickers;

namespace Homes
{
    public class HomeSceneRoot : SceneRoot<HomeSceneRoot>
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

