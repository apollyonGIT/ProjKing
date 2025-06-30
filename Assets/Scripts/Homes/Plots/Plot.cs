using Foundations.MVVM;

namespace Homes.Plots
{
    public interface IPlotView : IModelView<Plot>
    {
        void notify_on_tick1();
    }


    public class Plot : Model<Plot, IPlotView>
    {

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





