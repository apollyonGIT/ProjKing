using Commons;
using Foundations;
using UnityEngine;
using static Commons.Attributes;

namespace Battles.Consoles
{
    public class BattleConsoleCode
    {
        public static void help()
        {
            Console_Code_Helper.help(typeof(BattleConsoleCode));
        }


        [Detail("【无敌】whosyourdaddy")]
        public static void whosyourdaddy()
        {
            var ctx = BattleContext.instance;

            ref var is_player_seckill = ref ctx.is_player_seckill;
            is_player_seckill = !is_player_seckill;

            if (is_player_seckill)
                Debug.Log("whosyourdaddy，已激活");
            else
                Debug.Log("whosyourdaddy，已取消");
        }


        [Detail("【添加蝙蝠】m1")]
        public static void m1()
        {
            Mission.instance.try_get_mgr("MonsterMgr", out Monsters.MonsterMgr mgr);

            var pd = mgr.pd;
            var cell = pd.cell(201101u, new(2, 0), Vector2.right);
        }


        [Detail("【添加洞穴人】m2")]
        public static void m2()
        {
            Mission.instance.try_get_mgr("MonsterMgr", out Monsters.MonsterMgr mgr);

            var pd = mgr.pd;
            pd.cell(201102u, new(0, 0), Vector2.left);
        }
    }
}

