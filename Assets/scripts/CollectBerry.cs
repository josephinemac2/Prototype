using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectBerry : MonoBehaviour
{
    public GameObject scoreText;
    public int theScore;

    private void OnTriggerEnter(Collider other)
    {
        ScoringSystem.theScore += 50;
        scoreText.GetComponent<Text>().text = "Score: " + theScore;
        Destroy(gameObject);
    }

}
