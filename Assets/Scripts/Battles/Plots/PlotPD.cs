using System.Collections.Generic;
using Foundations;
using UnityEngine;

namespace Battles.Plots
{
    public class PlotPD : Producer
    {
        public override IMgr imgr => mgr;
        PlotMgr mgr;

        public PlotView plot_model;
        public int counts;

        Vector2 m_mid_pos;

        //==================================================================================================

        public override void call()
        {
            
        }


        public override void init(int priority)
        {
            mgr = new("PlotMgr", priority);

            foreach (var cell in cells())
            {
                var plot_view = Instantiate(plot_model, transform);
                cell.add_view(plot_view);
            }

            BattleSceneRoot.instance.mainCamera.transform.localPosition = m_mid_pos;
        }


        IEnumerable<Plot> cells()
        {
            for (int x = 0; x < counts; x++)
            {
                Plot cell = new();
                cell.pos = new(x, 0);
                cell.view_pos = 1.25f * cell.pos;

                mgr.cells.Add(cell.pos, cell);

                if (x == (counts - 1) / 2)
                    m_mid_pos = cell.view_pos;

                yield return cell;
            }
        }
    }
}

