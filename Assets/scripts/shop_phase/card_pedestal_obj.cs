using UnityEngine;

public class card_pedestal_obj : MonoBehaviour
{
    [SerializeField] GameObject my_purchaseable_card_obj;
    card my_card;
    purchaseable_card my_card_script;
    void Start()
    { 
        my_card_script = my_purchaseable_card_obj.GetComponent<purchaseable_card>();
    }

    public void create_card(card temp_card)
    {
        my_card = temp_card;
    }

    public void card_sold()
    {
        Player_data.player_deck.enqueue(my_card);
    }
}
