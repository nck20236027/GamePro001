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
        //‰E‚É‹…‚ðˆÚ“®
        transform.position += new Vector3(Speed, 0, 0) * Time.deltaTime;
        //‰æ–Ê‰E•ûŒü‚ÉÁ‚¦‚½‚çíœ
        if (transform.position.x>=20.0f)
        {
            Destroy(gameObject);
        }
    }
}
