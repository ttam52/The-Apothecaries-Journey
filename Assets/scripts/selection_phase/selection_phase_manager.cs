using UnityEngine;
using UnityEngine.U2D.Animation;

public class selection_phase_manager : MonoBehaviour
{
    public GameObject choice1, choice2;
    Option_pannel_obj choice1_script, choice2_script;

    SpriteLibrary patient_sprites;
    void Start()
    {
        patient_sprites = GetComponent<SpriteLibrary>();
        choice1_script = choice1.GetComponent<Option_pannel_obj>();
        choice2_script = choice2.GetComponent<Option_pannel_obj>();

        choice1_script.set_patient_queue(create_patient_queue());
        choice2_script.set_patient_queue(create_patient_queue());
    }

    private patient[] create_patient_queue()
    {
        int number_of_patients = Random.Range(1, 3);
        patient[] patient_queue = new patient[number_of_patients];

        for (int i = 0; i < number_of_patients; i++)
        {
            patient_queue[i] = create_patient();
        }

        return patient_queue;
    }

    private patient create_patient()
    {
        return new patient(Random.Range(8,12), patient_sprites.GetSprite("patients","bees"));
    }

}
