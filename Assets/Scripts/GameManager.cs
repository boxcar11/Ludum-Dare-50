using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Slider healthSlider;
    public Slider hungerSlider;
    public Slider thirstSlider;

    [SerializeField] private float health, hunger, thirst;

    [SerializeField] private float hungerRate, thirstRate;

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        hunger = 100;
        thirst = 100;
    }

    // Update is called once per frame
    void Update()
    {
        hunger = hunger - hungerRate * Time.deltaTime;
        thirst = thirst - thirstRate * Time.deltaTime;

        healthSlider.value = health/100;
        hungerSlider.value = hunger/100;
        thirstSlider.value = thirst/100;

        if(hunger <= 0)
        {
            health -= .005f;
            hunger = 0;
        }
        
        if(thirst <=0)
        {
            health -= .005f;
            thirst = 0;
        }
    }

    public void AddFood(float food)
    {
        hunger += food;
        if(hunger >= 100)
        {
            hunger = 100;
        }
    }
}