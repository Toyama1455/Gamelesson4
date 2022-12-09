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
    
    public int physical;//体力
    public int mind;//精神力
    public int addiction;//中毒値
    public int ethic;//倫理値
    public int money;//お金


    //リザルト画面でエンディング処理ができるかどうかを行う
    void Start()
    {
        if (PlayerState.day > 30)
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

    public void StateInit()//初期値の設定
    {
        PlayerState.Physical = physical;
        PlayerState.Mind = mind;
        PlayerState.Addiction = addiction;
        PlayerState.Ethic = ethic;
        PlayerState.Money = money;

    }

    //タイトル画面からメイン画面へ
    public void OnClickStart()
    {
        StateInit();
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
        Debug.Log("エンディングナンバーは"+PlayerState.EndingNum);

        if (PlayerState.EndingNum　> 0 )
        {
            switch (PlayerState.EndingNum)
            {
                //ED1 借金返済
                case 1:
                    Debug.Log("これからの平穏な日々");
                    SceneManager.LoadScene("EndScene");
                    break;
                //ED2 借金返済出来ず内臓売り捌かれて海の藻屑
                case 2:
                    Debug.Log("海の藻屑");
                    SceneManager.LoadScene("EndScene");
                    break;
                //ED3 ギャンブラー、強制労働堕ち
                case 3:
                    Debug.Log("ギャンブル狂いの債務者は強制労働じゃぁぁあああ");
                    SceneManager.LoadScene("EndScene");
                    break;
                //ED4 ギャンブラー
                case 4:
                    Debug.Log("一生これで食っていく");
                    SceneManager.LoadScene("EndScene");
                    break;
                //ED5 牢獄入所
                case 5:
                    Debug.Log("監獄生活のはじまり");
                    SceneManager.LoadScene("EndScene");
                    break;
                //ED6 大泥棒
                case 6:
                    Debug.Log("俺が令和の大泥棒だぜ");
                    SceneManager.LoadScene("EndScene");
                    break;
                //ED7 死亡
                case 7:
                    Debug.Log("体力がなくなりました");
                    SceneManager.LoadScene("EndScene");
                    break;
                //ED8 病み落ち自殺
                case 8:
                    Debug.Log("現実に耐え切れず自殺しました");
                    SceneManager.LoadScene("EndScene");
                    break;
                //ED9 エンドレス借金
                case 9:
                    Debug.Log("返しても返しても増える借金");
                    SceneManager.LoadScene("EndScene");
                    break;
                //ED10 人間のクズ
                case 10:
                    Debug.Log("お前、マジで人間のクズだな");
                    SceneManager.LoadScene("EndScene");
                    break;
                //ED11　人生終わり組
                case 11:
                    Debug.Log("人として終わってんな");
                    SceneManager.LoadScene("EndScene");
                    break;
                //バグ
                default:
                    Debug.Log("バグっています");
                    break;

            }
        }
        else
        {
            SceneManager.LoadScene("MainScene");
        }
    }

    public void OnClickEnding()
    {
        PlayerState.EndingNum = 0;
        PlayerState.Physical = physical;
        PlayerState.Mind = mind;
        PlayerState.Addiction = addiction;
        PlayerState.Ethic = ethic;
        PlayerState.Money = money;
        PlayerState.day = 0;
        PlayerState.time = 0;
        SceneManager.LoadScene("StartScene");
    }
    
    //メイン画面から各選択肢へ
    public void OnClickWork() //体力と精神力を消費してお金を増やす
    {
        //背景の呼び出し
        Action = ActionBackgroundState.Work;
        //ステータス変更

        //PlayerState.Physical -= 10; //体力の変更

        PlayerState.addPhysical(-10);

        //PlayerState.Mind -= 10; //精神力の変更

        PlayerState.addMind(-10);

        int rnd = Random.Range(1,51);

        

        PlayerState.WorkMoney = rnd * 1000;

        PlayerState.Money += PlayerState.WorkMoney;

        
        Debug.Log(PlayerState.WorkMoney + "稼ぎました");

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickEat()　//お金を使って、体力と精神力を回復する
    {
        Action = ActionBackgroundState.Eat;

        PlayerState.Luck = Random.Range(1, 4);

        switch (PlayerState.Luck)
        {
            case 1:
                //PlayerState.Physical += 50; //体力の変更
                //PlayerState.Mind += 50; //精神力の変更

                PlayerState.addPhysical(30);
                PlayerState.addMind(30);

                PlayerState.Money -= 15000;//お金の変更
                Debug.Log("高級な食事をしました。");
                break;

            case 2:

                //PlayerState.Physical += 30; //体力の変更
                //PlayerState.Mind += 20; //精神力の変更

                PlayerState.addPhysical(20);
                PlayerState.addMind(15);

                PlayerState.Money -= 3000;//お金の変更
                Debug.Log("普通の食事をしました。");
                break;
            case 3:

                //PlayerState.Physical += 15; //体力の変更
                //PlayerState.Mind += 10; //精神力の変更

                PlayerState.addPhysical(10);
                PlayerState.addMind(5);

                PlayerState.Money -= 1000;//お金の変更
                Debug.Log("節約的な食事をしました。");
                break;                
            default:
                Debug.Log("バグっています。早急に直してください");
                break;
        }
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickSleep() //お金を使わず、体力と精神力を回復する
    {
        Action = ActionBackgroundState.Sleep;

        PlayerState.Luck = Random.Range(1, 4);

        switch (PlayerState.Luck)
        {
            case 1:

                //PlayerState.Physical += 20; //体力の変更
                //PlayerState.Mind += 30; //精神力の変更

                PlayerState.addPhysical(20);
                PlayerState.addMind(30);

                Debug.Log("熟睡できました。");
                break;
            case 2:

                //PlayerState.Physical += 10; //体力の変更
                //PlayerState.Mind += 15; //精神力の変更                

                PlayerState.addPhysical(10);
                PlayerState.addMind(15);

                Debug.Log("普通に眠れました");
                break;
            case 3:

                PlayerState.Physical += 5; //体力の変更
                PlayerState.Mind += 10; //精神力の変更

                PlayerState.addPhysical(5);
                PlayerState.addMind(10);

                Debug.Log("あまり眠れませんでした");
                break;
            default:
                Debug.Log("バグっています。早急に直してください");
                break;
        }

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickPark() //体力を使って精神力を回復する
    {
        Action = ActionBackgroundState.Park;

        PlayerState.Luck = Random.Range(1, 4);

        switch (PlayerState.Luck)
        {
            case 1:

                //PlayerState.Physical -= 15; //体力の変更
                //PlayerState.Mind += 30; //精神力の変更

                PlayerState.addPhysical(-15);
                PlayerState.addMind(30);

                Debug.Log("遠くの綺麗な公園にいきました");
                break;
            case 2:

                //PlayerState.Physical -= 10; //体力の変更
                //PlayerState.Mind += 20; //精神力の変更                

                PlayerState.addPhysical(-10);
                PlayerState.addMind(20);

                Debug.Log("近場の綺麗な公園にいきました");
                break;
            case 3:

                PlayerState.Physical -= 5; //体力の変更
                PlayerState.Mind += 10; //精神力の変更

                PlayerState.addPhysical(-5);
                PlayerState.addMind(10);

                Debug.Log("そのへんを散歩しました");
                break;
            default:
                Debug.Log("バグっています。早急に直してください");
                break;
        }
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickAquarium()//お金を使って精神力を回復する
    {
        Action = ActionBackgroundState.Aquarium;

        PlayerState.Luck = Random.Range(1, 4);

        switch (PlayerState.Luck)
        {
            case 1:

                PlayerState.Money -= 15000; //所持金から減らす
                PlayerState.Mind += 50; //精神力の変更

                PlayerState.addMind(50);

                Debug.Log("遠くの超有名水族館に行きました");
                break;
            case 2:

                PlayerState.Money -= 10000; //所持金から減らす
                PlayerState.Mind += 30; //精神力の変更

                PlayerState.addMind(30);

                Debug.Log("近場の有名水族館に行きました");
                break;
            case 3:

                //PlayerState.Money -= 5000; //所持金から減らす
                //PlayerState.Mind += 15; //精神力の変更

                PlayerState.addMind(15);

                Debug.Log("なんとなく水族館に行きました");
                break;
            default:
                Debug.Log("バグっています。早急に直してください");
                break;
        }
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickShopping() //お金を使って倫理値を回復する
    {
        Action = ActionBackgroundState.Shopping;

        PlayerState.Luck = Random.Range(1, 4);

        switch (PlayerState.Luck)
        {
            case 1:
                PlayerState.Money -= 50000; //所持金から減らす
                PlayerState.Ethic += 50; //倫理値の変更
                Debug.Log("超爆買いしました");
                break;
            case 2:
                PlayerState.Money -= 30000; //所持金から減らす
                PlayerState.Ethic += 30; //倫理値の変更
                Debug.Log("爆買いしました");
                break;
            case 3:
                PlayerState.Money -= 10000; //所持金から減らす
                PlayerState.Ethic += 15; //倫理値の変更
                Debug.Log("買い物をしました");
                break;
            default:
                Debug.Log("バグっています。早急に直してください");
                break;
        }
        
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickPachinkoAndSlot()　//お金を使って、中毒値とお金を増やす
    {
        Action = ActionBackgroundState.PachinkoAndSlot;

        PlayerState.Luck = Random.Range(1, 6);

        switch (PlayerState.Luck)
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

        PlayerState.Luck = Random.Range(1, 6);

        switch (PlayerState.Luck)
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

        PlayerState.Luck = Random.Range(1, 6);

        switch (PlayerState.Luck)
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

        PlayerState.Luck = Random.Range(1, 6);

        switch (PlayerState.Luck)
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

        PlayerState.Luck = Random.Range(1, 6);

        switch (PlayerState.Luck)
        {
            case 1://勝ち

                PlayerState.Addiction += 100;
                PlayerState.Money += 100000000;
                break;

            case 2://負け
                PlayerState.Addiction += 5;
                PlayerState.Money -= 50000;
                break;

            case 3://負け
                PlayerState.Addiction += 10;
                PlayerState.Money -= 100000;
                break;
            case 4://大負け
                PlayerState.Addiction += 20;
                PlayerState.Money -= 500000;
                break;
            case 5://超大負け
                PlayerState.Addiction += 30;
                PlayerState.Money -= 1000000;
                break;
                
        }

        SceneManager.LoadScene("ResultScene");
    }



    public void OnClickPettycrime() //倫理値を下げて、お金と精神力と体力を増やす
    {
        Action = ActionBackgroundState.Pettycrime;

        PlayerState.Luck = Random.Range(1, 4);

        switch (PlayerState.Luck)
        {
            case 1://成功

                PlayerState.Ethic -= 5;

                //PlayerState.Physical += 10;

                PlayerState.addPhysical(10);

                //PlayerState.Mind += 10;

                PlayerState.addMind(10);

                PlayerState.Money += 10000;

                break;

            case 2://未遂

                PlayerState.Ethic -= 3;

                SceneManager.LoadScene("ResultScene");

                break;

            case 3://失敗

                PlayerState.EndingNum = 5;

                SceneManager.LoadScene("ResultScene");

                break;


        }

    }

    public void OnClickMidiumcrime()//倫理値を下げて、お金ちと精神力を増やす
    {
        Action = ActionBackgroundState.Midiumcrime;

        PlayerState.Luck = Random.Range(1, 6);

        switch (PlayerState.Luck)
        {
            case 1://成功

                PlayerState.Ethic -= 30;

                PlayerState.Money += 100000;

                SceneManager.LoadScene("ResultScene");

                break;

            case 2://未遂

                PlayerState.Ethic -= 20;
                SceneManager.LoadScene("ResultScene");
                break;

            case 3://未遂


                PlayerState.Ethic -= 15;
                SceneManager.LoadScene("ResultScene");
                break;

            case 4://失敗

                PlayerState.EndingNum = 5;

                SceneManager.LoadScene("ResultScene");

                break;

            case 5://失敗

                PlayerState.EndingNum = 5;

                SceneManager.LoadScene("ResultScene");

                break;


        }

        
    }

    public void OnClickHeveycrime()//倫理値を下げて、お金を増やす
    {
        Action = ActionBackgroundState.Heveycrime;//倫理値を大きく下げて、お金を大きく得る

        PlayerState.Luck = Random.Range(1, 6);

        switch (PlayerState.Luck)
        {
            case 1://成功

                PlayerState.Ethic -= 100;

                PlayerState.Money += 1000000;

                Debug.Log("成功しました");

                SceneManager.LoadScene("ResultScene");

                break;

            case 2://未遂

                PlayerState.Ethic -= 50;

                Debug.Log("未遂に終わりました");
                SceneManager.LoadScene("ResultScene");

                break;

            case 3://失敗

                PlayerState.EndingNum = 5;

                Debug.Log("失敗しました");

                SceneManager.LoadScene("ResultScene");

                break;

            case 4://失敗

                PlayerState.EndingNum = 5;

                Debug.Log("失敗しました２");
                Debug.Log(PlayerState.EndingNum);

                SceneManager.LoadScene("ResultScene");

                break;

            case 5://失敗

                PlayerState.EndingNum = 5;

                Debug.Log("失敗しました３");
                Debug.Log(PlayerState.EndingNum);

                SceneManager.LoadScene("ResultScene");

                break;
                
        }

    }


}
