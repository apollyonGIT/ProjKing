using System.Collections.Generic;
using System.Linq;
using Foundations;
using UnityEngine;

namespace Homes.Plots
{
    public class PlotPD : Producer
    {
        public override IMgr imgr => mgr;
        PlotMgr mgr;

        public PlotView plot_model;

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
        }


        IEnumerable<Plot> cells()
        {
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    Plot cell = new();
                    cell.pos = new(x, y);
                    cell.view_pos = 1.25f * new Vector2(x, y);

                    mgr.cells.Add(cell.pos, cell);

                    yield return cell;
                }
            }
            
        }
    }
}

