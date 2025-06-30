using Foundations.MVVM;
using UnityEngine;

namespace Homes.Plots
{
    public class PlotView : MonoBehaviour, IPlotView
    {
        Plot owner;

        //==================================================================================================

        void IModelView<Plot>.attach(Plot owner)
        {
            this.owner = owner;
        }


        void IModelView<Plot>.detach(Plot owner)
        {
            this.owner = null;
        }


        void IPlotView.notify_on_tick1()
        {
        }
    }
}

