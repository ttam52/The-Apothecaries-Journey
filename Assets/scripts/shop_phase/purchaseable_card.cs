using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class purchaseable_card : card_obj
{
    [SerializeField] GameObject button_obj, price_tag_obj;
    GameObject yes_button, price_tag;

    Button_obj yes_button_script;
    Display_text price_tag_script;

    private void Start() 
    {
        base.Start();
        create_button();
        create_price_tag();
    }

    private void OnMouseDown()
    {
        yes_button_script.set_visibility(true);
    }

    private void create_button()
    {
        Vector3 spawn = transform.position;
        spawn.y -= 0.5f;
        yes_button = Instantiate(button_obj, spawn, Quaternion.identity);
        yes_button_script = yes_button.GetComponent<Button_obj>();

        yes_button_script.initialize(Color.green, true, gameObject);
    }

    private void create_price_tag()
    {
        Vector3 spawn = transform.position;
        spawn.y += -0.3f;
        spawn.x += -0.6f;
        price_tag = Instantiate(price_tag_obj, spawn, Quaternion.identity);
        price_tag_script = price_tag.GetComponent<Display_text>();

        price_tag_script.Text = "$2";
    }

    public void recieve_button_press(bool button_type)
    {
        if (button_type == true)
        {
            
            Destroy();
        }
    }

    new public void Destroy()
    {
        Destroy(price_tag);
        Destroy(yes_button);
        base.Destroy();
    }
}
