using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum ActionBackgroundState
{
    Error,
    Work,
    Eat,
    Sleep,
    Park,
    Aquarium,
    Shopping,
    PachinkoAndSlot,
    Bortrace,
    Bicyclerace,
    Horserace,
    Lottery,
    Pettycrime,
    Midiumcrime,
    Heveycrime

}

public class SceneScript : MonoBehaviour
{
    public static ActionBackgroundState Action { get; private set; }

    

    //リザルト画面でエンディング処理ができるかどうかを行う
    void Start()
    {
        if (MainBackgroundManeger.day > 30)
        {
            //１００万円以上もっている
            if (PlayerState.Money > 1000000)
            {
                //エンディング１１の判定
                if (PlayerState.Addiction >= 75)
                {
                    if (PlayerState.Ethic <= 25)
                    {
                        PlayerState.EndingNum = 11;
                        return;
                    }
                }

                //エンディング４の判定
                if (PlayerState.Addiction >= 75)
                {
                    PlayerState.EndingNum = 4;
                    return;
                }

                //エンディング６の判定
                if (PlayerState.Ethic <= 25)
                {
                    PlayerState.EndingNum = 6;
                    return;
                }

                //エンディング１
                PlayerState.EndingNum = 1;

            }
            //１００万円持っていない
            else
            {
                //エンディング１０の判定
                if (PlayerState.Addiction > 75)
                {
                    if (PlayerState.Ethic <= 25)
                    {
                        PlayerState.EndingNum = 10;
                        return;
                    }
                }

                //エンディング３の判定
                if (PlayerState.Addiction >= 75)
                {
                    PlayerState.EndingNum = 3;
                    return;
                }
                //エンディング２
                PlayerState.EndingNum = 2;
                return;
            }
            
        }


        //体力が０になったら
        if (PlayerState.Physical < 0)
        {
            PlayerState.EndingNum = 7;
        }

        //精神力が０になったら
        if (PlayerState.Mind < 0)
        {
            PlayerState.EndingNum = 8;
        }

        //お金が０になったら
        if (PlayerState.Money < 0)
        {
            PlayerState.EndingNum = 9;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //タイトル画面からメイン画面へ
    public void OnClickStart()
    {
        SceneManager.LoadScene("MainScene");
    }

    //タイトル画面からデスクトップへ
    public void OnClickEnd()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }


    //リザルト画面からメインシーンに戻る処理
    public void OnClickNext()
    {
        if (PlayerState.EndingNum　> 0 )
        {
            switch (PlayerState.EndingNum)
            {
                //ED1 借金返済
                case 1:
                    break;
                //ED2 借金返済出来ず内臓売り捌かれて海の藻屑
                case 2:
                    break;
                //ED3 ギャンブラー、強制労働堕ち
                case 3:
                    break;
                //ED4 ギャンブラー
                case 4:
                    break;
                //ED5 牢獄入所
                case 5:
                    break;
                //ED6 大泥棒
                case 6:
                    break;
                //ED7 死亡
                case 7:
                    break;
                //ED8 病み落ち自殺
                case 8:
                    break;
                //ED9 エンドレス借金
                case 9:
                    break;
                //ED10 人間のクズ
                case 10:
                    break;
                //ED11　人生終わり組
                case 11:
                    break;
                //バグ
                default:
                    Debug.Log("バグっています");

                    break;






            }




        }







        SceneManager.LoadScene("MainScene");
    }
    
    //メイン画面から各選択肢へ
    public void OnClickWork() //体力と精神力を消費してお金を増やす
    {
        //背景の呼び出し
        Action = ActionBackgroundState.Work;
        //ステータス変更

        PlayerState.Physical += 1; //体力の変更

        PlayerState.Mind += 1; //精神力の変更

        PlayerState.Money += 1;//お金の変更

        Debug.Log("働きました");

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickEat()　//お金を使って、体力と精神力を回復する
    {
        Action = ActionBackgroundState.Eat;

        PlayerState.Physical += 1; //体力の変更

        PlayerState.Mind += 1; //精神力の変更

        PlayerState.Money += 1;//お金の変更

        Debug.Log("食べました");

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickSleep() //お金を使わず、体力と精神力を回復する
    {
        Action = ActionBackgroundState.Sleep;

        PlayerState.Physical += 1; //体力の変更

        PlayerState.Mind += 1; //精神力の変更

        PlayerState.Money += 1;//お金の変更

        Debug.Log("寝ました");

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickPark() //体力を使って精神力を回復する
    {
        Action = ActionBackgroundState.Park;

        PlayerState.Physical -= 1;

        PlayerState.Mind += 1;

        Debug.Log("公園に行きました");

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickAquarium()//お金を使って精神力を回復する
    {
        Action = ActionBackgroundState.Aquarium;

        PlayerState.Money -= 1;

        PlayerState.Money += 1;

        Debug.Log("水族館に行きました");

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickShopping() //お金を使って倫理値を回復する
    {
        Action = ActionBackgroundState.Shopping;

        PlayerState.Money -= 1;

        PlayerState.Mind += 1;

        Debug.Log("買い物に行きました");

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickPachinkoAndSlot()　//お金を使って、中毒値とお金を増やす
    {
        Action = ActionBackgroundState.PachinkoAndSlot;



        int rnd = Random.Range(1, 6);

        switch (rnd)
        {
            case 1://大勝

                PlayerState.Addiction += 10;
                PlayerState.Money += 80000;

                Debug.Log("パチンコで大勝ちしました");

                break;

            case 2://勝ち
                PlayerState.Addiction += 5;
                PlayerState.Money += 40000;

                Debug.Log("パチンコで勝ちしました");

                break;

            case 3://トントン
                PlayerState.Addiction += 3;

                Debug.Log("パチンコでトントンでした");

                break;
            case 4://負け
                PlayerState.Addiction += 2;
                PlayerState.Money -= 40000;

                Debug.Log("パチンコで負けました");

                break;
            case 5://大負け
                PlayerState.Addiction += 1;
                PlayerState.Money -= 80000;

                Debug.Log("パチンコで大負けました");

                break;

                
        }

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickBortRace() //お金を使って、中毒値とお金を増やす
    {
        Action = ActionBackgroundState.Bortrace;

        int rnd = Random.Range(1, 6);

        switch (rnd)
        {
            case 1://大勝

                PlayerState.Addiction += 10;
                PlayerState.Money += 100000;
                break;

            case 2://勝ち
                PlayerState.Addiction += 5;
                PlayerState.Money += 30000;
                break;

            case 3://トントン
                PlayerState.Addiction += 3;
                break;
            case 4://負け
                PlayerState.Addiction += 2;
                PlayerState.Money -= 50000;
                break;
            case 5://大負け
                PlayerState.Addiction += 1;
                PlayerState.Money -= 100000;
                break;


        }

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickBicyleRace() //お金を使って、中毒値とお金を増やす
    {
        Action = ActionBackgroundState.Bicyclerace;

        int rnd = Random.Range(1, 6);

        switch (rnd)
        {
            case 1://大勝

                PlayerState.Addiction += 10;
                PlayerState.Money += 100000;
                break;

            case 2://勝ち
                PlayerState.Addiction += 5;
                PlayerState.Money += 50000;
                break;

            case 3://トントン
                PlayerState.Addiction += 3;
                break;
            case 4://負け
                PlayerState.Addiction += 2;
                PlayerState.Money -= 80000;
                break;
            case 5://大負け
                PlayerState.Addiction += 1;
                PlayerState.Money -= 150000;
                break;


        }
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickHorseRase() //お金を使って、中毒値とお金を増やす
    {
        Action = ActionBackgroundState.Horserace;

        int rnd = Random.Range(1, 6);

        switch (rnd)
        {
            case 1://大勝

                PlayerState.Addiction += 10;
                PlayerState.Money += 500000;
                break;

            case 2://トントン
                PlayerState.Addiction += 5;
                
                break;

            case 3://負け
                PlayerState.Addiction += 3;
                PlayerState.Money -= 50000;
                break;
            case 4://大負け
                PlayerState.Addiction += 2;
                PlayerState.Money -= 100000;
                break;
            case 5://超負け
                PlayerState.Addiction += 1;
                PlayerState.Money -= 200000;
                break;


        }


        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickLottery() //お金を使って、中毒値とお金を増やす
    {
        Action = ActionBackgroundState.Lottery;

        int rnd = Random.Range(1, 6);

        switch (rnd)
        {
            case 1://勝ち

                PlayerState.Addiction += 10;
                PlayerState.Money += 100000000;
                break;

            case 2://負け
                PlayerState.Addiction += 5;
                PlayerState.Money -= 50000;
                break;

            case 3://負け
                PlayerState.Addiction += 3;
                PlayerState.Money -= 100000;
                break;
            case 4://大負け
                PlayerState.Addiction += 2;
                PlayerState.Money -= 500000;
                break;
            case 5://超大負け
                PlayerState.Addiction += 1;
                PlayerState.Money -= 1000000;
                break;
                
        }

        SceneManager.LoadScene("ResultScene");
    }



    public void OnClickPettycrime() //倫理値を下げて、お金と精神力と体力を増やす
    {
        Action = ActionBackgroundState.Pettycrime;

        int rnd = Random.Range(1, 4);

        switch (rnd)
        {
            case 1://成功

                PlayerState.Ethic -= 5;

                PlayerState.Physical += 10;

                PlayerState.Mind += 10;

                PlayerState.Money += 10000;

                break;

            case 2://未遂

                PlayerState.Ethic -= 3;

                break;

            case 3://失敗

                PlayerState.EndingNum = 5;

                break;


        }
    }

    public void OnClickMidiumcrime()//倫理値を下げて、お金ちと精神力を増やす
    {
        Action = ActionBackgroundState.Midiumcrime;

        int rnd = Random.Range(1, 6);

        switch (rnd)
        {
            case 1://成功

                PlayerState.Ethic -= 10;

                PlayerState.Money += 100000;

                SceneManager.LoadScene("ResultScene");

                break;

            case 2://未遂

                PlayerState.Ethic -= 5;
                SceneManager.LoadScene("ResultScene");
                break;

            case 3://未遂


                PlayerState.Ethic -= 5;
                SceneManager.LoadScene("ResultScene");
                break;

            case 4://失敗

                PlayerState.EndingNum = 5;

                break;

            case 5://失敗

                PlayerState.EndingNum = 5;

                break;


        }

        
    }

    public void OnClickHeveycrime()//倫理値を下げて、お金を増やす
    {
        Action = ActionBackgroundState.Heveycrime;//倫理値を大きく下げて、お金を大きく得る

        int rnd = Random.Range(1, 6);

        switch (rnd)
        {
            case 1://成功

                PlayerState.Ethic -= 30;

                PlayerState.Money += 1000000;

                Debug.Log("成功しました");

                SceneManager.LoadScene("ResultScene");

                break;

            case 2://未遂

                PlayerState.Ethic -= 10;

                Debug.Log("未遂に終わりました");
                SceneManager.LoadScene("ResultScene");

                break;

            case 3://失敗

                PlayerState.EndingNum = 5;

                Debug.Log("失敗しました");

                break;

            case 4://失敗

                PlayerState.EndingNum = 5;

                Debug.Log("失敗しました２");

                break;

            case 5://失敗

                PlayerState.EndingNum = 5;

                Debug.Log("失敗しました３");

                break;
                
        }

    }


}
