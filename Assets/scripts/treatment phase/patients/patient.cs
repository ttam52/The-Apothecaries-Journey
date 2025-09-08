using UnityEngine;

public class patient
{
    GameObject patient_obj;
    bool condition_met = true;
    int healing_target;
    Sprite image;

    public patient(int h_value, Sprite i_visual)
    {
        healing_target = h_value;
        image = i_visual;
    }

    public int get_healing_target()
    {
        return healing_target;
    }
    public Sprite get_image()
    {
        return image;
    }
    public GameObject get_patient_obj()
    {
        return patient_obj;
    }

    public void set_healing_target(int h_value)
    {
        healing_target = h_value;
    }

    public void set_image(Sprite i_visual)
    {
        image = i_visual;
    }

    public void set_patient_obj(GameObject p_obj)
    { 
        patient_obj = p_obj;
    }
}
