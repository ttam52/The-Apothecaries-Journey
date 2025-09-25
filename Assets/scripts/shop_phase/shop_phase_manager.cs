using UnityEngine;

public class Shop_phase_manager : MonoBehaviour
{
    public GameObject[] pedestals;
    Player_stats_manager player_stats;
    card_generator shop_pool = new card_generator();

    void Start()
    {
        player_stats = GetComponent<Player_stats_manager>();
        Card_pedestal_obj temp_pedestal_script;

        for (int i = 0; i < pedestals.Length; i++)
        {
            temp_pedestal_script = pedestals[i].GetComponent<Card_pedestal_obj>();

            temp_pedestal_script.Link_to_shop_manager(gameObject);
            temp_pedestal_script.Create_card(shop_pool.return_herb());
        }
    }

    public void Card_bought()
    {
        player_stats.Update_display();
    }
}
