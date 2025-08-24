using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Option_pannel_obj : MonoBehaviour
{
    public GameObject info_display;
    patient[] patient_queue;
    Display_text info_display_script;
    int stock;

    private void Awake()
    {
        info_display_script = info_display.GetComponent<Display_text>();
    }

    public void set_patient_queue(patient[] temp_queue)
    {
        patient_queue = temp_queue;
        stock = patient_queue.Length * 6;

        info_display_script.Text =
        "patients: " + patient_queue.Length.ToString() + "\n"
      + "stock: " + stock.ToString();
    }

    //public void set_stock(int value)
    //{ 
    //    stock = value;
    //}

    private void OnMouseDown()
    {
        game_data.patient_queue = patient_queue;
        game_data.stock = stock;
        SceneManager.LoadScene("treatment_phase");
    }

}
