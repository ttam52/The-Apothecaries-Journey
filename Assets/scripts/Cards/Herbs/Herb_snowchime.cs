using UnityEngine;

public class Herb_snowchime : Card
{
    public Herb_snowchime(int value, string name, string desc) : base(value, name, desc)
    {
        card_type = 'H';
        has_effect = true;
    }

    public override int Trigger_effect(Card[] cards_in_play, int total_cards)
    {
        int tally = 0;
        Card card;

        for (int i = 0; i < total_cards; i++)
        {
            card = cards_in_play[i];
            if (card.card_type == 'S')
            {
                return healing_value;
            }
        }
        return healing_value + 2;
    }
}
