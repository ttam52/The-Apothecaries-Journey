using Unity.Mathematics;
using UnityEngine;

public class card_sorter
{
    int screen_space;
    int capacity;
    card_parent[] display;
    int position = 0;

    public card_sorter(int c,int scr_sp)
    { 
        capacity = c;
        display = new card_parent[capacity];
        screen_space = scr_sp;
    }

    public card_parent get_card(int card_pos)
    { 
        return display[card_pos];
    }

    public void add_to_display(card_parent input)
    {
        if (position < capacity)
        {
            display[position] = input;
            position++;
        }
        
    }

    public float[] card_spacing()
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


    // x_coords[i] = ((current_spacing * (i+1)) - screen_space)/2;

}
