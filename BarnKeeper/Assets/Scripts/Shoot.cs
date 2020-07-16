using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject[] animals;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GameObject randomAnimal = animals[Random.Range(0,animals.Length)];
            Instantiate(randomAnimal, transform.position, transform.rotation);
        }
    }
}
