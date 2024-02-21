using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Seeker.Core;

namespace Seeker.UI
{
	public class UIController : MonoBehaviour
	{
		private GameController gc;

		public void InitController(GameController gc)
		{
			this.gc = gc;
		}

        public void StartGame()
        {
            Debug.Log("New game started");
            gc.ChangeState(new GameState());
        }

        public void ExitGame()
        {
            Debug.Log("Exit");
        }

        public void PauseGame()
        {
            Debug.Log("Pause");
            gc.ChangeState(new PauseState());
        }

        public void ResumeGame()
        {
            Debug.Log("Resume");
            gc.ChangeState(new GameState());
        }

        public void GoToMainMenu()
        {
            Debug.Log("Main Menu");
            gc.ChangeState(new MainState());
        }

        public void LoseGame()
        {
            Debug.Log("Lose");
            gc.ChangeState(new LoseState());
        }
    } 
}
