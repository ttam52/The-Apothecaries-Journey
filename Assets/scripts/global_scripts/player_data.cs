using UnityEngine;

public static class Player_data
{
    private static card_generator card_pool = new card_generator();
    public static int reputation = 5;
    public static int money = 0;
    public static Deck player_deck = new Deck(100);

    static Player_data()
    {
        //for (int i = 0; i < 10; i++)
        //{
        //    player_deck.Enqueue(new Herb_leaf(1, "leaf - 1", "does nothing"));
        //}

        //player_deck.Enqueue(new Herb_leaf(1, "leaf - 1", "does nothing"));
        //player_deck.Enqueue(new Herb_leaf(1, "leaf - 1", "does nothing"));
        //player_deck.Enqueue(new Herb_leaf(1, "leaf - 1", "does nothing"));
        //player_deck.Enqueue(new Spice_tally(0, "tally - 0", "score 1 for every herb in play"));

        //player_deck.Enqueue(new Herb_leaf(1, "leaf - 1", "does nothing"));
        //player_deck.Enqueue(new Herb_snowchime(0, "snowchime - 0", "gives 2 bonus points if the recipe contains no spices"));
        //player_deck.Enqueue(new Herb_snowchime(0, "snowchime - 0", "gives 2 bonus points if the recipe contains no spices"));
        //player_deck.Enqueue(new Herb_snowchime(0, "snowchime - 0", "gives 2 bonus points if the recipe contains no spices"));
        //player_deck.Enqueue(new Spice_tally(0, "tally - 0", "score 1 for each herb in play"));

        //player_deck.Enqueue(new Herb_leaf(1, "leaf - 1", "does nothing"));
        //player_deck.Enqueue(new Herb_leaf(1, "leaf - 1", "does nothing"));
        //player_deck.Enqueue(new Herb_leaf(1, "leaf - 1", "does nothing"));
        //player_deck.Enqueue(new Herb_witch_orchid(1, "witch orchid - 1", "gives 2 bonus points if the recipe contains exactly 3 herbs"));

        //
    }
}
