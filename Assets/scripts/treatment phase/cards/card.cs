using Unity.VisualScripting;
using UnityEngine;

public class card
{
    GameObject card_obj;
    int healing_value = 0;
    string card_name = "";
    string description = "";

    public card (int value, string name, string desc)
    {
        healing_value = value;
        card_name = name;
        description = desc;
    }

    public int get_value()
    {
        return healing_value;
    }
    public string get_name()
    { 
        return card_name;
    }

    public string get_description()
    {
        return description;
    }

    public void set_card_obj(GameObject obj)
    {
        card_obj = obj;
        card_obj.GetComponent<card_obj>().description = card_name + "\n" + description;
    }
    public GameObject get_card_obj()
    {
        return card_obj;
    }

}
