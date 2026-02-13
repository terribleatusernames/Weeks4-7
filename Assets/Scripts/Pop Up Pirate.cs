using NUnit.Framework;

using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PopUpPirate : MonoBehaviour
{
     public List<GameObject> knives = new List<GameObject>();
     public GameObject knifeToSpawn; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        for (int i = 0; i < 5; i++)
        {

            GameObject spawnedKnife = Instantiate(knifeToSpawn, new Vector3(Random.Range(-1f, 1f), Random.Range(-0.5f, 0.5f), 0f), Quaternion.identity);

            knives.Add(spawnedKnife);
            for (int j = 0; j < knives.Count; j++)
            {
                Debug.Log(knives[j]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


