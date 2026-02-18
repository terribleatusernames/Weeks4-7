using UnityEngine;

public class CardShowcase : MonoBehaviour
{
    public Vector3 startPos = new Vector3 (0, 10, 0);
    public Vector3 endPos = new Vector3(0, 0, 0);
    public Vector3 exitPos = new Vector3 (0, -10, 0);
    public Vector3 output;

    public float duration = 0;
    public bool spinnyMode = false;
    float rotationSpeed = 360f;

    void Start()
    {
        //when the card is spawned, set the position of the card to the start position so it doesn't flash on screen
        output = startPos;
    }

    
    void Update()
    {

        duration += Time.deltaTime;
        transform.position = output;

        //when spinny mode is activated, rotate the card around the z axis at a speed of 360 degree per second
        if (spinnyMode)
        {
            Vector3 currentRotation = transform.eulerAngles;
            currentRotation.z += rotationSpeed * Time.deltaTime;
 
            transform.eulerAngles = currentRotation;
        }

        //move the card from the start position to the end position in 1 second,
        //then move offscreen after 4 seconds, then destroy the card after 5 seconds
        if (duration <= 1)
        {
            output = Vector3.Lerp(startPos, endPos, duration);
        }
        
        if (duration >= 4)
        {
            output = Vector3.Lerp(endPos, exitPos, (duration -4));
        }

        if(duration >= 5)
        {
            Destroy(gameObject);
        }
    }

    public void activateSpinnyMode()
    {
        spinnyMode = !spinnyMode;
    }
}
