using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SocialPlatforms.GameCenter;
using static UnityEditor.Rendering.CameraUI;

public class MenuPopup : MonoBehaviour
{
   
    public float progress = 0;
   

    public float duration = 0.15f;
    public float direction = 1;

    public Vector3 startPos;
    public Vector3 endPos;
    private Vector3 output;

    public bool opening = false;
    public bool closing = false;
 
    public bool infoOpening = false;
    public bool infoOpen = false; 
    public GameObject Profile;
    void Start()
    {
      
    }

    void Update()
    {
        //checker to see if the info tab is open or opening, if it is, the menu will not close
        Info infoComponent = Profile.GetComponent<Info>();
        infoOpening = infoComponent.opening;
        infoOpen = infoComponent.opened;

        // Check if the Escape key is pressed and the menu is not currently closing or opening
        if (Input.GetKeyDown(KeyCode.Escape) && !closing || opening)
        {
            direction = 1;
            opening = true;
            progress += (Time.deltaTime / duration) * direction;
            output = Vector3.Lerp(startPos, endPos, progress);

            Vector3 newOutput = Camera.main.WorldToScreenPoint(output);

            transform.position = newOutput;

            if( progress >= 1)
            {
                opening = false;
            }
        }

        // Check if the Escape key is pressed and the menu is currently open
        if (Input.GetKeyDown(KeyCode.Escape) && progress >=1 && !infoOpening && !infoOpen)
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
            }
        }
    }
}
