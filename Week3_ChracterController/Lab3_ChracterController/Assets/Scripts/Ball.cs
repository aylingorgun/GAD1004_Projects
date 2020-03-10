using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 30;
    int x;

    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(0, 2);
        if(x == 0)
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        else
            GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
            
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
