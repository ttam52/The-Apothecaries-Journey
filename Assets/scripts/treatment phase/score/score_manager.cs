using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class score_manager : MonoBehaviour
{
    public GameObject treatment_phase_manager;
    public TextMeshPro score_counter;
    private int score = 0;

    patient_management patient_script;

    private void Start()
    {
        patient_script = treatment_phase_manager.GetComponent<patient_management>();
        Update_display();
    }

    public int Score
    {
        get
        { 
            return score;        
        }
        set
        {
            score = value;
            Update_display();
            patient_script.set_current_healing_value(score);
        }       
    }

    public void reset()
    {
        score = 0;
    }

    public void Update_display()
    {
        score_counter.text = score.ToString();
    }
}
