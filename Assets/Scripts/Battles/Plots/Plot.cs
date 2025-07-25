﻿using Foundations.MVVM;
using UnityEngine;

namespace Battles.Plots
{
    public interface IPlotView : IModelView<Plot>
    {
        void notify_on_tick1();
    }


    public class Plot : Model<Plot, IPlotView>
    {
        public Vector2 pos;
        public Vector2 view_pos => 1.25f * pos;

        //==================================================================================================

        public void tick()
        {

        }


        public void tick1()
        {
            foreach (var view in views)
            {
                view.notify_on_tick1();
            }
        }
    }
}





