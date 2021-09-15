using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class FallingThrash : MonoBehaviour
{
    [SerializeField] private GameObject[] thash_list;
    [SerializeField] private int objects_quantity = 5;
    
    private void Awake()
    {
        InstanciateThrash();
    }

    void InstanciateThrash()
    {
        int i = 0;
        for (i = 0; i <= objects_quantity; i++)
        {
            Instantiate(thash_list[Random.Range(0, 8)], new Vector3(Random.Range(-1, 1), 2, Random.Range(-60, 4)), Quaternion.identity);
        }
    }
}
