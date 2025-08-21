using Commons;
using Foundations.MVVM;
using Spine.Unity;
using System;
using UnityEngine;

namespace Battles.Monsters
{
    public class MonsterView : MonoBehaviour, IMonsterView
    {
        public SkeletonAnimation anim;

        Monster owner;

        Action<object> IModelView.tick1 { get => m_tick1_ac; set => m_tick1_ac = value; }
        Action<object> m_tick1_ac;

        //==================================================================================================

        void IModelView<Monster>.attach(Monster owner)
        {
            this.owner = owner;

            calc_transform();
        }


        void IModelView<Monster>.detach(Monster owner)
        {
            this.owner = null;
        }


        void IMonsterView.notify_on_tick1()
        {
            calc_transform();

            if (anim != null)
            {
                anim.Update(Config.PHYSICS_TICK_DELTA_TIME);
            }

            m_tick1_ac?.Invoke(owner);
        }


        void calc_transform()
        {
            transform.localPosition = owner.view_pos;
            transform.localScale = new(owner.flipX, 1, 1);
        }
    }
}

