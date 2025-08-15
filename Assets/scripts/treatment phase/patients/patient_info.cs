using TMPro;
using UnityEngine;

public class patient_info : MonoBehaviour
{
    public TextMeshPro info_display;
    private string text;
    int target_value;
    

    //private void Awake()
    //{
    //    text =
    //    "Target Healing Value: " + target_value.ToString() + "\n" +
    //    "#" + "\n" +
    //    "#";
    //}

    //public string Text
    //{
    //    get
    //    {
    //        return text;
    //    }
    //    set
    //    {
    //        text = value;
    //        Update_display();
    //    }
    //}

    public void set_target_value(int score)
    { 
        target_value = score;
        Update_display();
    }

    public void Update_display()
    {
        text =
        "Target Healing Value: " + target_value.ToString() + "\n" +
        "" + "\n" +
        "";
        info_display.text = text;
    }

}
