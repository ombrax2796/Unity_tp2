using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    //Variables
    public int score;

    public Text points;

    public static Score instance;



    private void Awake()
    {

        instance = this;

    }


    // Update is called once per frame
    public void AddPoints()
    {
        
        score += 100;
        points.text = score.ToString();

    }
}
