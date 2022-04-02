using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeController : Interactable
{
    [SerializeField] private int treeHealth;

    private Inventory inventory;

    void Start()
    {
        inventory = FindObjectOfType<Inventory>();
    }

    public override void Interact()
    {
        treeHealth -= 1;

        if(treeHealth <= 0)
        {
            inventory.GiveItem("Wood");
            Destroy(this.gameObject);
        }
    }
}
