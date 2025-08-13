using Unity.VisualScripting;
using UnityEngine;

public class card
{
    GameObject card_obj;
    int healing_value = 0;
    string card_name = "";

    public card (int value, string name)
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

    public void set_card_obj(GameObject obj)
    {
        card_obj = obj;
    }
    public GameObject get_card_obj()
    {
        return card_obj;
    }

}
