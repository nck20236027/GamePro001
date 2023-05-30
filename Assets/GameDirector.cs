using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GameDirector : MonoBehaviour
{
    GameObject km;
    GameObject hpGauge;
    float time = 0.0f;
    float hp = 100.0f;

    public void HitEnemy()
    {
        this.hp -= 10.0f;
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
        //this.hpGauge -=0,01666f ;
        this.time += 0.06f;
        this.km.GetComponent<TextMeshProUGUI>().text =
            this.time.ToString("F1")+"km";
        //this.hpGauge.GetComponent<TextMeshProUGUI>().text =
        //    this.hp.ToString();
    }
}
