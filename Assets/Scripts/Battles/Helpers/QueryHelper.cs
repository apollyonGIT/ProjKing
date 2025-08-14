using Battles.Monsters;
using Battles.Players;
using Foundations;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Battles.Helpers
{
    public class QueryHelper
    {
        public static Vector2 query_player_pos()
        {
            Mission.instance.try_get_mgr("PlayerMgr", out PlayerMgr mgr);
            return mgr.cell.pos;
        }


        public static Vector2[] query_monster_pos_array()
        {
            Mission.instance.try_get_mgr("MonsterMgr", out MonsterMgr mgr);

            List<Vector2> pos_list = new();
            foreach (var (_, cell) in mgr.cells)
            {
                pos_list.Add(cell.pos);
            }

            return pos_list.ToArray();
        }


        public static Vector2[] query_full_pos()
        {
            var player_pos = query_player_pos();
            var monster_pos_list = query_monster_pos_array().ToList();

            var pos_list = monster_pos_list.Append(player_pos);
            return pos_list.ToArray();
        }


        public static Vector2[] query_empty_pos()
        {
            var full_pos_array = query_full_pos();

            Mission.instance.try_get_mgr("PlotMgr", out Plots.PlotMgr mgr);

            List<Vector2> pos_list = new();
            foreach (var (_, cell) in mgr.cells)
            {
                var pos = cell.pos;

                if (full_pos_array.Contains(pos)) continue;

                pos_list.Add(pos);
            }

            return pos_list.ToArray();
        }
    }
}

