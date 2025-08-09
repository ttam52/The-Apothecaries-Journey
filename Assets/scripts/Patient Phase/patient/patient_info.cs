using TMPro;
using UnityEngine;

public class patient_info : MonoBehaviour
{
    public TextMeshPro info_display;
    private string text = 
        "Target Healing Value:" + "\n" +
        "#" + "\n" +
        "#";

    private void Awake()
    {
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


    public void Update_display()
    {
        info_display.text = text;
    }

}
