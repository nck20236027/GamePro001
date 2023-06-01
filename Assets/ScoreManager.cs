using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    private int score = 0;
    public Text scoreLadel;
    // Start is called before the first frame update
    void Start()
    {
        scoreLadel.text = "score" + score.ToString("D");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
