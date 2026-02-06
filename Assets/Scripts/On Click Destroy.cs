using UnityEngine;
using UnityEngine.InputSystem;

public class OnClickDestroy : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public bool test = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldMousePosition.z = 0;
        bool isHovered = spriteRenderer.bounds.Contains(worldMousePosition);

        if (isHovered)
        {
            test = true;
        } else {
            test = false;
        }

        if (test && Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject);
        }
    }
}
