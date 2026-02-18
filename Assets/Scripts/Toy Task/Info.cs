using UnityEngine;

public class Info : MonoBehaviour
{
    public float progress = 0;


    public float duration = 0.15f;
    public float direction = 1;

    public Vector3 startPos;
    public Vector3 endPos;
    private Vector3 output;

    public bool opening = false;
    public bool closing = false;
    public bool opened = false;
    void Start()
    {

    }

    void Update()
    {
        // Check if the Escape key is pressed and the menu is not currently closing or opening
        if (opening && !closing)
        {
            direction = 1;
            progress += (Time.deltaTime / duration) * direction;
            output = Vector3.Lerp(startPos, endPos, progress);

            Vector3 newOutput = Camera.main.WorldToScreenPoint(output);

            transform.position = newOutput;

            if (progress >= 1)
            {
                opening = false;
                opened = true;
            }
        }

        // Check if the Escape key is pressed and the menu is currently open
        if (Input.GetKeyDown(KeyCode.Escape) && progress >= 1)
        {
            closing = true;
            direction *= -1;
            progress = 1;


        }
        else if (closing)
        {
            progress += (Time.deltaTime / duration) * direction;
            output = Vector3.Lerp(startPos, endPos, progress);

            Vector3 newOutput = Camera.main.WorldToScreenPoint(output);

            transform.position = newOutput;

            if (progress <= 0)
            {
                closing = false;
                opened = false;
            }
        }
    }

    //function to open the info tab, called when the info button is clicked
    public void Open()
    {
        opening = true;
    }
}
