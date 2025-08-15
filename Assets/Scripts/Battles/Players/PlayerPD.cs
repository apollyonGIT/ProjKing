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
            
        }


        Player cell()
        {
            Player cell = new();
            cell.pos = new(1, 0);

            return cell;
        }
    }
}