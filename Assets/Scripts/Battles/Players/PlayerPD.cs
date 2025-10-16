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
            Player cell = new()
            {
                //规则：随机位置、朝向
                pos = new(Random.Range(0, BattleContext.instance.plots_count), 0),
                dir = Random.Range(0, 100) > 50 ? Vector2.right : Vector2.left
            };

            return cell;
        }
    }
}