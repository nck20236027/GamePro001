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
    GameObject timer;
    Animator anim;
    GameObject director;


    void Start()
    {
        Application.targetFrameRate = 60;
       anim= GetComponent<Animator>();
        director = GameObject.Find("GameDirector");
    }
    //void OnTriggerEnter2D (Collider other)
    //{
    //    Debug.Log("��������");
    //    Destroy(other.gameObject);
    //}




    //private Vector2 mousePos;
    //private Vector2 target;
    int i = 10;

    void Update()
    {
        this.rigid2D= GetComponent<Rigidbody2D>();
        //mousePos=Input.mousePosition;
        //target = Camera.main.ScreenToWorldPoint(new Vector2(mousePos.x, mousePos.y));
        //transform.LookAt(target);
        // �����L�[�œ��͂��ꂽ�����̒l���擾
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if (y == 0)
        {
            anim.Play("Player Animation");
        }
        else if (y >0)
        {
            anim.Play("up Animation");
        }
        else if (y <0)
        {
            anim.Play("DownrrAnimation");
        }


        // ���݈ʒu��x,y �̒l�����Z����
        transform.position += new Vector3(x, y, 0) * Time.deltaTime * Speed;


        //�}�E�X�{�^�����N���b�N���ꂽ�狅�𔭎�
       //���͂P�O��܂ł����łĂȂ�
        if(Input.GetMouseButtonDown(0)&&i>0)
        {
            i--;
            Instantiate(ShotPrefab,transform.position,Quaternion.identity);
            director.GetComponent<GameDirector>().GetShot();
        }
        if(Input.GetKeyDown (KeyCode.Escape))
        {
            ////////////////////////
        }


    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "EnemyPrefab")
        {
            Debug.Log("hit");
            Destroy(other.gameObject);
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();
        }
        if (other.gameObject.tag == "Boss") 
        {
            GetComponent<GameDirector>().DecreaseHp();
            Debug.Log("�{�X�q�b�g");
            Destroy(other.gameObject);
            GameObject director = GameObject.Find("GameDirector");
            //for (int i = 0; i < 5;++i)
            //{
            //    for (int j = 4; j <= i;)
            //    {
            //        Destroy(other.gameObject);
                    
            //    }
            //}
        }
    }

}
