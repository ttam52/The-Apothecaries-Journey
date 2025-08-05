using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{
   public void play_game ()
   {
    SceneManager.LoadScene("game_test");
   }
}
