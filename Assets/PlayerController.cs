using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Playercontroller : MonoBehaviour
{
    // �v���C���[�̈ړ����x
    public float Speed;
    //���̃v���n�u
    public GameObject ShotPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
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
}
