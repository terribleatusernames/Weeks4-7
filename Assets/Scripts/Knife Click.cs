using UnityEngine;

public class KnifeClick : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public bool isClicked = false;
    bool hovered = false;
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
            hovered = true;
        }
        else
        {
            hovered = false;
        }

        if (hovered && Input.GetMouseButtonDown(0))
        {
            isClicked = true;
        }

        if (isClicked)
        {
            Destroy(gameObject);
        }

        }
}
