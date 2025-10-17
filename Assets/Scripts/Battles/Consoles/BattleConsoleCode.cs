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
        public static void m1(string _pos_x, string _dir_x)
        {
            Vector2 pos = new(float.Parse(_pos_x), 0);
            Vector2 dir = new(float.Parse(_dir_x), 0);

            Mission.instance.try_get_mgr("MonsterMgr", out Monsters.MonsterMgr mgr);

            var pd = mgr.pd;
            pd.cell(201101u, pos, dir);
        }


        [Detail("【添加洞穴人】m2")]
        public static void m2(string _pos_x, string _dir_x)
        {
            Vector2 pos = new(float.Parse(_pos_x), 0);
            Vector2 dir = new(float.Parse(_dir_x), 0);

            Mission.instance.try_get_mgr("MonsterMgr", out Monsters.MonsterMgr mgr);

            var pd = mgr.pd;
            pd.cell(201102u, pos, dir);
        }


        [Detail("【添加蝙蝠骑士】m5")]
        public static void m5(string _pos_x, string _dir_x)
        {
            Vector2 pos = new(float.Parse(_pos_x), 0);
            Vector2 dir = new(float.Parse(_dir_x), 0);

            Mission.instance.try_get_mgr("MonsterMgr", out Monsters.MonsterMgr mgr);

            var pd = mgr.pd;
            pd.cell(201105u, pos, dir);
        }


        [Detail("【添加怪物】m5")]
        public static void m(string seq, string _pos_x)
        {
            Vector2 pos = new(float.Parse(_pos_x), 0);
            Vector2 dir = new(1, 0);

            Mission.instance.try_get_mgr("MonsterMgr", out Monsters.MonsterMgr mgr);

            var pd = mgr.pd;
            pd.cell(201100u + uint.Parse(seq), pos, dir);
        }
    }
}

