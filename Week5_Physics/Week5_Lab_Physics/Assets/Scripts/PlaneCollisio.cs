using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneCollisio : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
}
