using UnityEngine;
using UnityEngine.InputSystem;

public class HoverDescription : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public bool hovered = false;
    public GameObject text;
    public Vector3 MousePosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        MousePosition = Mouse.current.position.ReadValue();
        MousePosition.z = 0;
        bool isHovered = spriteRenderer.bounds.Contains(MousePosition);


        if (isHovered)
        {
            text.SetActive(true);
        }
        else
        {
            text.SetActive(false);
        }
    }
}
