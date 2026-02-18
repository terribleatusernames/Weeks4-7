using System.Diagnostics.CodeAnalysis;
using TMPro;
using UnityEngine;

public class CardSpawner : MonoBehaviour
{
    public GameObject commonCard;
    public GameObject rareCard;
    public GameObject legendaryCard;
    public TextMeshProUGUI commonCardCount;
    public TextMeshProUGUI rareCardCount;
    public TextMeshProUGUI legendaryCardCount;

    private int commonCardCounter = 0;
    private int rareCardCounter = 0;
    private int legendaryCardCounter = 0;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SpawnCard()
    {
        //When the screen button is clicked, generate a random number between 0 and 10 to determine the rarity of the card that will be spawned.
        float rarity = Random.Range(0, 10);

        if (rarity <= 5)
        {
            Instantiate(commonCard, new Vector3(0, 0, 0), Quaternion.identity);
            Debug.Log("Common Card Spawned");
            //When a card is spawned, update the corresponding card counter and display the updated count in the info box
            commonCardCounter++;
            commonCardCount.text = "Common Cards: " + commonCardCounter.ToString();
        }
        else if (rarity > 5 && rarity <= 8)
        {
            Instantiate(rareCard, new Vector3(0, 0, 0), Quaternion.identity);
            Debug.Log("Rare Card Spawned");
            rareCardCounter++;
            rareCardCount.text = "Rare Cards: " + rareCardCounter.ToString();
        }
        else if (rarity >= 9 && rarity <= 10)
        {
            Instantiate(legendaryCard, new Vector3(0, 0, 0), Quaternion.identity);
            Debug.Log("Legendary Card Spawned");
            legendaryCardCounter++;
            legendaryCardCount.text = "Legendary Cards: " + legendaryCardCounter.ToString();
        }
    }
}
