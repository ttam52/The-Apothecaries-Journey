using UnityEngine;

public class Finish_treatment_button_obj : MonoBehaviour
{
    public GameObject treatment_phase_manager;

    Treatment_phase_manager_obj treatment_phase_manager_script;
    SpriteRenderer sprite;
    bool is_healed;

    private void Awake()
    {
        treatment_phase_manager_script = treatment_phase_manager.GetComponent<Treatment_phase_manager_obj>();
        sprite = GetComponent<SpriteRenderer>();
        Update_colour(false);
    }
    
    private void OnMouseDown()
    {
        treatment_phase_manager_script.Treatment_finished(is_healed);
    }

    private void Update_colour(bool is_healed)
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

    public void Update_healing_progress(int hv, bool healing)
    {
        is_healed = healing;
        Update_colour(is_healed);
    }

}
