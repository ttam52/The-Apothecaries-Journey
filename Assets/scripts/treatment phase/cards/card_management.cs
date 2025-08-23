using System;
using System.Linq;
using UnityEngine;

public class card_management : MonoBehaviour
{
    public GameObject card_obj;
    public GameObject score_manager;
    public GameObject deck;

    deck_obj deck_script;
    card_sorter playing_area = new card_sorter(100, 10);
    score_manager score_display;
    Vector3 card_spawn;

    private void Start()
    {
        deck_script = deck.GetComponent<deck_obj>();
        score_display = score_manager.GetComponent<score_manager>();
        card_spawn = transform.position;
        card_spawn.x = -5;
        card_spawn.y = -3.5f;
    }

    public void card_drawn(card temp)
    {
        playing_area.add(temp);
        score_display.Score += temp.get_value();

        clear_playing_area();
        set_playing_area(temp);
    }

    public void set_playing_area(card card)
    {
        Vector3 spawn = card_spawn;



        for (int i = 0; i < playing_area.card_spacing().Count(); i++)
        {
            card = playing_area.get_card(i);

            float x_offset = playing_area.card_spacing()[i];
            spawn.x = card_spawn.x + x_offset;

            card.set_card_obj(Instantiate(card_obj, spawn, Quaternion.identity));

        }
    }

    public void clear_playing_area()
    {
        int card_total = playing_area.card_spacing().Count();
        for (int i = 0; i < card_total; i++)
        {
            card temp = playing_area.get_card(i);
            Destroy(temp.get_card_obj());
        }
    }

    public void reset_playing_area()
    {
        clear_playing_area();
        deck_script.reshuffle_played_cards();
        playing_area.clear_display();
        score_display.reset();
    }

    //public void update_score()
    //{ 
        
    //}

}
