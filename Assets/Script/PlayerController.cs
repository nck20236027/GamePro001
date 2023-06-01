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
    GameObject director;


    void Start()
    {
        Application.targetFrameRate = 60;
       anim= GetComponent<Animator>();
        director = GameObject.Find("GameDirector");
    }
    //void OnTriggerEnter2D (Collider other)
    //{
    //    Debug.Log("当たった");
    //    Destroy(other.gameObject);
    //}




    //private Vector2 mousePos;
    //private Vector2 target;
    int i = 10;

    void Update()
    {
        this.rigid2D= GetComponent<Rigidbody2D>();
        //mousePos=Input.mousePosition;
        //target = Camera.main.ScreenToWorldPoint(new Vector2(mousePos.x, mousePos.y));
        //transform.LookAt(target);
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
       //球は１０回までしか打てない
        if(Input.GetMouseButtonDown(0)&&i>0)
        {
            i--;
            Instantiate(ShotPrefab,transform.position,Quaternion.identity);
            director.GetComponent<GameDirector>().GetShot();
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
        if (other.gameObject.tag == "Boss") 
        {
            GetComponent<GameDirector>().DecreaseHp();
            Debug.Log("ボスヒット");
            Destroy(other.gameObject);
            GameObject director = GameObject.Find("GameDirector");
            //for (int i = 0; i < 5;++i)
            //{
            //    for (int j = 4; j <= i;)
            //    {
            //        Destroy(other.gameObject);
                    
            //    }
            //}
        }
    }

}
