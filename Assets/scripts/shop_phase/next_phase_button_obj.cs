using UnityEngine;
using UnityEngine.SceneManagement;

public class next_phase_button_obj : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("selection_phase");
    }
}
