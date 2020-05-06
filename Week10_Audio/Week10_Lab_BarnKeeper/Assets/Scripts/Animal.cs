using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public int speed = 2;
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnBecameInvisible(){
        Destroy(this.gameObject);
    }

}
