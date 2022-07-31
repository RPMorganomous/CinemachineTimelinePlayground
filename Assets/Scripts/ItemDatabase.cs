using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    //[SerializeField]
    public Item sword;
    public Item hammer;
    public Item bread;

    // Start is called before the first frame update
    void Start()
    {
        sword = new Item();
        sword.name = "Sword";
        sword.id = 1;
        sword.description = "This is a sword.";

        hammer = new Item("Hammer", 2, "This is a Hammer.");

        bread = CreateItem("Bread", 3, "You can eat this.");
    }

private Item CreateItem(string name, int id, string description)
    {
        var item = new Item(name, id, description);

        return item;
    }
}
