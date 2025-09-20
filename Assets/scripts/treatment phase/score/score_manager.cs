using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Score_manager : MonoBehaviour
{
    public GameObject treatment_phase_manager;
    public TextMeshPro score_counter;
    private int score = 0;

    Patient_management patient_script;

    private void Start()
    {
        patient_script = treatment_phase_manager.GetComponent<Patient_management>();
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
            patient_script.Set_current_healing_value(score);
        }       
    }

    public void Reset_score()
    {
        score = 0;
        Update_display();
    }

    public void Update_display()
    {
        score_counter.text = score.ToString();
    }
}
