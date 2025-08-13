using UnityEngine;
using UnityEngine.U2D.Animation;

public class treatment_phase_manager : MonoBehaviour
{
    patient[] patient_queue = new patient[2];
    patient_management patients;
    SpriteLibrary patient_sprites;

    void Start()
    {
        patients = GetComponent<patient_management>();
        patient_sprites = GetComponent<SpriteLibrary>();

        for (int i = 0; i < patient_queue.Length; i++)
        {
            patient_queue[i] = new patient(Random.Range(8, 12), patient_sprites.GetSprite("patients", "bees"));
        }

        patients.set_patient_queue(patient_queue);
        patients.start_treatment(0);
        
    }

}
