using System;
using System.Linq;
using UnityEngine;

public class card_management : MonoBehaviour
{
    public GameObject card_obj;
    public GameObject score_manager;
    public GameObject deck;
    
    card_sorter playing_area = new card_sorter(100, 10);
    Score_display score_display;

    private void Start()
    {
        score_display = score_manager.GetComponent<Score_display>();
    }

    public void card_drawn(card_parent card)
    {
        playing_area.add(card);
        score_display.Add(card.get_value());

        clear_playing_area();
        set_playing_area(card);
    }

    public void set_playing_area(card_parent card)
    {
        Vector3 spawn = transform.position;

        for (int i = 0; i < playing_area.card_spacing().Count(); i++)
        {
            card = playing_area.get_card(i);

            float x_offset = playing_area.card_spacing()[i];
            spawn.x = transform.position.x + x_offset;

            card.set_card_obj(Instantiate(card_obj, spawn, Quaternion.identity));

        }
    }

    public void clear_playing_area()
    {
        int card_total = playing_area.card_spacing().Count();
        for (int i = 0; i < card_total; i++)
        {
            card_parent card = playing_area.get_card(i);
            Destroy(card.get_card_obj());
        }
    }

    public void update_score()
    { 
        
    }

}
