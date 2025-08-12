using Commons;

namespace Battles.Consoles
{
    public class BattleConsoleCode
    {
        //[Detail("【无敌】whosyourdaddy")]
        //public static void whosyourdaddy()
        //{
        //    var ctx = WorldContext.instance;

        //    if (ctx.is_player_seckill)
        //        Debug.Log("whosyourdaddy，已激活");
        //    else
        //        Debug.Log("whosyourdaddy，已取消");
        //}


        public static void help()
        {
            Console_Code_Helper.help(typeof(BattleConsoleCode));
        }


        
    }
}

