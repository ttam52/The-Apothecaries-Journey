using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;


public class main_menu : MonoBehaviour
{
   public void play_game ()
   {
    SceneManager.LoadScene("game_test");
   }

   public void quit_game ()
   {
    Debug.Log("application closed");
    Application.Quit();
   }
}
