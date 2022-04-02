using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] InputManager inputManager;

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            inputManager.SetInteractable(this);
        }
    }

    void OnCollisionExit2D()
    {
        inputManager.SetInteractable(null);
    }

    public virtual void Interact()
    {

    }
}
