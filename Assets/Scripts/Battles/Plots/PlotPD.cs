using System.Collections.Generic;
using Commons;
using Foundations;
using UnityEngine;

namespace Battles.Plots
{
    public class PlotPD : Producer
    {
        public PlotView model;
        public int counts;

        Vector2 m_mid_pos;

        public override IMgr imgr => mgr;
        PlotMgr mgr;

        //==================================================================================================

        public override void call()
        {
            
        }


        public override void init(int priority)
        {
            mgr = new("PlotMgr", priority);

            foreach (var cell in cells())
            {
                var view = Instantiate(model, transform);
                cell.add_view(view);
            }

            BattleSceneRoot.instance.mainCamera.transform.localPosition = m_mid_pos;
            GameContext.instance.plots_count = counts;
        }


        IEnumerable<Plot> cells()
        {
            for (int x = 0; x < counts; x++)
            {
                Plot cell = new()
                {
                    pos = new(x, 0)
                };

                mgr.cells.Add(cell.pos, cell);

                if (x == (counts - 1) / 2)
                    m_mid_pos = cell.view_pos;

                yield return cell;
            }
        }
    }
}

