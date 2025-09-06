using UnityEngine;

public static class game_data
{
    public static int currrent_level;
    public static patient[] patient_queue;
    public static int stock;
    static game_data()
    {
        currrent_level = 0;
        stock = 0;
    }
}
