using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(BallCollision.flag == true){
            Invoke("Spawn", 2);
            BallCollision.flag = false;
        }
        
    }

    void Spawn()
    {
        Instantiate(go);
    }
}
