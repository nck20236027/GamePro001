using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameDirector : MonoBehaviour
{
    GameObject km;
    GameObject hpGauge;
    GameObject ShotCount;
    float time = 0.0f;
    int ShotPP = 10;
    int speed = 0; 
    public Text Scoretext;
    public static float score = Time.time;

    
    public void GetShot()
    {
        this.ShotPP -= 1;
    }
    
    public static float getScore()
    {
        return score;
    }//�N���A�V�[���ɃX�R�A�̏o�������킩��܂���ł����@
    
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
        this.km = GameObject.Find("0km");
        this.ShotCount = GameObject.Find("ShotCount");
        
    }

    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;

    }
    void Update()
    {
        speed++;
        if(speed>=6)
        {
            this.hpGauge.GetComponent<Image>().fillAmount -= 0.001f;
            speed = 0;
        }
        this.ShotCount.GetComponent<TextMeshProUGUI>().text =
            this.ShotPP.ToString();
        
        this.time += 0.6f;
        this.km.GetComponent<TextMeshProUGUI>().text =
            this.time.ToString("00000")+"km";
        

        //this.hpGauge.GetComponent<Image>().fillAmount =
        //    this.hp.ToString();
        if (this.hpGauge.GetComponent<Image>().fillAmount <= 0)
        {
            SceneManager.LoadScene("GameOrverScene");
        }

    }
    
}
