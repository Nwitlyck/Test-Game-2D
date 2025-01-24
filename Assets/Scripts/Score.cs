using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    private int scoreCount;

    private void Start()
    {
        scoreCount = gameObject.transform.childCount;
        Collected();
    }

    private void Update()
    {
        Collected();
    }

    private void Collected()
    {
        int count = gameObject.transform.childCount;

        score.text = "Felipe estuvo aqui " + (scoreCount - count) + " / " + scoreCount; 

    }

}
