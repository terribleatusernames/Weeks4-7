using NUnit.Framework;

using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PopUpPirate : MonoBehaviour
{
    public List<GameObject> knives = new List<GameObject>();
    public GameObject knifeToSpawn;
    public GameObject barreltToSpawn;
    public GameObject knife;

    void Start()
    {
        GameObject spawnedBarrel = Instantiate(barreltToSpawn, new Vector3(0f, 0f, -1f), Quaternion.identity);

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

    
    void Update()
    {
        KnifeClick currentKnife = knife.GetComponent<KnifeClick>();
        for (int i = 0; i < knives.Count; i++)
        {
            if (knives[i] == currentKnife.isClicked)
            {
                knives.Remove(knives[i]);
                Debug.Log("Knife removed");
            }
        }


    }

}


