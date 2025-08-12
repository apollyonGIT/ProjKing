using Foundations.MVVM;
using UnityEngine;

namespace Battles.Monsters
{
    public class MonsterView : MonoBehaviour, IMonsterView
    {
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
        }
    }
}

