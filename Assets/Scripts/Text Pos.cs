using System.Runtime.CompilerServices;
using UnityEngine;

public class TextPos : MonoBehaviour
{
    public Vector3 textPos = new(0, 0, 1);
    public Vector3 worldPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        worldPos = Camera.main.WorldToScreenPoint(transform.position);
        transform.position = worldPos;
    }
}
