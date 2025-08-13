using UnityEngine;

public class finish_treatment_button_obj : MonoBehaviour
{
    SpriteRenderer sprite;
    bool is_healed;
    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    private void OnMouseDown()
    {
        if (is_healed == true)
        { 
            
        }
    }

    private void update_colour(bool is_healed)
    {
        if (is_healed == true)
        {
            sprite.color = Color.green;
        }
        else 
        { 
            sprite.color= Color.red;
        }
    }

    public void update_healing_progress(int hv, bool healing)
    {
        is_healed = healing;
        update_colour(is_healed);
    }

}
