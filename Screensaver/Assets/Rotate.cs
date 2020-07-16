using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public Vector3 rot;
    public int speed = 10;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rot * speed* Time.deltaTime);

        if(Input.anyKey)
            Application.Quit();
    }
}
