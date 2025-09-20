using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Purchaseable_card : Card_obj
{
    [SerializeField] GameObject button_obj, price_tag_obj;
    GameObject shop_manager, yes_button, price_tag;

    Shop_phase_manager shop_manager_script;
    Button_obj yes_button_script;
    Display_text price_tag_script;

    Card my_card;
    int price;

    new private void Start() 
    {
        base.Start();
        Create_button();
        Create_price_tag();
    }

    private void OnMouseDown()
    {
        yes_button_script.Set_visibility(true);
    }

    private void Create_button()
    {
        Vector3 spawn = transform.position;
        spawn.y -= 1.25f;
        yes_button = Instantiate(button_obj, spawn, Quaternion.identity);
        yes_button_script = yes_button.GetComponent<Button_obj>();

        yes_button_script.Initialize(Color.green, true, gameObject);
    }

    private void Create_price_tag()
    {
        Vector3 spawn = transform.position;
        spawn.y += -0.3f;
        spawn.x += -1f;
        price_tag = Instantiate(price_tag_obj, spawn, Quaternion.identity);
        price_tag_script = price_tag.GetComponent<Display_text>();

        price_tag_script.Text = price.ToString() + "$";
    }

    public void Recieve_button_press(bool button_type)
    {
        if (button_type == true)
        {
            Attempt_purchase();            
        }
    }

    private void Attempt_purchase()
    {
        if (Player_data.money >= price)
        {
            Player_data.player_deck.Enqueue(my_card);
            Player_data.money -= price;
            shop_manager_script.Card_bought();
            Destroy();
        }
        else
        {
            print("poor");
        }
    }


    public void Link_to_shop_manager(GameObject temp_manager)
    {
        shop_manager = temp_manager;
        shop_manager_script = shop_manager.GetComponent<Shop_phase_manager>();
    }

    public void Setup_card(Card temp_card, int temp_price)
    {
        my_card = temp_card;
        my_card.Set_card_obj(gameObject);
        price = temp_price;
    }

    new public void Destroy()
    {
        Destroy(price_tag);
        Destroy(yes_button);
        base.Destroy();
    }
}
