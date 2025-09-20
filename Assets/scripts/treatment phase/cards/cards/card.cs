using Unity.VisualScripting;
using UnityEngine;

public class Card
{
    GameObject card_obj;
    public char card_type;
    protected bool has_effect = false;
    protected int healing_value = 0;
    string card_name = "";
    string description = "";

    public Card (int value, string name, string desc)
    {
        healing_value = value;
        card_name = name;
        description = desc;
    }
    public virtual int Trigger_effect(Card[] cards_in_play, int total_cards)
    {
        return 0;
    }

    public virtual int Get_value()
    {
        return healing_value;
    }
    public bool Has_effect()
    { 
        return has_effect;
    }
    public string Get_name()
    { 
        return card_name;
    }

    public string Get_description()
    {
        return description;
    }

    public void Set_card_obj(GameObject obj)
    {
        card_obj = obj;
        card_obj.GetComponent<Card_obj>().description = card_name + "\n" + description;
    }
    public GameObject Get_card_obj()
    {
        return card_obj;
    }

}
