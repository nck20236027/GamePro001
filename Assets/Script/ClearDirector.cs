using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClearDirector : MonoBehaviour
{
    public Text ScoreText;
    float score;
    void Start()
    {


        ScoreText.text = string.Format("Score:{0}", score);
        //�N���A�V�[���ɃX�R�A�̏o�������킩��܂���ł���
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
