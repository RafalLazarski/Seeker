using UnityEngine;

namespace Seeker.Core
{
    public class PauseState : BaseState
    {
        public override void InitState(GameController gc)
        {
            base.InitState(gc);
            gc.PauseView.ShowView();
        }
        public override void DestroyState()
        {
            gc.PauseView.HideView();
        }

        public override void FixedUpdateState()
        {

        }

        public override void UpdateState()
        {

        }
    }
}
