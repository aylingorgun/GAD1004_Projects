﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {

    public GameObject CubePrefab;

	// Use this for initialization
	void Start () {
        InvokeRepeating("CreateCube", 2, 2);
	}
	
	// Update is called once per frame
	void Update () {
	}

    void CreateCube()
    {
        Instantiate(CubePrefab, new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0), Quaternion.identity);
    }
}