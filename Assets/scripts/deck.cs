using UnityEngine;
using UnityEngine.Rendering;

public class deck : MonoBehaviour
{
    deck_script main_deck = new deck_script(5);
    public GameObject obj;
    Camera main = new Camera();
    float i = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        main_deck.enqueue(new card_parent(0, "a"));
        main_deck.enqueue(new card_parent(0, "b"));
        main_deck.enqueue(new card_parent(0, "c"));
        main_deck.enqueue(new card_parent(0, "d"));
        main_deck.enqueue(new card_parent(0, "e"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        
        if (main_deck.is_empty() != true)
        {
            print(main_deck.dequeue().get_name());

            main = Camera.main;
            Vector3 spawn = main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, main.nearClipPlane));
            spawn.z = 0;
            spawn.x += i;
            Instantiate(obj, spawn, Quaternion.identity);
            i += 0.2f;
        }
        


    }
}
