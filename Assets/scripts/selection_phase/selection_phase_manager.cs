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

        choice1_script.Set_patient_queue(Create_patient_queue());
        choice2_script.Set_patient_queue(Create_patient_queue());
    }

    private Patient[] Create_patient_queue()
    {
        int number_of_patients = Random.Range(1, 3);
        Patient[] patient_queue = new Patient[number_of_patients];

        for (int i = 0; i < number_of_patients; i++)
        {
            patient_queue[i] = Create_patient();
        }

        return patient_queue;
    }

    private Patient Create_patient()
    {
        return new Patient(Random.Range(8,12), patient_sprites.GetSprite("patients","bees"));
    }

}
