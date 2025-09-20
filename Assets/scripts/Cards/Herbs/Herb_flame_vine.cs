using Unity.VisualScripting;
using UnityEngine;

public class Herb_flame_vine : Card
{
    public Herb_flame_vine(int value, string name, string desc) : base(value, name, desc)
    {
        card_type = 'H';
    }

    protected override void Card_drawn()
    {
        healing_value--;
    }

}
