using Unity.VisualScripting;
using UnityEngine;

public class sc : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        deck_script deck = new deck_script(5);
        deck.enqueue(new card_parent(0, "a"));
        deck.enqueue(new card_parent(0, "b"));
        deck.enqueue(new card_parent(0, "c"));
        deck.enqueue(new card_parent(0, "d"));
        deck.enqueue(new card_parent(0, "e"));
        deck.enqueue(new card_parent(0, "fail"));

        print(deck.dequeue().get_name());
        print(deck.dequeue().get_name());
        print(deck.dequeue().get_name());
        print(deck.dequeue().get_name());
        print(deck.dequeue().get_name());
        print(deck.dequeue().get_name());
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void OnMouseDown()
    {
        card_parent herb = new card_parent(1, "herb");
        

    }
}
