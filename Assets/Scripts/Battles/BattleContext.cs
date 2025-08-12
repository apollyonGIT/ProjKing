using Foundations;
using Foundations.Tickers;

namespace Battles
{
    public class BattleContext : Singleton<BattleContext>
    {
        public bool is_ban_player_input;

        public bool is_player_seckill;

        //==================================================================================================

        public void attach()
        {
            Ticker.instance.do_when_tick_start += ctx_tick_start;
            Ticker.instance.do_when_tick_end += ctx_tick_end;
        }


        public void detach()
        {
        }


        private void ctx_tick_start()
        {
        }


        private void ctx_tick_end()
        {
        }
    }
}

