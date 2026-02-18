using UnityEngine;

public class TextDestroyer9000 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //destroy the initial instruction text after escape is pressed.
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Destroy(gameObject);
        }
    }
}
