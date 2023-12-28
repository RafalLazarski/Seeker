using UnityEngine;

namespace Seeker.Core
{
    public abstract class BaseState
    {
        protected GameController gc;

        public virtual void InitState(GameController gc)
        {
            this.gc = gc;
        }
        public abstract void UpdateState();
        public abstract void FixedUpdateState();
        public abstract void DestroyState();
    } 
}
