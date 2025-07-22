using UnityEngine;

public class card_parent
{
    int healing_value = 0;
    string card_name = "";

    public card_parent (int value, string name)
    {
        healing_value = value;
        card_name = name;
    }

    public int get_value()
    {
        return healing_value;
    }
    public string get_name()
    { 
        return card_name;
    }

}
