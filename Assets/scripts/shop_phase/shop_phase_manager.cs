using UnityEngine;

public class Shop_phase_manager : MonoBehaviour
{
    public GameObject[] pedestals;
    void Start()
    {
        for (int i = 0; i < pedestals.Length; i++)
        {
            pedestals[i].GetComponent<card_pedestal_obj>().create_card(new card(10,"test","does nothing"));
        }
    }
}
