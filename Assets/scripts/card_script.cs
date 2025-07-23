using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class sc : MonoBehaviour
{
    Vector3 selected;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        selected.z = 1;
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void OnMouseEnter()
    {

        transform.position += selected;

    }
    private void OnMouseExit()
    {
        transform.position -= selected;
    }

}
