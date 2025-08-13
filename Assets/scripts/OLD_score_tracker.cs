using UnityEngine;
using UnityEngine.UIElements;

public class score_tracker
{
    int score = 0;
    int screen_space;
    int position = 0;
    int digits = 0;

    public score_tracker(int scr_sp)
    {
        screen_space = scr_sp;
    }

    private void set_digits()
    {
        digits = score.ToString().Length;
    }

    public void tally_score(card[] played_cards)
    {
        score = 0;
        for (int i = 0; i < played_cards.Length; i++) 
        {
            score = played_cards[i].get_value();
        }
    }
    public float[] card_spacing()
    {
        set_digits();
        float steps = (digits + 1);
        float current_spacing = screen_space / steps;
        float[] x_coords = new float[digits];
        for (int i = 0; i < digits; i++)
        {
            x_coords[i] = ((current_spacing * (i + 1)));
        }

        return x_coords;
    }

    public string[] numbers_to_display()
    {
        set_digits();
        string[] digits_to_display = new string[digits];
        for (int i = 0; i < digits; i++)
        { 
            
        }

        return new string[0];
    }

}
