using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class deck : MonoBehaviour
{
    public GameObject obj;

    deck_script main_deck = new deck_script(5);
    card_sorter display = new card_sorter(100, 10);

    private card_parent current_card;

    Camera main = new Camera();
    Vector3 spawn;
    float flag;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        main_deck.enqueue(new card_parent(0, "a"));
        main_deck.enqueue(new card_parent(0, "b"));
        main_deck.enqueue(new card_parent(0, "c"));
        main_deck.enqueue(new card_parent(0, "d"));
        main_deck.enqueue(new card_parent(0, "e"));

        main = Camera.main;
        spawn = main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, main.nearClipPlane));
        spawn.z = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        
        if (main_deck.is_empty() != true)
        {

            print(main_deck.get_front());
            display.add_to_display(main_deck.dequeue());
            
            for (int i = 0; i < display.card_spacing().Count(); i++)
            {
                current_card = display.get_card(i);

                flag = display.card_spacing()[i];
                print(flag);

                spawn.x = flag;
                current_card.set_card_obj(Instantiate(obj, spawn, Quaternion.identity));
            }
        }
        


    }

    private void OnMouseUp()
    {
        for (int i = 0; i < display.card_spacing().Count(); i++)
        {
            current_card = display.get_card(i);
            Destroy(current_card.get_card_obj());
        }
    }
}
