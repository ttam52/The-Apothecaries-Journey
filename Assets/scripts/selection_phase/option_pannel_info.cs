using TMPro;
using UnityEngine;

public class Option_pannel_info : MonoBehaviour
{
    public TextMeshPro info_display;
    private string text;
    int number_of_patients;
    
    public void set_number_of_patients(int value)
    { 
        number_of_patients = value;
        Update_display();
    }

    public void Update_display()
    {
        text =
        "Patients in queue: " + number_of_patients.ToString() + "\n" +
        "" + "\n" +
        "";
        info_display.text = text;

    }

}
