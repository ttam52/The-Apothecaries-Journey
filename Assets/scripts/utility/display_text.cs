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

    public void set_colour(Color colour)
    {
        info_display.color = colour;
    }

    public void set_visibility(bool visibility)
    {
        info_display.enabled = visibility;
    }

}
