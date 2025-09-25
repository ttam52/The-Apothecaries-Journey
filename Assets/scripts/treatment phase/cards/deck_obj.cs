using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;


public class Deck_obj : MonoBehaviour
{
    public GameObject treatment_phase_manager, deck_stock_obj, deck_size_obj;
    public Deck main_deck = new Deck(100);
    public Deck discard_pile = new Deck(100);

    Card_management card_manager;
    Display_text deck_stock, deck_size;
    int stock;

    private void Awake()
    {
        card_manager = treatment_phase_manager.GetComponent<Card_management>();
        deck_stock = deck_stock_obj.GetComponent<Display_text>();
        deck_size = deck_size_obj.GetComponent<Display_text>();

        main_deck = Player_data.player_deck;
        main_deck.Shuffle();

        stock = Game_data.stock;
    }
    void Start()
    {
        Update_number_of_cards();
    }

    private void OnMouseDown()
    {
        Card temp_card = Get_next_card();
        
        if (Can_draw_card(temp_card) == true)
        {
            stock--;

            discard_pile.Enqueue(main_deck.Dequeue()); //officially draws the card
            card_manager.Card_drawn(temp_card);
            Update_number_of_cards();
        }
        else 
        {
            //print("null");
            //print("stock: " + stock.ToString());
        }
    }

    public Card Get_next_card()
    {
        if (!main_deck.Is_empty())
        {
            return main_deck.Get_front();
        }

        print("empty deck draw attempt");
        return null;
    }

    public void Reshuffle_played_cards()
    {
        int steps = discard_pile.Get_size();
        print(steps + "discard thing");
        for (int i = 0; i < steps; i++)
        {
            main_deck.Enqueue(discard_pile.Dequeue());
        }
        main_deck.Shuffle();
        Pack_player_deck();
        Update_number_of_cards();
    }

    public void Pack_player_deck()
    { 
        Player_data.player_deck = main_deck;
    }

    private void Update_number_of_cards()
    {
        deck_stock.Text = stock.ToString();
        deck_size.Text = main_deck.Get_size().ToString();
    }
    private bool Can_draw_card(Card drawn_card)
    {
        if (stock <= 0)
        {
            //print("no stock");
            return false;
        }

        if (drawn_card == null)
        {
            //print("null card drawn");
            return false;
        }

        return true;
    }
}
