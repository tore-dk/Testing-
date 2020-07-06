﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    public GameObject customerPrefab;
    public Vector3 centerPoint;
    public Vector3 spawnSize;
    GameObject tempCustomer;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnCustomer", 5, 5);
    }

    // Update is called once per frame
    void Update()
    {
//        spawnCustomer();
    }

    public void spawnCustomer(){
        Vector3 position = centerPoint + new Vector3(Random.Range(-spawnSize.x/2, spawnSize.x/2), 0, Random.Range(-spawnSize.z/2, spawnSize.z/2));

        tempCustomer = Instantiate(customerPrefab, position, Quaternion.identity);
        tempCustomer.name = (Random.Range(1, 100)).ToString();
    }
}
