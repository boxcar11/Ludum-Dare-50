using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushController : Interactable
{
    private Inventory inventory;

    void Start()
    {
        inventory = FindObjectOfType<Inventory>();
    }

    public override void Interact()
    {
        int numberOfBerries = Random.Range(1,3);
        for (int i = 0; i < numberOfBerries; i++)
        {
            inventory.GiveItem("Berry");
        }
    }
}
