using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    //�l�̊Ǘ�
    [SerializeField]
    public int Physical //�̗�
    { 
        get
        {
            return Physical;
        }
        set
        {
            Physical = value;
        }
    }

    [SerializeField]
    public int Mind //���_��
    {
        get
        {
            return Mind;
        }
        set
        {
            Mind = value;
        }
    }

    [SerializeField]
    public int Addiction //���Œl
    {
        get
        {
            return Addiction;
        }
        set
        {
            Addiction = value;
        }
    }
    [SerializeField]
    public int Ethic //�ϗ��l
    {
        get
        {
            return Ethic;
        }
        set
        {
            Ethic = value;
        }
    }
    [SerializeField]
    public int Money //����
    {
        get
        {
            return Money;
        }
        set
        {
            Money = value;
        }
    }


    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
