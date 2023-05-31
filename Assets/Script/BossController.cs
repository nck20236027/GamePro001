using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
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
        transform.Translate(-0.08f, 0, 0);

        if (transform.position.x < -10.0f)
        {
            Destroy(gameObject);
        }
        void OnTriggerEnter2D(Collider2D other)
        {
            Debug.Log("“–‚½‚Á‚½");
        }
    }
}
