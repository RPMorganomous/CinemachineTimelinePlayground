using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInventoryDb : MonoBehaviour
{
    public ItemInventory[] itemsInInventory;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(itemsInInventory[0].name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
