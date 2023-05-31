using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class Playercontroller : MonoBehaviour
{

    // プレイヤーの移動速度
    public float Speed;
    //球のプレハブ
    public GameObject ShotPrefab;
    Rigidbody2D rigid2D;
    GameObject timer;
    Animator anim;


    void Start()
    {
        Application.targetFrameRate = 60;
       anim= GetComponent<Animator>();

    }
    //void OnTriggerEnter2D (Collider other)
    //{
    //    Debug.Log("当たった");
    //    Destroy(other.gameObject);
    //}

    // Update is called once per frame
    void Update()
    {
        this.rigid2D= GetComponent<Rigidbody2D>();
        // 方向キーで入力された横軸の値を取得
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if (y == 0)
        {
            anim.Play("Player Animation");
        }
        else if (y >0)
        {
            anim.Play("up Animation");
        }
        else if (y <0)
        {
            anim.Play("DownrrAnimation");
        }


        // 現在位置にx,y の値を加算する
        transform.position += new Vector3(x, y, 0) * Time.deltaTime * Speed;


        //マウスボタンがクリックされたら球を発射
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(ShotPrefab,transform.position,Quaternion.identity); 

        }
        if(Input.GetKeyDown (KeyCode.Escape))
        {
            ////////////////////////
        }


    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "EnemyPrefab")
        {
            Debug.Log("hit");
            Destroy(other.gameObject);
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();
        }
    }

}
