using System;
using UnityEngine;
using UnityEngine.U2D.Animation;
using UnityEngine.VFX;

public class patient_management : MonoBehaviour
{
    public GameObject patient_obj;
    public GameObject patient_info;
    public GameObject finish_treatment_button;
    //public GameObject score_manager;

    patient[] patients;
    SpriteLibrary library;
    patient current_patient;
    Vector3 spawn;
    int healing_value;
    finish_treatment_button_obj finish_treatment_button_script;
    patient_info patient_info_script;

    void Start()
    {
        spawn = gameObject.transform.position;
        finish_treatment_button_script = finish_treatment_button.GetComponent<finish_treatment_button_obj>();
        patient_info_script = patient_info.GetComponent<patient_info>();
    }
    private void setup_patient(patient from_patient_queue)
    {
        current_patient = from_patient_queue;
        GameObject temp = (Instantiate(patient_obj, spawn, Quaternion.identity));
        current_patient.set_patient_obj(temp); // uncertain of whether having the patient script hold the game object is neccecary

        temp.GetComponent<patient_obj>().set_sprite(current_patient.get_image());

    }
    private bool is_healed()
    {
        print("reached");
        if (healing_value >= current_patient.get_value())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void update_patient_info()
    { 
        patient_info_script.set_healing_value(healing_value);
    }

    public void start_treatment(int value)
    {
        setup_patient(patients[value]);
        healing_value = 0;
        patient_info_script.set_healing_value(healing_value);
    }

    public void finish_treatment()
    {
        if (healing_value >= current_patient.get_value())
        {
            //success
        }
        else
        { 
            //fail
        }

    }

    public void set_healing_value(int value)
    { 
        healing_value = value;
        finish_treatment_button_script.update_healing_progress(value, is_healed());
    }

    public void set_patient_queue(patient[] ps)
    { 
        patients = ps;
    }

}
