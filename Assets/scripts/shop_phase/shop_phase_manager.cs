using UnityEngine;

public class Shop_phase_manager : MonoBehaviour
{
    public GameObject[] pedestals;
    player_stats_manager player_stats;

    void Start()
    {
        player_stats = GetComponent<player_stats_manager>();
        card_pedestal_obj temp_pedestal_script;

        for (int i = 0; i < pedestals.Length; i++)
        {
            temp_pedestal_script = pedestals[i].GetComponent<card_pedestal_obj>();

            temp_pedestal_script.link_to_shop_manager(gameObject);
            temp_pedestal_script.create_card(new card(10,"test","does nothing"));            
        }
    }

    public void card_bought()
    {
        player_stats.update_display();
    }
}
