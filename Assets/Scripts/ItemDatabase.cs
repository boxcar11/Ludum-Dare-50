using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    void Awake()
    {
        BuildItemDatabase();
    }

    public Item GetItem(int id)
    {
        return items.Find(item => item.id == id);
    }

    public Item GetItem(string title)
    {
        return items.Find(item => item.title == title);
    }

    void BuildItemDatabase()
    {
        items = new List<Item>()
        {
            new Item(1, "Wood", "Stack of wood", new Dictionary<string, int>{{"Fuel", 15}}),
            new Item(2, "Cooked Meat", "Tastes like chicken", new Dictionary<string, int>{{"Food", 20}}),
            new Item(1, "Raw Rabbit", "Cook before eating", new Dictionary<string, int>())
        };
    }
}
