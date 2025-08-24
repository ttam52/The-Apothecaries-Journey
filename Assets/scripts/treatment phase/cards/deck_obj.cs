using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;


public class Deck_obj : MonoBehaviour
{
    public GameObject treatment_phase_manager, deck_info_obj;
    public deck main_deck = new deck(100);
    public deck discard_pile = new deck(100);

    card_management card_manager;
    Display_text deck_info;
    int total_cards;

    private void Awake()
    {
        card_manager = treatment_phase_manager.GetComponent<card_management>();
        deck_info = deck_info_obj.GetComponent<Display_text>();

        main_deck = Player_data.player_deck;
        total_cards = main_deck.get_size();
        main_deck.shuffle();
    }
    void Start()
    {
        update_number_of_cards();
    }

    private void OnMouseDown()
    {
        card temp_card = draw_card();
        
        if (temp_card != null)
        {
            discard_pile.enqueue(temp_card);
            card_manager.card_drawn(temp_card);
            update_number_of_cards();
        }
        else 
        {
            print("null");
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
        deck_info.Text = main_deck.get_size().ToString() + "/" + total_cards.ToString();
    }

}
