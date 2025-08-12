using Commons;
using Foundations.MVVM;
using Spine.Unity;
using UnityEngine;

namespace Battles.Monsters
{
    public class MonsterView : MonoBehaviour, IMonsterView
    {
        public SkeletonAnimation anim;

        Monster owner;

        //==================================================================================================

        void IModelView<Monster>.attach(Monster owner)
        {
            this.owner = owner;
        }


        void IModelView<Monster>.detach(Monster owner)
        {
            this.owner = null;
        }


        void IMonsterView.notify_on_tick1()
        {
            if (anim != null)
            {
                anim.Update(Config.PHYSICS_TICK_DELTA_TIME);
            }
        }
    }
}

