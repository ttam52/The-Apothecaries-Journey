using UnityEngine;
using UnityEngine.U2D.Animation;

public class selection_phase_manager : MonoBehaviour
{
    public GameObject choice1, choice2;
    option_pannel_obj choice1_script, choice2_script;

    SpriteLibrary patient_sprites;
    void Start()
    {
        patient_sprites = GetComponent<SpriteLibrary>();
        choice1_script = choice1.GetComponent<option_pannel_obj>();
        //choice2_script = choice2.GetComponent<option_pannel_obj>();

        choice1_script.set_patient_queue(create_patient_queue());
    }

    private patient[] create_patient_queue()
    {
        patient[] patient_queue = new patient[3];

        for (int i = 0; i < 3; i++)
        {
            patient_queue[i] = create_patient();
        }

        return patient_queue;
    }

    private patient create_patient()
    {
        return new patient(10, patient_sprites.GetSprite("patients","bees"));
    }

}
