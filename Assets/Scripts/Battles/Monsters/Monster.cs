using Commons;
using Foundations.MVVM;
using System;
using UnityEngine;

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

        public Vector2 pos;
        public Vector2 view_pos => Config.current.pos_coef * pos;

        public Vector2 dir = Vector2.right;
        public int flipX => dir.x > 0 ? 1 : -1;

        //==================================================================================================

        public Monster(uint uid, Vector2 pos, Vector2 dir)
        {
            AutoCodes.monsters.TryGetValue($"{uid}", out _desc);

            GUID = Guid.NewGuid().ToString();

            this.pos = pos;
            this.dir = dir;
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





