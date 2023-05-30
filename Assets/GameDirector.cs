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
    float time = 0.0f;
    //float hp =133333333333333.0f;
    int speed = 0;

    public void HitEnemy()
    {
        //this.hp -= 0.1f;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
        this.km = GameObject.Find("0km");
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
