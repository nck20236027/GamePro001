using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class Playercontroller : MonoBehaviour
{
    // �v���C���[�̈ړ����x
    public float Speed;
    //���̃v���n�u
    public GameObject ShotPrefab;
    Rigidbody2D rigid2D;

    // Start is called before the first frame update
    void Start()
    {

    }
    //void OnTriggerEnter2D (Collider other)
    //{
    //    Debug.Log("��������");
    //    Destroy(other.gameObject);
    //}

    // Update is called once per frame
    void Update()
    {
        this.rigid2D= GetComponent<Rigidbody2D>();
        // �����L�[�œ��͂��ꂽ�����̒l���擾
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        // ���݈ʒu��x,y �̒l�����Z����
        transform.position += new Vector3(x, y, 0) * Time.deltaTime * Speed;


        //�}�E�X�{�^�����N���b�N���ꂽ�狅�𔭎�
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(ShotPrefab,transform.position,Quaternion.identity); 

        }


    }
    void OnTriggerEnter2D(Collider other)
    {
        Debug.Log("��������");
        Destroy(other.gameObject);
    }

}
