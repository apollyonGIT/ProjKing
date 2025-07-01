using System.Collections.Generic;
using Foundations;
using UnityEngine;

namespace Homes.Plots
{
    public class PlotPD : Producer
    {
        public override IMgr imgr => mgr;
        PlotMgr mgr;

        public PlotView plot_model;
        public Vector2 counts;

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

            //规则：移动相机至地块中心
            HomeSceneRoot.instance.mainCamera.transform.localPosition = 1.25f * new Vector2(Mathf.FloorToInt(counts.x / 2f), Mathf.FloorToInt(counts.y / 2f));
        }


        IEnumerable<Plot> cells()
        {
            for (int y = 0; y < counts.y; y++)
            {
                for (int x = 0; x < counts.x; x++)
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

