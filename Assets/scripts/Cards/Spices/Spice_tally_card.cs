using UnityEngine;

public class Spice_tally : Card
{
    public Spice_tally(int value, string name, string desc) : base(value, name, desc)
    {
        card_type = 'S';
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
        return tally + healing_value;
    }
}
