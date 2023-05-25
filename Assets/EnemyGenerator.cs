
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject EnemyPrefab;
    float span = 0.5f;
    float delta = 0;

    

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(EnemyPrefab);
            int px = Random.Range(-7, 5);
            go.transform.position = new Vector3(20,px,0);
        }
    }
}
