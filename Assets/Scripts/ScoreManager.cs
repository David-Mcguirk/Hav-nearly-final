using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public static int scoreCounter;



    // Start is called before the first frame update
    void Start()
    {
       scoreCounter=0;
    }

    // Update is called once per frame
    void Update()
    {
       scoreText.text="Score: " + Mathf.Round(scoreCounter);
    }
}

