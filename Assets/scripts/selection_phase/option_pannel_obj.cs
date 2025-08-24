using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Option_pannel_obj : MonoBehaviour
{
    public GameObject info_display;
    patient[] patient_queue;

    Option_pannel_info info_display_script;
    
    private void Awake()
    {
        info_display_script = info_display.GetComponent<Option_pannel_info>();
    }

    public void set_patient_queue(patient[] temp_queue)
    {
        patient_queue = temp_queue;
        info_display_script.set_number_of_patients(patient_queue.Length);
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
