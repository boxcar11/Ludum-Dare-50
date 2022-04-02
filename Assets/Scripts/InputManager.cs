using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private GameObject inventoryPanel;
    [SerializeField] private GameObject craftingPanel;
    [SerializeField] private GameObject craftedItemPanel;

    Interactable interactable; 

    private bool inventoryBool = false;
    private bool craftingBool = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            inventoryBool = !inventoryBool;
        }

        if(Input.GetKeyDown(KeyCode.C))
        {
            craftingBool = !craftingBool;
        }

        if(Input.GetButtonDown("Action"))
        {
            interactable.Interact();
        }

        inventoryPanel.SetActive(inventoryBool);
        craftingPanel.SetActive(craftingBool);
        craftedItemPanel.SetActive(craftingBool);
    }

    public void SetInteractable(Interactable i)
    {
        interactable = i;
    }
}
