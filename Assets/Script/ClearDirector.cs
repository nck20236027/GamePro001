using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClearDirector : MonoBehaviour
{
    public Text SocoreLoad;
    private int a;
    void Start()
    {
        //a = (Count.score);
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("GameScene");
        }

        if(Input.GetKeyDown(KeyCode.Z)) 
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
