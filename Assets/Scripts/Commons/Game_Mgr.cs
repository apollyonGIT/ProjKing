using Foundations;
using Foundations.Tickers;

namespace Commons
{
    public class Game_Mgr
    {

        //==================================================================================================

        public static void on_init_game()
        {
            Share_DS._init();
        }


        public static void on_start_new_game()
        {
        }


        public static void on_continue_game()
        {
        }


        public static void on_exit_game()
        {
        }


        public static void on_enter_world(params object[] args)
        {
        }


        public static void on_exit_world(params object[] args)
        {
            Ticker.instance.is_end = true;
        }
    }
}

