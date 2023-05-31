using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController2 : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        //this.player = GameObject.Find("Player");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Shot")
        {

            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.06f,-0.08f, 0);

        if (transform.position.y < -20.0f)
        {
            Destroy(gameObject);
        }
        void OnTriggerEnter2D(Collider2D other)
        {
            Debug.Log("“–‚½‚Á‚½");
        }

    }
}
