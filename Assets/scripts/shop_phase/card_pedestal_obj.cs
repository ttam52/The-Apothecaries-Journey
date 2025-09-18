using UnityEngine;

public class card_pedestal_obj : MonoBehaviour
{
    [SerializeField] GameObject my_purchaseable_card_obj;
    GameObject shop_manager;

    purchaseable_card my_card_script;
    void Start()
    {
        
    }

    public void link_to_shop_manager(GameObject temp_manager)
    { 
        shop_manager = temp_manager;
    }

    public void create_card(card temp_card)
    {
        GameObject temp_obj = Instantiate(my_purchaseable_card_obj, transform.position, Quaternion.identity);
        my_card_script = temp_obj.GetComponent<purchaseable_card>();

        my_card_script.link_to_shop_manager(shop_manager);
        my_card_script.setup_card(temp_card, Random.Range(1,5));        
    }

}
