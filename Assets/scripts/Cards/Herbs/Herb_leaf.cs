using UnityEngine;

public class Herb_leaf: Card
{
    public Herb_leaf(int value, string name, string desc) : base(value, name, desc)
    {
        card_type = 'H';
    }
}
