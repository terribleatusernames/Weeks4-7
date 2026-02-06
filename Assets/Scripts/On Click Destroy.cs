using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class OnClickDestroy : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public bool hovered = false;
    public int life = 3;
    public TextMeshProUGUI lifeCounter;
    public GameObject Text;
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
            hovered = true;
        } else {
            hovered = false;
        }

        if (hovered && Input.GetMouseButtonDown(0))
        {
            life = life - 1;
            if (life <= 0 ){
                Destroy(gameObject);
            }
            
        }
        LifeCount();
    }

    public void LifeCount()
    {
            lifeCounter.text = life.ToString();
    }
}
