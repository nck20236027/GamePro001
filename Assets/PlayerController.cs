using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    //�v���C���[�̈ړ����x
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

        //���ݒn��x,y�̒l�����Z����
        transform.position += new Vector3(x, y, 0) * Time.deltaTime * Speed;

    }
}
