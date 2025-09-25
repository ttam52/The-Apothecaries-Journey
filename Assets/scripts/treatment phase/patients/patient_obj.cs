using UnityEngine;

public class Patient_obj : MonoBehaviour
{
    SpriteRenderer visual;

    private void Awake()
    {
        visual = gameObject.GetComponent<SpriteRenderer>();
    }

    public void Set_sprite(Sprite sprite)
    { 
        visual.sprite = sprite;
    }
}
