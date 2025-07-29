using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Score_display : MonoBehaviour
{
    [SerializeField] Text score_counter;
    int score = 0;

    private void Awake()
    {
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
        }
        
    
    }

    public void Update_display()
    {
        score_counter.text = score.ToString();
    }

}
