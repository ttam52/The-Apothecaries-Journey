using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{
   public void play_game ()
   {
    SceneManager.LoadScene("game_test");
   }

   public void quit_game ()
   {
    Debug.Log("closing successful");
    Application.Quit();  
   }
}
