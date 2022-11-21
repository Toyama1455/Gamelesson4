using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    //値の管理
    [SerializeField]
    public int Physical //体力
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
    public int Mind //精神力
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
    public int Addiction //中毒値
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
    public int Ethic //倫理値
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
    public int Money //お金
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
