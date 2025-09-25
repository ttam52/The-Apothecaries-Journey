using UnityEngine;

public class Herb_witch_orchid : Card
{
    public Herb_witch_orchid(int value, string name, string desc) : base(value, name, desc)
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
            if (card.card_type == 'H')
            {
                tally++;
            }
        }

        if (tally == 3)
        {
            return 2 + healing_value;
        }

        return healing_value;
    }
}
