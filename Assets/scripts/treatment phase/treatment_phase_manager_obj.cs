using UnityEngine;
using UnityEngine.U2D.Animation;

public class treatment_phase_manager_obj : MonoBehaviour
{
    patient[] patient_queue = new patient[3];
    patient_management patients;
    card_management cards;
    SpriteLibrary patient_sprites;

    int position_in_queue = 0;

    void Start()
    {
        patients = GetComponent<patient_management>();
        cards = GetComponent<card_management>();
        patient_sprites = GetComponent<SpriteLibrary>();

        patient_queue[0] = new patient(Random.Range(8, 12), patient_sprites.GetSprite("patients", "bees"));
        patient_queue[1] = new patient(Random.Range(8, 12), patient_sprites.GetSprite("patients", "bees"));
        patient_queue[2] = new patient(Random.Range(8, 12), patient_sprites.GetSprite("patients", "bees"));


        treat_patient();
    }
    public void treat_patient()
    {
        cards.reset_playing_area();
        patients.start_treatment(patient_queue[position_in_queue]);
    }

    public void treatment_finished(bool success)
    {
        if (success == true)
        {

        }
        else
        {
        
        }
        position_in_queue++;
        treat_patient();

    }

}
