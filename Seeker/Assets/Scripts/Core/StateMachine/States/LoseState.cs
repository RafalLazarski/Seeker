using System;
using UnityEngine;

namespace Seeker.Core
{
    public class LoseState : BaseState
    {
        public override void InitState(GameController gc)
        {
            base.InitState(gc);
            gc.LoseView.ShowView();
        }

        public override void DestroyState()
        {
            gc.LoseView.HideView();
        }

        public override void FixedUpdateState()
        {

        }

        public override void UpdateState()
        {

        }
    }
}
