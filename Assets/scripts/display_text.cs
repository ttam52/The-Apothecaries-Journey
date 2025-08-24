using TMPro;
using UnityEngine;

public class Display_text : MonoBehaviour
{
    public TextMeshPro info_display;
    private string text;

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
