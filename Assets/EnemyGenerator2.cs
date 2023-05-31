using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator2 : MonoBehaviour
{
    public GameObject EnemyPrefab;
    float span = 0.5f;
    float delta = 0;



    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(EnemyPrefab);
            int px = Random.Range(6,6);
            int xx=Random.Range(10, -5);
            go.transform.position = new Vector3(xx, px, 0);
        }

    }
}