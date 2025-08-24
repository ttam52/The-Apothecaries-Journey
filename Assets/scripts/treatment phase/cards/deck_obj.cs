using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;


public class Deck_obj : MonoBehaviour
{
    public GameObject treatment_phase_manager, deck_stock_obj, deck_size_obj;
    public deck main_deck = new deck(100);
    public deck discard_pile = new deck(100);

    card_management card_manager;
    Display_text deck_stock, deck_size;
    int stock;

    private void Awake()
    {
        card_manager = treatment_phase_manager.GetComponent<card_management>();
        deck_stock = deck_stock_obj.GetComponent<Display_text>();
        deck_size = deck_size_obj.GetComponent<Display_text>();

        main_deck = Player_data.player_deck;
        main_deck.shuffle();

        stock = game_data.stock;
    }
    void Start()
    {
        update_number_of_cards();
    }

    private void OnMouseDown()
    {
        card temp_card = draw_card();
        
        if (can_draw_card(temp_card))
        {
            stock--;

            discard_pile.enqueue(temp_card);
            card_manager.card_drawn(temp_card);
            update_number_of_cards();
        }
        else 
        {
            print("null");
            print("stock: " + stock.ToString());
        }
    }

    public card draw_card()
    {
        if (!main_deck.is_empty())
        {
            return main_deck.dequeue();
        }

        print("empty deck draw attempt");
        return null;
    }

    public void reshuffle_played_cards()
    {
        int steps = discard_pile.get_size();
        for (int i = 0; i < steps; i++)
        {
            main_deck.enqueue(discard_pile.dequeue());
        }
        main_deck.shuffle();
        pack_player_deck();
        update_number_of_cards();
    }

    public void pack_player_deck()
    { 
        Player_data.player_deck = main_deck;
    }

    private void update_number_of_cards()
    {
        deck_stock.Text = stock.ToString();
        deck_size.Text = main_deck.get_size().ToString();
    }
    private bool can_draw_card(card drawn_card)
    {
        if (stock <= 0)
        {
            print("no stock");
            return false;
        }

        if (drawn_card == null)
        {
            print("null card drawn");
            return false;
        }

        return true;
    }
}
