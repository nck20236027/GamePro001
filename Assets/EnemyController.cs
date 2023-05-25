using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.08f, 0, 0);

        if(transform.position.x<-10.0f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float  d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 0.5f;

        if(d<r1+r2)
        {
            //監督スクリプトにプレイヤーと衝突したことを伝える
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();


            //衝突した場合
            Destroy(gameObject);
        }


    }
}
