using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    GameManager gameManager;
    [SerializeField] private float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(horizontal, vertical);
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Animal")
        {
            gameManager.AddFood(other.gameObject.GetComponent<AnimalController>().GetFoodValue());
            //Debug.Log("Collided with animal");
        }
    }
}
