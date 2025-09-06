using UnityEngine;

public static class Player_data
{
    public static int reputation = 0;
    public static int money = 0;
    public static deck player_deck = new deck(100);

    static Player_data()
    {
        for (int i = 0; i < 10; i++)
        {
            player_deck.enqueue(new card(2, "basic_card", "does nothing"));
        }
    }
}
