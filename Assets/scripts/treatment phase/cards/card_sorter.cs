using Unity.Mathematics;
using UnityEngine;

public class Card_sorter
{
    int screen_space;
    int capacity;
    Card[] display;
    int position = 0;

    public Card_sorter(int c,int scr_sp)
    { 
        capacity = c;
        display = new Card[capacity];
        screen_space = scr_sp;
    }

    public Card Get_card(int card_pos)
    { 
        return display[card_pos];
    }

    public void Add(Card input)
    {
        if (position < capacity)
        {
            display[position] = input;
            position++;
        }
    }

    public void Clear_display()
    {
        for (int i = 0; i < position; i++)
        {
            display[i] = null;
        }
        position = 0;
    }

    public float[] Card_spacing()
    {
        float steps = (position + 1);
        float current_spacing = screen_space / steps;
        float[] x_coords = new float[position];
        for (int i = 0; i < position; i++ )
        {
            x_coords[i] = ((current_spacing * (i+1)));
        }

        return x_coords;
    }

    public int Tally_score()
    {
        Card card;
        int score = 0;
        for (int i = 0; i < position; i++)
        {
            card = display[i];
            if (card.Has_effect() == true)
            {
                score += card.Trigger_effect(display, position);
            }
            else
            {
                score += card.Get_value();
            }
        }

        return score;
    }
    

}
