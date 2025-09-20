using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class card_generator
{
    public Dictionary<int, Card> herb_cards = new Dictionary<int, Card>();
    public Dictionary<int, Card> spice_cards = new Dictionary<int, Card>();
    //Dictionary<int, Card> mineral_cards = new Dictionary<int, Card>();
    //Dictionary<int, Card> toxin_cards = new Dictionary<int, Card>();
    //Dictionary<int, Card> tool_cards = new Dictionary<int, Card>();

    public card_generator() 
    {
        //herbs
        herb_cards.Add(1, new Herb_leaf(1, "leaf - 1", "does nothing"));
        herb_cards.Add(2, new Herb_witch_orchid(1, "witch orchid - 1", "gives 2 bonus points if the recipe contains exactly 3 herbs"));
        herb_cards.Add(3, new Herb_snowchime(0, "snowchime - 0", "gives 2 bonus points if the recipe contains no spices"));
        herb_cards.Add(4, new Herb_flame_vine(15, "flame vine - 15", "loses 1 point each time its scored"));

        //spices
        spice_cards.Add(1, new Spice_tally(0, "tally - 0", "score 1 for each herb in play"));
    }

    public Card return_herb()
    {
        return herb_cards[Random.Range(1,3)];
    }
}
