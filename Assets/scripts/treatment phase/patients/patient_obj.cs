using UnityEngine;

public class patient_obj : MonoBehaviour
{
    SpriteRenderer visual;

    private void Awake()
    {
        visual = gameObject.GetComponent<SpriteRenderer>();
    }

    public void set_sprite(Sprite sprite)
    { 
        visual.sprite = sprite;
    }
}
