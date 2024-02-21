using UnityEngine;

namespace Seeker.Core
{
    public class MainState : BaseState
    {
        public override void InitState(GameController gc)
        {
            base.InitState(gc);
            gc.MainView.ShowView();
        }

        public override void DestroyState()
        {
            gc.MainView.HideView();
        }

        public override void FixedUpdateState()
        {

        }

        public override void UpdateState()
        {

        }

        public void StartGame()
        {
            gc.ChangeState(new GameState());
        }
    }
}
