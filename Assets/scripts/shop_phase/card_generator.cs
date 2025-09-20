using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class card_generator
{
    Dictionary<int, Card> herb_cards = new Dictionary<int, Card>();
    Dictionary<int, Card> spice_cards = new Dictionary<int, Card>();
    //Dictionary<int, Card> mineral_cards = new Dictionary<int, Card>();
    //Dictionary<int, Card> toxin_cards = new Dictionary<int, Card>();
    //Dictionary<int, Card> tool_cards = new Dictionary<int, Card>();

    public card_generator() 
    {
        //herbs
        herb_cards.Add(1, new Herb_basic_card(1, "basic herb", "does nothing"));

        //spices
        spice_cards.Add(1, new Spice_tally_card(0, "tally spice", "gain 1 for each herb in play"));
    }

    public Card return_herb()
    {
        return herb_cards[1];
    }
}
