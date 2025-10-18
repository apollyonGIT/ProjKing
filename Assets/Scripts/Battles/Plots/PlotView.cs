using Foundations.MVVM;
using System;
using UnityEngine;

namespace Battle.Plots
{
    public class PlotView : MonoBehaviour, IPlotView
    {
        Plot owner;

        Action<object> IModelView.tick1 { get => m_tick1_ac; set => m_tick1_ac = value; }
        Action<object> m_tick1_ac;

        //==================================================================================================

        void IModelView<Plot>.attach(Plot owner)
        {
            this.owner = owner;

            transform.localPosition = owner.view_pos;
        }


        void IModelView<Plot>.detach(Plot owner)
        {
            this.owner = null;
        }


        void IPlotView.notify_on_tick1()
        {
            m_tick1_ac?.Invoke(owner);
        }
    }
}