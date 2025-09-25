using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class Card_management : MonoBehaviour
{
    public GameObject card_obj;
    public GameObject score_manager;
    public GameObject deck;
    public bool is_card_held = false;
    //List<GameObject> card_objs = new List<GameObject>();


    Deck_obj deck_script;
    Card_sorter playing_area = new Card_sorter(100, 10);
    Score_manager score_display;
    Vector3 card_spawn;

    private void Start()
    {
        deck_script = deck.GetComponent<Deck_obj>();
        score_display = score_manager.GetComponent<Score_manager>();
        card_spawn = transform.position;
        card_spawn.x = -5;
        card_spawn.y = -3.8f;
        
    }

    public void Card_drawn(Card drawn_card)
    {
        playing_area.Add(drawn_card);
        score_display.Score = playing_area.Tally_score();

        drawn_card.Set_card_obj(Instantiate(card_obj, deck.transform.position, Quaternion.identity));
        drawn_card.Get_card_obj().GetComponent<Card_obj>().card_manager_script = gameObject.GetComponent<Card_management>();

        playing_area_update();
    }

    public void playing_area_update()
    {
        Card current_card;
        Card_obj current_card_script;
        float[] x_offsets = playing_area.Card_spacing();
        Vector3 spawn = transform.position;
        spawn.y = -3.8f;

        for (int i = 0; i < playing_area.Card_spacing().Count(); i++)
        {
            current_card = playing_area.Get_card(i);
            current_card_script = current_card.Get_card_obj().GetComponent<Card_obj>();

            
            spawn.x = card_spawn.x + x_offsets[i];

            current_card_script.set_base_position(spawn, x_offsets[0], i);
        }
    }

    public void swap_card_base_position(string direction, int position_in_array)
    {

        if (direction == "Left" && position_in_array != 0)
        {
            playing_area.swap_cards(position_in_array, position_in_array - 1);
        }
        else if (direction == "Right" && position_in_array != playing_area.Get_position() - 1)
        {
            playing_area.swap_cards(position_in_array, position_in_array + 1);
        }
        playing_area_update();
    }

    //public void Set_playing_area(Card card)
    //{
    //    Vector3 spawn = transform.position;



    //    for (int i = 0; i < playing_area.Card_spacing().Count(); i++)
    //    {
    //        card = playing_area.Get_card(i);

    //        float x_offset = playing_area.Card_spacing()[i];
    //        spawn.x = card_spawn.x + x_offset;

    //        card.Set_card_obj(Instantiate(card_obj, deck.transform.position, Quaternion.identity));
    //        card.Get_card_obj().GetComponent<Card_obj>().set_base_position(spawn, x_offset);
    //    }
    //}

    public void Clear_playing_area()
    {
        int card_total = playing_area.Card_spacing().Count();
        for (int i = 0; i < card_total; i++)
        {
            Card temp = playing_area.Get_card(i);
            Destroy(temp.Get_card_obj());
        }
    }

    public void Reset_playing_area()
    {
        Clear_playing_area();
        deck_script.Reshuffle_played_cards();
        playing_area.Clear_display();
        score_display.Reset_score();
    }

    //public void update_score()
    //{ 
        
    //}

}
