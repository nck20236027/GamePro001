using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    public float Speed;
    GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        this.Enemy = GameObject.Find("EnemyPrefab");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "EnemyPrefab")
        {
            Debug.Log("ShotHIt");
            Destroy(other.gameObject);
        }
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
        
        //Vector2 p1 = transform.position;
        //Vector2 p2 = this.Enemy.transform.position;
        //Vector2 dir = p1- p2;
        //float d = dir.magnitude;
        //float r1 = 0.5f;
        //float r2 = 0.5f;

        //if(d <r1+r2)
        //{
        //    Destroy (Enemy);
        //}



    }
}
