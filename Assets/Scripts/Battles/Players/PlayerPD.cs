using Foundations;
using UnityEngine;

namespace Battles.Players
{
    public class PlayerPD : Producer
    {
        public PlayerView model;

        public override IMgr imgr => mgr;
        PlayerMgr mgr;

        //==================================================================================================

        public override void init(int priority)
        {
            mgr = new("PlayerMgr", priority);
            mgr.cell = cell();

            var view = Instantiate(model, transform);
            mgr.cell.add_view(view);
        }


        public override void call()
        {
            var ts = Helpers.QueryHelper.query_full_pos();

            foreach (var t in ts)
            {
                Debug.Log(t);
            }
        }


        Player cell()
        {
            Player cell = new();
            cell.pos = new(1, 0);

            return cell;
        }
    }
}