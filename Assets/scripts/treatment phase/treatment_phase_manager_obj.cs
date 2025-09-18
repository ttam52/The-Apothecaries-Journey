using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.U2D.Animation;

public class treatment_phase_manager_obj : MonoBehaviour
{
    patient[] patient_queue = new patient[3];
    patient_management patients;
    card_management cards;
    player_stats_manager player_stats;
    SpriteLibrary patient_sprites;

    int position_in_queue;

    void Start()
    {
        position_in_queue = 0;
        patients = GetComponent<patient_management>();
        cards = GetComponent<card_management>();
        player_stats = GetComponent<player_stats_manager>();
        patient_sprites = GetComponent<SpriteLibrary>();

        patient_queue = game_data.patient_queue;
        treat_next_patient();
    }
    //public void initiate_patients(patient[] patients)
    //{
    //    patient_queue = patients;
    //    treat_next_patient();
    //}

    public void treat_next_patient()
    {
        cards.reset_playing_area();
        patients.start_treatment(patient_queue[position_in_queue]);
        position_in_queue++;
    }

    public void treatment_finished(bool success)
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
        player_stats.update_display();

        if (position_in_queue == patient_queue.Length)
        {
            cards.reset_playing_area();
            finish_treatment_phase();
        }
        else
        {
            treat_next_patient();
        }

    }

    private void finish_treatment_phase()
    {
        SceneManager.LoadScene("shop_phase");
    }

}
