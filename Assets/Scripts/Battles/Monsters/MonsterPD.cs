using Foundations;
using UnityEngine;

namespace Battle.Monsters
{
    public class MonsterPD : Producer
    {
        public override IMgr imgr => mgr;
        MonsterMgr mgr;

        //==================================================================================================

        public override void init(int priority)
        {
            mgr = new("MonsterMgr", priority);
            mgr.pd = this;
        }


        public override void call()
        {
            foreach (var (_, cell) in mgr.cells)
            {
                cell.do_turn();
            }
        }


        public Monster cell(uint uid, Vector2 pos, Vector2 dir)
        {
            Monster cell = new(uid, pos, dir);

            mgr.cells.Add(cell.GUID, cell);

            Addrs.Addressable_Utility.try_load_asset<MonsterView>(cell._desc.monster_view, out var model_view);
            var view = Instantiate(model_view, transform);
            cell.add_view(view);

            return cell;
        }
    }
}