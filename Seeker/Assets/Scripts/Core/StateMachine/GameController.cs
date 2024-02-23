using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Seeker.UI;

namespace Seeker.Core
{
    public class GameController : MonoBehaviour
    {
        [SerializeField]
        private MainView mainView;
        public MainView MainView => mainView;

        [SerializeField]
        private GameView gameView;
        public GameView GameView => gameView;

        [SerializeField]
        private PauseView pauseView;
        public PauseView PauseView => pauseView;

        [SerializeField]
        private LoseView loseView;
        public LoseView LoseView => loseView;

        [SerializeField]
        private UIController uiController;
        public UIController UIController => uiController;

        private BaseState currentState;

        private void Start()
        {
            UIController.InitController(this);
            ChangeState(new GameStartState());
        }

        private void Update()
        {
            currentState?.UpdateState();
        }

        private void FixedUpdate()
        {
            currentState?.FixedUpdateState();
        }

        private void OnDestroy()
        {
            // ChangeState(null);
            // some method to save game before shut down
        }

        public void ChangeState(BaseState newState)
        {
            currentState?.DestroyState();
            currentState = newState;
            currentState?.InitState(this);
        }        
    }
}
