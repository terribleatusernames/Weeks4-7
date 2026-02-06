using UnityEngine;
using UnityEngine.UI;

public class CakeClock : MonoBehaviour
{
    public float duriation = 5f;
    public float time = 0f;

    public Slider cakeSlider;
    public GameObject warperObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cakeSlider.maxValue = duriation;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime * 1;
        cakeSlider.value = time;

        if (time >= duriation)
        {
            time = 0f;
            Debug.Log("Timer over");

            bool shouldTurnOn = !warperObject.activeInHierarchy;
            bool shouldTurnOff = warperObject.activeInHierarchy;

            if (shouldTurnOn) {
                warperObject.SetActive(false);
            }
        
            if (shouldTurnOff == false) {
                warperObject.SetActive(true);
            }
        }
    }
}
