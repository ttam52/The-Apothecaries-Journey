using UnityEngine;

public class Patient
{
    GameObject patient_obj;
    bool condition_met = true;
    int healing_target;
    Sprite image;

    public Patient(int h_value, Sprite i_visual)
    {
        healing_target = h_value;
        image = i_visual;
    }

    public int Get_healing_target()
    {
        return healing_target;
    }
    public Sprite Get_image()
    {
        return image;
    }
    public GameObject Get_patient_obj()
    {
        return patient_obj;
    }

    public void Set_healing_target(int h_value)
    {
        healing_target = h_value;
    }

    public void Set_image(Sprite i_visual)
    {
        image = i_visual;
    }

    public void Set_patient_obj(GameObject p_obj)
    { 
        patient_obj = p_obj;
    }
}
