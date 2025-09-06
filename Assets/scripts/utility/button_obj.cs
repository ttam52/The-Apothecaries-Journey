using UnityEngine;
using UnityEngine.UI;

public class Button_obj : MonoBehaviour
{
    GameObject creator;
    SpriteRenderer my_sprite;
    bool choice;
    string mystring;
    void Awake()
    {
        my_sprite = GetComponent<SpriteRenderer>();
        my_sprite.enabled = false;
    }
    public void initialize(Color chosen_colour, bool button_type, GameObject controller)
    {
        my_sprite.color = chosen_colour;
        choice = button_type;
        creator = controller;
    }

    private void OnMouseDown()
    {
        creator.GetComponent<purchaseable_card>().recieve_button_press(choice);
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }

    public void set_visibility(bool visible)
    {
        my_sprite.enabled = visible;
    }
}
