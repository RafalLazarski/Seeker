using System;
using UnityEngine;

namespace Seeker.Core
{
    public class GameState : BaseState
    {
        public override void InitState(GameController gc)
        {
            base.InitState(gc);
            gc.GameView.ShowView();
        }
        public override void DestroyState()
        {
            gc.GameView.HideView();
        }

        public override void FixedUpdateState()
        {
            
        }

        public override void UpdateState()
        {

        }
    }
}
