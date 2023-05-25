using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //右に球を移動
        transform.position += new Vector3(Speed, 0, 0) * Time.deltaTime;
        //画面右方向に消えたら削除
        if (transform.position.x>=20.0f)
        {
            Destroy(gameObject);
        }
    }
}
