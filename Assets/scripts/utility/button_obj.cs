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
    public void Initialize(Color chosen_colour, bool button_type, GameObject controller)
    {
        my_sprite.color = chosen_colour;
        choice = button_type;
        creator = controller;
    }

    private void OnMouseDown()
    {
        creator.GetComponent<Purchaseable_card>().Recieve_button_press(choice);
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }

    public void Set_visibility(bool visible)
    {
        my_sprite.enabled = visible;
    }
}
