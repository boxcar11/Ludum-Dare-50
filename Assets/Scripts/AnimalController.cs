using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalController : MonoBehaviour
{
    [SerializeField] int foodValue;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public Vector2 Wander()
    {
        return new Vector3(Random.Range(-100, 100), Random.Range(-100, 100),0);
    }

        public int GetFoodValue()
    {
        //Debug.Log("getting food");
        return foodValue;
    }
}
