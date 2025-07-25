using UnityEngine;

public class score_tracker
{
    int score = 0;
    public score_tracker()
    { 
        
    }

    public void display_HV()
    { 
        
    }

    public void tally_score(card_parent[] played_cards)
    {
        score = 0;
        for (int i = 0; i < played_cards.Length; i++) 
        {
            score = played_cards[i].get_value();
        }
    }

}
