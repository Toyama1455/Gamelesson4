using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    //�l�̊Ǘ�
    [field: SerializeField]
    public static int Physical { get; set; }//�̗�
    
    [field: SerializeField]
    public static int Mind { get; set; }//���_��

    [field: SerializeField]
    public static int Addiction { get; set; }//���Œl

    [field: SerializeField]
    public static int Ethic { get; set; }//�ϗ��l

    [field: SerializeField]
    public static int Money { get; set; }//����

    [field: SerializeField]
    public static int EndingNum { get; set; }//�G���f�B���O�V�[���ɕK�v�Ȃ���

    public static int day { get; set; }//���t

    [field: SerializeField]
    public static int time { get; set; }//����

    [field: SerializeField]
    public static int WorkMoney { get; set; }//����

    [field: SerializeField]
    public static int Luck { get; set; }//����



    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
