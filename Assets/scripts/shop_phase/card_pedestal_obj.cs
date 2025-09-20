using UnityEngine;

public class Card_pedestal_obj : MonoBehaviour
{
    [SerializeField] GameObject my_purchaseable_card_obj;
    GameObject shop_manager;

    Purchaseable_card my_card_script;
    void Start()
    {
        
    }

    public void Link_to_shop_manager(GameObject temp_manager)
    { 
        shop_manager = temp_manager;
    }

    public void Create_card(Card temp_card)
    {
        GameObject temp_obj = Instantiate(my_purchaseable_card_obj, transform.position, Quaternion.identity);
        my_card_script = temp_obj.GetComponent<Purchaseable_card>();

        my_card_script.Link_to_shop_manager(shop_manager);
        my_card_script.Setup_card(temp_card, Random.Range(1,5)); 
    }

}
