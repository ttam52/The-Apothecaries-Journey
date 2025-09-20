using UnityEngine;

public static class Player_data
{
    public static int reputation = 5;
    public static int money = 0;
    public static Deck player_deck = new Deck(100);

    static Player_data()
    {
        for (int i = 0; i < 10; i++)
        {
            player_deck.Enqueue(new Herb_basic_card(1, "basic herb card", "does nothing"));
        }
        player_deck.Enqueue(new Spice_tally_card(0, "tally card", "score 1 for every herb in play"));
    }
}
