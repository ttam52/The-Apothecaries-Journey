using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class option_pannel_obj : MonoBehaviour
{
    patient[] patient_queue;

    public void set_patient_queue(patient[] temp_queue)
    {
        patient_queue = temp_queue;
    }

    private void OnMouseDown()
    {
        game_data.patient_queue = patient_queue;
        SceneManager.LoadScene("treatment_phase");
    }

    private void update_info()
    { 
        
    }
}
