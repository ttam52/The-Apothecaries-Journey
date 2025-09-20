using UnityEngine;

public class Player_stats_manager : MonoBehaviour
{
    public GameObject money_display, reputation_display;
    Display_text money_display_script, reputation_display_script;

    int money;
    int reputation;

    private void Awake()
    {
        money_display_script = money_display.GetComponent<Display_text>();
        reputation_display_script = reputation_display.GetComponent<Display_text>();

        Update_display();
    }

    public void Update_display()
    {
        money = Player_data.money;
        reputation = Player_data.reputation;

        money_display_script.Text = money.ToString() + "$";
        reputation_display_script.Text = reputation.ToString() + "*";
    }

}
