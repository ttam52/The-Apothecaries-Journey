using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;


public class deck_obj : MonoBehaviour
{
    public GameObject treatment_phase_manager;
    deck main_deck = new deck(5);
    card_management card_manager;

    void Start()
    {
        card_manager = treatment_phase_manager.GetComponent<card_management>();

        main_deck.enqueue(new card(1, "a"));
        main_deck.enqueue(new card(2, "b"));
        main_deck.enqueue(new card(3, "c"));
        main_deck.enqueue(new card(4, "d"));
        main_deck.enqueue(new card(5, "e"));

        main_deck.shuffle();
    }

    private void OnMouseDown()
    {
        card temp = draw_card();
        if (temp != null)
        {
            card_manager.card_drawn(temp);
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

}
