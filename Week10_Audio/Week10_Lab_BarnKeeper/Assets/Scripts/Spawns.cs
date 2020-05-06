using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawns : MonoBehaviour
{
    public GameObject[] wolves;

    void Start(){
        Invoke("spawnWolves", 3f);
        
    }

    void spawnWolves(){

        Instantiate(wolves[0], new Vector3(-5,0,0), Quaternion.identity);
        Invoke("spawnWolves", 3f);
    }
}
