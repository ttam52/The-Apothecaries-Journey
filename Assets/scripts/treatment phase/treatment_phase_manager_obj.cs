using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.U2D.Animation;

public class Treatment_phase_manager_obj : MonoBehaviour
{
    Patient[] patient_queue = new Patient[3];
    Patient_management patients;
    Card_management cards;
    Player_stats_manager player_stats;
    SpriteLibrary patient_sprites;

    int position_in_queue;

    void Start()
    {
        position_in_queue = 0;
        patients = GetComponent<Patient_management>();
        cards = GetComponent<Card_management>();
        player_stats = GetComponent<Player_stats_manager>();
        patient_sprites = GetComponent<SpriteLibrary>();

        patient_queue = Game_data.patient_queue;
        Treat_next_patient();
    }
    //public void initiate_patients(patient[] patients)
    //{
    //    patient_queue = patients;
    //    treat_next_patient();
    //}

    public void Treat_next_patient()
    {
        cards.Reset_playing_area();
        patients.Start_treatment(patient_queue[position_in_queue]);
        position_in_queue++;
    }

    public void Treatment_finished(bool success)
    {
        if (success == true)
        {
            Player_data.money += 2;
            Player_data.reputation += 1;
        }
        else
        {
            Player_data.reputation -= 1;
        }
        player_stats.Update_display();

        if (position_in_queue == patient_queue.Length)
        {
            cards.Reset_playing_area();
            Finish_treatment_phase();
        }
        else
        {
            Treat_next_patient();
        }

    }

    private void Finish_treatment_phase()
    {
        SceneManager.LoadScene("shop_phase");
    }

}
