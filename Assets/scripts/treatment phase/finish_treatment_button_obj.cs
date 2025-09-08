using UnityEngine;

public class finish_treatment_button_obj : MonoBehaviour
{
    public GameObject treatment_phase_manager;

    treatment_phase_manager_obj treatment_phase_manager_script;
    SpriteRenderer sprite;
    bool is_healed;

    private void Awake()
    {
        treatment_phase_manager_script = treatment_phase_manager.GetComponent<treatment_phase_manager_obj>();
        sprite = GetComponent<SpriteRenderer>();
        update_colour(false);
    }
    
    private void OnMouseDown()
    {
        treatment_phase_manager_script.treatment_finished(is_healed);
    }

    private void update_colour(bool is_healed)
    {
        if (is_healed == true)
        {
            sprite.color = Color.green;
        }
        else 
        { 
            sprite.color = Color.red;
        }
    }

    public void update_healing_progress(int hv, bool healing)
    {
        is_healed = healing;
        update_colour(is_healed);
    }

}
