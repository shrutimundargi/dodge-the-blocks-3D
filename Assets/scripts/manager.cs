using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
   bool gameEnd = false;
   public float delay = 1f;
   public GameObject CompleteLevelUI;
   public void CompleteLevel()
   {
      CompleteLevelUI.SetActive(true);
   }
   public void GameOver()
   {
	   	if (gameEnd == false)
	   	{
	   		gameEnd = true;
	   		Debug.Log("GAME OVER");
	   		Invoke("Restart", delay);
	   	}
   	
   }

   void Restart()
   {
   		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
