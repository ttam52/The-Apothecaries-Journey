using System;
using System.Linq;
using UnityEngine;

public class Card_management : MonoBehaviour
{
    public GameObject card_obj;
    public GameObject score_manager;
    public GameObject deck;

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

    public void Card_drawn(Card temp)
    {
        playing_area.Add(temp);
        score_display.Score = playing_area.Tally_score();

        Clear_playing_area();
        Set_playing_area(temp);
    }

    public void Set_playing_area(Card card)
    {
        Vector3 spawn = card_spawn;



        for (int i = 0; i < playing_area.Card_spacing().Count(); i++)
        {
            card = playing_area.Get_card(i);

            float x_offset = playing_area.Card_spacing()[i];
            spawn.x = card_spawn.x + x_offset;

            card.Set_card_obj(Instantiate(card_obj, spawn, Quaternion.identity));
        }
    }

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
