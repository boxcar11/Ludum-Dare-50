using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingController : Interactable
{
    private Inventory inventory;
    private bool fishing = false;
    private bool fishOnLine = false;
    private float castTimer;
    private float reelTimer = 5;


    void Start()
    {
        inventory = FindObjectOfType<Inventory>();
    }

    void Update()
    {
        if(fishing)
        {
            castTimer -= Time.deltaTime;

            if(castTimer <= 0)
            {
                //Bobber move
                fishOnLine = true;
                reelTimer -= Time.deltaTime;

                if(reelTimer <= 0)
                {
                    fishing = false;
                    fishOnLine = false;
                }
            }
        }
    }

    public override void Interact()
    {
        if(fishing == false)
        {
            castTimer = Random.Range(2f, 10f);
            reelTimer = 5;
            fishing = true;
            //Cast line
        }
        else
        {
            //Reel in line
            if(fishOnLine)
            {
                fishOnLine = false;
                fishing = false;
                inventory.GiveItem("Berry");
            }
        }
    }
}
