using UnityEngine;

public class patient
{
    bool condition_met = true;
    int healing_target;
    Texture2D image;

    public patient(int h_value, Texture2D i_visual)
    {
        healing_target = h_value;
        image = i_visual;
    }

    public int get_value()
    {
        return healing_target;
    }
    public Texture2D get_image()
    {
        return image;
    }

    public void set_value(int h_value)
    {
        healing_target = h_value;
    }

    public void set_image(Texture2D i_visual)
    {
        image = i_visual;
    }
}
