using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;


public class deck : MonoBehaviour
{
    public GameObject card_manager;
    deck_script main_deck = new deck_script(5);
    card_management c_m;

    void Start()
    {
        c_m = card_manager.GetComponent<card_management>();

        main_deck.enqueue(new card_parent(1, "a"));
        main_deck.enqueue(new card_parent(1, "b"));
        main_deck.enqueue(new card_parent(1, "c"));
        main_deck.enqueue(new card_parent(1, "d"));
        main_deck.enqueue(new card_parent(1, "e"));
    }

    private void OnMouseDown()
    {
        card_parent card = draw_card();
        if (card != null)
        {
            c_m.card_drawn(card);
        }
        
    }

    public card_parent draw_card()
    {
        if (!main_deck.is_empty())
        {
            return main_deck.dequeue();
        }

        print("empty deck draw attempt");
        return null;
    }

}
