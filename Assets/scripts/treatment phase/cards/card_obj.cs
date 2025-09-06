using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class card_obj : MonoBehaviour
{
    [SerializeField] GameObject description_obj;
    protected GameObject my_description;

    protected Display_text my_description_script;

    public string description = "null";

    protected void Start()
    {
        create_description_obj();        
    }
    protected void OnMouseEnter()
    {
        my_description_script.set_visibility(true);
    }
    protected void OnMouseExit()
    {
        my_description_script.set_visibility(false);
    }
    public void Destroy()
    {
        Destroy(my_description);
        Destroy(gameObject);
    }

    protected void create_description_obj()
    {
        Vector3 spawn = transform.position;
        spawn.y += 0.5f;
        my_description = Instantiate(description_obj, spawn, Quaternion.identity);
        my_description_script = my_description.GetComponent<Display_text>();
        my_description_script.set_visibility(false);

        my_description_script.Text = description;
        
    }
}
