using System;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.U2D.Animation;
using UnityEngine.VFX;

public class Patient_management : MonoBehaviour
{
    public GameObject patient_obj;
    public GameObject patient_info;
    public GameObject finish_treatment_button;
    //public GameObject score_manager;

    SpriteLibrary library;
    Patient current_patient;
    Vector3 spawn;
    int current_healing_value;
    Finish_treatment_button_obj finish_treatment_button_script;
    Patient_info patient_info_script;

    void Start()
    {
        spawn = gameObject.transform.position;

        finish_treatment_button_script = finish_treatment_button.GetComponent<Finish_treatment_button_obj>();
        patient_info_script = patient_info.GetComponent<Patient_info>();
    }

    public void Setup_patient()
    {
        GameObject temp_patient = (Instantiate(patient_obj, spawn, Quaternion.identity));
        current_patient.Set_patient_obj(temp_patient); // uncertain of whether having the patient script hold the game object is neccecary

        temp_patient.GetComponent<Patient_obj>().Set_sprite(current_patient.Get_image());
    }
    public bool Is_healed()
    {
        if (current_healing_value < current_patient.Get_healing_target())
        {
            return false;
        }
        return true;
    }

    private void Update_patient_info()
    { 
        int value = current_patient.Get_healing_target();
        patient_info_script.Set_target_value(value);
    }

    private void Clear_patient()
    {
        if (current_patient != null)
        {
            Destroy(current_patient.Get_patient_obj());
        }
    }

    public void Set_current_healing_value(int value)
    { 
        current_healing_value = value;
        finish_treatment_button_script.Update_healing_progress(value, Is_healed());
    }

    public void Start_treatment(Patient temp_patient)
    {
        Clear_patient();
        current_patient = temp_patient;
        Setup_patient();
        Set_current_healing_value(0);
        Update_patient_info();
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
