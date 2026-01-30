using System;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    public float speed = 2f;
    public float direction = 1f;
    public bool shouldMove = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (shouldMove)
        {
            transform.position += transform.right * speed * direction * Time.deltaTime;
        }
        else
        {
            // Do nothing
        }
    }
    public void OnMoveClick(){
        shouldMove = true;
    }
    
    public void OnStopClick() { 
        shouldMove = false;
    }

    public void OnFlipClick() {
        direction *= -1f;
    }
}
