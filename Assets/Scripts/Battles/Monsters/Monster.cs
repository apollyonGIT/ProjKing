using Foundations.MVVM;
using System;

namespace Battles.Monsters
{
    public interface IMonsterView : IModelView<Monster>
    {
        void notify_on_tick1();
    }


    public class Monster : Model<Monster, IMonsterView>
    {
        public AutoCodes.monster _desc;
        public string GUID;

        //==================================================================================================

        public Monster(uint uid)
        {
            AutoCodes.monsters.TryGetValue($"{uid}", out _desc);

            GUID = Guid.NewGuid().ToString();
        }


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





