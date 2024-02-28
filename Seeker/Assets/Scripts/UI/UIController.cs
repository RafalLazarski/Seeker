using UnityEngine;
using Seeker.Core;
using UnityEngine.SceneManagement;

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
            Debug.Log("Start");
            gc.ChangeState(new GameState());
        }

        public void ExitGame()
        {
            Debug.Log("Exit");

            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #endif

            Application.Quit();
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
            gc.ChangeState(new GameStartState());
        }

        public void LoseGame()
        {
            Debug.Log("Lose");
            gc.ChangeState(new LoseState());
        }

        public void RestartGame()
        {
            Debug.Log("Restart");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            gc.ChangeState(new GameStartState());
        }
    } 
}
