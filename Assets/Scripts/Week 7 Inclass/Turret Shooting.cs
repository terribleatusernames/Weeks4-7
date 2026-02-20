using UnityEngine;
using UnityEngine.InputSystem;

public class TurretShooting : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = 0f;

        Vector3 direction = worldMousePosition - transform.position;
        transform.up = direction;
    }
}
