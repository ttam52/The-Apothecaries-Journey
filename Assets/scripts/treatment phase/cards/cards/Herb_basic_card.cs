using UnityEngine;

public class Herb_basic_card : Card
{
    public Herb_basic_card(int value, string name, string desc) : base(value, name, desc)
    {
        card_type = 'H';
    }
}
