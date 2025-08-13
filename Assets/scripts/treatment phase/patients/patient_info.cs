using TMPro;
using UnityEngine;

public class patient_info : MonoBehaviour
{
    public TextMeshPro info_display;
    private string text;
    int healing_value;
    

    private void Awake()
    {
        text =
        "Target Healing Value: " + healing_value.ToString() + "\n" +
        "#" + "\n" +
        "#";
        Update_display();
    }

    public string Text
    {
        get
        {
            return text;
        }
        set
        {
            text = value;
            Update_display();
        }
    }
    public void set_healing_value(int score)
    { 
        healing_value = score;
        Update_display();
    }

    public void Update_display()
    {
        info_display.text = text;
    }

}
