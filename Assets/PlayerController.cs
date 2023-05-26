using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Playercontroller : MonoBehaviour
{
    // プレイヤーの移動速度
    public float Speed;
    //球のプレハブ
    public GameObject ShotPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 方向キーで入力された横軸の値を取得
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        // 現在位置にx,y の値を加算する
        transform.position += new Vector3(x, y, 0) * Time.deltaTime * Speed;

        //マウスボタンがクリックされたら球を発射
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(ShotPrefab,transform.position,Quaternion.identity);

        }

    }
}
