using System.Runtime.InteropServices.WindowsRuntime;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Card_obj : MonoBehaviour
{
    [SerializeField] GameObject description_obj;
    protected GameObject my_description;
    protected Display_text my_description_script;
    private Vector3 offset, base_position, current_position;

    public string description = "null";
    bool holding, mouse_over = false;

    private int position_in_array;
    private float x_offset;
    private float desired_duration = 0.05f;
    private float elapsed_time;

    public Card_management card_manager_script;

    protected void Start()
    {
        Create_description_obj();
    }


    protected void Create_description_obj()
    {
        //Vector3 spawn = transform.position;
        //spawn.y += 1.5f;
        //my_description = Instantiate(description_obj, spawn, Quaternion.identity);
        //my_description_script = my_description.GetComponent<Display_text>();
        //my_description_script.Set_visibility(false);

        //my_description_script.Text = description;

    }
    public void Destroy()
    {
        Destroy(my_description);
        Destroy(gameObject);
    }

    private void return_to_base()
    {
        elapsed_time = 0;
        current_position = transform.position;
    }

    public void set_base_position(Vector3 position, float x_offset, int position_in_array)
    {
        base_position = position;
        this.x_offset = x_offset;
        this.position_in_array = position_in_array;
        return_to_base();
    }    

    protected void OnMouseEnter()
    {
        mouse_over = true;
        if (holding != true)
        {
            //my_description_script.Set_visibility(true);
        }
    }
    protected void OnMouseExit()
    {
        mouse_over = false;
        //my_description_script.Set_visibility(false);
    }

    private void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        holding = true;
        //my_description_script.Set_visibility(false);
    }
    private void OnMouseUp()
    {
        holding = false;
        //transform.position = base_position;
        return_to_base();
        if (mouse_over == true)
        {
            //my_description_script.Set_visibility(true);
        }
    }


    private void Update()
    {
        if ((current_position != base_position) && holding != true)
        {
            elapsed_time += Time.deltaTime;
            float percentage_complete = elapsed_time / desired_duration;

            transform.position = Vector3.Lerp(current_position, base_position, percentage_complete);
        }
        else if (holding == true)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
            //transform.position = Vector3.MoveTowards(current_position, (Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset), 1);
        }

        if (transform.position.x < base_position.x - x_offset)
        {
            card_manager_script.swap_card_base_position("Left", position_in_array);
        }
        else if (transform.position.x > base_position.x + x_offset)
        {
            card_manager_script.swap_card_base_position("Right", position_in_array);
        }


    }
}
