using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    //プレイヤーの移動速度
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        Animator.settrigger("upTrigger")
        float y = Input.GetAxis("Vertical");

        //現在地にx,yの値を加算する
        transform.position += new Vector3(x, y, 0) * Time.deltaTime * Speed;

    }
}
