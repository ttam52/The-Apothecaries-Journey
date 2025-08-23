using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;


public class deck_obj : MonoBehaviour
{
    public GameObject treatment_phase_manager;
    public deck main_deck = new deck(100);
    public deck discard_pile = new deck(100);
    card_management card_manager;

    private void Awake()
    {
        main_deck = Player_data.player_deck;
        main_deck.shuffle();
    }
    void Start()
    {
        card_manager = treatment_phase_manager.GetComponent<card_management>();
    }

    private void OnMouseDown()
    {
        card temp_card = draw_card();
        
        if (temp_card != null)
        {
            discard_pile.enqueue(temp_card);
            card_manager.card_drawn(temp_card);
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
    }

    public void pack_player_deck()
    { 
        Player_data.player_deck = main_deck;
    }

}
