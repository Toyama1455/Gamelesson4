using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManeger : MonoBehaviour
{
    public Text DayTime = null;//日付テキストオブジェクト
    public Text Physical = null;//体力テキストオブジェクト
    public Text Mind = null;//精神力テキストオブジェクト
    public Text Addiction = null;//中毒値テキストオブジェクト
    public Text Ethic = null;//倫理値テキストオブジェクト
    public Text Money = null;//お金テキストオブジェクト

   




    // Start is called before the first frame update
    void Start()
    {
        //日付を更新する
        DaytimeUpdete();


    }

    // Update is called once per frame
    void Update()
    {

        //体力を更新する
        PhysicalUpdate();
        //精神力を更新する
        MindUpdate();
        //中毒値を更新する
        AddictionUpdate();
        //倫理値を更新する
        EthicUpdate();
        //お金を更新する
        MoneyUpdate();
    }

    //日付を変更する
    void DaytimeUpdete()
    {
        switch (PlayerState.time)
        {
            case 0:
                DayTime.text = (PlayerState.day + "日" + "　９時");
                break;

            case 1:
                DayTime.text = (PlayerState.day + "日" + "　１７時");
                break;

            case 2:
                DayTime.text = (PlayerState.day + "日" + "　２５時");
                break;
                
            default:

                Debug.Log("バグってます");

                break;
        }
        
    }

    //体力更新を行います
    void PhysicalUpdate()
    {
        Physical.text = PlayerState.Physical.ToString();
    }
    //精神力更新を行います
    void MindUpdate()
    {
        Mind.text = PlayerState.Mind.ToString();
    }
    //中毒値更新を行います
    void AddictionUpdate()
    {
        Addiction.text = PlayerState.Addiction.ToString();
    }
    //倫理値更新を行います
    void EthicUpdate()
    {
        Ethic.text = PlayerState.Ethic.ToString();
    }
    //所持金更新を行います
    void MoneyUpdate()
    {
        Money.text = ("所持金　" + PlayerState.Money.ToString() + "円");
    }






}
