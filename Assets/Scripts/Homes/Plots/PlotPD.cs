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

            for (int i = 0; i < 3; i++)
            {
                var plot = Instantiate(plot_model, transform);
                plot.transform.localPosition = new Vector2(i * 1.25f, 0);
            }
        }
    }
}

