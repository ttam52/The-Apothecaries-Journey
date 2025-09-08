using System;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.U2D.Animation;
using UnityEngine.VFX;

public class patient_management : MonoBehaviour
{
    public GameObject patient_obj;
    public GameObject patient_info;
    public GameObject finish_treatment_button;
    //public GameObject score_manager;

    SpriteLibrary library;
    patient current_patient;
    Vector3 spawn;
    int current_healing_value;
    finish_treatment_button_obj finish_treatment_button_script;
    patient_info patient_info_script;

    void Start()
    {
        spawn = gameObject.transform.position;

        finish_treatment_button_script = finish_treatment_button.GetComponent<finish_treatment_button_obj>();
        patient_info_script = patient_info.GetComponent<patient_info>();
    }

    public void setup_patient()
    {
        GameObject temp_patient = (Instantiate(patient_obj, spawn, Quaternion.identity));
        current_patient.set_patient_obj(temp_patient); // uncertain of whether having the patient script hold the game object is neccecary

        temp_patient.GetComponent<patient_obj>().set_sprite(current_patient.get_image());
    }
    public bool is_healed()
    {
        if (current_healing_value < current_patient.get_healing_target())
        {
            return false;
        }
        return true;
    }

    private void update_patient_info()
    { 
        int value = current_patient.get_healing_target();
        patient_info_script.set_target_value(value);
    }

    private void clear_patient()
    {
        if (current_patient != null)
        {
            Destroy(current_patient.get_patient_obj());
        }
    }

    public void set_current_healing_value(int value)
    { 
        current_healing_value = value;
        finish_treatment_button_script.update_healing_progress(value, is_healed());
    }

    public void start_treatment(patient temp_patient)
    {
        clear_patient();
        current_patient = temp_patient;
        setup_patient();
        set_current_healing_value(0);
        update_patient_info();
    }

    //public void finish_treatment()
    //{
    //    if (healing_value >= current_patient.get_healing_target())
    //    {
    //        //success
    //    }
    //    else
    //    { 
    //        //fail
    //    }
    //}

}
