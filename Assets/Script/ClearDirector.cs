using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearDirector : MonoBehaviour
{
    public static
    // Update is called once per frame
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
