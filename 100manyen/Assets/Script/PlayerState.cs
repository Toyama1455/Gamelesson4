using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    //値の管理
    [field: SerializeField]
    public static int Physical { get; set; }//体力

    public static int PhysicalMax { get; set; }//体力の上限

    [field: SerializeField]
    public static int Mind { get; set; }//精神力

    public static int MindMax { get; set; }

    [field: SerializeField]
    public static int Addiction { get; set; }//中毒値

    [field: SerializeField]
    public static int Ethic { get; set; }//倫理値

    [field: SerializeField]
    public static int Money { get; set; }//お金

    [field: SerializeField]
    public static int EndingNum { get; set; }//エンディングシーンに必要なもの

    public static int day { get; set; }//日付

    [field: SerializeField]
    public static int time { get; set; }//時間

    [field: SerializeField]
    public static int WorkMoney { get; set; }//時間

    [field: SerializeField]
    public static int Luck { get; set; }//時間

    public static void addPhysical(int value)
    {
        Physical += value;

        if (Physical > 100)
        {

            Physical = 100;

        }
        
    }

    public static void addMind(int value)
    {
        Mind += value;

        if (Mind  > 100)
        {

            Mind = 100;

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
