using UnityEngine;

public class Pacer : MonoBehaviour
{
    public float speed = 2f;
    private float direction = 1f; 
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * speed * direction * Time.deltaTime;

        Vector3 pacerPosition = Camera.main.WorldToScreenPoint(transform.position);

        if(pacerPosition.x > Screen.width || pacerPosition.x < 0)
        {
            direction *= -1f;
        }
    }
}
