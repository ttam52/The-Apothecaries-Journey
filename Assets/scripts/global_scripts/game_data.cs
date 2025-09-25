using UnityEngine;

public static class Game_data
{
    public static int currrent_level;
    public static Patient[] patient_queue;
    public static int stock;
    static Game_data()
    {
        currrent_level = 0;
        stock = 0;
    }
}
