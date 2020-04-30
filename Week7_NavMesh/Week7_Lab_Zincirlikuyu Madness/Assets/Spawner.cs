using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int SpawnCount = 20;
    public GameObject[] Chars;

    // Start is called before the first frame update
    void Start()
    {
        CharSpawner();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CharSpawner () {
        for(int i=0; i < 20; i++)
            Instantiate(Chars[Random.Range(0, 4)], this.gameObject.transform.position, Quaternion.identity);
    }
}
